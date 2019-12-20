using Crystallography;
using Crystallography.Controls;
using Crystallography.Controls.Numeric;
using Crystallography.OpenGL;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Col4 = OpenTK.Graphics.Color4;
using Vec3 = OpenTK.Vector3d;


namespace ReciPro
{
    public partial class FormMain : Form
    {
        [DllImport("user32")]
        private static extern short GetAsyncKeyState(int nVirtKey);

        #region �N���b�v�{�[�h�Ď�

        private IntPtr NextHandle;
        private const int WM_DRAWCLIPBOARD = 0x0308;
        private const int WM_CHANGECBCHAIN = 0x030D;

        [DllImport("user32")]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("user32")]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            switch (msg.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if ((Clipboard.GetDataObject()).GetDataPresent(typeof(Crystal2)))
                    {
                        var data = Clipboard.GetDataObject();
                        var c2 = (Crystal2)data.GetData(typeof(Crystal2));
                        crystalControl.Crystal = Crystal2.GetCrystal(c2);
                    }

                    if ((int)NextHandle != 0)
                        SendMessage(NextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (msg.WParam == NextHandle)
                        NextHandle = (IntPtr)msg.LParam;
                    else if ((int)NextHandle != 0)
                        SendMessage(NextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;
            }
            base.WndProc(ref msg);
        }

        #endregion �N���b�v�{�[�h�Ď�

        public double Phi { get => (double)numericUpDownEulerPhi.Value / 180.0 * Math.PI; set => numericUpDownEulerPhi.Value = (decimal)(value / Math.PI * 180.0); }
        public double Theta { get => (double)numericUpDownEulerTheta.Value / 180.0 * Math.PI; set => numericUpDownEulerTheta.Value = (decimal)(value / Math.PI * 180.0); }
        public double Psi { get { return (double)numericUpDownEulerPsi.Value / 180.0 * Math.PI; } set { numericUpDownEulerPsi.Value = (decimal)(value / Math.PI * 180.0); } }

        public string UserAppDataPath = new DirectoryInfo(Application.UserAppDataPath).Parent.FullName + @"\";


        public Crystal Crystal { get => crystalControl.Crystal; set => crystalControl.Crystal = Crystal; }//=new Crystal();

        public Crystal[] Crystals
        {
            get
            {
                if (listBox.SelectedItems.Count == 1)
                    return new[] { Crystal };
                else
                {
                    var crystals = listBox.SelectedItems.Cast<Crystal>().ToArray();
                    for (int i = 0; i < crystals.Length; i++)
                        if (crystals[i] == (Crystal)listBox.SelectedItem)
                            crystals[i] = Crystal;
                    return crystals;
                }
            }
        }

        public FormStructureViewer FormStructureViewer;
        public FormDiffractionSimulator FormDiffractionSimulator;
        public FormStereonet FormStereonet;
        public FormTEMID FormTEMID;
        public FormSpotID FormSpotID;
        public FormCalculator FormCalculator;
        public FormPolycrystallineDiffractionSimulator FormPolycrystallineDiffractionSimulator;
        public FormRotationMatrix FormRotation;
        public FormImageSimulator FormImageSimulator;

        private WaitDlg initialDialog;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public FormMain()
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\Crystallography\\ReciPro");
            try
            {
                if ((ModifierKeys & Keys.Control) == Keys.Control)
                    regKey.SetValue("DisableOpenGL", true);

                string culture = (string)regKey.GetValue("Culture", Thread.CurrentThread.CurrentUICulture.Name);
                if (culture.ToLower().StartsWith("ja"))
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
                else
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            }
            catch { }

            InitializeComponent();
        }

        private GLControlAlpha glControlAxes;

        /// <summary>
        /// �t�H�[�����[�h��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            sw.Restart();


            //#if !DEBUG
            //Ngen.Compile(new string[] { "Crystallography.dll", "Crystallography.Control.dll", "GLSharp.dll", "OpenTK.dll", "OpenTK.GLU.dll", "ReciPro.exe" });
            //Ngen.Compile();
            //#endif
            //  long t;
            //  toolStripStatusLabelCalcTime.Text = "";
            //  Stopwatch sw = new System.Diagnostics.Stopwatch();
            //  sw.Start();

            englishToolStripMenuItem.Checked = Thread.CurrentThread.CurrentUICulture.Name != "ja";

            japaneseToolStripMenuItem.Checked = Thread.CurrentThread.CurrentUICulture.Name == "ja";

            initialDialog = new WaitDlg
            {
                Owner = this,
                Version = "ReciPro  " + Version.VersionAndDate,
                Text = "Now Loading...",
                ShowVersion = true,
                //Hint = Version.Hint,
                ShowHints = false,
            };
            initialDialog.Show();
            Application.DoEvents();

            try { ReadInitialRegistry(); }
            catch { MessageBox.Show("failed reading registries."); }

            //������glControl�R���g���[����ǉ�. Mac���̑Ή��̂��߁B
            try
            {
                glControlAxes = new GLControlAlpha
                {
                    AllowMouseRotation = false,
                    AllowMouseScaling = false,
                    AllowMouseTranslating = false,
                    DisablingOpenGL = disableOpneGLToolStripMenuItem.Checked,
                    Width = groupBox7.ClientSize.Width,
                    Height = groupBox7.ClientSize.Width,
                    Name = "glControlAxes",
                    NodeCoefficient = 1,
                    ProjectionMode = GLControlAlpha.ProjectionModes.Orhographic,
                    ProjWidth = 4D,
                    RenderingTransparency = GLControlAlpha.RenderingTransparencyModes.Never,
                    RotationMode = GLControlAlpha.RotationModes.Object,
                    TranslatingMode = GLControlAlpha.TranslatingModes.View
                };
                glControlAxes.Paint += new PaintEventHandler(glControlAxes_Paint);
                glControlAxes.MouseDown += new MouseEventHandler(panelAxes_MouseDown);
                glControlAxes.MouseMove += new MouseEventHandler(panelAxes_MouseMove);

                groupBox7.Controls.Add(glControlAxes);
            }
            catch
            {
                RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\Crystallography\\ReciPro");
                regKey.SetValue("DisableOpenGL", true);
                this.Close();
            }

            initialDialog.Text = "Now Loading...Initializing OpenGL.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.1);
            glControlAxes.LightPosition = new Vec3(100, 100, 100);
            glControlAxes.ProjWidth = 2.4;
            Application.DoEvents();


            initialDialog.Text = "Now Loading...Initializing 'Rotation' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.15);
            Application.DoEvents();
            FormRotation = new FormRotationMatrix
            {
                FormMain = this,
                Visible = false
            };


            initialDialog.Text = "Now Loading...Initializing 'Structure Viewer' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.2);
            Application.DoEvents();
            FormStructureViewer = new FormStructureViewer
            {
                formMain = this,
                Visible = false
            };
            FormStructureViewer.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            FormStructureViewer.KeyUp += new KeyEventHandler(FormMain_KeyUp);

            initialDialog.Text = "Now Loading...Initializing 'Stereonet' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.3);
            Application.DoEvents();
            FormStereonet = new FormStereonet
            {
                formMain = this,
                Visible = false
            };
            FormStereonet.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            FormStereonet.KeyUp += new KeyEventHandler(FormMain_KeyUp);

            initialDialog.Text = "Now Loading...Initializing 'Crystal diffraction' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.4);
            Application.DoEvents();
            FormDiffractionSimulator = new FormDiffractionSimulator
            {
                formMain = this,
                Visible = false
            };
            FormDiffractionSimulator.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            FormDiffractionSimulator.KeyUp += new KeyEventHandler(FormMain_KeyUp);
            FormDiffractionSimulator.VisibleChanged += FormElectronDiffraction_VisibleChanged;


            initialDialog.Text = "Now Loading...Initializing 'HRTEM/STEM Image Simulator' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.45);
            Application.DoEvents();
            FormImageSimulator = new FormImageSimulator
            {
                FormMain = this,
                Visible = false
            };
            //FormDiffractionSimulator.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            //FormDiffractionSimulator.KeyUp += new KeyEventHandler(FormMain_KeyUp);
            //FormDiffractionSimulator.VisibleChanged += FormElectronDiffraction_VisibleChanged;


            initialDialog.Text = "Now Loading...Initializing 'Powder diffraction' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.5);
            Application.DoEvents();
            FormPolycrystallineDiffractionSimulator = new FormPolycrystallineDiffractionSimulator
            {
                formMain = this,
                Visible = false
            };
            FormPolycrystallineDiffractionSimulator.VisibleChanged += formPolycrystallineDiffractionSimulator_VisibleChanged;

            initialDialog.Text = "Now Loading...Initializing 'TEM ID' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.6);
            Application.DoEvents();
            //  t = sw.ElapsedMilliseconds;
            FormTEMID = new FormTEMID
            {
                formMain = this,
                Visible = false
            };
            FormTEMID.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            FormTEMID.KeyUp += new KeyEventHandler(FormMain_KeyUp);
            FormTEMID.Visible = false;
            FormTEMID.VisibleChanged += FormTEMID_VisibleChanged;

            initialDialog.Text = "Now Loading...Initializing 'Spot ID' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.7);
            Application.DoEvents();
            FormSpotID = new FormSpotID
            {
                FormMain = this,
                Visible = false
            };

            initialDialog.Text = "Now Loading...Initializing 'Calculator' form.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.8);
            Application.DoEvents();
            //  toolStripStatusLabelCalcTime.Text += "formTEMID " + (sw.ElapsedMilliseconds-t).ToString() + "  ";

            FormCalculator = new FormCalculator
            {
                Owner = this,
                Visible = false
            };
            FormCalculator.KeyDown += new KeyEventHandler(FormMain_KeyDown);
            FormCalculator.KeyUp += new KeyEventHandler(FormMain_KeyUp);
            FormCalculator.FormClosing += new FormClosingEventHandler(formCalculator_FormClosing);

            initialDialog.Text = "Now Loading...Initializing clipboard viewer.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.9);
            Application.DoEvents();
            NextHandle = SetClipboardViewer(this.Handle);

            initialDialog.Text = "Now Loading...Setting CrystalChanged event.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.91);
            Application.DoEvents();
            crystalControl.CrystalChanged += new CrystalControl.MyEventHandler(crystalControl_CrystalChanged);

            initialDialog.Text = "Now Loading...Initialize Crystal class.";
            Crystal = new Crystal();

            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.92);
            Application.DoEvents();

            initialDialog.Text = "Now Loading...Setting default crystal list.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.94);

            //���[�U�[�p�X��initial.xml�����݂��Ȃ��ꍇ�́Adefault.xml��initial.xml�Ƃ��ăR�s�[
            if (!File.Exists(UserAppDataPath + "initial.xml"))
                File.Copy("default.xml", UserAppDataPath + "initial.xml", true);

            //���[�U�[�p�X��default.xml�����݂��Ȃ��ꍇ�́A���s�t�H���_��default.xml�����[�U�[�p�X�ɃR�s�[
            //!!����͊J������ClickOnece�Ŏ��s�����ꍇ�ւ̑Ή�!!�@
            if (!File.Exists(UserAppDataPath + "default.xml"))
                File.Copy("default.xml", UserAppDataPath + "default.xml", true);

            Directory.Delete(Application.UserAppDataPath, true);
            if (File.Exists(UserAppDataPath + "ReciProSetup.msi"))
                File.Delete(UserAppDataPath + "ReciProSetup.msi");

            //�����������X�g��ǂݍ���
            readCrystalList(UserAppDataPath + "default.xml", false, true);
            
            //���炩�̗��R(�O�񂪕s���I���������Ȃ�)��defalut.xml�����Ă���ꍇ��initial.xml��ǂݍ���
            if(listBox.Items.Count==0)
                readCrystalList(UserAppDataPath + "initial.xml", false, true);

            initialDialog.Text = "Now Loading...Setting ReadMe.txt.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.96);
            Application.DoEvents();

            DrawAxes();

            initialDialog.Text = "Now Loading...Reading registries again.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.98);
            Application.DoEvents();
            ReadInitialRegistry();

            initialDialog.Text = "Now Loading...Recognizing Click Once application or not.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 0.99);
            Application.DoEvents();
            this.Text = "ReciPro  " + Version.VersionAndDate;

            //if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            //{
            //    checkUpdatesToolStripMenuItem.Visible = false;//click once�̏ꍇ
            //    this.Text += "   Caution! ClickOnce vesion will be not maintained in the future.";
            //}

            initialDialog.Text = "Initializing has been finished successfully. You can close this window.";
            initialDialog.progressBar.Value = (int)(initialDialog.progressBar.Maximum * 1.0);
            if (initialDialog.AutomaricallyClose)
                initialDialog.Visible = false;

            toolStripStatusLabelCalcTime.Text = "Startup time: " + sw.ElapsedMilliseconds + " ms.";

            if (disableOpneGLToolStripMenuItem.Checked)
            {
                toolStripButtonStructureViewer.Visible = false;
            }
            else if (!glControlAxes.GLRequirement)
            {
                MessageBox.Show(
                     "Open GL ver " + glControlAxes.GLVersionCurrent + " is running on the current environment." + ".\r\n" +
                     "Because ReciPro requires OpenGL ver " + glControlAxes.GLVersionRequired +
                     " or later for rendering 3D objects, the functions are currently disabled. Sorry."
                     , "Caution!");
                toolStripButtonStructureViewer.Visible = false;
                glControlAxes.Visible = false;
            }
        }

        //�A�j���[�V����
        public bool AnimationMode { get { return checkBoxAnimation.Checked; } set { checkBoxAnimation.Checked = value; } }

        public bool YusaGonioMode { get => yusaGonioMode; set => yusaGonioMode = value; }

        private bool yusaGonioMode = false;

        /// <summary>
        /// ��]�ʂƉ�]�p�x���w�肵�āA�S�t�H�[���ɉ�]���߂��o��
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        public void Rotate((double X, double Y, double Z) axis, double angle)
        {
            Rotate(new Vector3DBase(axis.X, axis.Y, axis.Z), angle);
        }

        /// <summary>
        /// ��]�ʂƉ�]�p�x���w�肵�āA�S�t�H�[���ɉ�]���߂��o��
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        public void Rotate(Vector3DBase axis, double angle)
        {
            axis = axis.Normarize();
            if (angle == 0) return;

            for (int i = 0; i < Crystals.Length; i++)
            {
                Matrix3D rot;
                if (!checkBoxFixAxis.Checked && !checkBoxFixePlane.Checked)
                    rot = Matrix3D.Rot(axis, angle);
                else
                {
                    Vector3DBase newAxis;
                    if (checkBoxFixAxis.Checked)
                        newAxis = Crystals[i].RotationMatrix * (numericalTextBoxAxisU.Value * Crystal.A_Axis + numericalTextBoxAxisV.Value * Crystal.B_Axis + numericalTextBoxAxisW.Value * Crystal.C_Axis);
                    else
                        newAxis = Crystals[i].RotationMatrix * (numericalTextBoxPlaneH.Value * Crystal.A_Star + numericalTextBoxPlaneK.Value * Crystal.B_Star + numericalTextBoxPlaneL.Value * Crystal.C_Star);
                    if (Vector3DBase.AngleBetVectors(newAxis, axis) < Math.PI / 2)
                        rot = Matrix3D.Rot(newAxis, angle);
                    else
                        rot = Matrix3D.Rot(newAxis, -angle);
                }
                Crystals[i].RotationMatrix = rot * Crystals[i].RotationMatrix;
            }
            SetRotation(Crystals[0].RotationMatrix);
        }

        /// <summary>
        /// ��]�s����w�肵�āA�S�t�H�[���̉�]��Ԃ��Z�b�g����
        /// </summary>
        /// <param name="mat"></param>
        public void SetRotation(Matrix3D mat)
        {
            if (this.InvokeRequired)//�ʃX���b�h����Ăяo���ꂽ�Ƃ� Invoke���ČĂтȂ���
            {
                this.Invoke(new Action(() => SetRotation(mat)), null);
                return;
            }
            Crystal.RotationMatrix = mat;
            if (FormStructureViewer.Visible)
                FormStructureViewer.Draw();
            if (FormStereonet.Visible)
                FormStereonet.Draw();
            if (FormDiffractionSimulator.Visible)
                FormDiffractionSimulator.Draw();
            if (FormImageSimulator.Visible)
                FormImageSimulator.RotationChanged();

            if (SkipEulerChange && FormRotation.Visible)//Euler angle �����ړ��͂���Ă��鎞
                FormRotation.SetRotation();


            DrawAxes();

            if (SkipEulerChange)
                return;
            var euler = Euler.GetEulerAngle(Crystal.RotationMatrix);
            SkipEulerChange = true;
            numericUpDownEulerPhi.Value = (decimal)(euler.Phi / Math.PI * 180);
            numericUpDownEulerTheta.Value = (decimal)(euler.Theta / Math.PI * 180);
            numericUpDownEulerPsi.Value = (decimal)(euler.Psi / Math.PI * 180);
            SkipEulerChange = false;

            if (FormRotation.Visible)//Euler Angle �����ړ��͂���Ă��Ȃ��Ƃ�
                FormRotation.SetRotation();

            SetNearestUVW();
        }

        private void FormTEMID_VisibleChanged(object sender, EventArgs e)
        {
            if (FormTEMID.Visible || FormDiffractionSimulator.Visible || FormPolycrystallineDiffractionSimulator.Visible)
                listBox.SelectionMode = SelectionMode.MultiExtended;
            else
                listBox.SelectionMode = SelectionMode.One;
        }

        private void FormElectronDiffraction_VisibleChanged(object sender, EventArgs e)
        {
            if (FormTEMID.Visible || FormDiffractionSimulator.Visible || FormPolycrystallineDiffractionSimulator.Visible)
                listBox.SelectionMode = SelectionMode.MultiExtended;
            else
                listBox.SelectionMode = SelectionMode.One;
        }

        private void formPolycrystallineDiffractionSimulator_VisibleChanged(object sender, EventArgs e)
        {
            if (FormTEMID.Visible || FormDiffractionSimulator.Visible || FormPolycrystallineDiffractionSimulator.Visible)
                listBox.SelectionMode = SelectionMode.MultiExtended;
            else
                listBox.SelectionMode = SelectionMode.One;
        }

        private void formCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCalculator.Visible = false;
            e.Cancel = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCalculator.Close();
            FormStereonet.Close();
            FormStructureViewer.Close();
            FormDiffractionSimulator.Close();
            e.Cancel = false;
            SaveInitialRegistry();
            ChangeClipboardChain(this.Handle, NextHandle);

            var cry = new List<Crystal>();
            for (int i = 0; i < listBox.Items.Count; i++)
                cry.Add((Crystal)listBox.Items[i]);
            ConvertCrystalData.SaveCrystalListXml(cry.ToArray(), UserAppDataPath + "default.xml");

        }

        #region ���W�X�g������

        //���W�X�g���̓ǂݍ���
        private void ReadInitialRegistry()
        {
            object o;

            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\Crystallography\\ReciPro");

            if (regKey == null) return;
            if (this != null && (int)regKey.GetValue("formMainLocationX", this.Location.X) >= 0)
            {
                disableOpneGLToolStripMenuItem.Checked = (string)regKey.GetValue("DisableOpenGL") == "True";

                this.Width = (int)regKey.GetValue("formMainWidth", this.Width);
                this.Height = (int)regKey.GetValue("formMainHeight", this.Height);
                this.Location = new Point((int)regKey.GetValue("formMainLocationX", this.Location.X), (int)regKey.GetValue("formMainLocationY", this.Location.Y));
            }

            if (initialDialog != null)
            {
                initialDialog.Location = new Point(this.Location.X + this.Width / 2 - initialDialog.Width / 2, this.Location.Y + this.Height / 2 - initialDialog.Height / 2);
                initialDialog.AutomaricallyClose = (string)regKey.GetValue("initialDialog.AutomaricallyClose", "False") == "True";
            }

            if (FormStructureViewer != null && (int)regKey.GetValue("formStructureViewerLocationX", this.FormStructureViewer.Location.X) >= 0)
            {
                this.FormStructureViewer.Width = (int)regKey.GetValue("formStructureViewerWidth", this.FormStructureViewer.Width);
                this.FormStructureViewer.Height = (int)regKey.GetValue("formCrystalHeight", this.FormStructureViewer.Height);
                this.FormStructureViewer.Location = new Point((int)regKey.GetValue("formStructureViewerLocationX", this.FormStructureViewer.Location.X),
                    (int)regKey.GetValue("formStructureViewerLocationY", this.FormStructureViewer.Location.Y));
            }

            if (FormStereonet != null && (int)regKey.GetValue("formStereonetLocationY", this.FormStereonet.Location.Y) >= 0)
            {
                this.FormStereonet.Width = (int)regKey.GetValue("formStereonetWidth", this.FormStereonet.Width);
                this.FormStereonet.Height = (int)regKey.GetValue("formStereonetHeight", this.FormStereonet.Height);
                this.FormStereonet.Location = new Point((int)regKey.GetValue("formStereonetLocationX", this.FormStereonet.Location.X),
                    (int)regKey.GetValue("formStereonetLocationY", this.FormStereonet.Location.Y));

                FormStereonet.colorControl10DegLine.Argb = (int)regKey.GetValue("formStereonet.colorControl10DegLine.Argb", this.FormStereonet.colorControl10DegLine.Argb);
                FormStereonet.colorControl1DegLine.Argb = (int)regKey.GetValue("formStereonet.colorControl1DegLine.Argb", this.FormStereonet.colorControl1DegLine.Argb);
                FormStereonet.colorControl90DegLine.Argb = (int)regKey.GetValue("formStereonet.colorControl90DegLine.Argb", this.FormStereonet.colorControl90DegLine.Argb);
                FormStereonet.colorControlBackGround.Argb = (int)regKey.GetValue("formStereonet.colorControlBackGround.Argb", this.FormStereonet.colorControlBackGround.Argb);
                FormStereonet.colorControlGeneralAxis.Argb = (int)regKey.GetValue("formStereonet.colorControlGeneralAxis.Argb", this.FormStereonet.colorControlGeneralAxis.Argb);
                FormStereonet.colorControlGeneralPlane.Argb = (int)regKey.GetValue("formStereonet.colorControlGeneralPlane.Argb", this.FormStereonet.colorControlGeneralPlane.Argb);
                FormStereonet.colorControlGreatCircle.Argb = (int)regKey.GetValue("formStereonet.colorControlGreatCircle.Argb", this.FormStereonet.colorControlGreatCircle.Argb);
                FormStereonet.colorControlSmallCircle.Argb = (int)regKey.GetValue("formStereonet.colorControlSmallCircle.Argb", this.FormStereonet.colorControlSmallCircle.Argb);
                FormStereonet.colorControlString.Argb = (int)regKey.GetValue("formStereonet.colorControlString.Argb", this.FormStereonet.colorControlString.Argb);
                FormStereonet.colorControlUniqueAxis.Argb = (int)regKey.GetValue("formStereonet.colorControlUniqueAxis.Argb", this.FormStereonet.colorControlUniqueAxis.Argb);
                FormStereonet.colorControlUniquePlane.Argb = (int)regKey.GetValue("formStereonet.colorControlUniquePlane.Argb", this.FormStereonet.colorControlUniquePlane.Argb);
            }
            if (FormDiffractionSimulator != null && (int)regKey.GetValue("formElectronDiffractionLocationY", this.FormDiffractionSimulator.Location.Y) >= 0)
            {
                FormDiffractionSimulator.CancelSetVector = true;
                this.FormDiffractionSimulator.Width = (int)regKey.GetValue("formElectronDiffractionWidth", this.FormDiffractionSimulator.Width);
                this.FormDiffractionSimulator.Height = (int)regKey.GetValue("formElectronDiffractionHeight", this.FormDiffractionSimulator.Height);
                this.FormDiffractionSimulator.Location = new Point((int)regKey.GetValue("formElectronDiffractionLocationX", this.FormDiffractionSimulator.Location.X),
                    (int)regKey.GetValue("formElectronDiffractionLocationY", this.FormDiffractionSimulator.Location.Y));

                FormDiffractionSimulator.pictureBoxBackGround.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxBackGround.BackColor", FormDiffractionSimulator.pictureBoxBackGround.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxDefectLine.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxDefectLine.BackColor", FormDiffractionSimulator.pictureBoxDefectLine.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxExcessLine.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxExcessLine.BackColor", FormDiffractionSimulator.pictureBoxExcessLine.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxForbiddenLattice.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxForbiddenLattice.BackColor", FormDiffractionSimulator.pictureBoxForbiddenLattice.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxForbiddenScrewGlide.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxForbiddenScrewGlide.BackColor", FormDiffractionSimulator.pictureBoxForbiddenScrewGlide.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxNoCondition.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxNoCondition.BackColor", FormDiffractionSimulator.pictureBoxNoCondition.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxOrigin.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxOrigin.BackColor", FormDiffractionSimulator.pictureBoxOrigin.BackColor.ToArgb()));
                FormDiffractionSimulator.pictureBoxString.BackColor = Color.FromArgb((int)regKey.GetValue("formElectronDiffraction.pictureBoxString.BackColor", FormDiffractionSimulator.pictureBoxString.BackColor.ToArgb()));

                FormDiffractionSimulator.FormElectronDiffraction_Load(new object(), new EventArgs());//.Visible = true;

                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.FootX")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.FootX = Convert.ToDouble((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.FootY")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.FootY = Convert.ToDouble((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.CameraLength2")) != null)
                    FormDiffractionSimulator.FormDiffractionSimulatorGeometry.CameraLength2 = Convert.ToDouble((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorWidth")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorWidth = Convert.ToInt32((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorHeight")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorHeight = Convert.ToInt32((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorPixelSize")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorPixelSize = Convert.ToDouble((string)o);
                if ((o = regKey.GetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.Tau")) != null) FormDiffractionSimulator.FormDiffractionSimulatorGeometry.Tau = Convert.ToDouble((string)o);

                double resolution = Convert.ToDouble((string)regKey.GetValue("formElectronDiffraction.numericUpDownResolution.Value", FormDiffractionSimulator.numericBoxResolution.Value.ToString()));

                FormDiffractionSimulator.numericBoxResolution.Value = Math.Min(Math.Max(FormDiffractionSimulator.numericBoxResolution.Minimum, resolution), FormDiffractionSimulator.numericBoxResolution.Maximum);

                FormDiffractionSimulator.waveLengthControl.WaveSource = 
                    (WaveSource)System.Enum.Parse(typeof(WaveSource), (string)regKey.GetValue("formElectronDiffraction.waveLengthControl.WaveSource", FormDiffractionSimulator.waveLengthControl.WaveSource.ToString()));
                FormDiffractionSimulator.waveLengthControl.WaveLength = 
                    Convert.ToDouble(regKey.GetValue("formElectronDiffraction.waveLengthControl.WaveLength", "0.0250793474552456"));
                FormDiffractionSimulator.waveLengthControl.XrayWaveSourceElementNumber = 
                    (int)regKey.GetValue("formElectronDiffraction.waveLengthControl.XrayWaveSourceElementNumber", FormDiffractionSimulator.waveLengthControl.XrayWaveSourceElementNumber);
                FormDiffractionSimulator.waveLengthControl.XrayWaveSourceLine = 
                    (XrayLine)System.Enum.Parse(typeof(XrayLine), (string)regKey.GetValue("formElectronDiffraction.waveLengthControl.XrayWaveSourceLine", FormDiffractionSimulator.waveLengthControl.XrayWaveSourceLine.ToString()));
                FormDiffractionSimulator.CancelSetVector = false;
            }
            if (FormTEMID != null && (int)regKey.GetValue("formTEMIDLocationY", this.FormTEMID.Location.Y) >= 0)
            {
                this.FormTEMID.Width = (int)regKey.GetValue("formTEMIDWidth", this.FormTEMID.Width);
                this.FormTEMID.Height = (int)regKey.GetValue("formTEMIDHeight", this.FormTEMID.Height);
                this.FormTEMID.Location = new Point((int)regKey.GetValue("formTEMIDLocationX", this.FormTEMID.Location.X),
                (int)regKey.GetValue("formTEMIDLocationY", this.FormTEMID.Location.Y));
            }

            regKey.Close();
        }

        //.ini�t�@�C������������
        private void SaveInitialRegistry()
        {
            if (resetRegistryToolStripMenuItem.Checked)
            {
                Registry.CurrentUser.DeleteSubKey("Software\\Crystallography\\ReciPro");
                return;
            }
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\Crystallography\\ReciPro");

            if (regKey == null) return;

            regKey.SetValue("Culture", Thread.CurrentThread.CurrentUICulture.Name);
            regKey.SetValue("DisableOpenGL", disableOpneGLToolStripMenuItem.Checked);

            regKey.SetValue("formMainWidth", this.Width);
            regKey.SetValue("formMainHeight", this.Height);
            regKey.SetValue("formMainLocationX", this.Location.X);
            regKey.SetValue("formMainLocationY", this.Location.Y);
            regKey.SetValue("initialDialog.AutomaricallyClose", initialDialog.AutomaricallyClose);

            regKey.SetValue("formStructureViewerWidth", this.FormStructureViewer.Width);
            regKey.SetValue("formStructureViewerHeight", this.FormStructureViewer.Height);
            regKey.SetValue("formStructureViewerLocationX", this.FormStructureViewer.Location.X);
            regKey.SetValue("formStructureViewerLocationY", this.FormStructureViewer.Location.Y);
            regKey.SetValue("formStereonetWidth", this.FormStereonet.Width);
            regKey.SetValue("formStereonetHeight", this.FormStereonet.Height);
            regKey.SetValue("formStereonetLocationX", this.FormStereonet.Location.X);
            regKey.SetValue("formStereonetLocationY", this.FormStereonet.Location.Y);
            regKey.SetValue("formElectronDiffractionWidth", this.FormDiffractionSimulator.Width);
            regKey.SetValue("formElectronDiffractionHeight", this.FormDiffractionSimulator.Height);
            regKey.SetValue("formElectronDiffractionLocationX", this.FormDiffractionSimulator.Location.X);
            regKey.SetValue("formElectronDiffractionLocationY", this.FormDiffractionSimulator.Location.Y);
            regKey.SetValue("formTEMIDWidth", this.FormTEMID.Width);
            regKey.SetValue("formTEMIDHeight", this.FormTEMID.Height);
            regKey.SetValue("formTEMIDLocationX", this.FormTEMID.Location.X);
            regKey.SetValue("formTEMIDLocationY", this.FormTEMID.Location.Y);

            regKey.SetValue("formElectronDiffraction.pictureBoxBackGround.BackColor", this.FormDiffractionSimulator.pictureBoxBackGround.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxDefectLine.BackColor", this.FormDiffractionSimulator.pictureBoxDefectLine.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxExcessLine.BackColor", this.FormDiffractionSimulator.pictureBoxExcessLine.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxForbiddenLattice.BackColor", this.FormDiffractionSimulator.pictureBoxForbiddenLattice.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxForbiddenScrewGlide.BackColor", this.FormDiffractionSimulator.pictureBoxForbiddenScrewGlide.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxNoCondition.BackColor", this.FormDiffractionSimulator.pictureBoxNoCondition.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxOrigin.BackColor", this.FormDiffractionSimulator.pictureBoxOrigin.BackColor.ToArgb());
            regKey.SetValue("formElectronDiffraction.pictureBoxString.BackColor", this.FormDiffractionSimulator.pictureBoxString.BackColor.ToArgb());

            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.FootX", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.FootX.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.FootY", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.FootY.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.CameraLength2", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.CameraLength2.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorWidth", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorWidth.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorHeight", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorHeight.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.DetectorPixelSize", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.DetectorPixelSize.ToString());
            regKey.SetValue("FormElectronDiffraction.FormDiffractionSimulatorGeometry.Tau", FormDiffractionSimulator.FormDiffractionSimulatorGeometry.Tau.ToString());

            //regKey.SetValue("formElectronDiffraction.numericUpDownPictureResolution.Value", formElectronDiffraction.formOverlapPicture.numericUpDownPictureResolution.Value.ToString());
            regKey.SetValue("formElectronDiffraction.numericUpDownResolution.Value", FormDiffractionSimulator.numericBoxResolution.Value.ToString());

            regKey.SetValue("formElectronDiffraction.waveLengthControl.WaveSource", FormDiffractionSimulator.waveLengthControl.WaveSource);
            regKey.SetValue("formElectronDiffraction.waveLengthControl.WaveLength", FormDiffractionSimulator.waveLengthControl.WaveLength);
            regKey.SetValue("formElectronDiffraction.waveLengthControl.XrayWaveSourceElementNumber", FormDiffractionSimulator.waveLengthControl.XrayWaveSourceElementNumber);
            regKey.SetValue("formElectronDiffraction.waveLengthControl.XrayWaveSourceLine", FormDiffractionSimulator.waveLengthControl.XrayWaveSourceLine);

            regKey.SetValue("formStereonet.colorControl10DegLine.Argb", this.FormStereonet.colorControl10DegLine.Argb);
            regKey.SetValue("formStereonet.colorControl1DegLine.Argb", this.FormStereonet.colorControl1DegLine.Argb);
            regKey.SetValue("formStereonet.colorControl90DegLine.Argb", this.FormStereonet.colorControl90DegLine.Argb);
            regKey.SetValue("formStereonet.colorControlBackGround.Argb", this.FormStereonet.colorControlBackGround.Argb);
            regKey.SetValue("formStereonet.colorControlGeneralAxis.Argb", this.FormStereonet.colorControlGeneralAxis.Argb);
            regKey.SetValue("formStereonet.colorControlGeneralPlane.Argb", this.FormStereonet.colorControlGeneralPlane.Argb);
            regKey.SetValue("formStereonet.colorControlGreatCircle.Argb", this.FormStereonet.colorControlGreatCircle.Argb);
            regKey.SetValue("formStereonet.colorControlSmallCircle.Argb", this.FormStereonet.colorControlSmallCircle.Argb);
            regKey.SetValue("formStereonet.colorControlString.Argb", this.FormStereonet.colorControlString.Argb);
            regKey.SetValue("formStereonet.colorControlUniqueAxis.Argb", this.FormStereonet.colorControlUniqueAxis.Argb);
            regKey.SetValue("formStereonet.colorControlUniquePlane.Argb", this.FormStereonet.colorControlUniquePlane.Argb);

            regKey.Close();
        }

        #endregion ���W�X�g������

        public bool skipDrawing = false;

        private void crystalControl_CrystalChanged(Crystal crystal)
        {
            if (crystal != null)
            {
                var euler = Euler.GetEulerAngle(Crystal.RotationMatrix);
                SkipEulerChange = true;
                numericUpDownEulerPhi.Value = (decimal)(euler.Phi / Math.PI * 180);
                numericUpDownEulerTheta.Value = (decimal)(euler.Theta / Math.PI * 180);
                numericUpDownEulerPsi.Value = (decimal)(euler.Psi / Math.PI * 180);
                SkipEulerChange = false;

                SetNearestUVW();

                if (skipDrawing) return;

                if (FormStructureViewer.Visible)
                    FormStructureViewer.SetGLObjects(crystal);
                if (FormStereonet.Visible)
                    FormStereonet.SetCrystal();
                if (FormDiffractionSimulator.Visible)
                    FormDiffractionSimulator.SetCrystal();
                if (FormSpotID.Visible)
                    FormSpotID.SetCrystal();
                if (FormRotation.Visible)
                    FormRotation.SetRotation();
                if (FormImageSimulator.Visible)
                    FormImageSimulator.RotationChanged();
                DrawAxes();
            }
        }

        #region ToolStripButton�̃C�x���g

        private void toolStripButtonSpotID_CheckedChanged(object sender, EventArgs e)
        {
            FormSpotID.Visible = toolStripButtonSpotID.Checked;
        }

        private void toolStripButtonSymmetryInformation_CheckedChanged(object sender, EventArgs e)
        {
            crystalControl.SymmetryInformationVisible = toolStripButtonSymmetryInformation.Checked;
        }

        private void toolStripButtonScatteringFactor_CheckedChanged(object sender, EventArgs e)
        {
            crystalControl.ScatteringFactorVisible = toolStripButtonScatteringFactor.Checked;
        }

        private void toolStripButtonStructureViewer_CheckedChanged(object sender, EventArgs e)
        {
            FormStructureViewer.Visible = toolStripButtonStructureViewer.Checked;
        }

        private void toolStripButtonStereonet_CheckedChanged(object sender, EventArgs e)
        {
            FormStereonet.Visible = toolStripButtonStereonet.Checked;
        }

        private void ToolStripButtonRotation_CheckedChanged(object sender, EventArgs e)
        {
            FormRotation.Visible = toolStripButtonRotation.Checked;
        }

        private void toolStripButtonElectronDiffraction_CheckedChanged(object sender, EventArgs e)
        {
            FormDiffractionSimulator.Visible = toolStripButtonElectronDiffraction.Checked;
        }

        private void toolStripButtonImageSimulation_CheckedChanged(object sender, EventArgs e)
        {
            FormImageSimulator.Visible = toolStripButtonImageSimulation.Checked;
        }

        private void toolStripButtonPolycrystallineDiffraction_CheckedChanged(object sender, EventArgs e)
        {
            FormPolycrystallineDiffractionSimulator.Visible = toolStripButtonPolycrystallineDiffraction.Checked;
            listBox_SelectedIndexChanged(listBox, e);
        }

        private void toolStripButtonTemID_CheckedChanged(object sender, EventArgs e)
        {
            FormTEMID.Visible = toolStripButtonTEMID.Checked;
        }

        #endregion ToolStripButton�̃C�x���g

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMe formAboutMe = new FormAboutMe();
            formAboutMe.ShowDialog();
        }

        #region ��]�{�^��

        //�p�x���Z�b�g�{�^��
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SetRotation(new Matrix3D());
        }

        private void buttonDirection_Click(object sender, EventArgs e)
        {
            var v = (sender as Button).Name switch
            {
                "buttonTopRight" => new Vector3DBase(-1, 1, 0),
                "buttonRight" => new Vector3DBase(0, 1, 0),
                "buttonBottomRight" => new Vector3DBase(1, 1, 0),
                "buttonBottom" => new Vector3DBase(1, 0, 0),
                "buttonBottomLeft" => new Vector3DBase(1, -1, 0),
                "buttonLeft" => new Vector3DBase(0, -1, 0),
                "buttonTopLeft" => new Vector3DBase(-1, -1, 0),
                "buttonTop" => new Vector3DBase(-1, 0, 0),
                "buttonClock" => new Vector3DBase(0, 0, -1),
                "buttonAntiClock" => new Vector3DBase(0, 0, 1),
                _ => new Vector3DBase(0, 0, 1)
            };

            if (checkBoxAnimation.Checked)
                startAnimation(v);
            else
                Rotate(v, numericBoxStep.RadianValue);
        }

        private Stopwatch stopwatchAnimation = new Stopwatch();
        private long ellapseTime = 0;

        private void startAnimation(Vector3DBase v)
        {
            timer.Stop();
            stopwatchAnimation.Reset();
            stopwatchAnimation.Start();
            ellapseTime = 0;
            rotationAxisAnimation = v;
            timer.Start();
        }

        private Vector3DBase rotationAxisAnimation = new Vector3D(0, 0, 1);
        private int timerCounter = 1;

        private void timer_Tick(object sender, EventArgs e)
        {
            double differenceTime = stopwatchAnimation.ElapsedMilliseconds - ellapseTime;
            ellapseTime = stopwatchAnimation.ElapsedMilliseconds;
            double angle = (differenceTime) / 1000.0 * numericBoxStep.RadianValue;
            if (timerCounter++ % 10 == 0)
            {
                toolStripStatusLabelCalcTime.Text = "Frame rate: " + (1000.0 / differenceTime).ToString("f1") + "frm/sec.";
                timerCounter = 1;
            }
            Rotate(rotationAxisAnimation, angle);
        }

        #endregion ��]�{�^��

        #region �x�N�g���ł̉�]�w��

        private void buttonSetVector_Click(object sender, EventArgs e)
        {
            if (Crystal == null) return;
            double u = numericalTextBoxAxisU.Value, v = numericalTextBoxAxisV.Value, w = numericalTextBoxAxisW.Value;
            double h = numericalTextBoxPlaneH.Value, k = numericalTextBoxPlaneK.Value, l = numericalTextBoxPlaneL.Value;

            Vector3D xVector, yVector, zVector;
            Vector3D aAxis = Crystal.A_Axis, bAxis = Crystal.B_Axis, cAxis = Crystal.C_Axis;
            Matrix3D matrixInverse = Matrix3D.Inverse(new Matrix3D(aAxis, bAxis, cAxis));
            Vector3D aStar = new Vector3D(matrixInverse.E11, matrixInverse.E12, matrixInverse.E13);
            Vector3D bStar = new Vector3D(matrixInverse.E21, matrixInverse.E22, matrixInverse.E23);
            Vector3D cStar = new Vector3D(matrixInverse.E31, matrixInverse.E32, matrixInverse.E33);
            //���𗧂Ă�Ƃ�
            if (((Button)sender).Name == "buttonSetAxis" && !(u == 0 && v == 0 && w == 0))
            {
                //�܂����Ă鎲�̃x�N�g����T��
                zVector = u * aAxis + v * bAxis + w * cAxis;
                zVector.NormarizeThis();
                //������̃x�N�g�������߂�
                if (u * h + v * k + w * l != 0 || (h == 0 && k == 0 && l == 0))//�������ݒ肳��Ă��Ȃ��Ƃ���hkl�ʂ�ݒ肵�Ă��
                {
                    if (u == 0 && v != 0 && w != 0) { h = 1; k = 0; l = 0; }
                    else if (u != 0 && v == 0 && w != 0) { h = 0; k = 1; l = 0; }
                    else if (u != 0 && v != 0 && w == 0) { h = 0; k = 0; l = 1; }
                    else if (u == 0 && v == 0 && w != 0) { h = 1; k = 0; l = 0; }
                    else if (u != 0 && v == 0 && w == 0) { h = 0; k = 1; l = 0; }
                    else if (u == 0 && v != 0 && w == 0) { h = 0; k = 0; l = 1; }
                    else { h = v; k = -u; l = 0; }
                }
                yVector = h * aStar + k * bStar + l * cStar;
                yVector.NormarizeThis();
            }//�ʂ𗧂Ă�Ƃ�
            else if (((Button)sender).Name == "buttonSetPlane" && !(h == 0 && k == 0 && l == 0))
            {
                //�܂����Ă�ʂ̃x�N�g����T��
                zVector = h * aStar + k * Crystal.B_Star + l * cStar;
                zVector.NormarizeThis();
                //������̃x�N�g�������߂�
                if (u * h + v * k + w * l != 0 || (u == 0 && v == 0 && w == 0))//�������ݒ肳��Ă��Ȃ��Ƃ���hkl�ʂ�ݒ肵�Ă��
                {
                    if (h == 0 && k != 0 && l != 0) { u = 1; v = 0; w = 0; }
                    else if (h != 0 && k == 0 && l != 0) { u = 0; v = 1; w = 0; }
                    else if (h != 0 && k != 0 && l == 0) { u = 0; v = 0; w = 1; }
                    else if (h == 0 && k == 0 && l != 0) { u = 1; v = 0; w = 0; }
                    else if (h != 0 && k == 0 && l == 0) { u = 0; v = 1; w = 0; }
                    else if (h == 0 && k != 0 && l == 0) { u = 0; v = 0; w = 1; }
                    else { u = k; v = -h; w = 0; }
                }
                yVector = u * aAxis + v * bAxis + w * cStar;
                yVector.NormarizeThis();
            }
            else
                return;

            xVector = Vector3D.VectorProduct(yVector, zVector);
            //xVector,yVector,zVector��(100),(010),(001)�Ɉ�v����΂����̂�����@
            Matrix3D matrix = Matrix3D.Inverse(new Matrix3D(xVector, yVector, zVector));
            SetRotation(matrix);
        }

        #endregion �x�N�g���ł̉�]�w��

        #region �I�C���[�p�x�𒼐ړ��͂����΂���

        public bool SkipEulerChange = false;

        private void numericUpDownPhi_ValueChanged(object sender, EventArgs e)
        {
            if (SkipEulerChange) return;
            SkipEulerChange = true;
            if (numericUpDownEulerPhi.Value > 180)
                numericUpDownEulerPhi.Value -= 360;
            if (numericUpDownEulerPhi.Value < -180)
                numericUpDownEulerPhi.Value += 360;

            if (numericUpDownEulerPsi.Value > 180)
                numericUpDownEulerPsi.Value -= 360;
            if (numericUpDownEulerPsi.Value < -180)
                numericUpDownEulerPsi.Value += 360;

            var phi = (double)numericUpDownEulerPhi.Value / 180.0 * Math.PI;
            var theta = (double)numericUpDownEulerTheta.Value / 180.0 * Math.PI;
            var psi = (double)numericUpDownEulerPsi.Value / 180.0 * Math.PI;

            double cosPhi = Math.Cos(phi), sinPhi = Math.Sin(phi);
            double cosTheta = Math.Cos(theta), sinTheta = Math.Sin(theta);
            double cosPsi= Math.Cos(psi), sinPsi = Math.Sin(psi);

            var matrix = new Matrix3D(
                cosPhi * cosPsi - cosTheta * sinPhi * sinPsi,
                sinPhi * cosPsi + cosTheta * cosPhi * sinPsi,
                sinPsi * sinTheta,

                -cosPhi * sinPsi - cosTheta * sinPhi * cosPsi,
                -sinPhi * sinPsi + cosTheta * cosPhi * cosPsi,
                cosPsi * sinTheta,

                sinTheta * sinPhi,
                -sinTheta * cosPhi,
                cosTheta

                );
            SetRotation(matrix);

            SkipEulerChange = false;
        }

        #endregion �I�C���[�p�x�𒼐ړ��͂����΂���

        #region ���X�g�{�b�N�X�֘A

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            int n = listBox.SelectedIndex;
            if (n <= 0) return;
            object o = listBox.SelectedItem;
            listBox.Items.Remove(listBox.SelectedItem);
            listBox.Items.Insert(n - 1, o);
            listBox.SelectedIndex = n - 1;
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            int n = listBox.SelectedIndex;
            if (n >= listBox.Items.Count - 1) return;
            object o = listBox.SelectedItem;
            listBox.Items.Remove(listBox.SelectedItem);
            listBox.Items.Insert(n + 1, o);
            listBox.SelectedIndex = n + 1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (crystalControl.StrainControlVisible) return;

            crystalControl.GenerateCrystal();
            if (crystalControl.Crystal != null)
                listBox.Items.Add(crystalControl.Crystal);
            listBox.SelectedIndex = -1;
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                int n = listBox.SelectedIndex;
                listBox.Items.Remove(listBox.SelectedItem);
                if (listBox.Items.Count > n)
                    listBox.SelectedIndex = n;
                else
                    listBox.SelectedIndex = n - 1;
            }
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (crystalControl.StrainControlVisible) return;

            if (listBox.SelectedIndex < 0) return;

            crystalControl.GenerateCrystal();

            if (crystalControl.Crystal != null && listBox.SelectedIndex >= 0)
                listBox.Items[listBox.SelectedIndex] = crystalControl.Crystal;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                crystalControl.Crystal = (Crystal)listBox.SelectedItem;
            }
            DrawAxes();
        }

        #endregion ���X�g�{�b�N�X�֘A

        #region FileMenu

        //�����f�[�^�̓ǂݍ���
        private void readCrystalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Dlg = new System.Windows.Forms.OpenFileDialog { Filter = "xml, out|*.xml;*.out" };
            if (Dlg.ShowDialog() == DialogResult.OK)
                readCrystalList(Dlg.FileName, true, true);
        }

        private void readCrystalDataAndAddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Dlg = new System.Windows.Forms.OpenFileDialog { Filter = "xml, out|*.xml;*.out" };
            if (Dlg.ShowDialog() == DialogResult.OK)
                readCrystalList(Dlg.FileName, true, false);
        }

        private void ToolStripMenuItemReadInitialCrystalList_Click(object sender, EventArgs e)
        {
            readCrystalList(UserAppDataPath + "initial.xml", false, true);
        }

        private void readCrystalList(string fileName, bool showSelectionDialog, bool clearPresentList)
        {
            var cry = new List<Crystal>();
            cry.AddRange(ConvertCrystalData.ConvertToCrystalList(fileName));
            if (showSelectionDialog)
            {
                var formCrystalSelection = new FormCrystalSelection
                {
                    LoadMode = true
                };
                formCrystalSelection.SetCrystalList(cry);
                formCrystalSelection.Location = new Point(this.Location.X + this.Width / 2 - formCrystalSelection.Width / 2, this.Location.Y + this.Height / 2 - formCrystalSelection.Height / 2);
                if (formCrystalSelection.ShowDialog() == DialogResult.OK)
                {
                    cry.Clear();
                    cry.AddRange(formCrystalSelection.CheckedCrystalList);
                }
                else return;
            }

            if (cry.Count > 0)
            {
                if (clearPresentList)
                    listBox.Items.Clear();

                foreach (var c in cry)
                    listBox.Items.Add(c);
                if (listBox.Items.Count > 0)
                    listBox.SelectedIndex = 0;
            }
        }

        private void saveCrystalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cry = new List<Crystal>();
            for (int i = 0; i < listBox.Items.Count; i++)
                cry.Add((Crystal)listBox.Items[i]);

            var formCrystalSelection = new FormCrystalSelection
            {
                LoadMode = false
            };
            formCrystalSelection.SetCrystalList(cry);
            if (formCrystalSelection.ShowDialog() == DialogResult.OK)
            {
                var Dlg = new System.Windows.Forms.SaveFileDialog { Filter = "xml|*.xml" };
                try
                {
                    if (Dlg.ShowDialog() == DialogResult.OK)
                        ConvertCrystalData.SaveCrystalListXml(formCrystalSelection.CheckedCrystalList, Dlg.FileName);
                }
                catch
                {
                    MessageBox.Show("�t�@�C�����������݂܂���");
                }
            }
        }

        #endregion FileMenu

        private void helpwebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Contains("ja"))
                    Process.Start("http://pmsl.planet.sci.kobe-u.ac.jp/~seto/software/ReciPro/ja/ReciProHelp.html");
                else
                    Process.Start("http://pmsl.planet.sci.kobe-u.ac.jp/~seto/software/ReciPro/en/ReciProHelp.html");
            }
            catch { }
        }

        private void toolTipToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            toolTip.Active = toolTipToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private Stopwatch sw = new Stopwatch();

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.D)
                toolStripButtonElectronDiffraction.Checked = !toolStripButtonElectronDiffraction.Checked;
            else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                toolStripButtonStructureViewer.Checked = !toolStripButtonStructureViewer.Checked;
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
                toolStripButtonStereonet.Checked = !toolStripButtonStereonet.Checked;
            else if (e.Control && e.Shift && e.KeyCode == Keys.T)
                toolStripButtonSpotID.Checked = !toolStripButtonSpotID.Checked;
            else if (e.Control)//Ctrl��f����2�񂨂��ƌv�Z�@�������B
                if (sw.IsRunning)
                {
                    sw.Stop();
                    if (sw.ElapsedMilliseconds < 100)
                        FormCalculator.Visible = !FormCalculator.Visible;
                    sw.Reset();
                }

            //�����L�[�̐���@�@Left = 37,Up = 38,Right = 39,Down = 40,
            if (e.Control && e.Shift)
            {
                //if (formStructureViewer.panelMain.Focused || formStructureViewer.panelAxes.Focused
                //    || formStereonet.panel.Focused || formElectronDiffraction.panel.Focused)
                {
                    bool left = GetAsyncKeyState(37) != 0;
                    bool up = GetAsyncKeyState(38) != 0;
                    bool right = GetAsyncKeyState(39) != 0;
                    bool down = GetAsyncKeyState(40) != 0;
                    if (up && left)
                        buttonTopLeft.PerformClick();
                    else if (up && right)
                        buttonTopRight.PerformClick();
                    else if (down && left)
                        buttonBottomLeft.PerformClick();
                    else if (down && right)
                        buttonBottomRight.PerformClick();
                    else if (up)
                        buttonTop.PerformClick();
                    else if (down)
                        buttonBottom.PerformClick();
                    else if (right)
                        buttonRight.PerformClick();
                    else if (left)
                        buttonLeft.PerformClick();
                }
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 17)
                sw.Start();
        }

        #region Axis�̕`��֘A

        //���̏���\�����镔��
        public void DrawAxes()
        {
            glControlAxes.WorldMatrixEx = Crystal?.RotationMatrix.Transpose();
        }

        private void crystalControl_CrystalChanged_1(Crystal crystal)
        {
            var max = new[] { Crystal.A, Crystal.B, Crystal.C }.Max();
            var vec = new[] { Crystal.A_Axis / max, Crystal.B_Axis / max, Crystal.C_Axis / max };
            var color = new[] { Col4.Red, Col4.Green, Col4.Blue };

            var obj = new List<GLObject>();
            var mat = new Material(Col4.White, 0.2, 0.7, 0.8, 50, 0.2);
            for (int i = 0; i < 3; i++)
            {
                mat.Color = color[i];
                obj.Add(new Cylinder(-vec[i], vec[i] * 2 - 0.3 * vec[i].Normarize(), 0.075, mat, DrawingMode.Surfaces));
                obj.Add(new Cone(vec[i], -0.3 * vec[i].Normarize(), 0.15, mat, DrawingMode.Surfaces));
            }
            mat.Color = Col4.Gray;
            obj.Add(new Sphere(new Vec3(0, 0, 0), 0.12, mat, DrawingMode.Surfaces));

            glControlAxes.DeleteAllObjects();
            glControlAxes.AddObjects(obj);
        }

        private void panelAxes_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawAxes();
        }

        private void glControlAxes_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("a", new Font("Times", 14, FontStyle.Italic | FontStyle.Bold), new SolidBrush(Color.Red), new PointF(0, 0));
            e.Graphics.DrawString("b", new Font("Times", 14, FontStyle.Italic | FontStyle.Bold), new SolidBrush(Color.Green), new PointF(14, 0));
            e.Graphics.DrawString("c", new Font("Times", 14, FontStyle.Italic | FontStyle.Bold), new SolidBrush(Color.Blue), new PointF(28, 0));
        }

        private void panelAxes_MouseDown(object sender, MouseEventArgs e)
        {
            glControlAxes.Focus();
            if (e.Button == MouseButtons.Right && e.Clicks == 2)
            {
                var bmp = glControlAxes.GenerateBitmap();
                if (bmp != null)
                    Clipboard.SetDataObject(bmp, true, 10, 100);
            }
        }

        private Point lastPosAxes = new Point();

        private void panelAxes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastPosAxes.X, dy = lastPosAxes.Y - e.Y;
                Rotate((-dy, dx, 0), Math.Sqrt(dx * dx + dy * dy) / 360 * Math.PI);
            }
            lastPosAxes = e.Location;
        }

        #endregion Axis�̕`��֘A

        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initialDialog.ShowProgressBar = false;
            initialDialog.Text = "Hint";
            initialDialog.Visible = true;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length == 1 && (fileName[0].ToLower().EndsWith("xml") || fileName[0].ToLower().EndsWith("out") || fileName[0].ToLower().EndsWith("cdb2")))
            {
                DialogResult dr = MessageBox.Show(this, "Read the list as a new list (if select 'No', add the list to the end of the present one",
                    "Option", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                    readCrystalList(fileName[0], true, true);
                else
                    readCrystalList(fileName[0], true, false);
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetData(DataFormats.FileDrop) != null) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void crystalControl_scatteringFactor_VisibleChanged(object sender, EventArgs e)
        {
            toolStripButtonScatteringFactor.Checked = crystalControl.ScatteringFactorVisible;
        }

        private void crystalControl_symmetryInformation_VisibleChanged(object sender, EventArgs e)
        {
            toolStripButtonSymmetryInformation.Checked = crystalControl.SymmetryInformationVisible;
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = ((ToolStripMenuItem)sender).Name.Contains("english");
            japaneseToolStripMenuItem.Checked = !englishToolStripMenuItem.Checked;
            Thread.CurrentThread.CurrentUICulture = englishToolStripMenuItem.Checked ? new System.Globalization.CultureInfo("en") : new System.Globalization.CultureInfo("ja");
            Language.Change(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            => Close();

        private void toolStripMenuItemExportCIF_Click(object sender, EventArgs e)
            => crystalControl.exportThisCrystalAsCIFToolStripMenuItem_Click(sender, e);

        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProgramUpdates.CheckUpdate(Version.Software, Version.VersionAndDate))
                Close();
        }

        private void ngenCompileToolStripMenuItem_Click(object sender, EventArgs e)
            => Ngen.Compile();

        private void numericBoxMaxUVW_ValueChanged(object sender, EventArgs e)
        {
            if (Crystal == null || Crystal.A == 0 || Crystal.B == 0 || Crystal.C == 0) return;
            if (Crystal.A_Axis == null)
                Crystal.SetAxis();

            uvwIndices = new List<(int U, int V, int W)>();
            uvwLength2 = new List<double>();

            int limit = numericBoxMaxUVW.ValueInteger;
            for (int u = -limit; u <= limit; u++)
                for (int v = -limit + Math.Abs(u); v <= limit - Math.Abs(u); v++)
                    for (int w = -limit + Math.Abs(u) + Math.Abs(v); w <= limit - Math.Abs(u) - Math.Abs(v); w++)
                    {
                        //���񂩂ǂ����`�F�b�N
                        bool flag = true;
                        for (int i = 2; i <= limit / 2; i++)
                            if (u % i == 0 && v % i == 0 && w % i == 0)
                            {
                                flag = false;
                                break;
                            }
                        if ((u == 0 && v == 0 && Math.Abs(w) != 1) || (Math.Abs(u) != 1 && v == 0 && w == 0) || (u == 0 && Math.Abs(v) != 1 && w == 0))
                            flag = false;
                        if (flag)
                        {
                            uvwIndices.Add((u, v, w));
                            uvwLength2.Add((u * Crystal.A_Axis + v * Crystal.B_Axis + w * Crystal.C_Axis).Length2);
                        }
                    }
            SetNearestUVW();
        }

        private List<(int U, int V, int W)> uvwIndices = new List<(int U, int V, int W)>();
        private List<double> uvwLength2 = new List<double>();

        private void SetNearestUVW()//�ł��߂�uvw������
        {
            if (Crystal == null || Crystal.A == 0 || Crystal.B == 0 || Crystal.C == 0) return;
            if (Crystal.A_Axis == null)
                Crystal.SetAxis();

            if (uvwIndices.Count == 0)
            {
                numericBoxMaxUVW_ValueChanged(new object(), new EventArgs());
                return;
            }

            (int U, int V, int W) bestIndex = (0, 0, 0);
            double aZ = (Crystal.RotationMatrix * Crystal.A_Axis).Z, bZ = (Crystal.RotationMatrix * Crystal.B_Axis).Z, cZ = (Crystal.RotationMatrix * Crystal.C_Axis).Z;
            double dev = 0, temp;

            for (int i = 0; i < uvwIndices.Count; i++)
            {
                var z = uvwIndices[i].U * aZ + uvwIndices[i].V * bZ + uvwIndices[i].W * cZ;
                if (z > 0 && dev < (temp = z * z / uvwLength2[i]))
                {
                    dev = temp;
                    bestIndex = uvwIndices[i];
                }
            }
            labelCurrentIndexU.Text = bestIndex.U.ToString();
            labelCurrentIndexV.Text = bestIndex.V.ToString();
            labelCurrentIndexW.Text = bestIndex.W.ToString();
        }

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
           /* if (e.Button == MouseButtons.Right && e.Clicks == 2)
            {
                FormRotationMatrix formRotationMatrix = new FormRotationMatrix();
                formRotationMatrix.FormMain = this;
                formRotationMatrix.Show();
            }
            */
        }

        private void checkBoxAnimation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnimation.Checked)
            {
                numericBoxStep.FooterText = "��/s";
            }
            else
            {
                numericBoxStep.FooterText = "��";
                timer.Stop();
            }
        }

        private void checkBoxFixAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (numericalTextBoxAxisU.Value == 0 && numericalTextBoxAxisV.Value == 0 && numericalTextBoxAxisW.Value == 0)
            {
                checkBoxFixAxis.Checked = false;
                return;
            }
            if (checkBoxFixAxis.Checked)
                checkBoxFixePlane.Checked = false;
        }

        private void checkBoxFixPlane_CheckedChanged(object sender, EventArgs e)
        {
            if (numericalTextBoxPlaneH.Value == 0 && numericalTextBoxPlaneK.Value == 0 && numericalTextBoxPlaneL.Value == 0)
            {
                checkBoxFixePlane.Checked = false;
                return;
            }
            if (checkBoxFixePlane.Checked)
                checkBoxFixAxis.Checked = false;
        }


    }
}