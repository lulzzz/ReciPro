using Crystallography;
using Crystallography.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciPro
{
    public partial class FormDiffractionSimulator : Form
    {
        public FormMain formMain;

        public double EwaldRadius { get { return 1 / WaveLength; } }
        public double WaveLength { get { return waveLengthControl.WaveLength; } }

        public double Energy { get => waveLengthControl.Energy; }
        public double ExcitationError { get { return trackBarAdvancedSpotRadius.Value; } }
        public int ClientWidth { get => numericBoxClientWidth.ValueInteger; }
        public int ClientHeight { get => numericBoxClientHeight.ValueInteger; }

        public double Thickness { get => trackBarAdvancedThickness.Value; set => trackBarAdvancedThickness.Value = value; }

        private Font font
        { get { return new Font("Tahoma", (float)(trackBarStrSize.Value * Resolution / 10.0)); } }

        /// <summary>
        /// ��ʉ𑜓x pixel/mm
        /// </summary>
        public double Resolution
        {
            set
            {
                if (value > numericBoxResolution.Maximum)
                    numericBoxResolution.Value = numericBoxResolution.Maximum;
                else if (value < numericBoxResolution.Minimum)
                    numericBoxResolution.Value = numericBoxResolution.Minimum;
                else
                    numericBoxResolution.Value = value;
                Draw();
            }
            get { return numericBoxResolution.Value; }
        }

        public enum DrawingMode { None, Kinematical, BetheSAED, BetheCBED }

        public DrawingMode Mode
        {
            get
            {
                if (radioButtonIntensityExcitation.Checked) return DrawingMode.None;
                else if (radioButtonIntensityKinematical.Checked) return DrawingMode.Kinematical;
                else if (radioButtonIntensityBethe.Checked) return DrawingMode.BetheSAED;
                else return DrawingMode.BetheCBED;
            }
        }

        public FormDiffractionSimulatorCBED FormDiffractionSimulatorCBED;

        public FormDiffractionSimulatorGeometry FormDiffractionSimulatorGeometry;
        public FormDiffractionSimulatorDynamicCompression FormDiffractionSimulatorDynamicCompression;

        public FormDiffractionSpotInfo FormDiffractionBeamTable;

        public bool DynamicCompressionMode { get; set; } = false;
        public List<double[]> DynamicCompression_SpotInformation = new List<double[]>();

        /*public double CameraLength1
        {
            set { FormDiffractionSimulatorGeometry.CameraLength1 = value; }
            get { return FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.CameraLength1; }
        }*/

        public double CameraLength2
        {
            set { FormDiffractionSimulatorGeometry.CameraLength2 = value; Draw(); }
            get { return FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.CameraLength2; }
        }

        public double Tau
        {
            set { FormDiffractionSimulatorGeometry.Tau = value; }
            get { return FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.Tau; }
        }

        public double CosTau { set; get; } = 0;
        public double SinTau { set; get; } = 0;

        public PointD FootPt = new PointD(0, 0);

        public FormDiffractionSimulator()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            timerBlinkSpot.Tag = true;
            timerBlinkKikuchiLine.Tag = true;
            timerBlinkDebyeRing.Tag = true;
        }

        //���[�h���ꂽ�Ƃ�
        public void FormElectronDiffraction_Load(object sender, EventArgs e)
        {
            comboBoxScaleColorScale.SelectedIndex = 0;

            if (FormDiffractionSimulatorGeometry == null)
            {
                lastPanelSize = graphicsBox.ClientSize;

                FormDiffractionSimulatorGeometry = new FormDiffractionSimulatorGeometry
                {
                    FormDiffractionSimulator = this
                };
                FormDiffractionSimulatorGeometry.comboBoxGradient.SelectedIndex = 0;
                FormDiffractionSimulatorGeometry.comboBoxScale1.SelectedIndex = 1;
                FormDiffractionSimulatorGeometry.comboBoxScale2.SelectedIndex = 0;
                FormDiffractionSimulatorGeometry.VisibleChanged += FormDiffractionSimulatorGeometry_VisibleChanged;

                FormDiffractionBeamTable = new FormDiffractionSpotInfo();
                FormDiffractionBeamTable.FormDiffractionSimulator = this;

                FormDiffractionSimulatorDynamicCompression = new FormDiffractionSimulatorDynamicCompression();
                FormDiffractionSimulatorDynamicCompression.FormDiffractionSimulator = this;
            }
            if (FormDiffractionSimulatorCBED == null)
            {
                FormDiffractionSimulatorCBED = new FormDiffractionSimulatorCBED
                {
                    FormDiffractionSimulator = this
                };
            }

            Draw();
        }

        private void FormDiffractionSimulatorGeometry_VisibleChanged(object sender, EventArgs e)
        {
            numericUpDownCamaraLength2.Enabled = !FormDiffractionSimulatorGeometry.Visible;
        }

        //Visible���ύX���ꂽ�Ƃ�
        private void FormElectronDiffraction_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                FootPt = new PointD(0, 0);
                setVector();
                graphicsBox.BringToFront();
                Draw();
                graphicsBox.Refresh();

                if(radioButtonBeamConvergence.Checked)
                    FormDiffractionSimulatorCBED.Visible = true;
            }
            else
            {
                FormDiffractionBeamTable.Visible = false;
                FormDiffractionSimulatorGeometry.Visible = false;
                FormDiffractionSimulatorCBED.Visible = false;
            }
        }

        /// <summary>
        /// �v���W�F�N�V�����s��̐ݒ���s���B
        /// </summary>
        public bool SetProjection(Graphics g = null)
        {
            if (g != null && graphicsBox.ClientSize.Width != 0 && graphicsBox.ClientSize.Height != 0)
                try
                {
                    g.Transform = new System.Drawing.Drawing2D.Matrix(
                    (float)(1 / Resolution), 0, 0, (float)(1 / Resolution),
                    (float)(graphicsBox.ClientSize.Width / 2.0 + FootPt.X / Resolution),
                    (float)(graphicsBox.ClientSize.Height / 2.0 + FootPt.Y / Resolution));
                }
                catch { return false; }
            return true;
        }

        /// <summary>
        /// �R���g���[���C�x���g���X�L�b�v����
        /// </summary>
        public bool SkipEvent { get; set; } = false;

        private bool skipDrawing = false;
        /// <summary>
        /// �`����X�L�b�v���� (�R���g���[���C�x���g���X�L�b�v����ꍇ�́ASkipEvent���g��)
        /// </summary>
        public bool SkipDrawing { set { skipDrawing = value; if (!value) Draw(); } get { return skipDrawing; } }

        /// <summary>
        /// �t��ԕ`��֐�
        /// </summary>
        /// <param name="g">Graphics�I�u�W�F�N�g���w��</param>
        /// <param name="drawLabel">���x�����������́Atrue</param>
        /// <param name="drawOverlappedImage">�I�[�o�[���b�v�C���[�W��`������true. �������Atrue�ł��A�摜���Z�b�g����Ă��Ȃ��ꍇ�͕`���Ȃ��@</param>
        public void Draw(Graphics g = null, bool drawLabel = true, bool drawOverlappedImage = true)
        {
            if (this.InvokeRequired)//�ʃX���b�h����Ăяo���ꂽ�Ƃ� Invoke���ČĂтȂ���
            {
                this.Invoke(new Action(() => Draw(g, drawLabel, drawOverlappedImage)), null);
                return;
            }

            if (SkipDrawing) return;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (formMain == null || formMain.Crystal == null || FormDiffractionSimulatorGeometry == null || formMain.Crystal.A * formMain.Crystal.B * formMain.Crystal.C == 0)
                return;

            if (g == null)//�O���t�B�b�N�X�{�b�N�X�ɕ`�悷��ꍇ
                g = graphicsBox.Graphics;

            if (!SetProjection(g))
                return;

            //�w�i��`��
            if (drawOverlappedImage)
            {
                var topleft = convertClientToSrc(new Point(0, 0));
                var bottomright = convertClientToSrc(new Point(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height));
                g.FillRectangle(new SolidBrush(pictureBoxBackGround.BackColor), new RectangleF((float)topleft.X, (float)topleft.Y, (float)(bottomright.X - topleft.X), (float)(bottomright.Y - topleft.Y)));
            }

            g.SmoothingMode = SmoothingMode.None;
            
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = PixelOffsetMode.Half;

            var fdsg = FormDiffractionSimulatorGeometry;
            var start = new PointD(-fdsg.DetectorPixelSize * fdsg.FootX, -fdsg.DetectorPixelSize * fdsg.FootY);
            var end = new PointD(fdsg.DetectorPixelSize * (fdsg.DetectorWidth - fdsg.FootX), fdsg.DetectorPixelSize * (fdsg.DetectorHeight - fdsg.FootY));
            //�摜�̏d�ˍ��킹
            if (drawOverlappedImage && fdsg.ShowDetectorArea && fdsg.OverlappedImage != null)
            {
                ColorMatrix cm = new ColorMatrix();//ColorMatrix�I�u�W�F�N�g�̍쐬
                cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = cm.Matrix44 = 1;
                cm.Matrix33 = fdsg.ImageOpacity;
                ImageAttributes ia = new ImageAttributes();//ImageAttributes�I�u�W�F�N�g�̍쐬
                ia.SetColorMatrix(cm);  //ColorMatrix��ݒ肷��
                var dest = new PointF[] { start.ToPointF(), new PointF((float)end.X, (float)start.Y), new PointF((float)start.X, (float)end.Y) };//����A�E��A�����̏���
                g.DrawImage(fdsg.OverlappedImage, dest, new RectangleF(0, 0, fdsg.OverlappedImage.Width, fdsg.OverlappedImage.Height), GraphicsUnit.Pixel, ia);
            }

            //CBED�̏d�ˍ��킹
            if (FormDiffractionSimulatorCBED.Visible && FormDiffractionSimulatorCBED.CBED_Image != null)
            {
                var cbed = FormDiffractionSimulatorCBED;
                start = new PointD(-cbed.ImagePixelSize * cbed.ImageCenterX, -cbed.ImagePixelSize * cbed.ImageCenterY);
                end = new PointD(cbed.ImagePixelSize * (cbed.ImageWidth - cbed.ImageCenterX), cbed.ImagePixelSize * (cbed.ImageHeight - cbed.ImageCenterY));
                var dest = new PointF[] { start.ToPointF(), new PointF((float)end.X, (float)start.Y), new PointF((float)start.X, (float)end.Y) };//����A�E��A�����̏���
                g.DrawImage(cbed.CBED_Image, dest, new RectangleF(0, 0, cbed.ImageWidth, cbed.ImageHeight), GraphicsUnit.Pixel);
            }

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (toolStripButtonKikuchiLines.Checked && (bool)timerBlinkKikuchiLine?.Tag)
                DrawKikuchiLine(g);

            if (toolStripButtonDebyeRing.Checked && (bool)timerBlinkDebyeRing?.Tag)
                DrawDebyeRing(g);

            if (toolStripButtonDiffractionSpots.Checked && (bool)timerBlinkSpot?.Tag)
                DrawDiffractionSpots(g, drawLabel);

            //���o��̘g��
            if (fdsg.ShowDetectorArea)
            {
                start = new PointD(-fdsg.DetectorPixelSize * fdsg.FootX, -fdsg.DetectorPixelSize * fdsg.FootY);
                end = new PointD(fdsg.DetectorPixelSize * (fdsg.DetectorWidth - fdsg.FootX), fdsg.DetectorPixelSize * (fdsg.DetectorHeight - fdsg.FootY));
                Pen pen = new Pen(Brushes.LightGreen, (float)Resolution);
                g.DrawRectangle(pen, (float)Math.Min(start.X, end.X), (float)Math.Min(start.Y, end.Y), (float)Math.Abs(start.X - end.X), (float)Math.Abs(start.Y - end.Y));
            }

            //�}�E�X�̑I��͈͕`��
            if (MouseRangingMode)
            {
                Pen pen = new Pen(Brushes.Gray, (float)Resolution) { DashStyle = DashStyle.Dash };
                var rangeStart = convertClientToSrc(MouseRangeStart).ToPointF();
                var rangeEnd = convertClientToSrc(MouseRangeEnd).ToPointF();
                g.DrawRectangle(pen, Math.Min(rangeStart.X, rangeEnd.X), Math.Min(rangeStart.Y, rangeEnd.Y), Math.Abs(rangeStart.X - rangeEnd.X), Math.Abs(rangeStart.Y - rangeEnd.Y));
            }

            //�Ε��i��͈̔͂������~
            if(formMain.toolStripButtonImageSimulation.Checked && formMain.FormImageSimulator.ImageMode== FormImageSimulator.ImageModes.HRTEM 
                && !double.IsInfinity( formMain.FormImageSimulator.ObjAperRadius))
            {

                var aperR = CameraLength2 * Math.Tan( formMain.FormImageSimulator.ObjAperRadius);
                var aperX = CameraLength2 * Math.Tan(formMain.FormImageSimulator.ObjAperX);
                var aperY = CameraLength2 * Math.Tan(formMain.FormImageSimulator.ObjAperY);

                Pen pen = new Pen(Brushes.LightGreen, (float)Resolution);
                g.DrawEllipse(pen, (float)(aperX- aperR), (float)(-aperY- aperR), (float)(aperR*2), (float)(aperR * 2));
            }

            graphicsBox.Refresh();

            toolStripStatusLabelTimeForDrawing.Text = "Time for drawing objects: " + sw.ElapsedMilliseconds.ToString() + " ms.  ";

            if (FormDiffractionBeamTable.Visible && radioButtonIntensityBethe.Checked)
                FormDiffractionBeamTable.SetTable(Energy, formMain.Crystal.Bethe.Beams);
        }

        public struct SpotInformation
        {
            public double X, Y, Intensity, Sigma;

            public SpotInformation(double x, double y, double intensity, double sigma)
            { X = x; Y = y; Intensity = intensity; Sigma = sigma; }
        }

        /// <summary>
        /// ��܃X�|�b�g����юw�����x���̕`��
        /// </summary>
        /// <param name="graphics">�`��Ώۂ̃O���t�B�b�N�I�u�W�F�N�g</param>
        /// <param name="drawLabel">���x����`�悷�邩�ǂ���</param>
        /// <param name="outputOnlySpotInformation">���̃t���O��True�̏ꍇ�́A��ʕ`��͍s�킸��spot�̏�񂾂���Ԃ�</param>
        public SpotInformation[] DrawDiffractionSpots(Graphics graphics, bool drawLabel = true, bool outputOnlySpotInformation = false)
        {
            if (radioButtonPointSpread.Checked && graphics != null)
                graphics.SmoothingMode = SmoothingMode.None;

            var spotInformation = new List<SpotInformation>();

            double alphaCoeff = (double)trackBarSpotOpacity.Value / trackBarSpotOpacity.Maximum;

            bool logScale = checkBoxLogScale.Checked;

            var fillCircle = new Action<Color, PointD, double>((c, pt, radius) =>
            {
                if (Math.Abs(pt.X) < 1E6 && Math.Abs(pt.Y) < 1E6)
                    graphics.FillEllipse(new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), c)), (float)(pt.X - radius), (float)(pt.Y - radius), (float)(2 * radius), (float)(2 * radius));
            });

            var drawCircle = new Action<Color, PointD, double>((c, pt, radius) =>
            {
                if (Math.Abs(pt.X) < 1E6 && Math.Abs(pt.Y) < 1E6)
                    graphics.DrawEllipse(new Pen(c, 0.0001f), (float)(pt.X - radius), (float)(pt.Y - radius), (float)(2 * radius), (float)(2 * radius));
            });

            double radiusCBED = Math.Tan(FormDiffractionSimulatorCBED.AlphaMax) * CameraLength2;

            int bgR = pictureBoxBackGround.BackColor.R, bgG = pictureBoxBackGround.BackColor.G, bgB = pictureBoxBackGround.BackColor.B;
            var fillCircleSpread = new Func<Color, PointD, double, double, double>((c, pt, intensity, sigma) =>
              {
                  //�v�Z����񎟌��K�E�X�֐��́A f(x,y) = intensity/ (2 pi sigma^2) *  e^{- (x^2+y^2) /2/sigma^2)
                  //intensity�̓X�|�b�g�̐ϕ����x�As�͔��l��
                  int gradation = 32;

                  double sigma2 = sigma * sigma;
                  double coeff1 = 1 / (2 * Math.PI * sigma2);

                  double maxI = intensity * coeff1;
                  if (maxI <= 1.0 / gradation) return 0;//�����A�ő勭�x��1/gradiation��菬����������A���������ɖ߂�

                  double minRadius = 0;

                  if (maxI > 1)//�������S�t�߂��O�a����ꍇ(���x��1�ȏ�)�́A���x���@1/gradiation �` 1 �̔��a�͈͂�gradation�ŕ���
                      minRadius = sigma * Math.Sqrt(-2 * Math.Log(2 * Math.PI * sigma2 / intensity));

                  double maxRadius = sigma * Math.Sqrt(-2 * Math.Log(1 / coeff1 / intensity * (1.0 / gradation))) * 1.5;//���x���@1/2*gradiation�@�ɂȂ锼�a�����߂�

                  //minR����maxR�܂ŁA�~��`��
                  for (int j = 0; j < gradation; j++)
                  {
                      double ratio1 = (double)(j + 1) / gradation;
                      double ratio2 = (double)(j + 2) / gradation;
                      double radius1 = ratio1 * minRadius + (1 - ratio1) * maxRadius;
                      double radius2 = ratio2 * minRadius + (1 - ratio2) * maxRadius;

                      double intensity2 = intensity * coeff1 * Math.Exp(-(radius1 * radius1) / 2 / sigma2);

                      
                      int alpha = (int)(255 * intensity2 * alphaCoeff);
                      if (comboBoxScaleColorScale.SelectedIndex == 1)
                      {
                          var index = Math.Min((int)(intensity2 * 65535), 65535);
                          c = Color.FromArgb(PseudoBitmap.BrightnessScaleLinerColorR[index], PseudoBitmap.BrightnessScaleLinerColorG[index], PseudoBitmap.BrightnessScaleLinerColorB[index]);
                          alpha = 255;
                      }


                      var brush = new SolidBrush(Color.FromArgb(alpha, c));
                      if (j < gradation - 1 && radius2 > 0)
                      {
                          GraphicsPath path = new GraphicsPath();
                          path.AddArc((float)(pt.X - radius1), (float)(pt.Y - radius1), (float)(radius1 * 2), (float)(radius1 * 2), 0, 360);
                          path.AddArc((float)(pt.X - radius2), (float)(pt.Y - radius2), (float)(radius2 * 2), (float)(radius2 * 2), 0, -360);
                          graphics.FillPath(brush, path);
                      }
                      else
                      {
                          graphics.FillEllipse(brush, (float)(pt.X - radius1), (float)(pt.Y - radius1), (float)(2 * radius1), (float)(2 * radius1));
                          return maxRadius;
                      }
                  }
                  return maxRadius;
              });

            #region 3�����K�E�X�֐��̃�������

            /*  ���̊֐�
            I/ { s^3 * (2 pi)^(3/2)} * exp{ -(x^2+y^2+z^2) /(2 s^2) }
            �́A�ϕ��l�� I �ŁA�Ђ�s��3�����K�E�X�֐��ł���B

            z=Z �̕��ʂŐ؂������f�ʂ́A
             I/ { s^3 * (2 pi)^(3/2)} * exp{ -Z^2 /(2 s^2)} * exp{ -(x^2+y^2) /(2 s^2) }
            �Ƃ����`�ɂȂ�B
            ����́A�񎟌��ϕ��l�� I/{ s * (2pi)^(1/2)} * exp{ -Z^2 /(2 s^2)} �� �Ђ�s�̓񎟌��K�E�X�֐��Ɠ�����  */

            #endregion 3�����K�E�X�֐��̃�������

            double cosTau = Math.Cos(Tau), sinTau = Math.Sin(Tau);
            double spotRadiusOnDetector = CameraLength2 * Math.Tan(2 * Math.Asin(WaveLength * ExcitationError / 2));
            double error2 = ExcitationError * ExcitationError, error3 = ExcitationError * ExcitationError * ExcitationError;
            double sqrt2PI = Math.Sqrt(2 * Math.PI);
            double linearCoeff = Math.Pow(trackBarIntensityForPointSpread.Value / 400.0, 6) * 100;
            double logCoeff = 16.0 * trackBarIntensityForPointSpread.Value / trackBarIntensityForPointSpread.Maximum;

            if(waveLengthControl.WaveSource== WaveSource.Xray)
            {
                linearCoeff *= 1000;
                logCoeff *= 1000000;
            }
            
            bool bethe = radioButtonIntensityBethe.Checked;
            Stopwatch sw = new Stopwatch();
            //toolStripStatusLabelTimeForBethe.Text = "";
            for (int i = 0; i < formMain.Crystals.Length; i++)
            {
                var crystal = formMain.Crystals[i];

                Vector3D[] gVector;

                if (bethe)//�x�[�e�@�ɂ�铮�͊w��܂̏ꍇ
                {
                    sw.Start();

                    var blochNum = FormDiffractionSimulatorCBED.Visible ? FormDiffractionSimulatorCBED.MaxNumOfBloch : numericBoxNumOfBlochWave.ValueInteger;

                    if (radioButtonBeamPrecession.Checked)//�v���Z�b�V�����̏ꍇ
                    {
                        var eigenValues = crystal.Bethe.EigenValuesPED;//�d�q���̏ꍇ

                        var gPED = crystal.Bethe.GetPrecessionElectronDiffraction(blochNum, waveLengthControl.Energy, crystal.RotationMatrix, trackBarAdvancedThickness.Value,
                            numericBoxPED_Semiangle.Value / 1000, numericBoxPED_Step.ValueInteger);
                        gVector = gPED.Select(g => g.ConvertToVector3D()).ToArray();

                        if (eigenValues == null || eigenValues[0] != crystal.Bethe.EigenValuesPED[0])
                            toolStripStatusLabelTimeForBethe.Text = "Time for solving dynamic effects (PED): " + sw.ElapsedMilliseconds.ToString() + " ms.  ";
                    }
                    else//�p��������CBED�̏ꍇ
                    {

                        var eigenValues = crystal.Bethe.EigenValues;

                        var gBethe = crystal.Bethe.GetDifractedBeamAmpriltudes(blochNum, waveLengthControl.Energy, crystal.RotationMatrix, trackBarAdvancedThickness.Value);
                        gVector = gBethe.Select(g => g.ConvertToVector3D()).ToArray();

                        if (eigenValues != crystal.Bethe.EigenValues)
                            toolStripStatusLabelTimeForBethe.Text = "Time for solving dynamic effects: " + sw.ElapsedMilliseconds.ToString() + " ms.  ";
                    }
                    var max = gVector.Max(g => double.IsInfinity(g.d) ? 0 : g.RawIntensity);
                    gVector = gVector.Select(g => { g.RelativeIntensity = g.RawIntensity / max; return g; }).ToArray();

                }
                else
                    gVector = crystal.VectorOfG.ToArray();

                //�`�悷��X�|�b�g�����߂�
                foreach (var g in gVector.Where(g => g.Flag))
                {
                    var vec = bethe ? g : crystal.RotationMatrix * g;//�x�[�e�@�Ōv�Z����ۂɂ́A���łɉ�]��̍��W�ɂȂ��Ă���B

                    vec.Y = -vec.Y; vec.Z = -vec.Z;//�����Ńx�N�g����Y,Z�̕����𔽓]
                    if (vec.Z < (radioButtonPointSpread.Checked ? 3 * ExcitationError : ExcitationError))
                    {
                        var L2 = (vec.X * vec.X) + (vec.Y * vec.Y);
                        var dev = 0.0;
                        if (!bethe)
                        {
                            dev = EwaldRadius - Math.Sqrt(L2 + (vec.Z + EwaldRadius) * (vec.Z + EwaldRadius));
                            g.Tag = dev;
                        }

                        var dev2 = dev * dev;
                        if (-sinTau * vec.Y + cosTau * (vec.Z + EwaldRadius) > 0)//(vec.X, vec.Y, vec.Z + EwaldRadius) ��(0, -sinTau, cosTau) �̓��ς�0���傫��)
                        {
                            var point = Geometriy.GetCrossPoint(0, -sinTau, cosTau, CameraLength2, new Vector3D(0, 0, 0), new Vector3D(vec.X, vec.Y, vec.Z + EwaldRadius));
                            PointD pt = new PointD(point.X, point.Y * cosTau + point.Z * sinTau);
                            if (IsDisplayArea(pt))
                            {
                                //CBED���[�h�̎�
                                if (FormDiffractionSimulatorCBED.Visible)
                                {
                                    if (FormDiffractionSimulatorCBED.DrawGuideCircles && Math.Abs(dev) < 3 * ExcitationError && g.RawIntensity > 1E-20)//���F���K�C�h�T�[�N����\��
                                        drawCircle(Color.Yellow, pt, radiusCBED);
                                }
                                //�_�C�i�~�b�N�R���v���b�V�������[�h��ON�̎��́A�`�悵�Ȃ��ŋ��x�ƍ��W�������i�[����
                                else if (outputOnlySpotInformation && IsDetectorArea(pt))
                                {
                                    double sigma = spotRadiusOnDetector, sigma2 = sigma * sigma;
                                    var intensity = g.RelativeIntensity / (sigma * sqrt2PI) * Math.Exp(-dev2 / error2 / 2);
                                    if (intensity > 1E-10)
                                        spotInformation.Add(new SpotInformation(pt.X, pt.Y, intensity, sigma));
                                }
                                //�_�L����֐��ŕ`�悷��Ƃ�
                                else if (radioButtonPointSpread.Checked)
                                {
                                    if (Math.Abs(dev) < 3 * ExcitationError)
                                    {
                                        //����g.RelativeIntensity=1�ŁA����coeff=1�̎��Asigma�̔����̂Ƃ���ŋ��x��255�ɂȂ�悤�Ɋ֐��̌`�𒲐�
                                        double sigma = spotRadiusOnDetector, sigma2 = sigma * sigma;
                                        double intensity;
                                        if (!logScale)
                                            intensity = g.RelativeIntensity / (sigma * sqrt2PI) * Math.Exp(-dev2 / error2 / 2) * linearCoeff;
                                        else
                                            intensity = (Math.Log10(g.RelativeIntensity) + logCoeff)  / (sigma * sqrt2PI) * Math.Exp(-dev2 / error2 / 2);

                                        if (!double.IsNaN(intensity))
                                        {
                                            var radius = fillCircleSpread(Color.FromArgb(g.Argb), pt, intensity, sigma);
                                            if (drawLabel && trackBarStrSize.Value != 1 && intensity / (2 * Math.PI * sigma * sigma) > 0.5)
                                                DrawDiffractionSpotsLabel(graphics, g, pt, radius, (double)g.Tag);
                                        }
                                    }
                                }
                                //�~�œh��Ԃ��Ƃ�
                                else
                                {
                                    var sphereRadius = ExcitationError;//�t��Ԃɂ�����t�i�q�_�̔��a
                                    if (!bethe)
                                        sphereRadius = ExcitationError * Math.Pow(g.RelativeIntensity, 1.0 / 3.0);//Kinematic�ȋ��x�v�Z���L���̏ꍇ�́A���a�ɁA���΋��x��1/3����|����
                                    else 
                                        sphereRadius = ExcitationError * Math.Sqrt(g.RelativeIntensity);//�x�[�e�@�̏ꍇ�́A���΋��x�̕����������a�ɔ��

                                    if (Math.Abs(dev) < sphereRadius)
                                    {
                                        var sectionRadius = Math.Sqrt(sphereRadius * sphereRadius - dev2);//�G�����h���ɐ؂�ꂽ�f�ʏ�́A�t�i�q�_�̔��a
                                        var r = CameraLength2 * WaveLength * sectionRadius;
                                        fillCircle(Color.FromArgb(g.Argb), pt, r);
                                        if (drawLabel && trackBarStrSize.Value != 1 && r > spotRadiusOnDetector * 0.4f)
                                            DrawDiffractionSpotsLabel(graphics, g, pt, r, (double)g.Tag);
                                    }
                                }
                            }
                        }

                    }
                }
            }
            if (outputOnlySpotInformation)
                return spotInformation.ToArray();

            var l = (float)(spotRadiusOnDetector);

            graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (FormDiffractionSimulatorCBED.Visible)//CBED���[�h�̎��́A�����ŃL�����Z��
                return null;

            //�_�C���N�g�X�|�b�g�̕`��
            var ptOrigin3D = Geometriy.GetCrossPoint(0, sinTau, cosTau, CameraLength2, new Vector3D(0, 0, 0), new Vector3D(0, 0, EwaldRadius));
            PointD ptOrigin = new PointD(ptOrigin3D.X, ptOrigin3D.Y * cosTau + ptOrigin3D.Z * sinTau);
            if (IsDisplayArea(ptOrigin))
            {
                var penOrigin = new Pen(pictureBoxOrigin.BackColor, (float)Resolution);
                graphics.DrawLine(penOrigin, ptOrigin.X - l / 2f, ptOrigin.Y - l / 2f, ptOrigin.X + l / 2f, ptOrigin.Y + l / 2f);
                graphics.DrawLine(penOrigin, ptOrigin.X + l / 2f, ptOrigin.Y - l / 2f, ptOrigin.X - l / 2f, ptOrigin.Y + l / 2f);
                //fillCircle(pictureBoxOrigin.BackColor, ptOrigin, l);
                if (toolStripButtonIndexLabels.Checked && trackBarStrSize.Value != 1 && !radioButtonIntensityBethe.Checked)
                    graphics.DrawString("0 0 0", font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), pictureBoxOrigin.BackColor)), (float)(ptOrigin.X + l / 2f), (float)(ptOrigin.Y + l / 2f));
                //�_�C���N�g�X�|�b�g�̕`�悱���܂�
            }
            //�����̑��̕`��
            if (Tau != 0 && IsDisplayArea(new PointD(0, 0)))
            {
                var penFoot = new Pen(pictureBoxFoot.BackColor, (float)Resolution);

                graphics.DrawLine(penFoot, -l / 2f, -l / 2f, l / 2f, l / 2f);
                graphics.DrawLine(penFoot, +l / 2f, -l / 2f, -l / 2f, l / 2f);

                if (toolStripButtonIndexLabels.Checked && trackBarStrSize.Value != 1)
                    graphics.DrawString("foot", font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), pictureBoxFoot.BackColor)), l / 2f, l / 2f);
            }
            //�����̑��̕`�悱���܂�
            return null;
        }

        public void DrawDiffractionSpotsLabel(Graphics graphics, Vector3D g, PointD pt, double radius, double error)
        {
            double alphaCoeff = (double)trackBarSpotOpacity.Value / trackBarSpotOpacity.Maximum;
            StringBuilder sb = new StringBuilder();
            if (toolStripButtonIndexLabels.Checked) sb.AppendLine(g.Index);
            if (toolStripButtonDspacing.Checked) sb.AppendLine((g.d * 10).ToString("#.###") + " ��");
            if (toolStripButtonDistance.Checked) sb.AppendLine((CameraLength2 * Math.Tan(2 * Math.Asin(WaveLength / g.d / 2))).ToString("#.###") + " mm");
            if (toolStripButtonExcitationError.Checked) sb.AppendLine(error.ToString("f3") + " /nm");

            if (toolStripButtonFg.Checked)
            {
                if (radioButtonIntensityKinematical.Checked)
                    sb.AppendLine((g.RelativeIntensity * 100).ToString("#.#") + " %");
                if (radioButtonIntensityBethe.Checked)
                    sb.AppendLine((g.RelativeIntensity * 100).ToString("#.#") + " %, (" + g.F.Real.ToString("0.###") + " + " + g.F.Imaginary.ToString("0.###") + "i)");
            }
            graphics.DrawString(sb.ToString(), font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), pictureBoxString.BackColor)), (float)(pt.X + radius / 1.4142 + 3 * Resolution), (float)(pt.Y + radius / 1.4142 + 3 * Resolution));
        }

        private void DrawKikuchiLine(Graphics graphics)
        {
            var penExcess = new Pen(new SolidBrush(pictureBoxExcessLine.BackColor), (float)(trackBarLineWidth.Value * Resolution / 2000f));
            var penDefect = new Pen(new SolidBrush(pictureBoxDefectLine.BackColor), (float)(trackBarLineWidth.Value * Resolution / 2000f));
            var diag = Resolution * Math.Sqrt(graphicsBox.ClientSize.Width * graphicsBox.ClientSize.Width + graphicsBox.ClientSize.Height * graphicsBox.ClientSize.Height) / 2;

            for (int i = 0; i < formMain.Crystals.Length; i++)
            {
                Crystal crystal = formMain.Crystals[i];

                foreach (var g in crystal.VectorOfG.Where(g => g.Flag))
                {
                    double sinTheta = WaveLength * g.Length / 2 , sin2Theta = sinTheta * sinTheta;

                    Vector3D vec1 = crystal.RotationMatrix * g;

                    //bool excess �́Aexcess �̎���true, �����łȂ��Ƃ���false
                    var excess = vec1.Z < 0;

                    //vec2�́A���o��@����Z���ƈ�v����悤��X������]���ɉ�]�������x�N�g��
                    var vec2 = Matrix3D.Rot(new Vector3DBase(1, 0, 0), Tau) * vec1;

                    //vec3�́A���o��@��(Z��)�����Ƃ���psi������]�����āA(0,y,z)�̌`�ɂȂ�悤�ɂ����x�N�g��
                    var psi = Math.Atan2(vec2.X, vec2.Y);
                    var vec3 = Matrix3D.Rot(new Vector3DBase(0, 0, 1), psi) * vec2;

                    //vec3norm�́Avec3���K�i�������x�N�g��
                    var vec3norm = vec3.Normarize();
                    double sinPhi = vec3norm.Y, sin2Phi = sinPhi * sinPhi;
                    double cosPhi = vec3norm.Z, cos2Phi = cosPhi * cosPhi;

                    double P = (sin2Phi - sin2Theta) / (CameraLength2 * CameraLength2 * (1 - sin2Theta)), Psqrt = Math.Sqrt(P);
                    double Q = P * (sin2Phi - sin2Theta) / sin2Theta, Qsqrt = Math.Sqrt(Q);
                    double Y = CameraLength2 * sinPhi * cosPhi / (sin2Phi - sin2Theta);

                    //���݂�Matrix��ۑ�
                    var original = graphics.Transform;

                    graphics.RotateTransform((float)(psi / Math.PI * 180));
                    graphics.TranslateTransform(0, -(float)Y);

                    if (!double.IsNaN(Psqrt) && !double.IsNaN(Qsqrt))
                    {
                        // y= sinh(x) �̋t�֐��� x = log{y+ sqrt(y*y+1)}
                        double omegaMax = Math.Log(diag * Psqrt + Math.Sqrt(diag * Psqrt * diag * Psqrt + 1)) * 2;
                        List<PointF> pts1 = new List<PointF>(), pts2 = new List<PointF>();
                        for (double omega = -omegaMax; omega < omegaMax; omega += omegaMax / 500)
                        {
                            float x = (float)(Math.Sinh(omega) / Psqrt), y = (float)(Math.Cosh(omega) / Qsqrt);
                            pts1.Add(new PointF(x, y));
                            pts2.Add(new PointF(x, -y));
                        }
                        try
                        {
                            graphics.DrawLines(excess ? penExcess : penDefect, pts1.ToArray());
                            graphics.DrawLines(excess ? penDefect : penExcess, pts2.ToArray());
                            if (toolStripButtonIndexLabels.Checked)
                            {
                                graphics.DrawString(g.Index, font, new SolidBrush(pictureBoxString.BackColor), pts1[pts1.Count / 2]);
                                graphics.DrawString(g.Index, font, new SolidBrush(pictureBoxString.BackColor), pts2[pts2.Count / 2]);
                            }
                        }
                        catch { }
                    }

                    graphics.Transform = original;
                }
            }
        }

        private void DrawDebyeRing(Graphics g)
        {
            int bgR = pictureBoxBackGround.BackColor.R, bgG = pictureBoxBackGround.BackColor.G, bgB = pictureBoxBackGround.BackColor.B;
            int ringR = pictureBoxDebyeRing.BackColor.R, ringG = pictureBoxDebyeRing.BackColor.G, ringB = pictureBoxDebyeRing.BackColor.B;
            double diag = Resolution * Math.Sqrt(graphicsBox.ClientSize.Width * graphicsBox.ClientSize.Width + graphicsBox.ClientSize.Height * graphicsBox.ClientSize.Height) / 2;
            double sinTau = Math.Sin(Tau), sin2Tau = sinTau * sinTau, cosTau = Math.Cos(Tau);
            for (int n = 0; n < formMain.Crystal.Plane.Count; n++)
            {
                var intensity = formMain.Crystal.Plane[n].Intensity;
                if (checkBoxDebyeRingIgnoreIntensity.Checked)
                    intensity = 1;

                var d = formMain.Crystal.Plane[n].d;
                //cos2�� = 1 - 2 (sin��)^2,  sin�� = wavelength/2/d
                double sinTheta = WaveLength / 2 / d, cosTwoTheta = 1 - 2 * sinTheta * sinTheta, cos2TwoTheta = cosTwoTheta * cosTwoTheta;

                double P = -(sin2Tau - cos2TwoTheta) / (CameraLength2 * CameraLength2 * (1 - cos2TwoTheta));
                double Psqrt = Math.Sqrt(Math.Abs(P));
                double Q = -P * (sin2Tau - cos2TwoTheta) / cos2TwoTheta, Qsqrt = Math.Sqrt(Q);
                double Y = -CameraLength2 * sinTau * cosTau / (sin2Tau - cos2TwoTheta);

                //���݂�Matrix��ۑ�
                var original = g.Transform;
                //���s�ړ�
                g.TranslateTransform(0, (float)Y);

                if (!double.IsNaN(Psqrt) && !double.IsNaN(Qsqrt))
                {
                    int red = (int)(ringR * intensity + bgR * (1 - intensity));
                    int green = (int)(ringG * intensity + bgG * (1 - intensity));
                    int blue = (int)(ringB * intensity + bgB * (1 - intensity));
                    Pen pen = new Pen(new SolidBrush(Color.FromArgb(red, green, blue)), (float)(this.trackBarDebyeRingWidth.Value * Resolution / 2f));

                    int sign = -1;
                    if (P > 0)
                    {
                        g.DrawEllipse(pen, -(float)(1 / Psqrt), -(float)(1 / Qsqrt), (float)(2 / Psqrt), (float)(2 / Qsqrt));
                    }
                    else
                    {
                        var v1 = new Vector3DBase(0, 1 / Qsqrt + Y, CameraLength2).Normarize();
                        var v2 = new Vector3DBase(0, -1 / Qsqrt + Y, CameraLength2).Normarize();
                        var e = new Vector3DBase(0, SinTau, CosTau);
                        sign = (Math.Abs(v1 * e - cosTwoTheta) > Math.Abs(v2 * e - cosTwoTheta)) ? -1 : 1;

                        // y= sinh(x) �̋t�֐��� x = log{y+ sqrt(y*y+1)}
                        double omegaMax = Math.Log(diag * Psqrt + Math.Sqrt(diag * Psqrt * diag * Psqrt + 1)) * 2;
                        List<PointF> pts = new List<PointF>();
                        for (double omega = -omegaMax; omega < omegaMax; omega += omegaMax / 1000)
                        {
                            float x = (float)(Math.Sinh(omega) / Psqrt), y = (float)(Math.Cosh(omega) / Qsqrt);
                            pts.Add(new PointF(x, sign * y));
                        }
                        g.DrawLines(pen, pts.ToArray());
                    }

                    if (checkBoxDebyeRingLabel.Checked)
                        g.DrawString("{" + formMain.Crystal.Plane[n].strHKL.Replace(" + ", "} + {") + "}", font, new SolidBrush(pictureBoxString.BackColor), 0, (float)(sign / Qsqrt));
                }
                g.Transform = original;
            }
        }


        /// <summary>
        /// �J������2�����̃t�H�[������ύX���ꂽ�Ƃ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownCamaraLength2_ValueChanged(object sender, EventArgs e)
        {
            if (!FormDiffractionSimulatorGeometry.Visible)
                FormDiffractionSimulatorGeometry.CameraLength2 = (double)numericUpDownCamaraLength2.Value;
        }

        //�𑜓x���ύX���ꂽ�Ƃ��ɋt�i�q�_���v�Z���Ȃ���
        private void numericUpDownResolution_ValueChanged(object sender, EventArgs e)
        {
            if (Visible == false) return;
            SetProjection();
            setVector();
            Draw();
        }

        //��ʂ����T�C�Y���ꂽ�Ƃ��ɋt�i�q�_���v�Z���Ȃ���
        //Dock��Fill�ɂȂ��Ă��Ȃ����Ƃɒ���!!

        /// <summary>
        /// �T�C�Y��numericBox���ύX���ꂽ�Ƃ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericBoxClientSize_ValueChanged(object sender, EventArgs e)
        {
            if (SkipEvent) return;

            var dW = numericBoxClientWidth.ValueInteger - graphicsBox.ClientSize.Width;
            var dH = numericBoxClientHeight.ValueInteger - graphicsBox.ClientSize.Height;
            this.Size = new Size(this.Size.Width + dW, this.Size.Height + dH);

        }

        private Size lastPanelSize = new Size(0, 0);

        private void FormElectronDiffraction_Resize(object sender, EventArgs e)
        {
            if (SkipEvent) return;

            if (graphicsBox.ClientSize.Width == 0 || graphicsBox.ClientSize.Height == 0) return; //�ŏ������ꂽ�Ƃ��Ȃ�
            setVector();
            Draw();

            SkipEvent = true;
            numericBoxClientWidth.Value = graphicsBox.ClientSize.Width;
            numericBoxClientHeight.Value = graphicsBox.ClientSize.Height;
            SkipEvent = false;

            lastPanelSize = graphicsBox.ClientSize;
        }

        private void graphicsBox_Move(object sender, EventArgs e)
        {
            Draw();
        }

        /// <summary>
        /// ���̃t���O��true�̎��́A�v�Z���L�����Z������
        /// </summary>
        public bool CancelSetVector { get; set; } = false;

        //�t�i�q�x�N�g����ݒ肷��
        public void setVector(bool renewCrystal = false)
        {
            if (CancelSetVector) return;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double d1 = 1 / convertClientToReciprocalSpace(0, 0, false).Length;
            double d2 = 1 / convertClientToReciprocalSpace(0, graphicsBox.ClientSize.Height, false).Length;
            double d3 = 1 / convertClientToReciprocalSpace(graphicsBox.ClientSize.Width, 0, false).Length;
            double d4 = 1 / convertClientToReciprocalSpace(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height, false).Length;
            double minD = new[] { d1, d2, d3, d4 }.Min();
            //double maxD = new[] { d1, d2, d3, d4 }.Max();
            WaveSource w = waveLengthControl.WaveSource;
            if (toolStripButtonDiffractionSpots.Checked)
            {
                if (toolStripMenuItemBackLaue.Checked)//Back Laue�̂Ƃ�
                    minD = WaveLength / 2;

                for (int i = 0; i < formMain.Crystals.Length; i++)
                {
                    Crystal crystal = formMain.Crystals[i];
                    crystal.SetVectorOfG(minD, radioButtonIntensityKinematical.Checked ? w : WaveSource.None);

                    int noConditionColor = formMain.Crystals.Length == 1 && !checkBoxUseCrystalColor.Checked ? pictureBoxNoCondition.BackColor.ToArgb() : crystal.Argb;
                    int screwGlideColor = pictureBoxForbiddenScrewGlide.BackColor.ToArgb();
                    int latticeColor = pictureBoxForbiddenLattice.BackColor.ToArgb();
                    string latticeType = crystal.Symmetry.LatticeTypeStr;

                    foreach (var gtemp in crystal.VectorOfG.AsParallel().Where(g => g.Extinction.Length == 0))
                    {
                        gtemp.Flag = true;
                        gtemp.Argb = noConditionColor;
                    }

                    if (!checkBoxExtinctionLattice.Checked)
                    {
                        foreach (var gtemp in crystal.VectorOfG.AsParallel().Where(g => g.Extinction.Length > 0 && g.Extinction[0] == latticeType))
                        {
                            gtemp.Flag = true;
                            gtemp.Argb = latticeColor;
                        }
                    }

                    if (!checkBoxExtinctionAll.Checked)
                    {
                        foreach (var gtemp in crystal.VectorOfG.AsParallel().Where(g => g.Extinction.Length > 0 && g.Extinction[0] != latticeType))
                        {
                            gtemp.Flag = true;
                            gtemp.Argb = screwGlideColor;
                        }
                    }
                }
            }

            if (toolStripButtonDebyeRing.Checked)
            {
                formMain.Crystal.SetPlanes(double.PositiveInfinity, minD, true, true, false, true, HorizontalAxis.d, 0.00000000, WaveLength);
                formMain.Crystal.SetPeakIntensity(w, WaveColor.Monochrome, WaveLength, null);
                for (int j = 0; j < formMain.Crystal.Plane.Count; j++)
                    if (formMain.Crystal.Plane[j].Intensity < 1E-6)
                        formMain.Crystal.Plane.RemoveAt(j--);
            }

            if (toolStripButtonKikuchiLines.Checked)
                formMain.Crystal.SetVectorOfG_KikuchiLine((double)numericUpDownMinKL.Value, WaveLength);

            toolStripStatusLabelTimeForSearchingG.Text = "Time for searching g-vectors: " + sw.ElapsedMilliseconds.ToString() + " ms.  ";
        }

        /// <summary>
        /// ���W�n�ϊ� ���(Client)��̓_(pixel) �� �t��ԏ�̓_(mm^-1)�ɕϊ� �@��]���Ă���ꍇ��Original���W�n�ɖ߂��ĕϊ��B
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>

        public Vector3D convertClientToReciprocalSpace(double x, double y, bool originalCoordinate)
        {
            //�܂��t�B������̈ʒu���擾
            PointD p = convertClientToSrc(x, y);

            double X, Y, Z;
            double _x, _y;
            double len, twoTheta;

            //����Ԃ̍��W�ɕϊ�
            var real3D = new Vector3DBase(p.X, -CameraLength2 * Math.Sin(Tau) + p.Y * Math.Cos(Tau), CameraLength2 * Math.Cos(Tau) + p.Y * Math.Sin(Tau));
            _x = real3D.X;
            _y = real3D.Y;
            len = Math.Sqrt(_x * _x + _y * _y);
            twoTheta = Math.Atan2(len, real3D.Z);
            //if()

            double sinTheta = Math.Sin(twoTheta / 2);
            double sinThetaSquare = sinTheta * sinTheta;
            Z = EwaldRadius * (1 - Math.Cos(twoTheta));

            double temp = 1 / len * Math.Sqrt((4 * sinThetaSquare * EwaldRadius * EwaldRadius) - Z * Z);
            X = _x * temp;
            Y = -_y * temp;

            if (originalCoordinate)
            {
                if (formMain.Crystal.RotationMatrix.E11 == 1 && formMain.Crystal.RotationMatrix.E22 == 1 && formMain.Crystal.RotationMatrix.E33 == 1)
                    return new Vector3D(X, Y, Z, false);
                else
                    return formMain.Crystal.RotationMatrix.Inverse() * new Vector3D(X, Y, Z, false);
            }
            else
                return new Vector3D(X, Y, Z, false);
        }

        /// <summary>
        /// �t�B����(Src)��̈ʒu (mm)�����W�n�ϊ� ���(Client)��̓_(pixel)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PointD convertSrcToClient(double x, double y)
        {
            return new PointD(
                (x - FootPt.X) / Resolution + graphicsBox.ClientSize.Width / 2.0,
                -(y - FootPt.Y) / Resolution + graphicsBox.ClientSize.Height / 2.0);
        }

        /// <summary>
        /// �t�B����(Src)��̈ʒu (mm)�����W�n�ϊ� ���(Client)��̓_(pixel)�ɕϊ�
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public PointD convertSrcToClient(PointD pt)
        {
            return new PointD(
                (pt.X + FootPt.X) / Resolution + graphicsBox.ClientSize.Width / 2.0,
                (pt.Y + FootPt.Y) / Resolution + graphicsBox.ClientSize.Height / 2.0);
        }

        /// <summary>
        /// ���W�n�ϊ� ���(Client)��̓_(pixel)�����o��(Src)��̈ʒu (mm)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PointD convertClientToSrc(double x, double y)
        {
            return new PointD(
                (x - graphicsBox.ClientSize.Width / 2.0) * Resolution - FootPt.X,
                (y - graphicsBox.ClientSize.Height / 2.0) * Resolution - FootPt.Y);
        }

        /// <summary>
        /// ���W�n�ϊ� ���(Client)��̓_(pixel)���t�B����(Src)��̈ʒu (mm)�ɕϊ�
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public PointD convertClientToSrc(Point p)
        {
            return convertClientToSrc(p.X, p.Y);
        }

        /// <summary>
        /// �t�B�������W�ŗ^����ꂽpt���A��ʓ��Ɋ܂܂�邩�ǂ�����Ԃ�
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public bool IsDisplayArea(PointD pt)
        {
            var clientPt = convertSrcToClient(pt);
            return clientPt.X > 0 && clientPt.Y > 0 && clientPt.X < graphicsBox.ClientRectangle.Width && clientPt.Y < graphicsBox.ClientRectangle.Height;
        }

        /// <summary>
        /// �t�B�������W�ŗ^����ꂽpt���A���o����Ɋ܂܂�邩�ǂ�����Ԃ��BOverlapPivture�@�\��OFF�̏ꍇ�́A��Ɍ��o��ݒ肪
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public bool IsDetectorArea(PointD pt)
        {
            var fdsg = FormDiffractionSimulatorGeometry;
            var start = new PointD(-fdsg.DetectorPixelSize * fdsg.FootX, -fdsg.DetectorPixelSize * fdsg.FootY);
            var end = new PointD(fdsg.DetectorPixelSize * (fdsg.DetectorWidth - fdsg.FootX), fdsg.DetectorPixelSize * (fdsg.DetectorHeight - fdsg.FootY));

            //var clientPt = convertSrcToClient(pt);
            //return clientPt.X > 0 && clientPt.Y > 0 && clientPt.X < graphicsBox.ClientRectangle.Width && clientPt.Y < graphicsBox.ClientRectangle.Height;
            return pt.X > start.X && pt.Y > start.Y && pt.X < end.X && pt.Y < end.Y;
        }

        private void FormElectronDiffraction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            formMain.toolStripButtonElectronDiffraction.Checked = false;
        }

        //formMain���猋����ݒ肳�ꂽ�Ƃ�
        internal void SetCrystal()
        {
            setVector(true);
            Draw();
        }

        //�J���[�ύX�p�̃s�N�`���[�{�b�N�X���N���b�N���ꂽ�Ƃ�
        private void panelColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = ((PictureBox)sender).BackColor,
                AllowFullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                ShowHelp = true
            };
            colorDialog.ShowDialog();
            ((PictureBox)sender).BackColor = colorDialog.Color;
            Draw();
        }

        #region graphicsBox�̃C�x���g

        private bool MouseRangingMode = false;
        private Point MouseRangeStart, MouseRangeEnd;//, startAnimation;

        private void graphicsBox_MouseDown(object sender, MouseEventArgs e)
        {
            graphicsBox.Focus();
            if (e.Button == MouseButtons.Right && e.Button != MouseButtons.Left)
            {
                MouseRangingMode = true;
                MouseRangeStart = new Point(e.X, e.Y);
                return;
            }
            else if (e.Button == MouseButtons.Left && e.Button != MouseButtons.Right && e.Clicks == 2)
            {
                //�܂��t�B������̈ʒu���t��ԓ_�ɕϊ�
                Vector3D inversePos = convertClientToReciprocalSpace(e.X, e.Y, true);
                //���W�𔽓]
                Vector3D[] gVector = formMain.Crystal.VectorOfG.ToArray();
                int num = -1;
                double minLength = double.PositiveInfinity;
                for (int i = 0; i < gVector.Length; i++)
                {
                    if (minLength > (gVector[i] - inversePos).Length2)
                    {
                        minLength = (gVector[i] - inversePos).Length2;
                        num = i;
                    }
                }

                var vec = formMain.Crystal.RotationMatrix * gVector[num];
                double dev = Math.Abs(EwaldRadius - Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y + (vec.Z - EwaldRadius) * (vec.Z - EwaldRadius)));

                MessageBox.Show(
                    "index: " + gVector[num].h.ToString() + " " + gVector[num].k.ToString() + " " + gVector[num].l.ToString()
                    + "\r\nd-spacing: " + (gVector[num].d).ToString("f4") + " nm"
                    + "\r\nInverse coordinate (1/nm): " + vec.X.ToString("f3") + " ," + vec.Y.ToString("f3") + " ," + vec.Z.ToString("f3")
                    + "\r\nExitation error: " + dev.ToString("f4") + " /nm"
                    )
                    ;
            }
        }

        private void graphicsBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                setVector();
                Draw();
            }

            if (MouseRangingMode)
            {
                MouseRangingMode = false;
                MouseRangeEnd = new Point(e.X, e.Y);

                PointD ptStart = convertClientToSrc(MouseRangeStart);
                PointD ptEnd = convertClientToSrc(MouseRangeEnd);

                if (Math.Abs(MouseRangeEnd.X - MouseRangeStart.X) < 2 && Math.Abs(MouseRangeEnd.Y - MouseRangeStart.Y) < 2)
                {//�I��͈͂����܂�ɏ�����������k��
                    if (checkBoxFixCenter.Checked)
                        FootPt = new PointD(0, 0);
                    else
                        FootPt = -(ptStart + ptEnd) / 2;
                    Resolution *= 1.2;
                }
                else if (Math.Abs(MouseRangeEnd.X - MouseRangeStart.X) > 10 && Math.Abs(MouseRangeEnd.Y - MouseRangeStart.Y) > 10)
                {
                    //���݂�mag�ƒ��S�ʒu����A�V����mag�ƒ��S�ʒu�����肷��

                    if (checkBoxFixCenter.Checked)
                        FootPt = new PointD(0, 0);
                    else
                        FootPt = -(ptStart + ptEnd) / 2;
                    Resolution = (Math.Abs(ptStart.X - ptEnd.X) / graphicsBox.ClientSize.Width + Math.Abs(ptStart.Y - ptEnd.Y) / graphicsBox.ClientSize.Height) / 2;
                }
            }
            else
                Draw();
        }

        private PointD lastMousePositionReal = new PointD();
        private Point lastMousePositionClient = new Point();

        private void graphicsBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //�}�E�X�|�C���^�̏���\��

            var srcPos = convertClientToSrc(e.X, e.Y);
            labelMousePointReal.Text = "Real Coord.(mm): " + srcPos.X.ToString("f3") + ", " + srcPos.Y.ToString("f3");

            Vector3D inversePos = convertClientToReciprocalSpace(e.X, e.Y, false);
            labelMousePointInverse.Text = "Inverse Coord. (nm^-1): " + inversePos.X.ToString("f3") + ", " + inversePos.Y.ToString("f3") + ", " + inversePos.Z.ToString("f3");

            labelDinv.Text = "1/d: " + inversePos.Length.ToString("f4") + " nm^-1";
            double d = 1 / inversePos.Length;
            labelD.Text = "d: " + d.ToString("f4") + "nm";
            var twoThetaRad = 2 * Math.Asin(WaveLength / 2 / d);
            var twoThetaDeg = twoThetaRad / Math.PI * 180;
            labelTwoTheta.Text = "2��: " + (twoThetaRad <0.1 ? (twoThetaRad*1000).ToString("g4") + " mrad, ": twoThetaRad.ToString("g4") + " rad, ")+ twoThetaDeg.ToString("g4") + "��";

            //Application.DoEvents();

            if (e.X > tabControl.Width || e.Y > tabControl.Height - 20)
            {
                graphicsBox.BringToFront();
                graphicsBox.Refresh();
            }

            //PointD pt = convertClientToSrc(e.X, e.Y);

            //���{�^����������Ȃ���}�E�X���������Ƃ�
            if (e.Button == MouseButtons.Left)
            {
                if ((e.X - graphicsBox.ClientSize.Width / 2) * (e.X - graphicsBox.ClientSize.Width / 2) + (e.Y - graphicsBox.ClientSize.Height / 2) * (e.Y - graphicsBox.ClientSize.Height / 2)
                    < Math.Min(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height) * Math.Min(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height) * 0.18)
                {
                    double angle = Math.Atan(new PointD(lastMousePositionReal.X - srcPos.X, lastMousePositionReal.Y - srcPos.Y).Length / CameraLength2 * Resolution) * trackBarRotationSpeed.Value / 50.0;
                    formMain.Rotate((srcPos.Y - lastMousePositionReal.Y, srcPos.X - lastMousePositionReal.X, 0), angle);
                }
                else
                {
                    formMain.Rotate((0, 0, 1), -Math.Atan2(lastMousePositionReal.X, lastMousePositionReal.Y) + Math.Atan2(srcPos.X, srcPos.Y));
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                if ((Control.ModifierKeys & Keys.Control) != Keys.Control && !checkBoxFixCenter.Checked)
                {
                    FootPt = new PointD(FootPt.X + (e.X - lastMousePositionClient.X) * Resolution, FootPt.Y + (e.Y - lastMousePositionClient.Y) * Resolution);
                    Draw(null, false);
                }
                else if (FormDiffractionSimulatorGeometry.ShowDetectorArea && FormDiffractionSimulatorGeometry.OverlappedImage != null)//�R���g���[���L�[��������Ă���ꍇ
                {
                    FormDiffractionSimulatorGeometry.FootX += (lastMousePositionClient.X - e.X) * Resolution / FormDiffractionSimulatorGeometry.DetectorPixelSize;
                    FormDiffractionSimulatorGeometry.FootY += (lastMousePositionClient.Y - e.Y) * Resolution / FormDiffractionSimulatorGeometry.DetectorPixelSize;
                    Draw(null, false);
                }
            }
            else if (e.Button == MouseButtons.Right && MouseRangingMode)
            {
                MouseRangeEnd = new Point(e.X, e.Y);
                Draw(null, false);
            }

            lastMousePositionReal = srcPos;
            lastMousePositionClient = new Point(e.X, e.Y);
        }

        #endregion graphicsBox�̃C�x���g

        private void checkBoxDiffractionSpot_CheckedChanged(object sender, EventArgs e)
        {
            setVector();
            Draw();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            graphicsBox.SendToBack();
            graphicsBox.Refresh();
        }

        private void checkBoxExtinctionAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtinctionAll.Checked)
            {
                checkBoxExtinctionLattice.Enabled = false;
                checkBoxExtinctionLattice.Checked = true;
            }
            else
                checkBoxExtinctionLattice.Enabled = true;
            setVector();
            Draw();
        }

        private void trackBarStrSize_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        #region ����֌W

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.PrinterSettings = pageSetupDialog1.PrinterSettings;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����v���r���[��\��
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Printing.PageSettings ps = printDocument1.PrinterSettings.DefaultPageSettings;
            //�p���T�C�Y�擾 ���̃T�C�Y��1/100�C���`
            float height = (ps.PaperSize.Height - ps.Margins.Top - ps.Margins.Bottom) / 100f;
            float width = (ps.PaperSize.Width - ps.Margins.Left - ps.Margins.Right) / 100f;

            if (printDocument1.PrinterSettings.DefaultPageSettings.Landscape)
            {//�c�����t�]
                float temp = width; width = height; height = temp;
            }
            double originalReso = numericBoxResolution.Value;
            switch (MessageBox.Show("Real scale printing ?", "Print Option", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    numericBoxResolution.Value = (300 / 25.4);
                    break;

                case DialogResult.Cancel: return;
            }

            /*
             //�𑜓x300dpi�̂Ƃ��̃C���[�W�T�C�Y��
             glString.Font = new Font("Tahoma", trackBarStrSize.Value / 10f);
             Bitmap bmp = glAlpha.GenerateBitmap(panelSimulation, (int)(width * 300), (int)(height * 300));

             bmp.SetResolution(300, 300);

             e.Graphics.PageUnit = GraphicsUnit.Inch;
             e.Graphics.DrawImage(bmp, new PointF(ps.Margins.Top / 100f, ps.Margins.Left / 100f));
             e.HasMorePages = false;

             numericUpDownResolution.Value=originalReso;
             glString.Font = new Font("Tahoma", trackBarStrSize.Value / 10f);
             */
        }

        #endregion ����֌W

        private void toolStripButtonDiffractionSpots_CheckedChanged(object sender, EventArgs e)
        {
            setVector();
            Draw();
        }

        private void toolStripButtonKinematicalSimulation_CheckedChanged(object sender, EventArgs e)
        {
            setVector();
            Draw();
        }

        private void waveLengthControl_WavelengthChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            setVector();

            Draw();
        }

        private void WaveLengthControl_WaveSourceChanged(object sender, EventArgs e)
        {
            if(waveLengthControl.WaveSource == WaveSource.Electron )
            {
                radioButtonBeamConvergence.Enabled = radioButtonBeamPrecession.Enabled= true;
                radioButtonIntensityBethe.Enabled = true;
            }
            else
            {
                radioButtonBeamConvergence.Enabled = radioButtonBeamPrecession.Enabled = false;
                
                if (radioButtonBeamConvergence.Checked || radioButtonBeamPrecession.Checked)
                    radioButtonBeamParallel.Checked = true;

                radioButtonIntensityBethe.Enabled = false;
                if (radioButtonIntensityBethe.Checked)
                    radioButtonIntensityKinematical.Checked = true;

            }
            radioButtonBeamParallel.Checked = true;
        }

        private void checkBoxPrecession_CheckedChanged(object sender, EventArgs e)
            => Draw();

        private void backLaueToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
            => Draw();

        public void FormDiffractionSimulator_DragDrop(object sender, DragEventArgs e)
        {
            FormDiffractionSimulatorGeometry.FormDiffractionSimulatorGeometry_DragDrop(sender, e);
        }

        private void FormDiffractionSimulator_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetData(DataFormats.FileDrop) != null) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void radioButtonPointSpread_CheckedChanged(object sender, EventArgs e)
        {
            labelSigma.Visible = radioButtonPointSpread.Checked;
            labelRadius.Visible = !radioButtonPointSpread.Checked;

            flowLayoutPanelColorScale.Visible = radioButtonPointSpread.Checked;


            setVector();
            trackBarIntensityForPointSpread.Enabled = radioButtonPointSpread.Checked;
            checkBoxLogScale.Enabled = radioButtonPointSpread.Checked;

            Draw();
        }

        private void radioButtonKinematical_CheckedChanged(object sender, EventArgs e)
        {
            formMain.Crystal.Bethe.MaxNumOfBloch = 0;

            FormDiffractionSimulatorCBED.Visible = radioButtonBeamConvergence.Checked;
            trackBarAdvancedSpotRadius.Enabled = !radioButtonBeamConvergence.Checked;

            saveDetectorAreaToolStripMenuItem.Visible = copyDetectorAreaToolStripMenuItem.Visible = FormDiffractionSimulatorGeometry.ShowDetectorArea;

            saveCBEDPatternToolStripMenuItem.Visible = copyCBEDPatternToolStripMenuItem.Visible = radioButtonBeamConvergence.Checked;

            if (radioButtonBeamConvergence.Checked)
                radioButtonPointSpread.Checked = true;

            if (!radioButtonIntensityBethe.Checked)
                FormDiffractionBeamTable.Visible = false;

            flowLayoutPanelPED.Enabled = radioButtonBeamPrecession.Checked;

            if (radioButtonBeamConvergence.Checked || radioButtonBeamPrecession.Checked)
            {
               
                    radioButtonIntensityExcitation.Enabled = false;
                    radioButtonIntensityKinematical.Enabled = false;
                    radioButtonIntensityBethe.Checked = true;
            }
            else
            {
                radioButtonIntensityExcitation.Enabled = true;
                radioButtonIntensityKinematical.Enabled = true;
            }
            flowLayoutPanelBethe.Enabled = radioButtonIntensityBethe.Checked;

           

            setVector();
            Draw();
        }

        private void buttonDetailedGeometry_Click(object sender, EventArgs e)
        {
            FormDiffractionSimulatorGeometry.Visible = true;
            FormDiffractionSimulatorGeometry.BringToFront();
        }

        private void buttonResetCenter_Click_1(object sender, EventArgs e)
        {
            FootPt = new PointD(0, 0);
            Draw();
        }

        private bool trackBarAdvancedSpotSize_ValueChanged(object sender, double value)
        {
            Draw();
            return true;
        }

        private void toolStripButtonDiffractionSpots_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Right && ((ToolStripButton)sender).Checked)
            {
                Timer timer;
                if ((ToolStripButton)sender == toolStripButtonDiffractionSpots)
                    timer = timerBlinkSpot;
                else if ((ToolStripButton)sender == toolStripButtonKikuchiLines)
                    timer = timerBlinkKikuchiLine;
                else
                    timer = timerBlinkDebyeRing;

                if (!timer.Enabled)
                    timer.Start();
                else
                {
                    ((ToolStripButton)sender).ForeColor = SystemColors.MenuHighlight;
                    timer.Stop();
                    timer.Tag = true;
                    Draw();
                }
            }
        }

        private void timerBlinkSpot_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Tag = !(bool)timer.Tag;
            toolStripButtonDiffractionSpots.ForeColor = (bool)timer.Tag ? SystemColors.MenuHighlight : SystemColors.Info;
            Draw();
        }

        private void timerBlinkKikuchiLine_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Tag = !(bool)timer.Tag;
            toolStripButtonKikuchiLines.ForeColor = (bool)timer.Tag ? SystemColors.MenuHighlight : SystemColors.Info;
            Draw();
        }

        private void timerBlinkDebyering_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Tag = !(bool)timer.Tag;
            toolStripButtonDebyeRing.ForeColor = (bool)timer.Tag ? SystemColors.MenuHighlight : SystemColors.Info;
            Draw();
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopy(true, true, true);
        }

        private void saveAsMetafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopy(true, false, true);
        }

        private void saveDetectorAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(true, true);
        }

        private void saveDetectorAsMetafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(true, false);
        }

        private void copyAsImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveOrCopy(false, true, true);
        }

        private void copyAsMetafileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveOrCopy(false, false, true);
        }

        private void copyDetectorAsImageWithOverlappeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(false, true);
        }

        private void copyDetectorAsMetafileWithOverlappedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(false, false);
        }

        private void saveCBEDasPngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(true, true);
        }

        private void saveCBEDasTiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "*.tif|*.tif" };
            if (FormDiffractionSimulatorCBED.SrcImage != null && FormDiffractionSimulatorCBED.SrcImage.Length != 0 && dlg.ShowDialog() == DialogResult.OK)
                Tiff.Writer(dlg.FileName, FormDiffractionSimulatorCBED.SrcImage, 3, FormDiffractionSimulatorCBED.CBED_Image.Width);
        }

        private void saveCBEDasMetafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(true, false);
        }

        private void copyCBEDasImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(false, true);
        }

        private void copyCBEDasMetafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOrCopyDetector(false, false);
        }

        private void SaveOrCopy(bool save, bool isImage, bool drawOverlappedImage)
        {
            if (isImage)
            {
                var bmp = new Bitmap(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height);
                var g = Graphics.FromImage(bmp);
                Draw(g, true, drawOverlappedImage);
                if (bmp != null)
                {
                    if (save)
                    {
                        SaveFileDialog dlg = new SaveFileDialog { Filter = "*.png|*.png" };
                        if (dlg.ShowDialog() == DialogResult.OK)
                            bmp.Save(dlg.FileName, ImageFormat.Png);
                    }
                    else
                    {
                        Clipboard.SetDataObject(bmp);
                    }
                }
            }
            else
            {
                Graphics grfx = CreateGraphics();
                IntPtr ipHdc = grfx.GetHdc();
                MemoryStream ms = new MemoryStream();
                Metafile mf = new Metafile(ms, ipHdc, EmfType.EmfPlusDual);
                grfx.ReleaseHdc(ipHdc);
                grfx.Dispose();
                var g = Graphics.FromImage(mf);
                Draw(g, true, drawOverlappedImage);
                g.Dispose();

                if (save)
                {
                    SaveFileDialog dlg = new SaveFileDialog { Filter = "*.emf|*.emf" };
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fsm = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
                        fsm.Write(ms.GetBuffer(), 0, (int)ms.Length);
                        fsm.Close();
                    }
                }
                else
                    ClipboardMetafileHelper.PutEnhMetafileOnClipboard(this.Handle, mf);
            }
        }

        private void SaveOrCopyDetector(bool save, bool asImage, bool asTiff = false)
        {
            var drawOverlappedImage = false;

            if (FormDiffractionSimulatorGeometry.ShowDetectorArea && FormDiffractionSimulatorGeometry.OverlappedImage != null)
            {
                drawOverlappedImage = MessageBox.Show("Include the overlapped image?", "Copy option", MessageBoxButtons.YesNo) == DialogResult.Yes;

                graphicsBox.Visible = false;
                var originalSize = graphicsBox.Size;
                var originalResolution = Resolution;
                var originalFoot = new PointD(FootPt.X, FootPt.Y);
                var originalStringSize = trackBarStrSize.Value;

                var fdsg = FormDiffractionSimulatorGeometry;

                Resolution = fdsg.DetectorPixelSize;
                graphicsBox.ClientSize = new Size(fdsg.DetectorWidth, fdsg.DetectorHeight);
                FootPt = new PointD((fdsg.FootX - fdsg.DetectorWidth / 2.0) * fdsg.DetectorPixelSize, (fdsg.FootY - fdsg.DetectorHeight / 2.0) * fdsg.DetectorPixelSize);

                int strSize = (int)(originalResolution / Resolution * originalStringSize);
                if (strSize > trackBarStrSize.Maximum)
                    trackBarStrSize.Value = trackBarStrSize.Maximum;
                else if (strSize < trackBarStrSize.Minimum)
                    trackBarStrSize.Value = trackBarStrSize.Minimum;
                else
                    trackBarStrSize.Value = strSize;

                setVector();

                SaveOrCopy(save, asImage, drawOverlappedImage);

                graphicsBox.Size = originalSize;
                Resolution = originalResolution;
                trackBarStrSize.Value = originalStringSize;
                FootPt = originalFoot;
                setVector();
                graphicsBox.Visible = true;
                Draw();
                graphicsBox.Refresh();
            }
            else if (FormDiffractionSimulatorCBED.Visible && FormDiffractionSimulatorCBED.CBED_Image != null)
            {
                drawOverlappedImage = true;

                graphicsBox.Visible = false;
                var originalSize = graphicsBox.Size;
                var originalResolution = Resolution;
                var originalFoot = new PointD(FootPt.X, FootPt.Y);

                Resolution = FormDiffractionSimulatorCBED.ImagePixelSize;
                graphicsBox.ClientSize = new Size(FormDiffractionSimulatorCBED.ImageWidth, FormDiffractionSimulatorCBED.ImageHeight);
                FootPt = new PointD(0, 0);

                SaveOrCopy(save, asImage, drawOverlappedImage);

                graphicsBox.Size = originalSize;
                Resolution = originalResolution;
                FootPt = originalFoot;
                setVector();
                graphicsBox.Visible = true;
                Draw();
                graphicsBox.Refresh();
            }
        }

        private void statusStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 2)
            {
                var fdsg = FormDiffractionSimulatorGeometry;
                string text =
                "Crystal:\t" + formMain.Crystal.Name + "\r\n" +
                "Euler Phi:\t" + (formMain.Phi / Math.PI * 180).ToString("f3") + "\r\n" +
                "Euler Theta:\t" + (formMain.Theta / Math.PI * 180).ToString("f3") + "\r\n" +
                "Euler Psi:\t" + (formMain.Psi / Math.PI * 180).ToString("f3") + "\r\n" +
                "Monitor resolution:\t" + Resolution + "\r\n" +
                "Camera Length2:  " + CameraLength2 + "\r\n" +

                "Spot shape:\t" + (radioButtonCircleArea.Checked ? "Solid sphere" : "Gaussian") + "\r\n" +
                "Radius or Sigma:\t" + trackBarAdvancedSpotRadius.Value + "\r\n" +
                "Intensity calculation:\t" + (radioButtonIntensityExcitation.Checked ? "Excitation error only" : "Kinematical") + "\r\n" +
                "Tau:\t" + (Tau / Math.PI * 180) + "\r\n" +
                "Image name:\t" + fdsg.textBoxFileName.Text + "\r\n" +
                "Detector width:\t" + fdsg.DetectorWidth + "\r\n" +
                "Detector height:\t" + fdsg.DetectorHeight + "\r\n" +
                "Detector pixel size:\t" + fdsg.DetectorPixelSize + "\r\n" +
                "Detector foot X:\t" + fdsg.FootX + "\r\n" +
                "Detector foot Y:\t" + fdsg.FootY + "\r\n";

                Clipboard.SetDataObject(text);
            }
        }

        private void checkBoxUseCrystalColor_CheckedChanged(object sender, EventArgs e)
        {
            setVector();
            Draw();
        }

        private void checkBoxLogScale_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericBoxNumOfBlochWave_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private bool trackBarAdvancedThickness_ValueChanged(object sender, double value)
        {
            Draw();
            return true;
        }

        private void dynamicCompressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiffractionSimulatorGeometry.Visible = true;
            FormDiffractionSimulatorDynamicCompression.Visible = true;
        }

        private void checkBoxFixCenter_CheckedChanged(object sender, EventArgs e)
        {
            buttonResetCenter.Enabled = !checkBoxFixCenter.Checked;
            if (checkBoxFixCenter.Checked)
                buttonResetCenter_Click_1(sender, e);
        }

        private void ButtonDetailsOfSpots_Click(object sender, EventArgs e)
        {
            FormDiffractionBeamTable.Visible = true;
            FormDiffractionBeamTable.BringToFront();
            if(radioButtonIntensityBethe.Checked)
                FormDiffractionBeamTable.SetTable(waveLengthControl.Energy, formMain.Crystal.Bethe.Beams);
        }

        private void toolStripComboBoxSolver_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void TrackBarAdvancedSpotRadius_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var step = 0.1;
            var range = 4;
            //-4�V�O�}����+4�V�O�}�܂ŁA0.1�V�O�}�X�e�b�v�ŁB

            var sum = new double[graphicsBox.ClientSize.Width * graphicsBox.ClientSize.Height];

            for (double s = -range; s <= range; s+= step)
            {
                waveLengthControl.Energy = numericBoxAcc.Value + numericBoxAcc.Value * numericBoxDev.Value / 100.0 * s;

                var bmp = new Bitmap(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height);
                Draw(Graphics.FromImage(bmp), false, false);
                var gray =BitmapConverter.ToByteGray(bmp);

                var temp = gray.Select(intensity => (double)intensity * step / Math.Sqrt(2.0* Math.PI) * Math.Exp(-s * s / 2)).ToArray();

                for (int i = 0; i < sum.Length; i++)
                    sum[i] += temp[i];
            }
            var destBmp = BitmapConverter.FromArrayToBitmap(sum.Select(s => (byte)Math.Min(s, 255)).ToArray(), graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height);
            graphicsBox.Image = destBmp;
            Clipboard.SetDataObject(destBmp);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(radioButtonBeamParallel.Checked && radioButtonIntensityBethe.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 300; i++)
                {
                    trackBarAdvancedThickness.Value = i;
                    Draw();
                    var intensity = formMain.Crystal.Bethe.Beams[0].Psi.Magnitude2();

                    sb.AppendLine(i.ToString() + "\t" + intensity.ToString());
                }

                Clipboard.SetDataObject(sb.ToString());

            }
        }

        private void basicConceptOfBethesMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var f = new FormPDF(appPath + @"\pdf\bethe.pdf");
            f.ShowDialog();
        }

        private void FormDiffractionSimulator_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}