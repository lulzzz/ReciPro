﻿using Crystallography;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ReciPro
{
    public partial class FormDiffractionSimulatorGeometry : Form
    {
        public FormDiffractionSimulator FormDiffractionSimulator;

        public double Tau { set { numericBoxTau.RadianValue = value; } get { return numericBoxTau.RadianValue; } }

        //public double CameraLength1 { set { numericBoxCameraLength1.Value = value; } get { return numericBoxCameraLength1.Value; } }
        public double CameraLength2 { set { numericBoxCameraLength2.Value = value; } get { return numericBoxCameraLength2.Value; } }

        public int DetectorWidth { set { numericalTextBoxPixelWidth.Value = value; } get { return (int)numericalTextBoxPixelWidth.Value; } }
        public int DetectorHeight { set { numericalTextBoxPixelHeight.Value = value; } get { return (int)numericalTextBoxPixelHeight.Value; } }
        public double DetectorPixelSize { set { numericalTextBoxPixelSize.Value = value; } get { return numericalTextBoxPixelSize.Value; } }

        public double FootX { set { numericalTextBoxFootX.Value = value; } get { return numericalTextBoxFootX.Value; } }
        public double FootY { set { numericalTextBoxFootY.Value = value; } get { return numericalTextBoxFootY.Value; } }

        public bool ShowDetectorArea { get { return checkBoxDetectorSizePosition.Checked; } set { checkBoxDetectorSizePosition.Checked = value; } }

        //public bool Precession { get { return checkBoxPrecession.Checked; } set { checkBoxPrecession.Checked = value; } }

        public float ImageOpacity { get { return (float)trackBarPictureOpacity1.Value / trackBarPictureOpacity1.Maximum; } }

        public PseudoBitmap pseudBitmap = null;
        public Bitmap OverlappedImage = null;

        public FormDiffractionSimulatorGeometry()
        {
            InitializeComponent();
        }

        private void FormDiffractionSimulatorGeometry_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(panel2.Width, panel2.Location.Y + panel2.Height);
        }

        private void FormDiffractionSimulatorGeometry_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void checkBoxDetectorSizePosition_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBoxDetectorSizePosition.Checked;
            FormDiffractionSimulator.Draw();

            FormDiffractionSimulator.copyDetectorAreaToolStripMenuItem.Visible = checkBoxDetectorSizePosition.Checked;
            FormDiffractionSimulator.saveDetectorAreaToolStripMenuItem.Visible = checkBoxDetectorSizePosition.Checked;
        }

        private void numericBoxCameraLength2_ValueChanged(object sender, EventArgs e)
        {
            var cosTau = Math.Cos(numericBoxTau.RadianValue);
            //numericBoxCameraLength1.Value = cosTau > 0.0000001 ? numericBoxCameraLength2.Value / cosTau : double.PositiveInfinity;

            if (this.Visible || !FormDiffractionSimulator.Visible)//このフォームがvisibleの時か、親フォームがvisible出ない時(つまり、最初のロード時)
                FormDiffractionSimulator.numericUpDownCamaraLength2.Value = (decimal)CameraLength2;

            FormDiffractionSimulator.setVector();

            FormDiffractionSimulator.Draw();
        }

        private void numericBoxTau_ValueChanged(object sender, EventArgs e)
        {
            FormDiffractionSimulator.setVector();

            FormDiffractionSimulator.CosTau = Math.Cos(Tau);
            FormDiffractionSimulator.SinTau = Math.Sin(Tau);
            FormDiffractionSimulator.Draw();
        }

        #region View関連

        private void toolStripComboBoxScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            setScale();
        }

        private void toolStripComboBoxScale2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setScale();
        }

        private void toolStripComboBoxGradient_SelectedIndexChanged(object sender, EventArgs e)
        {
            setScale();
        }

        private void setScale()
        {
            if (pseudBitmap != null)
            {
                pseudBitmap.IsNegative = comboBoxGradient.SelectedIndex == 1;

                //スケールをセット
                if (comboBoxScale1.SelectedIndex == 0)//ログスケール
                    if (comboBoxScale2.SelectedIndex == 0)//グレー
                    {
                        pseudBitmap.ScaleR = pseudBitmap.ScaleG = pseudBitmap.ScaleB = PseudoBitmap.BrightnessScaleLog;
                        pseudBitmap.GrayScale = true;
                    }
                    else
                    {
                        pseudBitmap.ScaleR = PseudoBitmap.BrightnessScaleLogColorR;
                        pseudBitmap.ScaleG = PseudoBitmap.BrightnessScaleLogColorG;
                        pseudBitmap.ScaleB = PseudoBitmap.BrightnessScaleLogColorB;
                        pseudBitmap.GrayScale = false;
                    }
                else//リニア
                    if (comboBoxScale2.SelectedIndex == 0)//グレー
                {
                    pseudBitmap.ScaleR = pseudBitmap.ScaleG = pseudBitmap.ScaleB = PseudoBitmap.BrightnessScaleLiner;
                    pseudBitmap.GrayScale = true;
                }
                else//color
                {
                    pseudBitmap.ScaleR = PseudoBitmap.BrightnessScaleLinerColorR;
                    pseudBitmap.ScaleG = PseudoBitmap.BrightnessScaleLinerColorG;
                    pseudBitmap.ScaleB = PseudoBitmap.BrightnessScaleLinerColorB;
                    pseudBitmap.GrayScale = false;
                }
                OverlappedImage = pseudBitmap.GetImage();
                FormDiffractionSimulator.Draw();
            }
        }

        #endregion View関連

        private void buttonReadPicture_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "*.bmp, *.jpg, *.tif, *.ipa | *.bmp;*.jpg;*.tif;*.ipa"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ReadImage(dlg.FileName);
            }
        }

        private double trackbarConstantA = 0, trackbarConstantB = 1;

        private double convertTrackbarIntensityToRealIntensity(int trackbarPosition)
        {
            return trackbarConstantA + Math.Exp(trackbarPosition / trackbarConstantB);
        }

        private double convertRealIntensityToTrackbarIntensity(double intensity)
        {
            return (int)(trackbarConstantB * Math.Log(intensity - trackbarConstantA));
        }

        private void trackBarMaxInt_ValueChanged(object sender, EventArgs e)
        {
            if (pseudBitmap != null)
            {
                pseudBitmap.MaxValue = convertTrackbarIntensityToRealIntensity(trackBarMaxInt.Value);
                pseudBitmap.MinValue = convertTrackbarIntensityToRealIntensity(trackBarMinInt.Value);
                OverlappedImage = pseudBitmap.GetImage();
                FormDiffractionSimulator.Draw();
            }
        }

        public void FormDiffractionSimulatorGeometry_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length == 1 && fileName[0].ToLower().EndsWith("prm"))
            {
                var prm = DiffractionOptics.Read(fileName[0]);
                FormDiffractionSimulator.SkipDrawing = true;
                if (prm.SACLA_EH5 == "True")
                {
                    FormDiffractionSimulator.waveLengthControl.WaveSource = WaveSource.Xray;
                    FormDiffractionSimulator.waveLengthControl.XrayWaveSourceElementNumber = 0;

                    FormDiffractionSimulator.waveLengthControl.WaveLength = Convert.ToDouble(prm.waveLength) * 0.1;

                    DetectorPixelSize = Convert.ToDouble(prm.SACLA_EH5_PixleSize);
                    DetectorHeight = Convert.ToInt32(prm.SACLA_EH5_PixelHeight);
                    DetectorWidth = Convert.ToInt32(prm.SACLA_EH5_PixelWidth);

                    if (pseudBitmap != null && (pseudBitmap.Width != DetectorWidth || pseudBitmap.Height != DetectorHeight))//既に読み込んでいる画像のサイズと異なっていたら
                    {
                        textBoxFileName.Text = "";
                        pseudBitmap = null;
                        OverlappedImage = null;
                    }

                    FootX = Convert.ToDouble(prm.SACLA_EH5_FootX);
                    FootY = Convert.ToDouble(prm.SACLA_EH5_FootY);
                    Tau = Convert.ToDouble(prm.SACLA_EH5_TwoTheta) / 180.0 * Math.PI;

                    CameraLength2 = Convert.ToDouble(prm.SACLA_EH5_Distance);
                }
                else
                {
                    FootX = Convert.ToDouble(prm.centerX);
                    FootY = Convert.ToDouble(prm.centerY);

                    FormDiffractionSimulator.waveLengthControl.WaveSource = (WaveSource)Convert.ToInt32(prm.waveSource);
                    FormDiffractionSimulator.waveLengthControl.XrayWaveSourceElementNumber = Convert.ToInt32(prm.xRayElement);
                    FormDiffractionSimulator.waveLengthControl.XrayWaveSourceLine = (XrayLine)Convert.ToInt32(prm.xRayLine);
                    FormDiffractionSimulator.waveLengthControl.WaveLength = Convert.ToDouble(prm.waveLength) * 0.1;

                    DetectorPixelSize = (Convert.ToDouble(prm.pixSizeX) + Convert.ToDouble(prm.pixSizeX)) / 2.0;
                }

                ShowDetectorArea = true;
                FormDiffractionSimulator.SkipDrawing = false;
            }
            else
            {
                if (ReadImage(fileName[0]))
                {
                    ShowDetectorArea = true;
                    this.Visible = true;
                }
            }
        }

        public void FormDiffractionSimulatorGeometry_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetData(DataFormats.FileDrop) != null) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void buttonClearPicture_Click(object sender, EventArgs e)
        {
            textBoxFileName.Text = "";
            pseudBitmap = null;
            OverlappedImage = null;
            FormDiffractionSimulator.Draw();
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            numericalTextBoxPixelHeight.Enabled = numericalTextBoxPixelWidth.Enabled = textBoxFileName.Text == "";
        }

        private void trackBarPictureOpacity1_ValueChanged(object sender, EventArgs e)
        {
            FormDiffractionSimulator.Draw();
        }

        private void buttonRot90_Click(object sender, EventArgs e)
        {
            if (pseudBitmap != null)
            {
                FormDiffractionSimulator.SkipDrawing = true;
                int width = pseudBitmap.Width, height = pseudBitmap.Height;
                double[] d = new double[pseudBitmap.SrcValuesGray.Length];
                int n = 0;
                for (int x = 0; x < width; x++)
                    for (int y = height - 1; y >= 0; y--)
                    {
                        d[n++] = pseudBitmap.SrcValuesGray[x + y * width];
                    }
                pseudBitmap.SrcValuesGray = d;
                numericalTextBoxPixelWidth.Value = pseudBitmap.Width = height;
                numericalTextBoxPixelHeight.Value = pseudBitmap.Height = width;
                OverlappedImage = pseudBitmap.GetImage();
                FormDiffractionSimulator.SkipDrawing = false;
            }
            else
            {
                FormDiffractionSimulator.SkipDrawing = true;
                int temp = (int)numericalTextBoxPixelWidth.Value;
                numericalTextBoxPixelWidth.Value = numericalTextBoxPixelHeight.Value;
                numericalTextBoxPixelHeight.Value = temp;
                FormDiffractionSimulator.SkipDrawing = false;
            }
        }

        private void CheckBoxShowSchematicDiagram_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelSchematicDiagram.Visible = checkBoxSchematicDiagram.Checked;
            this.ClientSize = new Size(panel2.Width, panel2.Location.Y + panel2.Height);
        }

        public bool ReadImage(string filename)
        {
            try
            {
                if (filename.EndsWith("ipa"))
                {
                    ImageIO.IPAImage ipa = ImageIO.GetIPA_Object(filename);
                    pseudBitmap = new PseudoBitmap(Ring.Intensity.ToArray(), Ring.SrcImgSize.Width, PseudoBitmap.BrightnessScaleR, PseudoBitmap.BrightnessScaleG, PseudoBitmap.BrightnessScaleB);

                    FormDiffractionSimulator.waveLengthControl.Property = ipa.WaveProperty;

                    DetectorWidth = pseudBitmap.Width;
                    DetectorHeight = pseudBitmap.Height;
                    DetectorPixelSize = ipa.Resolution; FootX = ipa.Center.X; FootY = ipa.Center.Y;
                    CameraLength2 = ipa.CameraLength;
                }
                if (filename.EndsWith("dm3") || filename.EndsWith("dm4"))

                {
                    if (ImageIO.ReadImage(filename))
                    {
                        //DigitalMicroGraphデータであればスケールの情報などを取得
                        if (Ring.DigitalMicrographProperty.PixelUnit == Crystallography.PixelUnitEnum.NanoMeterInv)
                        {
                            pseudBitmap = new PseudoBitmap(Ring.Intensity.ToArray(), Ring.SrcImgSize.Width, PseudoBitmap.BrightnessScaleR, PseudoBitmap.BrightnessScaleG, PseudoBitmap.BrightnessScaleB, false);

                            FormDiffractionSimulator.waveLengthControl.WaveSource = Crystallography.WaveSource.Electron;
                            FormDiffractionSimulator.waveLengthControl.Energy = Ring.DigitalMicrographProperty.AccVoltage / 1000.0;
                            DetectorPixelSize = Ring.DigitalMicrographProperty.PixelSizeInMicron / 1000.0;
                            CameraLength2 = Ring.DigitalMicrographProperty.PixelSizeInMicron / 1000 / Math.Tan(2 * Math.Asin(FormDiffractionSimulator.WaveLength * Ring.DigitalMicrographProperty.PixelScale / 2));
                            Tau = 0;
                            if (DetectorWidth != pseudBitmap.Width || DetectorHeight != pseudBitmap.Height)
                            {
                                DetectorWidth = pseudBitmap.Width;
                                DetectorHeight = pseudBitmap.Height;
                                FootX = DetectorWidth / 2;
                                FootY = DetectorHeight / 2;
                            }
                        }
                    }
                }
                else if (filename.ToLower().EndsWith("bmp") || filename.ToLower().EndsWith("jpg") || filename.ToLower().EndsWith("tif"))
                {
                    ImageIO.ReadImage(filename);

                    //tifの場合は上下反転(理由は不明)
                    /*for (int y = 0; y < Ring.SrcImgSize.Height / 2; y++)
                    {
                        for (int x = 0; x < Ring.SrcImgSize.Width; x++)
                        {
                            double temp = Ring.Intensity[x + y * Ring.SrcImgSize.Width];
                            Ring.Intensity[x + y * Ring.SrcImgSize.Width] = Ring.Intensity[x + (Ring.SrcImgSize.Height - y - 1) * Ring.SrcImgSize.Width];
                            Ring.Intensity[x + (Ring.SrcImgSize.Height - y - 1) * Ring.SrcImgSize.Width] = temp;
                        }
                    }*/

                    pseudBitmap = new PseudoBitmap(Ring.Intensity.ToArray(), Ring.SrcImgSize.Width, PseudoBitmap.BrightnessScaleR, PseudoBitmap.BrightnessScaleG, PseudoBitmap.BrightnessScaleB, false);
                    DetectorWidth = pseudBitmap.Width;
                    DetectorHeight = pseudBitmap.Height;
                }
                else
                    return false;

                textBoxFileName.Text = filename;

                Ring.CalcFreq();
                trackbarConstantA = Ring.Intensity.Min() - 1;
                trackbarConstantB = trackBarMaxInt.Maximum / Math.Log(Ring.Intensity.Max() - trackbarConstantA);

                pseudBitmap.MaxValue = Ring.Intensity.Max();
                pseudBitmap.MinValue = Ring.Intensity.Min();

                setScale();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}