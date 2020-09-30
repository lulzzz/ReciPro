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
        #region �t�B�[���h�A�v���p�e�B

        public enum DrawingMode { None, Kinematical, BetheSAED, BetheCBED }

        public FormMain formMain;

        public double EwaldRadius => 1 / WaveLength;
        public double WaveLength => waveLengthControl.WaveLength;
        public double Energy => waveLengthControl.Energy;
        public double ExcitationError => numericBoxSpotRadius.Value;
        public int ClientWidth => numericBoxClientWidth.ValueInteger;
        public int ClientHeight => numericBoxClientHeight.ValueInteger;

        public double Thickness { get => numericBoxThickness.Value; set => numericBoxThickness.Value = value; }

        private Font font => new Font("Tahoma", (float)(trackBarStrSize.Value * Resolution / 10.0));

        /// <summary>
        /// ��ʉ𑜓x mm/pix
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
            get => numericBoxResolution.Value;
        }


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
            get => FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.CameraLength2;
        }

        public double Tau { set => FormDiffractionSimulatorGeometry.Tau = value; get => FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.Tau; }

        public double Phi { set => FormDiffractionSimulatorGeometry.Phi = value; get => FormDiffractionSimulatorGeometry == null ? 0 : FormDiffractionSimulatorGeometry.Phi; }


        public double CosTau => FormDiffractionSimulatorGeometry.CosTau;
        public double CosTauSquare => FormDiffractionSimulatorGeometry.CosTauSquare;
        public double SinTau => FormDiffractionSimulatorGeometry.SinTau;
        public double SinTauSquare => FormDiffractionSimulatorGeometry.SinTauSquare;
        public double CosPhi => FormDiffractionSimulatorGeometry.CosPhi;
        public double CosPhiSquare => FormDiffractionSimulatorGeometry.CosPhiSquare;
        public double SinPhi => FormDiffractionSimulatorGeometry.SinPhi;
        public double SinPhiSquare => FormDiffractionSimulatorGeometry.SinPhiSquare;

        /// <summary>
        /// (CosPhi, SinPhi, 0) �̎���� Tau��]����s��
        ///  Cos2Phi * (1 - CosTau) + CosTau | CosPhi * SinPhi * (1 - CosTau)  |  SinPhi * SinTau
        ///  CosPhi * SinPhi * (1 - CosTau)  | Sin2Phi * (1 - CosTau) + CosTau | -CosPhi * SinTau
        /// -SinPhi * SinTau                 | cosPhi  * sinTau                |  CosTau 
        /// ���̍s���v��(X,Y,CL2)�ɍ�p������ƁA���o����W(X,Y)������ԍ��W�ɕϊ��ł���B
        /// </summary>
        public Matrix3D DetectorRotation => FormDiffractionSimulatorGeometry == null ? new Matrix3D() : FormDiffractionSimulatorGeometry.DetectorRotation;


        public Matrix3D DetectorRotationInv => FormDiffractionSimulatorGeometry.DetectorRotationInv;
        /// <summary>
        /// �摜�̒��S�B���o��(Detector)���W�n(Foot���_)�ŕ\��
        /// </summary>
        public PointD DisplayCenter { get; set; } = new PointD(0, 0);

        /// <summary>
        /// �R���g���[���C�x���g���X�L�b�v����
        /// </summary>
        public bool SkipEvent { get; set; } = false;


        private bool skipDrawing = false;
        /// <summary>
        /// �`����X�L�b�v���� (�R���g���[���C�x���g���X�L�b�v����ꍇ�́ASkipEvent���g��)
        /// </summary>
        public bool SkipDrawing { set { skipDrawing = value; if (!value) Draw(); } get => skipDrawing; }

        #endregion

        #region �R���X�g���N�^�A���[�h�A�N���[�Y

        public FormDiffractionSimulator()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            timerBlinkSpot.Tag = true;
            timerBlinkKikuchiLine.Tag = true;
            timerBlinkDebyeRing.Tag = true;
            timerBlinkScale.Tag = true;
        }

        //���[�h���ꂽ�Ƃ�
        public void FormElectronDiffraction_Load(object sender, EventArgs e)
        {
            comboBoxScaleColorScale.SelectedIndex = 0;

            if (FormDiffractionSimulatorGeometry == null)
            {
                lastPanelSize = graphicsBox.ClientSize;

                FormDiffractionSimulatorGeometry = new FormDiffractionSimulatorGeometry { FormDiffractionSimulator = this };
                FormDiffractionSimulatorGeometry.comboBoxGradient.SelectedIndex = 0;
                FormDiffractionSimulatorGeometry.comboBoxScale1.SelectedIndex = 1;
                FormDiffractionSimulatorGeometry.comboBoxScale2.SelectedIndex = 0;
                FormDiffractionSimulatorGeometry.VisibleChanged += FormDiffractionSimulatorGeometry_VisibleChanged;

                FormDiffractionBeamTable = new FormDiffractionSpotInfo { FormDiffractionSimulator = this };

                FormDiffractionSimulatorDynamicCompression = new FormDiffractionSimulatorDynamicCompression { FormDiffractionSimulator = this };
            }
            if (FormDiffractionSimulatorCBED == null)
                FormDiffractionSimulatorCBED = new FormDiffractionSimulatorCBED { FormDiffractionSimulator = this };

            Draw();
        }

        private void FormElectronDiffraction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            formMain.toolStripButtonElectronDiffraction.Checked = false;
        }

        #endregion
        private void FormDiffractionSimulatorGeometry_VisibleChanged(object sender, EventArgs e) => numericUpDownCamaraLength2.Enabled = !FormDiffractionSimulatorGeometry.Visible;

        //Visible���ύX���ꂽ�Ƃ�
        private void FormElectronDiffraction_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                DisplayCenter = new PointD(0, 0);
                SetVector();
                panelMain.BringToFront();
                Draw();
                graphicsBox.Refresh();

                if (radioButtonBeamConvergence.Checked)
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
                    g.Transform = new Matrix(
                    (float)(1 / Resolution), 0, 0, (float)(1 / Resolution),
                    (float)(graphicsBox.ClientSize.Width / 2.0 + DisplayCenter.X / Resolution),
                    (float)(graphicsBox.ClientSize.Height / 2.0 + DisplayCenter.Y / Resolution));
                }
                catch { return false; }
            return true;
        }

        #region Draw�֐��B��������ADrawScale, DrawKikuchiLine, DrawDebyeRing, DrawDiffractionSpots���Ăяo�����B

        private void Draw(object sender, EventArgs e) => Draw();

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

            var sw = new Stopwatch();
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
                var topleft = convertScreenToDetector(new Point(0, 0));
                var bottomright = convertScreenToDetector(new Point(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height));
                g.FillRectangle(new SolidBrush(colorControlBackGround.Color), new RectangleF((float)topleft.X, (float)topleft.Y, (float)(bottomright.X - topleft.X), (float)(bottomright.Y - topleft.Y)));
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
                var cm = new ColorMatrix();//ColorMatrix�I�u�W�F�N�g�̍쐬
                cm.Matrix00 = cm.Matrix11 = cm.Matrix22 = cm.Matrix44 = 1;
                cm.Matrix33 = fdsg.ImageOpacity;
                var ia = new ImageAttributes();//ImageAttributes�I�u�W�F�N�g�̍쐬
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

            if (toolStripButtonScale.Checked && (bool)timerBlinkScale?.Tag)
                DrawScale(g);

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
                var pen = new Pen(Brushes.LightGreen, (float)Resolution);
                g.DrawRectangle(pen, (float)Math.Min(start.X, end.X), (float)Math.Min(start.Y, end.Y), (float)Math.Abs(start.X - end.X), (float)Math.Abs(start.Y - end.Y));
            }

            //�}�E�X�̑I��͈͕`��
            if (MouseRangingMode)
            {
                var pen = new Pen(Brushes.Gray, (float)Resolution) { DashStyle = DashStyle.Dash };
                var rangeStart = convertScreenToDetector(MouseRangeStart).ToPointF();
                var rangeEnd = convertScreenToDetector(MouseRangeEnd).ToPointF();
                g.DrawRectangle(pen, Math.Min(rangeStart.X, rangeEnd.X), Math.Min(rangeStart.Y, rangeEnd.Y), Math.Abs(rangeStart.X - rangeEnd.X), Math.Abs(rangeStart.Y - rangeEnd.Y));
            }

            //�Ε��i��͈̔͂������~
            if (formMain.toolStripButtonImageSimulation.Checked && formMain.FormImageSimulator.ImageMode == FormImageSimulator.ImageModes.HRTEM
                && !double.IsInfinity(formMain.FormImageSimulator.ObjAperRadius))
            {
                var aperR = CameraLength2 * Math.Tan(formMain.FormImageSimulator.ObjAperRadius);
                var aperX = CameraLength2 * Math.Tan(formMain.FormImageSimulator.ObjAperX);
                var aperY = CameraLength2 * Math.Tan(formMain.FormImageSimulator.ObjAperY);

                var pen = new Pen(Brushes.LightGreen, (float)Resolution);
                g.DrawEllipse(pen, (float)(aperX - aperR), (float)(-aperY - aperR), (float)(aperR * 2), (float)(aperR * 2));
            }

            graphicsBox.Refresh();

            toolStripStatusLabelTimeForDrawing.Text = $"Time for drawing objects: {sw.ElapsedMilliseconds} ms.  ";

            if (FormDiffractionBeamTable.Visible && radioButtonIntensityBethe.Checked)
                FormDiffractionBeamTable.SetTable(Energy, formMain.Crystal.Bethe.Beams);
        } 
        #endregion

        #region DrawDiffractionSpots

        /// <summary>
        /// ��܃X�|�b�g����юw�����x���̕`��
        /// </summary>
        /// <param name="graphics">�`��Ώۂ̃O���t�B�b�N�I�u�W�F�N�g</param>
        /// <param name="drawLabel">���x����`�悷�邩�ǂ���</param>
        /// <param name="outputOnlySpotInformation">���̃t���O��True�̏ꍇ�́A��ʕ`��͍s�킸��spot�̏�񂾂���Ԃ�</param>
        public (double X, double Y, double Intensity, double Sigma)[] DrawDiffractionSpots(Graphics graphics, bool drawLabel = true, bool outputOnlySpotInformation = false)
        {
            if (radioButtonPointSpread.Checked && graphics != null)
                graphics.SmoothingMode = SmoothingMode.None;

            var spotInformation = new List<(double X, double Y, double Intensity, double Sigma)>();

            var alphaCoeff = (double)trackBarSpotOpacity.Value / trackBarSpotOpacity.Maximum;

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

            var radiusCBED = Math.Tan(FormDiffractionSimulatorCBED.AlphaMax) * CameraLength2;

            #region �K�E�X�֐��`��
            int bgR = colorControlBackGround.Color.R, bgG = colorControlBackGround.Color.G, bgB = colorControlBackGround.Color.B;
            var fillCircleSpread = new Func<Color, PointD, double, double, double>((c, pt, intensity, sigma) =>
              {
                  //�v�Z����񎟌��K�E�X�֐��́A f(x,y) = intensity/ (2 pi sigma^2) *  e^{- (x^2+y^2) /2/sigma^2)
                  //intensity�̓X�|�b�g�̐ϕ����x�As�͔��l��
                  int gradation = 32;
                  double sigma2 = sigma * sigma, coeff1 = 1 / (2 * Math.PI * sigma2);

                  var maxI = intensity * coeff1;
                  if (maxI <= 1.0 / gradation) return 0;//�����A�ő勭�x��1/gradiation��菬����������A���������ɖ߂�

                  double minRadius = 0;

                  if (maxI > 1)//�������S�t�߂��O�a����ꍇ(���x��1�ȏ�)�́A���x���@1/gradiation �` 1 �̔��a�͈͂�gradation�ŕ���
                      minRadius = sigma * Math.Sqrt(-2 * Math.Log(2 * Math.PI * sigma2 / intensity));

                  var maxRadius = sigma * Math.Sqrt(-2 * Math.Log(1 / coeff1 / intensity * (1.0 / gradation))) * 1.5;//���x���@1/2*gradiation�@�ɂȂ锼�a�����߂�

                  //minR����maxR�܂ŁA�~��`��
                  for (int j = 0; j < gradation; j++)
                  {
                      double ratio1 = (double)(j + 1) / gradation, ratio2 = (double)(j + 2) / gradation;
                      double radius1 = ratio1 * minRadius + (1 - ratio1) * maxRadius, radius2 = ratio2 * minRadius + (1 - ratio2) * maxRadius;

                      var intensity2 = intensity * coeff1 * Math.Exp(-(radius1 * radius1) / 2 / sigma2);

                      var alpha = (int)(255 * intensity2 * alphaCoeff);
                      if (comboBoxScaleColorScale.SelectedIndex == 1)
                      {
                          var index = Math.Min((int)(intensity2 * 65535), 65535);
                          c = Color.FromArgb(PseudoBitmap.BrightnessScaleLinerColorR[index], PseudoBitmap.BrightnessScaleLinerColorG[index], PseudoBitmap.BrightnessScaleLinerColorB[index]);
                          alpha = 255;
                      }

                      var brush = new SolidBrush(Color.FromArgb(alpha, c));
                      if (j < gradation - 1 && radius2 > 0)
                      {
                          var path = new GraphicsPath();
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
            #endregion

            #region 3�����K�E�X�֐��̃�������

            /*  ���̊֐�
            I/ { s^3 * (2 pi)^(3/2)} * exp{ -(x^2+y^2+z^2) /(2 s^2) }
            �́A�ϕ��l�� I �ŁA�Ђ�s��3�����K�E�X�֐��ł���B

            z=Z �̕��ʂŐ؂������f�ʂ́A
             I/ { s^3 * (2 pi)^(3/2)} * exp{ -Z^2 /(2 s^2)} * exp{ -(x^2+y^2) /(2 s^2) }
            �Ƃ����`�ɂȂ�B
            ����́A�񎟌��ϕ��l�� I/{ s * (2pi)^(1/2)} * exp{ -Z^2 /(2 s^2)} �� �Ђ�s�̓񎟌��K�E�X�֐��Ɠ�����  */

            #endregion 3�����K�E�X�֐��̃�������

            var spotRadiusOnDetector = CameraLength2 * Math.Tan(2 * Math.Asin(WaveLength * ExcitationError / 2));
            var error2 = ExcitationError * ExcitationError;
            var sqrtTwoPI = Math.Sqrt(2 * Math.PI);
            var linearCoeff = Math.Pow(trackBarIntensityForPointSpread.Value / 400.0, 6) * 100;
            var logCoeff = 16.0 * trackBarIntensityForPointSpread.Value / trackBarIntensityForPointSpread.Maximum;

            if (waveLengthControl.WaveSource == WaveSource.Xray)
            {
                linearCoeff *= 1000;
                logCoeff *= 1000000;
            }

            var bethe = radioButtonIntensityBethe.Checked;
            var sw = new Stopwatch();
           foreach(var crystal in formMain.Crystals)
            {
                Vector3D[] gVector;

                if (bethe)//�x�[�e�@�ɂ�铮�͊w��܂̏ꍇ
                {
                    sw.Start();

                    var blochNum = FormDiffractionSimulatorCBED.Visible ? FormDiffractionSimulatorCBED.MaxNumOfBloch : numericBoxNumOfBlochWave.ValueInteger;

                    if (radioButtonBeamPrecession.Checked)//�v���Z�b�V�����̏ꍇ
                    {
                        var eigenValues = crystal.Bethe.EigenValuesPED;//�d�q���̏ꍇ

                        var gPED = crystal.Bethe.GetPrecessionElectronDiffraction(blochNum, waveLengthControl.Energy, crystal.RotationMatrix, numericBoxThickness.Value,
                            numericBoxPED_Semiangle.Value / 1000, numericBoxPED_Step.ValueInteger);
                        gVector = gPED.Select(g => g.ConvertToVector3D()).ToArray();

                        if (eigenValues == null || eigenValues[0] != crystal.Bethe.EigenValuesPED[0])
                            toolStripStatusLabelTimeForBethe.Text = $"Time for solving dynamic effects (PED): {sw.ElapsedMilliseconds} ms.  ";
                    }
                    else//�p��������CBED�̏ꍇ
                    {
                        var eigenValues = crystal.Bethe.EigenValues;

                        var gBethe = crystal.Bethe.GetDifractedBeamAmpriltudes(blochNum, waveLengthControl.Energy, crystal.RotationMatrix, numericBoxThickness.Value);
                        gVector = gBethe.Select(g => g.ConvertToVector3D()).ToArray();

                        if (eigenValues != crystal.Bethe.EigenValues)
                            toolStripStatusLabelTimeForBethe.Text = $"Time for solving dynamic effects: {sw.ElapsedMilliseconds} ms.  ";
                    }
                    var max = gVector.Max(g => double.IsInfinity(g.d) ? 0 : g.RawIntensity);
                    gVector = gVector.Select(g => { g.RelativeIntensity = g.RawIntensity / max; return g; }).ToArray();

                    foreach (var g in gVector)
                        g.Argb = formMain.Crystals.Length == 1 ? colorControlNoCondition.Argb : crystal.Argb;
                }
                else
                    gVector = crystal.VectorOfG.ToArray();

                //�`�悷��X�|�b�g�����߂�
                foreach (var g in gVector.Where(g => g.Flag))
                {
                    var vec = bethe ? g : crystal.RotationMatrix * g;//�x�[�e�@�Ōv�Z����ۂɂ́A���łɉ�]��̍��W�ɂȂ��Ă���B

                    //�t��� <=>����ԂŁAY,Z�̕��������]���Ă��邱�Ƃɒ���
                    if (-vec.Z < (radioButtonPointSpread.Checked ? 3 * ExcitationError : ExcitationError))
                    {
                        double L2 = (vec.X * vec.X) + (vec.Y * vec.Y), dev = 0.0;
                        if (!bethe)
                            g.Tag = dev = EwaldRadius - Math.Sqrt(L2 + (-vec.Z + EwaldRadius) * (-vec.Z + EwaldRadius));

                        var dev2 = dev * dev;
                        if (SinPhi * SinTau * vec.X + CosPhi * SinTau * vec.Y + CosTau * (-vec.Z + EwaldRadius) > 0)
                        //(vec.X, -vec.Y, -vec.Z + EwaldRadius) ��(SinPhi*SinTau, -CosPhi*sinTau, cosTau) �̓��ς�0���傫�� = �O���U��)
                        {
                            var pt = convertReciprocalToDetector(vec);
                            if (IsScreenArea(pt))
                            {
                                //CBED���[�h�̎�
                                if (FormDiffractionSimulatorCBED.Visible)
                                {
                                    if (FormDiffractionSimulatorCBED.DrawGuideCircles && Math.Abs(dev) < 3 * ExcitationError && g.RawIntensity > 1E-20)//���F���K�C�h�T�[�N����\��
                                        drawCircle(Color.Yellow, pt, radiusCBED);
                                }
                                //�_�C�i�~�b�N�R���v���b�V�������[�h��ON�̎��́A�`�悵�Ȃ��ŋ��x�ƍ��W�������i�[����
                                else if (outputOnlySpotInformation && IsScreenArea(pt))
                                {
                                    double sigma = spotRadiusOnDetector, sigma2 = sigma * sigma;
                                    var intensity = g.RelativeIntensity / (sigma * sqrtTwoPI) * Math.Exp(-dev2 / error2 / 2);
                                    if (intensity > 1E-10)
                                        spotInformation.Add((pt.X, pt.Y, intensity, sigma));
                                }
                                //�_�L����֐��ŕ`�悷��Ƃ�
                                else if (radioButtonPointSpread.Checked)
                                {
                                    if (bethe || Math.Abs(dev) < 3 * ExcitationError)
                                    {
                                        //����g.RelativeIntensity=1�ŁA����coeff=1�̎��Asigma�̔����̂Ƃ���ŋ��x��255�ɂȂ�悤�Ɋ֐��̌`�𒲐�
                                        double sigma = spotRadiusOnDetector, sigma2 = sigma * sigma, intensity;
                                        if (!logScale)
                                            intensity = bethe ?
                                                g.RelativeIntensity * linearCoeff :
                                                g.RelativeIntensity / (sigma * sqrtTwoPI) * Math.Exp(-dev2 / error2 / 2) * linearCoeff;
                                        else
                                            intensity = bethe ?
                                                (Math.Log10(g.RelativeIntensity) + logCoeff) :
                                                (Math.Log10(g.RelativeIntensity) + logCoeff) / (sigma * sqrtTwoPI) * Math.Exp(-dev2 / error2 / 2);

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
                                    //�t��Ԃɂ�����t�i�q�_�̔��a
                                    var sphereRadius = bethe?
                                        ExcitationError * Math.Sqrt(g.RelativeIntensity) ://�x�[�e�@�̏ꍇ�́A���΋��x�̕����������a�ɔ��
                                        ExcitationError * Math.Pow(g.RelativeIntensity, 1.0 / 3.0);//excitaion only ���邢�� Kinematic�̏ꍇ�́A���a�ɑ��΋��x��1/3����|����

                                    if (bethe || Math.Abs(dev) < sphereRadius)
                                    {
                                        var sectionRadius = bethe ? 
                                            sphereRadius : //�x�[�e�@�̏ꍇ�͂��̂܂�
                                            Math.Sqrt(sphereRadius * sphereRadius - dev2);//excitaion only ���邢�� Kinematic�̏ꍇ�́A�G�����h���ɐ؂�ꂽ�f�ʏ�́A�t�i�q�_�̔��a
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

            var l = (float)spotRadiusOnDetector;

            graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (FormDiffractionSimulatorCBED.Visible)//CBED���[�h�̎��́A�����ŃL�����Z��
                return null;

            //�_�C���N�g�X�|�b�g�̕`��
            var ptOrigin = convertReciprocalToDetector(new Vector3DBase(0, 0, 0));
            if (IsScreenArea(ptOrigin))
            {
                var penOrigin = new Pen(colorControlOrigin.Color, (float)Resolution);
                graphics.DrawLine(penOrigin, ptOrigin.X - l / 2f, ptOrigin.Y - l / 2f, ptOrigin.X + l / 2f, ptOrigin.Y + l / 2f);
                graphics.DrawLine(penOrigin, ptOrigin.X + l / 2f, ptOrigin.Y - l / 2f, ptOrigin.X - l / 2f, ptOrigin.Y + l / 2f);
                //fillCircle(pictureBoxOrigin.BackColor, ptOrigin, l);
                if (toolStripButtonIndexLabels.Checked && trackBarStrSize.Value != 1 && !radioButtonIntensityBethe.Checked)
                    graphics.DrawString("0 0 0", font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), colorControlOrigin.Color)), (float)(ptOrigin.X + l / 2f), (float)(ptOrigin.Y + l / 2f));
                //�_�C���N�g�X�|�b�g�̕`�悱���܂�
            }
            //�����̑��̕`��
            if (Tau != 0 && IsScreenArea(new PointD(0, 0)))
            {
                var penFoot = new Pen(colorControlFoot.Color, (float)Resolution);

                graphics.DrawLine(penFoot, -l / 2f, -l / 2f, l / 2f, l / 2f);
                graphics.DrawLine(penFoot, +l / 2f, -l / 2f, -l / 2f, l / 2f);

                if (toolStripButtonIndexLabels.Checked && trackBarStrSize.Value != 1)
                    graphics.DrawString("foot", font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), colorControlFoot.Color)), l / 2f, l / 2f);
            }
            //�����̑��̕`�悱���܂�
            return null;
        }
        #endregion

        #region DrawDiffractionSpostLabel

        public void DrawDiffractionSpotsLabel(Graphics graphics, Vector3D g, PointD pt, double radius, double error)
        {
            double alphaCoeff = (double)trackBarSpotOpacity.Value / trackBarSpotOpacity.Maximum;
            var sb = new StringBuilder();
            if (toolStripButtonIndexLabels.Checked) sb.AppendLine(g.Index);
            if (toolStripButtonDspacing.Checked) sb.AppendLine($"{g.d * 10:#.###} ��");
            if (toolStripButtonDistance.Checked) sb.AppendLine($"{CameraLength2 * Math.Tan(2 * Math.Asin(WaveLength / g.d / 2)):#.###} mm");
            if (toolStripButtonExcitationError.Checked) sb.AppendLine($"{error:f3} /nm");

            if (toolStripButtonFg.Checked)
            {
                if (radioButtonIntensityKinematical.Checked)
                    sb.AppendLine($"{g.RelativeIntensity * 100:#.#} %");
                if (radioButtonIntensityBethe.Checked)
                    sb.AppendLine($"{g.RelativeIntensity * 100:#.#} %, ({g.F.Real:0.###} + {g.F.Imaginary:0.###}i)");
            }
            graphics.DrawString(sb.ToString(), font, new SolidBrush(Color.FromArgb((int)(alphaCoeff * 255), colorControlString.Color)), (float)(pt.X + radius / 1.4142 + 3 * Resolution), (float)(pt.Y + radius / 1.4142 + 3 * Resolution));
        }

        #endregion

        #region DrawKikuchiLine

        private void DrawKikuchiLine(Graphics graphics)
        {
            var penExcess = new Pen(new SolidBrush(colorControlExcessLine.Color), (float)(trackBarLineWidth.Value * Resolution / 2000f));
            var penDefect = new Pen(new SolidBrush(colorControlDefectLine.Color), (float)(trackBarLineWidth.Value * Resolution / 2000f));
            var diag = Resolution * Math.Sqrt(graphicsBox.ClientSize.Width * graphicsBox.ClientSize.Width + graphicsBox.ClientSize.Height * graphicsBox.ClientSize.Height) / 2;

            for (int i = 0; i < formMain.Crystals.Length; i++)
            {
                var crystal = formMain.Crystals[i];

                foreach (var g in crystal.VectorOfG.Where(g => g.Flag))
                {
                    double sinTheta = WaveLength * g.Length / 2, sin2Theta = sinTheta * sinTheta;

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
                                graphics.DrawString(g.Index, font, new SolidBrush(colorControlString.Color), pts1[pts1.Count / 2]);
                                graphics.DrawString(g.Index, font, new SolidBrush(colorControlString.Color), pts2[pts2.Count / 2]);
                            }
                        }
                        catch { }
                    }

                    graphics.Transform = original;
                }
            }
        }
        #endregion

        #region DrawDebyeRing
        private void DrawDebyeRing(Graphics g)
        {
            int width = graphicsBox.ClientSize.Width, height = graphicsBox.ClientSize.Height;
            if (width == 0 || height == 0)
                return;

            var cornerDetector = new[] { convertScreenToDetector(0, 0), convertScreenToDetector(width, 0), convertScreenToDetector(width, height), convertScreenToDetector(0, height) };
            var originSrc = convertReciprocalToDetector(new Vector3DBase(0, 0, 0));

            int bgR = colorControlBackGround.Color.R, bgG = colorControlBackGround.Color.G, bgB = colorControlBackGround.Color.B;
            int ringR = colorControlDebyeRing.Color.R, ringG = colorControlDebyeRing.Color.G, ringB = colorControlDebyeRing.Color.B;
            for (int n = 0; n < formMain.Crystal.Plane.Count; n++)
            {
                var intensity = formMain.Crystal.Plane[n].Intensity;
                if (checkBoxDebyeRingIgnoreIntensity.Checked)
                    intensity = 1;

                var twoTheta = 2 * Math.Asin(WaveLength / 2 / formMain.Crystal.Plane[n].d);

                var ptsArray = Geometriy.ConicSection(twoTheta, Phi, Tau, CameraLength2, cornerDetector[0], cornerDetector[2]);

                int red = (int)(ringR * intensity + bgR * (1 - intensity));
                int green = (int)(ringG * intensity + bgG * (1 - intensity));
                int blue = (int)(ringB * intensity + bgB * (1 - intensity));
                Pen pen = new Pen(new SolidBrush(Color.FromArgb(red, green, blue)), (float)(this.trackBarDebyeRingWidth.Value * Resolution / 2f));

                foreach (var pts in ptsArray)
                    g.DrawLines(pen, pts.ToArray());

                var labelPosition = getLabelPosition(ptsArray.SelectMany(p => p).Where(p => IsScreenArea(p, 5)), originSrc, -90);
                if (checkBoxScaleLabel.Checked && !double.IsNaN(labelPosition.X))
                    g.DrawString("{" + formMain.Crystal.Plane[n].strHKL.Replace(" + ", "} + {") + "}", font, new SolidBrush(colorControlString.Color), labelPosition.ToPointF());
            }
        }
        #endregion

        #region DrawScale
        private void DrawScale(Graphics g)
        {

            int width = graphicsBox.ClientSize.Width, height = graphicsBox.ClientSize.Height;
            if (width == 0 || height == 0)
                return;

            var cornerDetector = new[] { convertScreenToDetector(0, 0), convertScreenToDetector(width, 0), convertScreenToDetector(width, height), convertScreenToDetector(0, height) };
            var cornerReals = new[] { convertScreenToReal(0, 0), convertScreenToReal(width, 0), convertScreenToReal(width, height), convertScreenToReal(0, height) };
            var originSrc = convertReciprocalToDetector(new Vector3DBase(0, 0, 0));
            var originInside = IsScreenArea(originSrc);

            //Azimuth�̃X�P�[�����C�� ��������
            int azimuthStep = radioButtonScaleDivisionFine.Checked ? 5 : radioButtonScaleDivisionMedium.Checked ? 15 : 30;
            var pen = new Pen(new SolidBrush(colorControlScaleAzimuth.Color), (float)(trackBarScaleLineWidth.Value * Resolution / 2f));

            var length = new[] { (cornerReals[0]- cornerReals[1]).Length, (cornerReals[1] - cornerReals[2]).Length,
                (cornerReals[2] - cornerReals[3]).Length, (cornerReals[3] - cornerReals[0]).Length };

            for (double n = 0; n < 180; n += azimuthStep)
            {
                pen.DashStyle = n % 10 == 0 ? DashStyle.Dash : DashStyle.Dot;

                var crossList = new List<(PointD pt, int index)>();
                double cos = Math.Cos(n / 180.0 * Math.PI), sin = Math.Sin(n / 180.0 * Math.PI);
                //n�x�X�������ʂƁA�摜�̃G�b�W�̌�_�����߂�
                for (int i = 0; i < 4; i++)
                {
                    //  0 - 1
                    //  |   |
                    //  3 - 2 
                    var j = i < 3 ? i + 1 : 0;
                    var cross = Geometriy.GetCrossPoint(cos, sin, 0, 0, cornerReals[i], cornerReals[j]);
                    double length1 = (cornerReals[i] - cross).Length, length2 = (cornerReals[j] - cross).Length;
                    if (length1 + length2 < length[i] * 1.001)
                        crossList.Add((length1 / length[i] * cornerDetector[j] + length2 / length[i] * cornerDetector[i], i));
                    if (crossList.Count == 2)
                    {
                        g.DrawLine(pen, crossList[0].pt.ToPointF(), crossList[1].pt.ToPointF());

                        if (checkBoxScaleLabel.Checked)//���x���`��
                        {
                            if (!originInside)//�_�C���N�g�X�|�b�g���`��͈͓��Ɋ܂܂�Ă��Ȃ��Ƃ��� ���S�ɋ߂��_�͍폜
                                crossList.Remove((crossList[0].pt - originSrc).Length > (crossList[1].pt - originSrc).Length ?
                                    crossList[1] : crossList[0]);

                            foreach (var (pt, index) in crossList)
                            {
                                double xx = pt.X - originSrc.X, yy = pt.X - originSrc.X;
                                var str = (xx > 1E-6) || (xx > -1E-6 && yy > 1E-6) ? n.ToString() : (n - 180).ToString();
                                var shift = new PointD(index == 1 ? -3 : 0, index == 2 ? -2 : 0) * font.Size;
                                g.DrawString(str + "��", font, new SolidBrush(colorControlScaleAzimuth.Color), (pt + shift).ToPointF());
                            }
                        }
                        break;
                    }
                }
            }
            //Azimuth�̃X�P�[�����C�� �����܂�

            //��������2�Ƃ̃X�P�[�����C���̕`��

            //2�Ƃ̍ő�/�ŏ��l
            double max2Theta = 0, min2Theta = 0.0;
            var edges = new List<Vector3DBase>();
            edges.AddRange(Enumerable.Range(0, width).Select(w => convertScreenToReal(w, 0)));
            edges.AddRange(Enumerable.Range(0, width).Select(w => convertScreenToReal(w, height)));
            edges.AddRange(Enumerable.Range(0, height).Select(h => convertScreenToReal(0, h)));
            edges.AddRange(Enumerable.Range(0, height).Select(h => convertScreenToReal(width, h)));
            if (!originInside)
                min2Theta = edges.Select(p => Math.Atan2(Math.Sqrt(p.X2Y2), p.Z)).Min() / Math.PI * 180.0;
            max2Theta = edges.Select(p => Math.Atan2(Math.Sqrt(p.X2Y2), p.Z)).Max() / Math.PI * 180.0;
            //2�Ƃ̍ő�/�ŏ��l�@�����܂�

            //�����������߂�@��������
            //fine�̂Ƃ���20�����ȏ�Amedium��10�����ȏ�Acoarse��5�����ȏ�ɂȂ�悤�ɒ���
            double dev = max2Theta - min2Theta;
            int thereshold = radioButtonScaleDivisionFine.Checked ? 30 : radioButtonScaleDivisionMedium.Checked ? 15 : 5;
            int stepInteger = 5, stepPow = 0;
            for (stepPow = (int)Math.Log10(dev) + 1; stepPow > -7; stepPow--)
            {
                if (dev / (stepInteger = 5) / Math.Pow(10, stepPow) > thereshold) break;
                if (dev / (stepInteger = 2) / Math.Pow(10, stepPow) > thereshold) break;
                if (dev / (stepInteger = 1) / Math.Pow(10, stepPow) > thereshold) break;
            }
            //�����������߂�@�����܂�

            int startN = (int)(min2Theta / stepInteger / Math.Pow(10, stepPow));
            int endN = (int)(max2Theta / stepInteger / Math.Pow(10, stepPow)) + 1;

            pen.Brush = new SolidBrush(colorControlScale2Theta.Color);



            for (double n = Math.Max(1, startN); n < endN; n++)
            {
                var twoTheta = n * stepInteger * Math.Pow(10, stepPow);
                var ptsArray = Geometriy.ConicSection(twoTheta / 180 * Math.PI, Phi, Tau, CameraLength2, cornerDetector[0], cornerDetector[2]);
                foreach (var pts in ptsArray)
                    g.DrawLines(pen, pts.ToArray());

                var labelPosition = getLabelPosition(ptsArray.SelectMany(p => p).Where(p => IsScreenArea(p, 20)), originSrc, -135);
                if (checkBoxScaleLabel.Checked && !double.IsNaN(labelPosition.X))
                    g.DrawString(twoTheta.ToString() + "��", font, new SolidBrush(colorControlScale2Theta.Color), labelPosition.ToPointF());
            }
        } 
        #endregion

        /// <summary>
        /// �^����ꂽ�_�W�� pts �̒�����A�����Ƃ��w�肵�������ɋ߂��_��Ԃ�. deg 0 : �E, deg 90: ��, deg 180: ��, deg -90:��
        /// </summary>
        /// <param name="list"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        private PointD getLabelPosition(IEnumerable<PointD> list, PointD origin, double deg)
        {
            var residual = double.PositiveInfinity;
            var result = new PointD(float.NaN, float.NaN);
            foreach (var p in list)
            {
                var dev = Math.Abs((deg / 180) * Math.PI - Math.Atan2(p.Y - origin.Y, p.X - origin.X));
                if (residual > dev)
                {
                    residual = dev;
                    result = p;
                }
            }
            return result;
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
            SetVector();
            Draw();
        }

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

        private Size lastPanelSize { get; set; } = new Size(0, 0);


        private void FormDiffractionSimulator_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void FormElectronDiffraction_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();

            if (SkipEvent) return;

            if (graphicsBox.ClientSize.Width == 0 || graphicsBox.ClientSize.Height == 0) return; //�ŏ������ꂽ�Ƃ��Ȃ�
            SetVector();
            Draw();

            SkipEvent = true;
            numericBoxClientWidth.Value = graphicsBox.ClientSize.Width;
            numericBoxClientHeight.Value = graphicsBox.ClientSize.Height;
            SkipEvent = false;

            lastPanelSize = graphicsBox.ClientSize;
        }

        /// <summary>
        /// ���̃t���O��true�̎��́A�v�Z���L�����Z������
        /// </summary>
        public bool CancelSetVector { get; set; } = false;

        //�t�i�q�x�N�g����ݒ肷��
        public void SetVector(bool renewCrystal = false)
        {
            if (formMain == null) return;
            if (CancelSetVector) return;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double d1 = 1 / convertScreenToReciprocal(0, 0, false).Length;
            double d2 = 1 / convertScreenToReciprocal(0, graphicsBox.ClientSize.Height, false).Length;
            double d3 = 1 / convertScreenToReciprocal(graphicsBox.ClientSize.Width, 0, false).Length;
            double d4 = 1 / convertScreenToReciprocal(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height, false).Length;
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

                    int noConditionColor = formMain.Crystals.Length == 1 && !checkBoxUseCrystalColor.Checked ? colorControlNoCondition.Color.ToArgb() : crystal.Argb;
                    int screwGlideColor = colorControlScrewGlide.Color.ToArgb();
                    int latticeColor = colorControlForbiddenLattice.Color.ToArgb();
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

            toolStripStatusLabelTimeForSearchingG.Text = $"Time for searching g-vectors: {sw.ElapsedMilliseconds} ms.  ";
        }


        #region ���W�ϊ�



        /// <summary>
        /// ���W�ϊ� ���(Screen)��̓_(pixel)�����o��(Detector)��̈ʒu (mm)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private PointD convertScreenToDetector(int x, int y) => new PointD(
                (x - graphicsBox.ClientSize.Width / 2.0) * Resolution - DisplayCenter.X,
                (y - graphicsBox.ClientSize.Height / 2.0) * Resolution - DisplayCenter.Y);

        /// <summary>
        /// ���W�ϊ� ���(Screen)��̓_(pixel)�����o��(Detector)��̈ʒu (mm)�ɕϊ�
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private PointD convertScreenToDetector(Point p) => convertScreenToDetector(p.X, p.Y);

        /// <summary>
        /// ���W�ϊ� ���(Screen)��̓_(pixel) �� ����ԍ��W(mm, �R�������W)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector3DBase convertScreenToReal(int x, int y)
        {
            PointD p = convertScreenToDetector(x, y);//�܂��t�B������̈ʒu���擾
            return convertDetectorToReal(p.X, p.Y);//����Ԃ̍��W�ɕϊ�
        }

        /// <summary>
        /// ���W�n�ϊ� ���(Client)��̓_(pixel) �� �t��ԏ�̓_(mm^-1)�ɕϊ� �@��]���Ă���ꍇ��Original���W�n�ɖ߂��ĕϊ��B
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector3DBase convertScreenToReciprocal(int x, int y, bool originalCoordinate)
            => convertRealToReciprocal(convertScreenToReal(x, y), originalCoordinate);

        /// <summary>
        /// �t�B����(Src)��̈ʒu (mm)�����W�n�ϊ� ���(Client)��̓_(pixel)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private PointD convertDetectorToScreen(double x, double y) => new PointD(
                (x + DisplayCenter.X) / Resolution + graphicsBox.ClientSize.Width / 2.0,
                (y + DisplayCenter.Y) / Resolution + graphicsBox.ClientSize.Height / 2.0);


        /// <summary>
        /// ���o��(Detector)��̈ʒu (mm)�����(Screen)��̓_(pixel)�ɕϊ�
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private PointD convertDetectorToScreen(PointD pt) => convertDetectorToScreen(pt.X, pt.Y);

        /// <summary>
        /// ���W�ϊ� ���o��(Detector)��̓_(Foot���S, mm�P��) �� ����ԍ��W(mm�P��, �R�������W)�ɕϊ�
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector3DBase convertDetectorToReal(double x, double y) =>
        #region ���W�ϊ��̌v�Z��
            // (CosPhi, SinPhi, 0) �̎���� Tau��]����s��́A
            //   Cos2Phi * (1 - CosTau) + CosTau | CosPhi * SinPhi * (1 - CosTau)  |  SinPhi * SinTau
            //   CosPhi * SinPhi * (1 - CosTau)  | Sin2Phi * (1 - CosTau) + CosTau | -CosPhi * SinTau
            //  -SinPhi * SinTau                 | cosPhi  * sinTau                |  CosTau  
            //���̍s���(x,y,CameraLength2)�ɍ�p������΂悢
        #endregion
            DetectorRotation * new Vector3DBase(x, y, CameraLength2);


        /// <summary>
        /// ����ԍ��W(mm�P��, �R�������W)���t��ԍ��W�ɕϊ�
        /// </summary>
        /// <param name="v"></param>
        /// <param name="originalCoordinate"></param>
        /// <returns></returns>
        private Vector3DBase convertRealToReciprocal(Vector3DBase v, bool originalCoordinate)
        {
            var len = Math.Sqrt(v.X2Y2);
            var twoTheta = Math.Atan2(len, v.Z);

            double sinTheta = Math.Sin(twoTheta / 2), sinThetaSquare = sinTheta * sinTheta;
            var Z = EwaldRadius * (1 - Math.Cos(twoTheta));

            var temp = 1 / len * Math.Sqrt((4 * sinThetaSquare * EwaldRadius * EwaldRadius) - Z * Z);
            double X = v.X * temp, Y = -v.Y * temp;

            return originalCoordinate ? formMain.Crystal.RotationMatrix.Inverse() * new Vector3DBase(X, Y, Z) : new Vector3DBase(X, Y, Z);

        }

        /// <summary>
        /// �t��ԍ��W������ԍ��W�ɕϊ��B�@ �t��ԍ��W��y,z�̕����𔽓]���邱�Ƃɒ���
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public Vector3DBase convertReciprocalToReal(Vector3DBase g)
            => Geometriy.GetCrossPoint(SinPhi * SinTau, -CosPhi * SinTau, CosTau, CameraLength2, new Vector3DBase(g.X, -g.Y, EwaldRadius - g.Z));

        // return p * d / (a * p.X + b * p.Y + c * p.Z);

        /// <summary>
        /// �t��ԍ��W�����o����W�ɕϊ��B�@ �t��ԍ��W��y,z�̕����𔽓]���邱�Ƃɒ���
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private PointD convertReciprocalToDetector(Vector3DBase g)
        {
            var v = DetectorRotationInv * new Vector3DBase(g.X, -g.Y, EwaldRadius - g.Z);
            var coeff = CameraLength2 / v.Z;
            return new PointD(v.X, v.Y) * coeff;
        }


        /// <summary>
        /// ���o����W�ŗ^����ꂽ���Wpt���A��ʓ��Ɋ܂܂�邩�ǂ�����Ԃ�
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private bool IsScreenArea(PointD pt, int margin = 0)
        {
            var clientPt = convertDetectorToScreen(pt);
            return clientPt.X > margin && clientPt.Y > margin
                && clientPt.X < graphicsBox.ClientRectangle.Width - margin
                && clientPt.Y < graphicsBox.ClientRectangle.Height - margin;
        }

        #endregion ���W�ϊ�

   

        //formMain���猋����ݒ肳�ꂽ�Ƃ�
        internal void SetCrystal()
        {
            SetVector(true);
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
                var inversePos = convertScreenToReciprocal(e.X, e.Y, true);
                //���W�𔽓]
                var gVector = formMain.Crystal.VectorOfG.ToArray();
                int num = -1;
                var minLength = double.PositiveInfinity;
                for (int i = 0; i < gVector.Length; i++)
                {
                    if (minLength > (gVector[i] - inversePos).Length2)
                    {
                        minLength = (gVector[i] - inversePos).Length2;
                        num = i;
                    }
                }

                var vec = formMain.Crystal.RotationMatrix * gVector[num];
                var dev = Math.Abs(EwaldRadius - Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y + (vec.Z - EwaldRadius) * (vec.Z - EwaldRadius)));

                MessageBox.Show(
                    $"index: {gVector[num].h} {gVector[num].k} {gVector[num].l}\r\n" +
                    $"d-spacing: {gVector[num].d:f4} nm\r\n" +
                    $"Inverse coordinate (1/nm): {vec.X:f3} ,{vec.Y:f3} ,{vec.Z:f3}\r\n"
                    + $"Exitation error: {dev:f4} /nm");
            }
        }

        private void graphicsBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                SetVector();
                Draw();
            }

            if (MouseRangingMode)
            {
                MouseRangingMode = false;
                MouseRangeEnd = new Point(e.X, e.Y);

                var ptStart = convertScreenToDetector(MouseRangeStart);
                var ptEnd = convertScreenToDetector(MouseRangeEnd);

                if (Math.Abs(MouseRangeEnd.X - MouseRangeStart.X) < 2 && Math.Abs(MouseRangeEnd.Y - MouseRangeStart.Y) < 2)
                {//�I��͈͂����܂�ɏ�����������k��
                    if (checkBoxFixCenter.Checked)
                        DisplayCenter = new PointD(0, 0);
                    else
                        DisplayCenter = -(ptStart + ptEnd) / 2;
                    Resolution *= 1.2;
                }
                else if (Math.Abs(MouseRangeEnd.X - MouseRangeStart.X) > 10 && Math.Abs(MouseRangeEnd.Y - MouseRangeStart.Y) > 10)
                {
                    //���݂�mag�ƒ��S�ʒu����A�V����mag�ƒ��S�ʒu�����肷��

                    if (checkBoxFixCenter.Checked)
                        DisplayCenter = new PointD(0, 0);
                    else
                        DisplayCenter = -(ptStart + ptEnd) / 2;
                    Resolution = (Math.Abs(ptStart.X - ptEnd.X) / graphicsBox.ClientSize.Width + Math.Abs(ptStart.Y - ptEnd.Y) / graphicsBox.ClientSize.Height) / 2;
                }
            }
            else
                Draw();
        }

        private PointD lastMousePositionDetector = new PointD();
        private Point lastMousePositionScreen = new Point();

        private void graphicsBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //�}�E�X�|�C���^�̏���\��

            var detectorPos = convertScreenToDetector(e.X, e.Y);
            labelMousePositionDetector.Text = $"Detector Coord. (origin: foot):�@{detectorPos.X:f3} mm, {detectorPos.Y:f3} mm";

            var realPos = convertDetectorToReal(detectorPos.X, detectorPos.Y);
            labelMousePositionReal.Text = $"Real Coord. (origin: sample):�@{realPos.X:f3} mm, {realPos.Y:f3} mm, {realPos.Z:f3} mm";


            var reciprocalPos = convertRealToReciprocal(realPos, false);
            labelMousePositionReciprocal.Text = $"Reciprocal Coord. :{reciprocalPos.X:f3} /nm, {reciprocalPos.Y:f3} /nm, {reciprocalPos.Z:f3} /nm";

            labelDinv.Text = $"1/d: {reciprocalPos.Length:f4} /nm";
            var d = 1.0 / reciprocalPos.Length;
            labelD.Text = $"d: {d:f4} nm";
            var twoThetaRad = 2 * Math.Asin(WaveLength / 2 / d);
            var twoThetaDeg = twoThetaRad / Math.PI * 180;
            labelTwoTheta.Text = $"2��: {(twoThetaRad < 0.1 ? $"{twoThetaRad * 1000:g4} mrad" : $"{twoThetaRad:g4} rad")},  {twoThetaDeg:g4}��";

            //Application.DoEvents();

            if (e.X > tabControl.Width || e.Y > tabControl.Height - 20)
            {
                panelMain.BringToFront();
                graphicsBox.Refresh();
            }

            //PointD pt = convertClientToSrc(e.X, e.Y);

            //���{�^����������Ȃ���}�E�X���������Ƃ�
            if (e.Button == MouseButtons.Left)
            {
                if ((e.X - graphicsBox.ClientSize.Width / 2) * (e.X - graphicsBox.ClientSize.Width / 2) + (e.Y - graphicsBox.ClientSize.Height / 2) * (e.Y - graphicsBox.ClientSize.Height / 2)
                    < Math.Min(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height) * Math.Min(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height) * 0.18)
                {
                    double angle = Math.Atan(new PointD(lastMousePositionDetector.X - detectorPos.X, lastMousePositionDetector.Y - detectorPos.Y).Length / CameraLength2 * Resolution) * trackBarRotationSpeed.Value / 50.0;
                    formMain.Rotate((detectorPos.Y - lastMousePositionDetector.Y, detectorPos.X - lastMousePositionDetector.X, 0), angle);
                }
                else
                {
                    formMain.Rotate((0, 0, 1), -Math.Atan2(lastMousePositionDetector.X, lastMousePositionDetector.Y) + Math.Atan2(detectorPos.X, detectorPos.Y));
                }
            }
            //�^�񒆃{�^����������Ȃ���}�E�X���������Ƃ�
            else if (e.Button == MouseButtons.Middle)
            {
                //�R���g���[���L�[��������Ă��Ȃ��āA�����S�ʒu���Œ�łȂ��Ƃ�
                if ((Control.ModifierKeys & Keys.Control) != Keys.Control && !checkBoxFixCenter.Checked)
                {
                    DisplayCenter = new PointD(DisplayCenter.X + (e.X - lastMousePositionScreen.X) * Resolution, DisplayCenter.Y + (e.Y - lastMousePositionScreen.Y) * Resolution);
                    Draw(null, false);
                }
                //�R���g���[���L�[��������Ă��āA�����o��G���A���\���̎�
                else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && FormDiffractionSimulatorGeometry.ShowDetectorArea)
                {
                    FormDiffractionSimulatorGeometry.FootX += (lastMousePositionScreen.X - e.X) * Resolution / FormDiffractionSimulatorGeometry.DetectorPixelSize;
                    FormDiffractionSimulatorGeometry.FootY += (lastMousePositionScreen.Y - e.Y) * Resolution / FormDiffractionSimulatorGeometry.DetectorPixelSize;
                    if (FormDiffractionSimulatorGeometry.Visible)
                        FormDiffractionSimulatorGeometry.Refresh();
                    Draw(null, false);
                }
            }
            else if (e.Button == MouseButtons.Right && MouseRangingMode)
            {
                MouseRangeEnd = new Point(e.X, e.Y);
                Draw(null, false);
            }

            lastMousePositionDetector = detectorPos;
            lastMousePositionScreen = new Point(e.X, e.Y);
        }

        #endregion graphicsBox�̃C�x���g


        private void tabControl_Click(object sender, EventArgs e)
        {
            panelMain.SendToBack();
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
            SetVector();
            Draw();
        }

        #region ����֌W

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.PrinterSettings = pageSetupDialog1.PrinterSettings;
        }

        // ����v���r���[��\��
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e) =>
            printPreviewDialog1.ShowDialog();

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
            SetVector();

            if (sender is ToolStripButton button)
            {
                if (button.Name.Contains("Spot"))
                    groupBoxSpotProperty.Enabled = button.Checked;
                else
                {
                    TabPage page;
                    if (button.Name.Contains("Kikuchi"))
                        page = tabPageKikuchi;
                    else if (button.Name.Contains("Debye"))
                        page = tabPageDebye;
                    else if (button.Name.Contains("Scale"))
                        page = tabPageScale;
                    else
                        return;

                    if (button.Checked)
                    {
                        tabControl.SelectedTab = page;
                        tabControl.BringToFront();
                    }
                    else if (tabControl.SelectedTab == page)
                        tabControl.SelectedTab = tabPageWave;
                }
                tabControl.Refresh();
            }
            Draw();
        }

        #region TabControl�֘A�̃C�x���g

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (
                (!toolStripButtonDebyeRing.Checked && e.TabPage.Name == tabPageDebye.Name) ||
                (!toolStripButtonScale.Checked && e.TabPage.Name == tabPageScale.Name) ||
                 (!toolStripButtonKikuchiLines.Checked && e.TabPage.Name == tabPageKikuchi.Name)
                )
                e.Cancel = true;

        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = (TabControl)sender;
            //�^�u�y�[�W�̃e�L�X�g���擾
            var txt = tab.TabPages[e.Index].Text;

            //StringFormat���쐬 //�������������̒����ɁA�s�����S�ɕ\�������悤�ɂ���
            var sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.LineLimit
            };
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //�w�i�̕`��
            if (tab.SelectedIndex == e.Index)
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(tabControl.BackColor), e.Bounds);

            //�����F��ݒ�
            var brush = new SolidBrush(tabControl.ForeColor);
            if ((!toolStripButtonDebyeRing.Checked && txt == tabPageDebye.Text) ||
                (!toolStripButtonScale.Checked && txt == tabPageScale.Text) ||
                 (!toolStripButtonKikuchiLines.Checked && txt == tabPageKikuchi.Text))
                brush = new SolidBrush(Color.Gray);

            //Text�̕`��
            e.Graphics.DrawString(txt, tabControl.Font, brush, e.Bounds, sf);
        }

        #endregion

        private void waveLengthControl_WavelengthChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            SetVector();

            Draw();
        }

        private void WaveLengthControl_WaveSourceChanged(object sender, EventArgs e)
        {
            if (waveLengthControl.WaveSource == WaveSource.Electron)
            {
                radioButtonBeamConvergence.Enabled = radioButtonBeamPrecession.Enabled = true;
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

        #region �h���b�O�h���b�v
        public void FormDiffractionSimulator_DragDrop(object sender, DragEventArgs e) => FormDiffractionSimulatorGeometry.FormDiffractionSimulatorGeometry_DragDrop(sender, e);

        private void FormDiffractionSimulator_DragEnter(object sender, DragEventArgs e) => e.Effect = (e.Data.GetData(DataFormats.FileDrop) != null) ? DragDropEffects.Copy : DragDropEffects.None;
        #endregion

        private void radioButtonPointSpread_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelGaussianOption.Enabled = radioButtonPointSpread.Checked;
            SetVector();
            trackBarIntensityForPointSpread.Enabled = radioButtonPointSpread.Checked;
            checkBoxLogScale.Enabled = radioButtonPointSpread.Checked;

            Draw();
        }

        private void radioButtonKinematical_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelExtinctionOption.Enabled = radioButtonIntensityExcitation.Checked;

            colorControlScrewGlide.Enabled = colorControlForbiddenLattice.Visible = radioButtonIntensityExcitation.Checked;

            buttonDetailsOfSpots.Enabled = radioButtonIntensityBethe.Checked;

            formMain.Crystal.Bethe.MaxNumOfBloch = 0;

            FormDiffractionSimulatorCBED.Visible = radioButtonBeamConvergence.Checked;
            numericBoxSpotRadius.Enabled = !radioButtonBeamConvergence.Checked;

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



            SetVector();
            Draw();
        }

        private void buttonDetailedGeometry_Click(object sender, EventArgs e)
        {
            FormDiffractionSimulatorGeometry.Visible = true;
            FormDiffractionSimulatorGeometry.BringToFront();
        }

        private void buttonResetCenter_Click_1(object sender, EventArgs e)
        {
            DisplayCenter = new PointD(0, 0);
            Draw();
        }

        #region �^�C�}�[�֘A
        private void toolStripButtonDiffractionSpots_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Right && ((ToolStripButton)sender).Checked)
            {
                Timer timer;
                if ((ToolStripButton)sender == toolStripButtonDiffractionSpots)
                    timer = timerBlinkSpot;
                else if ((ToolStripButton)sender == toolStripButtonKikuchiLines)
                    timer = timerBlinkKikuchiLine;
                else if ((ToolStripButton)sender == toolStripButtonDebyeRing)
                    timer = timerBlinkDebyeRing;
                else
                    timer = timerBlinkScale;

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

        private void timerBlinkScale_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Tag = !(bool)timer.Tag;
            toolStripButtonScale.ForeColor = (bool)timer.Tag ? SystemColors.MenuHighlight : SystemColors.Info;
            Draw();
        }
        #endregion

        #region �ۑ��A�R�s�[�֘A��
        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopy(true, true, true);

        private void saveAsMetafileToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopy(true, false, true);

        private void saveDetectorAsImageToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(true, true);

        private void saveDetectorAsMetafileToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(true, false);

        private void copyAsImageToolStripMenuItem1_Click(object sender, EventArgs e) => SaveOrCopy(false, true, true);

        private void copyAsMetafileToolStripMenuItem1_Click(object sender, EventArgs e) => SaveOrCopy(false, false, true);

        private void copyDetectorAsImageWithOverlappeImageToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(false, true);

        private void copyDetectorAsMetafileWithOverlappedImageToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(false, false);

        private void saveCBEDasPngToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(true, true);

        private void saveCBEDasTiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "*.tif|*.tif" };
            if (FormDiffractionSimulatorCBED.SrcImage != null && FormDiffractionSimulatorCBED.SrcImage.Length != 0 && dlg.ShowDialog() == DialogResult.OK)
                Tiff.Writer(dlg.FileName, FormDiffractionSimulatorCBED.SrcImage, 3, FormDiffractionSimulatorCBED.CBED_Image.Width);
        }

        private void saveCBEDasMetafileToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(true, false);

        private void copyCBEDasImageToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(false, true);

        private void copyCBEDasMetafileToolStripMenuItem_Click(object sender, EventArgs e) => SaveOrCopyDetector(false, false);

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
                var originalFoot = new PointD(DisplayCenter.X, DisplayCenter.Y);
                var originalStringSize = trackBarStrSize.Value;

                var fdsg = FormDiffractionSimulatorGeometry;

                Resolution = fdsg.DetectorPixelSize;
                graphicsBox.ClientSize = new Size(fdsg.DetectorWidth, fdsg.DetectorHeight);
                DisplayCenter = new PointD((fdsg.FootX - fdsg.DetectorWidth / 2.0) * fdsg.DetectorPixelSize, (fdsg.FootY - fdsg.DetectorHeight / 2.0) * fdsg.DetectorPixelSize);

                int strSize = (int)(originalResolution / Resolution * originalStringSize);
                if (strSize > trackBarStrSize.Maximum)
                    trackBarStrSize.Value = trackBarStrSize.Maximum;
                else if (strSize < trackBarStrSize.Minimum)
                    trackBarStrSize.Value = trackBarStrSize.Minimum;
                else
                    trackBarStrSize.Value = strSize;

                SetVector();

                SaveOrCopy(save, asImage, drawOverlappedImage);

                graphicsBox.Size = originalSize;
                Resolution = originalResolution;
                trackBarStrSize.Value = originalStringSize;
                DisplayCenter = originalFoot;
                SetVector();
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
                var originalFoot = new PointD(DisplayCenter.X, DisplayCenter.Y);

                Resolution = FormDiffractionSimulatorCBED.ImagePixelSize;
                graphicsBox.ClientSize = new Size(FormDiffractionSimulatorCBED.ImageWidth, FormDiffractionSimulatorCBED.ImageHeight);
                DisplayCenter = new PointD(0, 0);

                SaveOrCopy(save, asImage, drawOverlappedImage);

                graphicsBox.Size = originalSize;
                Resolution = originalResolution;
                DisplayCenter = originalFoot;
                SetVector();
                graphicsBox.Visible = true;
                Draw();
                graphicsBox.Refresh();
            }
        }

        #endregion

        private void statusStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 2)
            {
                var fdsg = FormDiffractionSimulatorGeometry;
                var sb = new StringBuilder();
                sb.AppendLine($"Crystal:\t{formMain.Crystal.Name}");
                sb.AppendLine($"Euler Phi:\t{formMain.Phi / Math.PI * 180:f3}");
                sb.AppendLine($"Euler Theta:\t{formMain.Theta / Math.PI * 180:f3}");
                sb.AppendLine($"Euler Psi:\t{formMain.Psi / Math.PI * 180:f3}");
                sb.AppendLine($"Monitor resolution:\t{Resolution}");
                sb.AppendLine($"Camera Length2:  {CameraLength2}");

                sb.AppendLine($"Spot shape:\t{(radioButtonCircleArea.Checked ? "Solid sphere" : "Gaussian")}");
                sb.AppendLine($"Radius or Sigma:\t{numericBoxSpotRadius.Value}");
                sb.AppendLine($"Intensity calculation:\t{(radioButtonIntensityExcitation.Checked ? "Excitation error only" : "Kinematical")}");
                sb.AppendLine($"Tau:\t{Tau / Math.PI * 180}");
                sb.AppendLine($"Image name:\t{fdsg.textBoxFileName.Text}");
                sb.AppendLine($"Detector width:\t{fdsg.DetectorWidth}");
                sb.AppendLine($"Detector height:\t{fdsg.DetectorHeight}");
                sb.AppendLine($"Detector pixel size:\t{fdsg.DetectorPixelSize}");
                sb.AppendLine($"Detector foot X:\t{fdsg.FootX}");
                sb.AppendLine($"Detector foot Y:\t{fdsg.FootY}");

                Clipboard.SetDataObject(sb.ToString());
            }
        }

        private void checkBoxUseCrystalColor_CheckedChanged(object sender, EventArgs e)
        {
            SetVector();
            Draw();
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
            if (radioButtonIntensityBethe.Checked)
                FormDiffractionBeamTable.SetTable(waveLengthControl.Energy, formMain.Crystal.Bethe.Beams);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var step = 0.1;
            var range = 4;
            //-4�V�O�}����+4�V�O�}�܂ŁA0.1�V�O�}�X�e�b�v�ŁB

            var sum = new double[graphicsBox.ClientSize.Width * graphicsBox.ClientSize.Height];

            for (double s = -range; s <= range; s += step)
            {
                waveLengthControl.Energy = numericBoxAcc.Value + numericBoxAcc.Value * numericBoxDev.Value / 100.0 * s;

                var bmp = new Bitmap(graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height);
                Draw(Graphics.FromImage(bmp), false, false);
                var gray = BitmapConverter.ToByteGray(bmp);

                var temp = gray.Select(intensity => intensity * step / Math.Sqrt(2.0 * Math.PI) * Math.Exp(-s * s / 2)).ToArray();

                for (int i = 0; i < sum.Length; i++)
                    sum[i] += temp[i];
            }
            var destBmp = BitmapConverter.FromArrayToBitmap(sum.Select(s => (byte)Math.Min(s, 255)).ToArray(), graphicsBox.ClientSize.Width, graphicsBox.ClientSize.Height);
            graphicsBox.Image = destBmp;
            Clipboard.SetDataObject(destBmp);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (radioButtonBeamParallel.Checked && radioButtonIntensityBethe.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 300; i++)
                {
                    numericBoxThickness.Value = i;
                    Draw();
                    var intensity = formMain.Crystal.Bethe.Beams[0].Psi.Magnitude2();

                    sb.AppendLine($"{i}\t{intensity}");
                }

                Clipboard.SetDataObject(sb.ToString());

            }
        }

        private void basicConceptOfBethesMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var f = new FormPDF(appPath + @"\doc\bethe.pdf");
            f.ShowDialog();
        }

        private void comboBoxScaleColorScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelSpotColor.Visible = comboBoxScaleColorScale.SelectedIndex == 0;
            Draw();
        }

        private void checkBoxMousePositionDetailes_CheckedChanged(object sender, EventArgs e) => labelMousePositionReciprocal.Visible =
                labelMousePositionDetector.Visible =
                labelMousePositionReal.Visible =
                checkBoxMousePositionDetailes.Checked;

      

        private void FormDiffractionSimulator_Paint(object sender, PaintEventArgs e) => Draw();
    }
}