﻿namespace ReciPro
{
    partial class FormDiffractionSimulator
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //if (context != null)
           //     context.Dispose();
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiffractionSimulator));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDiffractionSpots = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonKikuchiLines = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDebyeRing = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIndexLabels = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDspacing = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDistance = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcitationError = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFg = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.waveLengthControl = new Crystallography.Controls.WaveLengthControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxUseCrystalColor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDefectLine = new System.Windows.Forms.Label();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.trackBarStrSize = new System.Windows.Forms.TrackBar();
            this.labelExcessLine = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1Origin = new System.Windows.Forms.Label();
            this.labelNoCondition = new System.Windows.Forms.Label();
            this.labelForbiddenScrewGlide = new System.Windows.Forms.Label();
            this.labelString = new System.Windows.Forms.Label();
            this.labelForbiddenLattice = new System.Windows.Forms.Label();
            this.pictureBoxDebyeRing = new System.Windows.Forms.PictureBox();
            this.pictureBoxDefectLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxNoCondition = new System.Windows.Forms.PictureBox();
            this.pictureBoxExcessLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxFoot = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.pictureBoxString = new System.Windows.Forms.PictureBox();
            this.pictureBoxForbiddenScrewGlide = new System.Windows.Forms.PictureBox();
            this.pictureBoxForbiddenLattice = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinKL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarLineWidth = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxExtinctionAll = new System.Windows.Forms.CheckBox();
            this.checkBoxExtinctionLattice = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.checkBoxDebyeRingLabel = new System.Windows.Forms.CheckBox();
            this.checkBoxDebyeRingIgnoreIntensity = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarDebyeRingWidth = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericBoxDev = new Crystallography.Controls.NumericBox();
            this.numericBoxAcc = new Crystallography.Controls.NumericBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBarRotationSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCamaraLength2 = new System.Windows.Forms.NumericUpDown();
            this.buttonDetailedGeometry = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonResetCenter = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericBoxClientHeight = new Crystallography.Controls.NumericBox();
            this.numericBoxClientWidth = new Crystallography.Controls.NumericBox();
            this.numericBoxResolution = new Crystallography.Controls.NumericBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelPED = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.numericBoxPED_Semiangle = new Crystallography.Controls.NumericBox();
            this.numericBoxPED_Step = new Crystallography.Controls.NumericBox();
            this.flowLayoutPanelBethe = new System.Windows.Forms.FlowLayoutPanel();
            this.numericBoxNumOfBlochWave = new Crystallography.Controls.NumericBox();
            this.buttonDetailsOfSpots = new System.Windows.Forms.Button();
            this.trackBarAdvancedThickness = new Crystallography.Controls.TrackBarAdvanced();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonIntensityExcitation = new System.Windows.Forms.RadioButton();
            this.radioButtonIntensityKinematical = new System.Windows.Forms.RadioButton();
            this.radioButtonIntensityBethe = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonBeamParallel = new System.Windows.Forms.RadioButton();
            this.radioButtonBeamPrecession = new System.Windows.Forms.RadioButton();
            this.radioButtonBeamConvergence = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.trackBarAdvancedSpotRadius = new Crystallography.Controls.TrackBarAdvanced();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.radioButtonCircleArea = new System.Windows.Forms.RadioButton();
            this.radioButtonPointSpread = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarIntensityForPointSpread = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanelColorScale = new System.Windows.Forms.FlowLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxScaleColorScale = new System.Windows.Forms.ComboBox();
            this.checkBoxLogScale = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarSpotOpacity = new System.Windows.Forms.TrackBar();
            this.labelD = new System.Windows.Forms.Label();
            this.labelMousePointReal = new System.Windows.Forms.Label();
            this.labelMousePointInverse = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDetectorAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDetectorAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDetectorAsMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBEDPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBEDasPngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBEDasTiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBEDasMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyImageToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDetectorAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDetectorAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDetectorAsMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCBEDPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCBEDasImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCBEDasMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackLaue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dynamicCompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.graphicsBox = new ImagingSolution.Control.GraphicsBox(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTimeForSearchingG = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeForDrawing = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeForBethe = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTwoTheta = new System.Windows.Forms.Label();
            this.checkBoxFixCenter = new System.Windows.Forms.CheckBox();
            this.labelDinv = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timerBlinkSpot = new System.Windows.Forms.Timer(this.components);
            this.timerBlinkKikuchiLine = new System.Windows.Forms.Timer(this.components);
            this.timerBlinkDebyeRing = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicConceptOfBethesMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebyeRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcessLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForbiddenScrewGlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForbiddenLattice)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinKL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineWidth)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDebyeRingWidth)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCamaraLength2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanelPED.SuspendLayout();
            this.flowLayoutPanelBethe.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensityForPointSpread)).BeginInit();
            this.flowLayoutPanelColorScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpotOpacity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            resources.ApplyResources(this.toolStrip3, "toolStrip3");
            this.toolStrip3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDiffractionSpots,
            this.toolStripSeparator2,
            this.toolStripButtonKikuchiLines,
            this.toolStripSeparator3,
            this.toolStripButtonDebyeRing});
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonDiffractionSpots
            // 
            this.toolStripButtonDiffractionSpots.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonDiffractionSpots.Checked = true;
            this.toolStripButtonDiffractionSpots.CheckOnClick = true;
            this.toolStripButtonDiffractionSpots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonDiffractionSpots.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDiffractionSpots.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.toolStripButtonDiffractionSpots, "toolStripButtonDiffractionSpots");
            this.toolStripButtonDiffractionSpots.Name = "toolStripButtonDiffractionSpots";
            this.toolStripButtonDiffractionSpots.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            this.toolStripButtonDiffractionSpots.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonDiffractionSpots_MouseDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripButtonKikuchiLines
            // 
            this.toolStripButtonKikuchiLines.CheckOnClick = true;
            this.toolStripButtonKikuchiLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonKikuchiLines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.toolStripButtonKikuchiLines, "toolStripButtonKikuchiLines");
            this.toolStripButtonKikuchiLines.Name = "toolStripButtonKikuchiLines";
            this.toolStripButtonKikuchiLines.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            this.toolStripButtonKikuchiLines.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonDiffractionSpots_MouseDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripButtonDebyeRing
            // 
            this.toolStripButtonDebyeRing.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonDebyeRing.CheckOnClick = true;
            this.toolStripButtonDebyeRing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDebyeRing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.toolStripButtonDebyeRing, "toolStripButtonDebyeRing");
            this.toolStripButtonDebyeRing.Name = "toolStripButtonDebyeRing";
            this.toolStripButtonDebyeRing.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            this.toolStripButtonDebyeRing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonDiffractionSpots_MouseDown);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIndexLabels,
            this.toolStripButtonDspacing,
            this.toolStripButtonDistance,
            this.toolStripButtonExcitationError,
            this.toolStripButtonFg});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonIndexLabels
            // 
            this.toolStripButtonIndexLabels.Checked = true;
            this.toolStripButtonIndexLabels.CheckOnClick = true;
            this.toolStripButtonIndexLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonIndexLabels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIndexLabels.ForeColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.toolStripButtonIndexLabels, "toolStripButtonIndexLabels");
            this.toolStripButtonIndexLabels.Name = "toolStripButtonIndexLabels";
            this.toolStripButtonIndexLabels.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            // 
            // toolStripButtonDspacing
            // 
            this.toolStripButtonDspacing.CheckOnClick = true;
            this.toolStripButtonDspacing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDspacing.ForeColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.toolStripButtonDspacing, "toolStripButtonDspacing");
            this.toolStripButtonDspacing.Name = "toolStripButtonDspacing";
            this.toolStripButtonDspacing.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            // 
            // toolStripButtonDistance
            // 
            this.toolStripButtonDistance.CheckOnClick = true;
            this.toolStripButtonDistance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDistance.ForeColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.toolStripButtonDistance, "toolStripButtonDistance");
            this.toolStripButtonDistance.Name = "toolStripButtonDistance";
            this.toolStripButtonDistance.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            // 
            // toolStripButtonExcitationError
            // 
            this.toolStripButtonExcitationError.CheckOnClick = true;
            this.toolStripButtonExcitationError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExcitationError.ForeColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.toolStripButtonExcitationError, "toolStripButtonExcitationError");
            this.toolStripButtonExcitationError.Name = "toolStripButtonExcitationError";
            this.toolStripButtonExcitationError.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            // 
            // toolStripButtonFg
            // 
            this.toolStripButtonFg.CheckOnClick = true;
            this.toolStripButtonFg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFg.ForeColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.toolStripButtonFg, "toolStripButtonFg");
            this.toolStripButtonFg.Name = "toolStripButtonFg";
            this.toolStripButtonFg.CheckedChanged += new System.EventHandler(this.toolStripButtonDiffractionSpots_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.HotTrack = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.waveLengthControl);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            // 
            // waveLengthControl
            // 
            resources.ApplyResources(this.waveLengthControl, "waveLengthControl");
            this.waveLengthControl.Energy = 120.00000000000001D;
            this.waveLengthControl.Name = "waveLengthControl";
            this.waveLengthControl.ShowWaveSource = true;
            this.waveLengthControl.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveLengthControl.WaveLength = 0.0033492161861278019D;
            this.waveLengthControl.WaveSource = Crystallography.WaveSource.Electron;
            this.waveLengthControl.XrayWaveSourceElementNumber = 0;
            this.waveLengthControl.XrayWaveSourceLine = Crystallography.XrayLine.Ka1;
            this.waveLengthControl.WavelengthChanged += new System.EventHandler(this.waveLengthControl_WavelengthChanged);
            this.waveLengthControl.WaveSourceChanged += new System.EventHandler(this.WaveLengthControl_WaveSourceChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.checkBoxUseCrystalColor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelDefectLine);
            this.tabPage1.Controls.Add(this.labelBackGround);
            this.tabPage1.Controls.Add(this.trackBarStrSize);
            this.tabPage1.Controls.Add(this.labelExcessLine);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label1Origin);
            this.tabPage1.Controls.Add(this.labelNoCondition);
            this.tabPage1.Controls.Add(this.labelForbiddenScrewGlide);
            this.tabPage1.Controls.Add(this.labelString);
            this.tabPage1.Controls.Add(this.labelForbiddenLattice);
            this.tabPage1.Controls.Add(this.pictureBoxDebyeRing);
            this.tabPage1.Controls.Add(this.pictureBoxDefectLine);
            this.tabPage1.Controls.Add(this.pictureBoxNoCondition);
            this.tabPage1.Controls.Add(this.pictureBoxExcessLine);
            this.tabPage1.Controls.Add(this.pictureBoxFoot);
            this.tabPage1.Controls.Add(this.pictureBoxOrigin);
            this.tabPage1.Controls.Add(this.pictureBoxBackGround);
            this.tabPage1.Controls.Add(this.pictureBoxString);
            this.tabPage1.Controls.Add(this.pictureBoxForbiddenScrewGlide);
            this.tabPage1.Controls.Add(this.pictureBoxForbiddenLattice);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // checkBoxUseCrystalColor
            // 
            resources.ApplyResources(this.checkBoxUseCrystalColor, "checkBoxUseCrystalColor");
            this.checkBoxUseCrystalColor.Name = "checkBoxUseCrystalColor";
            this.checkBoxUseCrystalColor.CheckedChanged += new System.EventHandler(this.checkBoxUseCrystalColor_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // labelDefectLine
            // 
            resources.ApplyResources(this.labelDefectLine, "labelDefectLine");
            this.labelDefectLine.Name = "labelDefectLine";
            this.toolTip.SetToolTip(this.labelDefectLine, resources.GetString("labelDefectLine.ToolTip"));
            // 
            // labelBackGround
            // 
            resources.ApplyResources(this.labelBackGround, "labelBackGround");
            this.labelBackGround.Name = "labelBackGround";
            this.toolTip.SetToolTip(this.labelBackGround, resources.GetString("labelBackGround.ToolTip"));
            // 
            // trackBarStrSize
            // 
            resources.ApplyResources(this.trackBarStrSize, "trackBarStrSize");
            this.trackBarStrSize.LargeChange = 50;
            this.trackBarStrSize.Maximum = 200;
            this.trackBarStrSize.Minimum = 1;
            this.trackBarStrSize.Name = "trackBarStrSize";
            this.trackBarStrSize.SmallChange = 10;
            this.trackBarStrSize.TickFrequency = 500;
            this.trackBarStrSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackBarStrSize, resources.GetString("trackBarStrSize.ToolTip"));
            this.trackBarStrSize.Value = 80;
            this.trackBarStrSize.ValueChanged += new System.EventHandler(this.trackBarStrSize_ValueChanged);
            // 
            // labelExcessLine
            // 
            resources.ApplyResources(this.labelExcessLine, "labelExcessLine");
            this.labelExcessLine.Name = "labelExcessLine";
            this.toolTip.SetToolTip(this.labelExcessLine, resources.GetString("labelExcessLine.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label1Origin
            // 
            resources.ApplyResources(this.label1Origin, "label1Origin");
            this.label1Origin.Name = "label1Origin";
            this.toolTip.SetToolTip(this.label1Origin, resources.GetString("label1Origin.ToolTip"));
            // 
            // labelNoCondition
            // 
            resources.ApplyResources(this.labelNoCondition, "labelNoCondition");
            this.labelNoCondition.Name = "labelNoCondition";
            this.toolTip.SetToolTip(this.labelNoCondition, resources.GetString("labelNoCondition.ToolTip"));
            // 
            // labelForbiddenScrewGlide
            // 
            resources.ApplyResources(this.labelForbiddenScrewGlide, "labelForbiddenScrewGlide");
            this.labelForbiddenScrewGlide.Name = "labelForbiddenScrewGlide";
            this.toolTip.SetToolTip(this.labelForbiddenScrewGlide, resources.GetString("labelForbiddenScrewGlide.ToolTip"));
            // 
            // labelString
            // 
            resources.ApplyResources(this.labelString, "labelString");
            this.labelString.Name = "labelString";
            this.toolTip.SetToolTip(this.labelString, resources.GetString("labelString.ToolTip"));
            // 
            // labelForbiddenLattice
            // 
            resources.ApplyResources(this.labelForbiddenLattice, "labelForbiddenLattice");
            this.labelForbiddenLattice.Name = "labelForbiddenLattice";
            this.toolTip.SetToolTip(this.labelForbiddenLattice, resources.GetString("labelForbiddenLattice.ToolTip"));
            // 
            // pictureBoxDebyeRing
            // 
            this.pictureBoxDebyeRing.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxDebyeRing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxDebyeRing, "pictureBoxDebyeRing");
            this.pictureBoxDebyeRing.Name = "pictureBoxDebyeRing";
            this.pictureBoxDebyeRing.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxDebyeRing, resources.GetString("pictureBoxDebyeRing.ToolTip"));
            this.pictureBoxDebyeRing.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxDefectLine
            // 
            this.pictureBoxDefectLine.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDefectLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxDefectLine, "pictureBoxDefectLine");
            this.pictureBoxDefectLine.Name = "pictureBoxDefectLine";
            this.pictureBoxDefectLine.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxDefectLine, resources.GetString("pictureBoxDefectLine.ToolTip"));
            this.pictureBoxDefectLine.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxNoCondition
            // 
            this.pictureBoxNoCondition.BackColor = System.Drawing.Color.White;
            this.pictureBoxNoCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxNoCondition, "pictureBoxNoCondition");
            this.pictureBoxNoCondition.Name = "pictureBoxNoCondition";
            this.pictureBoxNoCondition.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxNoCondition, resources.GetString("pictureBoxNoCondition.ToolTip"));
            this.pictureBoxNoCondition.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxExcessLine
            // 
            this.pictureBoxExcessLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxExcessLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxExcessLine, "pictureBoxExcessLine");
            this.pictureBoxExcessLine.Name = "pictureBoxExcessLine";
            this.pictureBoxExcessLine.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxExcessLine, resources.GetString("pictureBoxExcessLine.ToolTip"));
            this.pictureBoxExcessLine.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxFoot
            // 
            this.pictureBoxFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBoxFoot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxFoot, "pictureBoxFoot");
            this.pictureBoxFoot.Name = "pictureBoxFoot";
            this.pictureBoxFoot.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxFoot, resources.GetString("pictureBoxFoot.ToolTip"));
            this.pictureBoxFoot.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.BackColor = System.Drawing.Color.Red;
            this.pictureBoxOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxOrigin, "pictureBoxOrigin");
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxOrigin, resources.GetString("pictureBoxOrigin.ToolTip"));
            this.pictureBoxOrigin.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pictureBoxBackGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxBackGround, "pictureBoxBackGround");
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxBackGround, resources.GetString("pictureBoxBackGround.ToolTip"));
            this.pictureBoxBackGround.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxString
            // 
            this.pictureBoxString.BackColor = System.Drawing.Color.White;
            this.pictureBoxString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxString, "pictureBoxString");
            this.pictureBoxString.Name = "pictureBoxString";
            this.pictureBoxString.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxString, resources.GetString("pictureBoxString.ToolTip"));
            this.pictureBoxString.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxForbiddenScrewGlide
            // 
            this.pictureBoxForbiddenScrewGlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxForbiddenScrewGlide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxForbiddenScrewGlide, "pictureBoxForbiddenScrewGlide");
            this.pictureBoxForbiddenScrewGlide.Name = "pictureBoxForbiddenScrewGlide";
            this.pictureBoxForbiddenScrewGlide.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxForbiddenScrewGlide, resources.GetString("pictureBoxForbiddenScrewGlide.ToolTip"));
            this.pictureBoxForbiddenScrewGlide.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pictureBoxForbiddenLattice
            // 
            this.pictureBoxForbiddenLattice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBoxForbiddenLattice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBoxForbiddenLattice, "pictureBoxForbiddenLattice");
            this.pictureBoxForbiddenLattice.Name = "pictureBoxForbiddenLattice";
            this.pictureBoxForbiddenLattice.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxForbiddenLattice, resources.GetString("pictureBoxForbiddenLattice.ToolTip"));
            this.pictureBoxForbiddenLattice.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.numericUpDownMinKL);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.trackBarLineWidth);
            this.tabPage4.Controls.Add(this.label11);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // numericUpDownMinKL
            // 
            resources.ApplyResources(this.numericUpDownMinKL, "numericUpDownMinKL");
            this.numericUpDownMinKL.DecimalPlaces = 3;
            this.numericUpDownMinKL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMinKL.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownMinKL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMinKL.Name = "numericUpDownMinKL";
            this.toolTip.SetToolTip(this.numericUpDownMinKL, resources.GetString("numericUpDownMinKL.ToolTip"));
            this.numericUpDownMinKL.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numericUpDownMinKL.ValueChanged += new System.EventHandler(this.numericUpDownResolution_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // trackBarLineWidth
            // 
            resources.ApplyResources(this.trackBarLineWidth, "trackBarLineWidth");
            this.trackBarLineWidth.Maximum = 10000;
            this.trackBarLineWidth.Minimum = 1;
            this.trackBarLineWidth.Name = "trackBarLineWidth";
            this.trackBarLineWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackBarLineWidth, resources.GetString("trackBarLineWidth.ToolTip"));
            this.trackBarLineWidth.Value = 2000;
            this.trackBarLineWidth.ValueChanged += new System.EventHandler(this.numericUpDownResolution_ValueChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.checkBoxExtinctionAll);
            this.tabPage3.Controls.Add(this.checkBoxExtinctionLattice);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // checkBoxExtinctionAll
            // 
            resources.ApplyResources(this.checkBoxExtinctionAll, "checkBoxExtinctionAll");
            this.checkBoxExtinctionAll.Name = "checkBoxExtinctionAll";
            this.toolTip.SetToolTip(this.checkBoxExtinctionAll, resources.GetString("checkBoxExtinctionAll.ToolTip"));
            this.checkBoxExtinctionAll.CheckedChanged += new System.EventHandler(this.checkBoxExtinctionAll_CheckedChanged);
            // 
            // checkBoxExtinctionLattice
            // 
            resources.ApplyResources(this.checkBoxExtinctionLattice, "checkBoxExtinctionLattice");
            this.checkBoxExtinctionLattice.Checked = true;
            this.checkBoxExtinctionLattice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExtinctionLattice.Name = "checkBoxExtinctionLattice";
            this.toolTip.SetToolTip(this.checkBoxExtinctionLattice, resources.GetString("checkBoxExtinctionLattice.ToolTip"));
            this.checkBoxExtinctionLattice.CheckedChanged += new System.EventHandler(this.checkBoxExtinctionAll_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.checkBoxDebyeRingLabel);
            this.tabPage6.Controls.Add(this.checkBoxDebyeRingIgnoreIntensity);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.trackBarDebyeRingWidth);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebyeRingLabel
            // 
            resources.ApplyResources(this.checkBoxDebyeRingLabel, "checkBoxDebyeRingLabel");
            this.checkBoxDebyeRingLabel.Name = "checkBoxDebyeRingLabel";
            this.checkBoxDebyeRingLabel.UseVisualStyleBackColor = true;
            this.checkBoxDebyeRingLabel.CheckedChanged += new System.EventHandler(this.checkBoxPrecession_CheckedChanged);
            // 
            // checkBoxDebyeRingIgnoreIntensity
            // 
            resources.ApplyResources(this.checkBoxDebyeRingIgnoreIntensity, "checkBoxDebyeRingIgnoreIntensity");
            this.checkBoxDebyeRingIgnoreIntensity.Name = "checkBoxDebyeRingIgnoreIntensity";
            this.checkBoxDebyeRingIgnoreIntensity.UseVisualStyleBackColor = true;
            this.checkBoxDebyeRingIgnoreIntensity.CheckedChanged += new System.EventHandler(this.checkBoxPrecession_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // trackBarDebyeRingWidth
            // 
            resources.ApplyResources(this.trackBarDebyeRingWidth, "trackBarDebyeRingWidth");
            this.trackBarDebyeRingWidth.LargeChange = 1;
            this.trackBarDebyeRingWidth.Minimum = 1;
            this.trackBarDebyeRingWidth.Name = "trackBarDebyeRingWidth";
            this.trackBarDebyeRingWidth.TickFrequency = 500;
            this.trackBarDebyeRingWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDebyeRingWidth.Value = 5;
            this.trackBarDebyeRingWidth.ValueChanged += new System.EventHandler(this.trackBarStrSize_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericBoxDev);
            this.tabPage2.Controls.Add(this.numericBoxAcc);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericBoxDev
            // 
            this.numericBoxDev.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxDev, "numericBoxDev");
            this.numericBoxDev.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDev.DecimalPlaces = -2;
            this.numericBoxDev.Maximum = double.PositiveInfinity;
            this.numericBoxDev.Minimum = double.NegativeInfinity;
            this.numericBoxDev.MouseDirection = Crystallography.VH_DirectionEnum.Horizontal;
            this.numericBoxDev.MouseSpeed = 1D;
            this.numericBoxDev.Multiline = false;
            this.numericBoxDev.Name = "numericBoxDev";
            this.numericBoxDev.RadianValue = 0.023911010752322315D;
            this.numericBoxDev.ReadOnly = false;
            this.numericBoxDev.RestrictLimitValue = true;
            this.numericBoxDev.ShowFraction = false;
            this.numericBoxDev.ShowPositiveSign = false;
            this.numericBoxDev.ShowUpDown = false;
            this.numericBoxDev.SkipEventDuringInput = false;
            this.numericBoxDev.SmartIncrement = true;
            this.numericBoxDev.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxDev.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxDev.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxDev.ThonsandsSeparator = true;
            this.numericBoxDev.UpDown_Increment = 1D;
            this.numericBoxDev.Value = 1.37D;
            this.numericBoxDev.WordWrap = true;
            // 
            // numericBoxAcc
            // 
            this.numericBoxAcc.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxAcc, "numericBoxAcc");
            this.numericBoxAcc.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAcc.DecimalPlaces = -2;
            this.numericBoxAcc.Maximum = double.PositiveInfinity;
            this.numericBoxAcc.Minimum = double.NegativeInfinity;
            this.numericBoxAcc.MouseDirection = Crystallography.VH_DirectionEnum.Horizontal;
            this.numericBoxAcc.MouseSpeed = 1D;
            this.numericBoxAcc.Multiline = false;
            this.numericBoxAcc.Name = "numericBoxAcc";
            this.numericBoxAcc.RadianValue = 216.42082724729684D;
            this.numericBoxAcc.ReadOnly = false;
            this.numericBoxAcc.RestrictLimitValue = true;
            this.numericBoxAcc.ShowFraction = false;
            this.numericBoxAcc.ShowPositiveSign = false;
            this.numericBoxAcc.ShowUpDown = false;
            this.numericBoxAcc.SkipEventDuringInput = false;
            this.numericBoxAcc.SmartIncrement = true;
            this.numericBoxAcc.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxAcc.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxAcc.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxAcc.ThonsandsSeparator = true;
            this.numericBoxAcc.UpDown_Increment = 1D;
            this.numericBoxAcc.Value = 12400D;
            this.numericBoxAcc.WordWrap = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.trackBarRotationSpeed);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // trackBarRotationSpeed
            // 
            resources.ApplyResources(this.trackBarRotationSpeed, "trackBarRotationSpeed");
            this.trackBarRotationSpeed.Maximum = 600;
            this.trackBarRotationSpeed.Minimum = 1;
            this.trackBarRotationSpeed.Name = "trackBarRotationSpeed";
            this.trackBarRotationSpeed.TickFrequency = 10000;
            this.trackBarRotationSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackBarRotationSpeed, resources.GetString("trackBarRotationSpeed.ToolTip"));
            this.trackBarRotationSpeed.Value = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownCamaraLength2);
            this.groupBox1.Controls.Add(this.buttonDetailedGeometry);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label18);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownCamaraLength2
            // 
            this.numericUpDownCamaraLength2.DecimalPlaces = 3;
            resources.ApplyResources(this.numericUpDownCamaraLength2, "numericUpDownCamaraLength2");
            this.numericUpDownCamaraLength2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCamaraLength2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCamaraLength2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCamaraLength2.Name = "numericUpDownCamaraLength2";
            this.toolTip.SetToolTip(this.numericUpDownCamaraLength2, resources.GetString("numericUpDownCamaraLength2.ToolTip"));
            this.numericUpDownCamaraLength2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCamaraLength2.ValueChanged += new System.EventHandler(this.numericUpDownCamaraLength2_ValueChanged);
            // 
            // buttonDetailedGeometry
            // 
            resources.ApplyResources(this.buttonDetailedGeometry, "buttonDetailedGeometry");
            this.buttonDetailedGeometry.Name = "buttonDetailedGeometry";
            this.buttonDetailedGeometry.UseVisualStyleBackColor = true;
            this.buttonDetailedGeometry.Click += new System.EventHandler(this.buttonDetailedGeometry_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.toolTip.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            // 
            // buttonResetCenter
            // 
            resources.ApplyResources(this.buttonResetCenter, "buttonResetCenter");
            this.buttonResetCenter.Name = "buttonResetCenter";
            this.buttonResetCenter.UseVisualStyleBackColor = true;
            this.buttonResetCenter.Click += new System.EventHandler(this.buttonResetCenter_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericBoxClientHeight);
            this.groupBox6.Controls.Add(this.numericBoxClientWidth);
            this.groupBox6.Controls.Add(this.numericBoxResolution);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
            // 
            // numericBoxClientHeight
            // 
            this.numericBoxClientHeight.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxClientHeight, "numericBoxClientHeight");
            this.numericBoxClientHeight.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxClientHeight.DecimalPlaces = 0;
            this.numericBoxClientHeight.Maximum = 2000D;
            this.numericBoxClientHeight.Minimum = 1D;
            this.numericBoxClientHeight.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxClientHeight.MouseSpeed = 1D;
            this.numericBoxClientHeight.Multiline = false;
            this.numericBoxClientHeight.Name = "numericBoxClientHeight";
            this.numericBoxClientHeight.RadianValue = 17.453292519943293D;
            this.numericBoxClientHeight.ReadOnly = false;
            this.numericBoxClientHeight.RestrictLimitValue = true;
            this.numericBoxClientHeight.ShowFraction = false;
            this.numericBoxClientHeight.ShowPositiveSign = false;
            this.numericBoxClientHeight.ShowUpDown = true;
            this.numericBoxClientHeight.SkipEventDuringInput = true;
            this.numericBoxClientHeight.SmartIncrement = true;
            this.numericBoxClientHeight.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxClientHeight.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxClientHeight.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxClientHeight.ThonsandsSeparator = true;
            this.numericBoxClientHeight.UpDown_Increment = 1D;
            this.numericBoxClientHeight.Value = 1000D;
            this.numericBoxClientHeight.WordWrap = true;
            this.numericBoxClientHeight.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxClientSize_ValueChanged);
            // 
            // numericBoxClientWidth
            // 
            this.numericBoxClientWidth.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxClientWidth, "numericBoxClientWidth");
            this.numericBoxClientWidth.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxClientWidth.DecimalPlaces = 0;
            this.numericBoxClientWidth.Maximum = 2000D;
            this.numericBoxClientWidth.Minimum = 1D;
            this.numericBoxClientWidth.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxClientWidth.MouseSpeed = 1D;
            this.numericBoxClientWidth.Multiline = false;
            this.numericBoxClientWidth.Name = "numericBoxClientWidth";
            this.numericBoxClientWidth.RadianValue = 17.453292519943293D;
            this.numericBoxClientWidth.ReadOnly = false;
            this.numericBoxClientWidth.RestrictLimitValue = true;
            this.numericBoxClientWidth.ShowFraction = false;
            this.numericBoxClientWidth.ShowPositiveSign = false;
            this.numericBoxClientWidth.ShowUpDown = true;
            this.numericBoxClientWidth.SkipEventDuringInput = true;
            this.numericBoxClientWidth.SmartIncrement = true;
            this.numericBoxClientWidth.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxClientWidth.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxClientWidth.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxClientWidth.ThonsandsSeparator = true;
            this.numericBoxClientWidth.UpDown_Increment = 1D;
            this.numericBoxClientWidth.Value = 1000D;
            this.numericBoxClientWidth.WordWrap = true;
            this.numericBoxClientWidth.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxClientSize_ValueChanged);
            // 
            // numericBoxResolution
            // 
            this.numericBoxResolution.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxResolution, "numericBoxResolution");
            this.numericBoxResolution.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxResolution.DecimalPlaces = 5;
            this.numericBoxResolution.Maximum = 10D;
            this.numericBoxResolution.Minimum = 1E-05D;
            this.numericBoxResolution.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxResolution.MouseSpeed = 1D;
            this.numericBoxResolution.Multiline = false;
            this.numericBoxResolution.Name = "numericBoxResolution";
            this.numericBoxResolution.RadianValue = 0.0013962634015954637D;
            this.numericBoxResolution.ReadOnly = false;
            this.numericBoxResolution.RestrictLimitValue = true;
            this.numericBoxResolution.ShowFraction = false;
            this.numericBoxResolution.ShowPositiveSign = false;
            this.numericBoxResolution.ShowUpDown = true;
            this.numericBoxResolution.SkipEventDuringInput = true;
            this.numericBoxResolution.SmartIncrement = true;
            this.numericBoxResolution.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxResolution.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxResolution.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxResolution.ThonsandsSeparator = true;
            this.numericBoxResolution.UpDown_Increment = 1D;
            this.numericBoxResolution.Value = 0.08D;
            this.numericBoxResolution.WordWrap = true;
            this.numericBoxResolution.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericUpDownResolution_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanelPED);
            this.groupBox2.Controls.Add(this.flowLayoutPanelBethe);
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Controls.Add(this.flowLayoutPanel5);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanelPED
            // 
            resources.ApplyResources(this.flowLayoutPanelPED, "flowLayoutPanelPED");
            this.flowLayoutPanelPED.Controls.Add(this.label16);
            this.flowLayoutPanelPED.Controls.Add(this.numericBoxPED_Semiangle);
            this.flowLayoutPanelPED.Controls.Add(this.numericBoxPED_Step);
            this.flowLayoutPanelPED.Name = "flowLayoutPanelPED";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.toolTip.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // numericBoxPED_Semiangle
            // 
            this.numericBoxPED_Semiangle.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxPED_Semiangle, "numericBoxPED_Semiangle");
            this.numericBoxPED_Semiangle.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxPED_Semiangle.DecimalPlaces = -2;
            this.numericBoxPED_Semiangle.Maximum = 500D;
            this.numericBoxPED_Semiangle.Minimum = 0.1D;
            this.numericBoxPED_Semiangle.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxPED_Semiangle.MouseSpeed = 1D;
            this.numericBoxPED_Semiangle.Multiline = false;
            this.numericBoxPED_Semiangle.Name = "numericBoxPED_Semiangle";
            this.numericBoxPED_Semiangle.RadianValue = 0.87266462599716477D;
            this.numericBoxPED_Semiangle.ReadOnly = false;
            this.numericBoxPED_Semiangle.RestrictLimitValue = true;
            this.numericBoxPED_Semiangle.ShowFraction = false;
            this.numericBoxPED_Semiangle.ShowPositiveSign = false;
            this.numericBoxPED_Semiangle.ShowUpDown = true;
            this.numericBoxPED_Semiangle.SkipEventDuringInput = true;
            this.numericBoxPED_Semiangle.SmartIncrement = true;
            this.numericBoxPED_Semiangle.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxPED_Semiangle.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxPED_Semiangle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxPED_Semiangle.ThonsandsSeparator = true;
            this.numericBoxPED_Semiangle.UpDown_Increment = 1D;
            this.numericBoxPED_Semiangle.Value = 50D;
            this.numericBoxPED_Semiangle.WordWrap = true;
            this.numericBoxPED_Semiangle.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericBoxNumOfBlochWave_ValueChanged);
            // 
            // numericBoxPED_Step
            // 
            this.numericBoxPED_Step.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxPED_Step, "numericBoxPED_Step");
            this.numericBoxPED_Step.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxPED_Step.DecimalPlaces = 0;
            this.numericBoxPED_Step.Maximum = 1080D;
            this.numericBoxPED_Step.Minimum = 2D;
            this.numericBoxPED_Step.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxPED_Step.MouseSpeed = 1D;
            this.numericBoxPED_Step.Multiline = false;
            this.numericBoxPED_Step.Name = "numericBoxPED_Step";
            this.numericBoxPED_Step.RadianValue = 0.62831853071795862D;
            this.numericBoxPED_Step.ReadOnly = false;
            this.numericBoxPED_Step.RestrictLimitValue = true;
            this.numericBoxPED_Step.ShowFraction = false;
            this.numericBoxPED_Step.ShowPositiveSign = false;
            this.numericBoxPED_Step.ShowUpDown = true;
            this.numericBoxPED_Step.SkipEventDuringInput = true;
            this.numericBoxPED_Step.SmartIncrement = true;
            this.numericBoxPED_Step.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxPED_Step.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxPED_Step.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxPED_Step.ThonsandsSeparator = true;
            this.numericBoxPED_Step.UpDown_Increment = 1D;
            this.numericBoxPED_Step.Value = 36D;
            this.numericBoxPED_Step.WordWrap = true;
            this.numericBoxPED_Step.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericBoxNumOfBlochWave_ValueChanged);
            // 
            // flowLayoutPanelBethe
            // 
            resources.ApplyResources(this.flowLayoutPanelBethe, "flowLayoutPanelBethe");
            this.flowLayoutPanelBethe.Controls.Add(this.numericBoxNumOfBlochWave);
            this.flowLayoutPanelBethe.Controls.Add(this.buttonDetailsOfSpots);
            this.flowLayoutPanelBethe.Controls.Add(this.trackBarAdvancedThickness);
            this.flowLayoutPanelBethe.Name = "flowLayoutPanelBethe";
            // 
            // numericBoxNumOfBlochWave
            // 
            this.numericBoxNumOfBlochWave.AllowMouseControl = false;
            resources.ApplyResources(this.numericBoxNumOfBlochWave, "numericBoxNumOfBlochWave");
            this.numericBoxNumOfBlochWave.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumOfBlochWave.DecimalPlaces = -2;
            this.numericBoxNumOfBlochWave.Maximum = 1000D;
            this.numericBoxNumOfBlochWave.Minimum = 8D;
            this.numericBoxNumOfBlochWave.MouseDirection = Crystallography.VH_DirectionEnum.Vertical;
            this.numericBoxNumOfBlochWave.MouseSpeed = 1D;
            this.numericBoxNumOfBlochWave.Multiline = false;
            this.numericBoxNumOfBlochWave.Name = "numericBoxNumOfBlochWave";
            this.numericBoxNumOfBlochWave.RadianValue = 4.1887902047863905D;
            this.numericBoxNumOfBlochWave.ReadOnly = false;
            this.numericBoxNumOfBlochWave.RestrictLimitValue = true;
            this.numericBoxNumOfBlochWave.ShowFraction = false;
            this.numericBoxNumOfBlochWave.ShowPositiveSign = false;
            this.numericBoxNumOfBlochWave.ShowUpDown = true;
            this.numericBoxNumOfBlochWave.SkipEventDuringInput = true;
            this.numericBoxNumOfBlochWave.SmartIncrement = true;
            this.numericBoxNumOfBlochWave.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.numericBoxNumOfBlochWave.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.numericBoxNumOfBlochWave.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.numericBoxNumOfBlochWave.ThonsandsSeparator = true;
            this.numericBoxNumOfBlochWave.UpDown_Increment = 1D;
            this.numericBoxNumOfBlochWave.Value = 240D;
            this.numericBoxNumOfBlochWave.WordWrap = true;
            this.numericBoxNumOfBlochWave.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericBoxNumOfBlochWave_ValueChanged);
            // 
            // buttonDetailsOfSpots
            // 
            resources.ApplyResources(this.buttonDetailsOfSpots, "buttonDetailsOfSpots");
            this.buttonDetailsOfSpots.Name = "buttonDetailsOfSpots";
            this.buttonDetailsOfSpots.UseVisualStyleBackColor = true;
            this.buttonDetailsOfSpots.Click += new System.EventHandler(this.ButtonDetailsOfSpots_Click);
            // 
            // trackBarAdvancedThickness
            // 
            resources.ApplyResources(this.trackBarAdvancedThickness, "trackBarAdvancedThickness");
            this.trackBarAdvancedThickness.ControlHeight = 59;
            this.trackBarAdvancedThickness.DecimalPlaces = -2;
            this.trackBarAdvancedThickness.LogScrollBar = false;
            this.trackBarAdvancedThickness.Maximum = 1000D;
            this.trackBarAdvancedThickness.Minimum = 0.1D;
            this.trackBarAdvancedThickness.Name = "trackBarAdvancedThickness";
            this.trackBarAdvancedThickness.NumericBoxSize = 24;
            this.trackBarAdvancedThickness.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.trackBarAdvancedThickness.Smart_Increment = false;
            this.trackBarAdvancedThickness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarAdvancedThickness.UpDown_Increment = 1D;
            this.trackBarAdvancedThickness.Value = 50D;
            this.trackBarAdvancedThickness.ValueChanged += new Crystallography.Controls.TrackBarAdvanced.ValueChangedDelegate(this.trackBarAdvancedThickness_ValueChanged);
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonIntensityExcitation);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonIntensityKinematical);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonIntensityBethe);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // radioButtonIntensityExcitation
            // 
            resources.ApplyResources(this.radioButtonIntensityExcitation, "radioButtonIntensityExcitation");
            this.radioButtonIntensityExcitation.Checked = true;
            this.radioButtonIntensityExcitation.Name = "radioButtonIntensityExcitation";
            this.radioButtonIntensityExcitation.TabStop = true;
            this.radioButtonIntensityExcitation.UseVisualStyleBackColor = true;
            this.radioButtonIntensityExcitation.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // radioButtonIntensityKinematical
            // 
            resources.ApplyResources(this.radioButtonIntensityKinematical, "radioButtonIntensityKinematical");
            this.radioButtonIntensityKinematical.Name = "radioButtonIntensityKinematical";
            this.radioButtonIntensityKinematical.UseVisualStyleBackColor = true;
            this.radioButtonIntensityKinematical.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // radioButtonIntensityBethe
            // 
            resources.ApplyResources(this.radioButtonIntensityBethe, "radioButtonIntensityBethe");
            this.radioButtonIntensityBethe.Name = "radioButtonIntensityBethe";
            this.radioButtonIntensityBethe.UseVisualStyleBackColor = true;
            this.radioButtonIntensityBethe.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Controls.Add(this.label13);
            this.flowLayoutPanel5.Controls.Add(this.radioButtonBeamParallel);
            this.flowLayoutPanel5.Controls.Add(this.radioButtonBeamPrecession);
            this.flowLayoutPanel5.Controls.Add(this.radioButtonBeamConvergence);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // radioButtonBeamParallel
            // 
            resources.ApplyResources(this.radioButtonBeamParallel, "radioButtonBeamParallel");
            this.radioButtonBeamParallel.Checked = true;
            this.radioButtonBeamParallel.Name = "radioButtonBeamParallel";
            this.radioButtonBeamParallel.TabStop = true;
            this.radioButtonBeamParallel.UseVisualStyleBackColor = true;
            this.radioButtonBeamParallel.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // radioButtonBeamPrecession
            // 
            resources.ApplyResources(this.radioButtonBeamPrecession, "radioButtonBeamPrecession");
            this.radioButtonBeamPrecession.Name = "radioButtonBeamPrecession";
            this.radioButtonBeamPrecession.UseVisualStyleBackColor = true;
            this.radioButtonBeamPrecession.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // radioButtonBeamConvergence
            // 
            resources.ApplyResources(this.radioButtonBeamConvergence, "radioButtonBeamConvergence");
            this.radioButtonBeamConvergence.Name = "radioButtonBeamConvergence";
            this.radioButtonBeamConvergence.UseVisualStyleBackColor = true;
            this.radioButtonBeamConvergence.CheckedChanged += new System.EventHandler(this.radioButtonKinematical_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.labelRadius);
            this.flowLayoutPanel2.Controls.Add(this.labelSigma);
            this.flowLayoutPanel2.Controls.Add(this.trackBarAdvancedSpotRadius);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // labelRadius
            // 
            resources.ApplyResources(this.labelRadius, "labelRadius");
            this.labelRadius.Name = "labelRadius";
            // 
            // labelSigma
            // 
            resources.ApplyResources(this.labelSigma, "labelSigma");
            this.labelSigma.Name = "labelSigma";
            // 
            // trackBarAdvancedSpotRadius
            // 
            resources.ApplyResources(this.trackBarAdvancedSpotRadius, "trackBarAdvancedSpotRadius");
            this.trackBarAdvancedSpotRadius.ControlHeight = 54;
            this.trackBarAdvancedSpotRadius.DecimalPlaces = 4;
            this.trackBarAdvancedSpotRadius.LogScrollBar = false;
            this.trackBarAdvancedSpotRadius.Maximum = 1D;
            this.trackBarAdvancedSpotRadius.Minimum = 0D;
            this.trackBarAdvancedSpotRadius.Name = "trackBarAdvancedSpotRadius";
            this.trackBarAdvancedSpotRadius.NumericBoxSize = 24;
            this.trackBarAdvancedSpotRadius.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.trackBarAdvancedSpotRadius.Smart_Increment = true;
            this.trackBarAdvancedSpotRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAdvancedSpotRadius.UpDown_Increment = 1D;
            this.trackBarAdvancedSpotRadius.Value = 0.2D;
            this.trackBarAdvancedSpotRadius.ValueChanged += new Crystallography.Controls.TrackBarAdvanced.ValueChangedDelegate(this.trackBarAdvancedSpotSize_ValueChanged);
            this.trackBarAdvancedSpotRadius.Load += new System.EventHandler(this.TrackBarAdvancedSpotRadius_Load);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.label19);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonCircleArea);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonPointSpread);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.trackBarIntensityForPointSpread);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanelColorScale);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxLogScale);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.trackBarSpotOpacity);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // radioButtonCircleArea
            // 
            resources.ApplyResources(this.radioButtonCircleArea, "radioButtonCircleArea");
            this.radioButtonCircleArea.Checked = true;
            this.radioButtonCircleArea.Name = "radioButtonCircleArea";
            this.radioButtonCircleArea.TabStop = true;
            this.radioButtonCircleArea.UseVisualStyleBackColor = true;
            this.radioButtonCircleArea.CheckedChanged += new System.EventHandler(this.radioButtonPointSpread_CheckedChanged);
            // 
            // radioButtonPointSpread
            // 
            resources.ApplyResources(this.radioButtonPointSpread, "radioButtonPointSpread");
            this.radioButtonPointSpread.Name = "radioButtonPointSpread";
            this.radioButtonPointSpread.UseVisualStyleBackColor = true;
            this.radioButtonPointSpread.CheckedChanged += new System.EventHandler(this.radioButtonPointSpread_CheckedChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // trackBarIntensityForPointSpread
            // 
            resources.ApplyResources(this.trackBarIntensityForPointSpread, "trackBarIntensityForPointSpread");
            this.trackBarIntensityForPointSpread.LargeChange = 50;
            this.trackBarIntensityForPointSpread.Maximum = 800;
            this.trackBarIntensityForPointSpread.Minimum = 1;
            this.trackBarIntensityForPointSpread.Name = "trackBarIntensityForPointSpread";
            this.trackBarIntensityForPointSpread.SmallChange = 10;
            this.trackBarIntensityForPointSpread.TickFrequency = 500;
            this.trackBarIntensityForPointSpread.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackBarIntensityForPointSpread, resources.GetString("trackBarIntensityForPointSpread.ToolTip"));
            this.trackBarIntensityForPointSpread.Value = 400;
            this.trackBarIntensityForPointSpread.ValueChanged += new System.EventHandler(this.trackBarStrSize_ValueChanged);
            // 
            // flowLayoutPanelColorScale
            // 
            resources.ApplyResources(this.flowLayoutPanelColorScale, "flowLayoutPanelColorScale");
            this.flowLayoutPanelColorScale.Controls.Add(this.label25);
            this.flowLayoutPanelColorScale.Controls.Add(this.comboBoxScaleColorScale);
            this.flowLayoutPanelColorScale.Name = "flowLayoutPanelColorScale";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // comboBoxScaleColorScale
            // 
            this.comboBoxScaleColorScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxScaleColorScale, "comboBoxScaleColorScale");
            this.comboBoxScaleColorScale.FormattingEnabled = true;
            this.comboBoxScaleColorScale.Items.AddRange(new object[] {
            resources.GetString("comboBoxScaleColorScale.Items"),
            resources.GetString("comboBoxScaleColorScale.Items1")});
            this.comboBoxScaleColorScale.Name = "comboBoxScaleColorScale";
            // 
            // checkBoxLogScale
            // 
            resources.ApplyResources(this.checkBoxLogScale, "checkBoxLogScale");
            this.checkBoxLogScale.Name = "checkBoxLogScale";
            this.checkBoxLogScale.UseVisualStyleBackColor = true;
            this.checkBoxLogScale.CheckedChanged += new System.EventHandler(this.checkBoxLogScale_CheckedChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // trackBarSpotOpacity
            // 
            resources.ApplyResources(this.trackBarSpotOpacity, "trackBarSpotOpacity");
            this.trackBarSpotOpacity.LargeChange = 20;
            this.trackBarSpotOpacity.Maximum = 100;
            this.trackBarSpotOpacity.Name = "trackBarSpotOpacity";
            this.trackBarSpotOpacity.SmallChange = 10;
            this.trackBarSpotOpacity.TickFrequency = 500;
            this.trackBarSpotOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackBarSpotOpacity, resources.GetString("trackBarSpotOpacity.ToolTip"));
            this.trackBarSpotOpacity.Value = 100;
            this.trackBarSpotOpacity.ValueChanged += new System.EventHandler(this.trackBarStrSize_ValueChanged);
            // 
            // labelD
            // 
            resources.ApplyResources(this.labelD, "labelD");
            this.labelD.Name = "labelD";
            // 
            // labelMousePointReal
            // 
            resources.ApplyResources(this.labelMousePointReal, "labelMousePointReal");
            this.labelMousePointReal.Name = "labelMousePointReal";
            // 
            // labelMousePointInverse
            // 
            resources.ApplyResources(this.labelMousePointInverse, "labelMousePointInverse");
            this.labelMousePointInverse.Name = "labelMousePointInverse";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.saveDetectorAreaToolStripMenuItem,
            this.saveCBEDPatternToolStripMenuItem,
            this.copyImageToClipboardToolStripMenuItem,
            this.copyDetectorAreaToolStripMenuItem,
            this.copyCBEDPatternToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.AutoToolTip = true;
            this.saveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.saveAsMetafileToolStripMenuItem});
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            resources.ApplyResources(this.saveImageToolStripMenuItem, "saveImageToolStripMenuItem");
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            resources.ApplyResources(this.saveAsImageToolStripMenuItem, "saveAsImageToolStripMenuItem");
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // saveAsMetafileToolStripMenuItem
            // 
            this.saveAsMetafileToolStripMenuItem.Name = "saveAsMetafileToolStripMenuItem";
            resources.ApplyResources(this.saveAsMetafileToolStripMenuItem, "saveAsMetafileToolStripMenuItem");
            this.saveAsMetafileToolStripMenuItem.Click += new System.EventHandler(this.saveAsMetafileToolStripMenuItem_Click);
            // 
            // saveDetectorAreaToolStripMenuItem
            // 
            this.saveDetectorAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDetectorAsImageToolStripMenuItem,
            this.saveDetectorAsMetafileToolStripMenuItem});
            this.saveDetectorAreaToolStripMenuItem.Name = "saveDetectorAreaToolStripMenuItem";
            resources.ApplyResources(this.saveDetectorAreaToolStripMenuItem, "saveDetectorAreaToolStripMenuItem");
            // 
            // saveDetectorAsImageToolStripMenuItem
            // 
            this.saveDetectorAsImageToolStripMenuItem.Name = "saveDetectorAsImageToolStripMenuItem";
            resources.ApplyResources(this.saveDetectorAsImageToolStripMenuItem, "saveDetectorAsImageToolStripMenuItem");
            this.saveDetectorAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveDetectorAsImageToolStripMenuItem_Click);
            // 
            // saveDetectorAsMetafileToolStripMenuItem
            // 
            this.saveDetectorAsMetafileToolStripMenuItem.Name = "saveDetectorAsMetafileToolStripMenuItem";
            resources.ApplyResources(this.saveDetectorAsMetafileToolStripMenuItem, "saveDetectorAsMetafileToolStripMenuItem");
            this.saveDetectorAsMetafileToolStripMenuItem.Click += new System.EventHandler(this.saveDetectorAsMetafileToolStripMenuItem_Click);
            // 
            // saveCBEDPatternToolStripMenuItem
            // 
            this.saveCBEDPatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCBEDasPngToolStripMenuItem,
            this.saveCBEDasTiffToolStripMenuItem,
            this.saveCBEDasMetafileToolStripMenuItem});
            this.saveCBEDPatternToolStripMenuItem.Name = "saveCBEDPatternToolStripMenuItem";
            resources.ApplyResources(this.saveCBEDPatternToolStripMenuItem, "saveCBEDPatternToolStripMenuItem");
            // 
            // saveCBEDasPngToolStripMenuItem
            // 
            this.saveCBEDasPngToolStripMenuItem.Name = "saveCBEDasPngToolStripMenuItem";
            resources.ApplyResources(this.saveCBEDasPngToolStripMenuItem, "saveCBEDasPngToolStripMenuItem");
            this.saveCBEDasPngToolStripMenuItem.Click += new System.EventHandler(this.saveCBEDasPngToolStripMenuItem_Click);
            // 
            // saveCBEDasTiffToolStripMenuItem
            // 
            this.saveCBEDasTiffToolStripMenuItem.Name = "saveCBEDasTiffToolStripMenuItem";
            resources.ApplyResources(this.saveCBEDasTiffToolStripMenuItem, "saveCBEDasTiffToolStripMenuItem");
            this.saveCBEDasTiffToolStripMenuItem.Click += new System.EventHandler(this.saveCBEDasTiffToolStripMenuItem_Click);
            // 
            // saveCBEDasMetafileToolStripMenuItem
            // 
            this.saveCBEDasMetafileToolStripMenuItem.Name = "saveCBEDasMetafileToolStripMenuItem";
            resources.ApplyResources(this.saveCBEDasMetafileToolStripMenuItem, "saveCBEDasMetafileToolStripMenuItem");
            this.saveCBEDasMetafileToolStripMenuItem.Click += new System.EventHandler(this.saveCBEDasMetafileToolStripMenuItem_Click);
            // 
            // copyImageToClipboardToolStripMenuItem
            // 
            this.copyImageToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsImageToolStripMenuItem,
            this.copyAsMetafileToolStripMenuItem});
            this.copyImageToClipboardToolStripMenuItem.Name = "copyImageToClipboardToolStripMenuItem";
            resources.ApplyResources(this.copyImageToClipboardToolStripMenuItem, "copyImageToClipboardToolStripMenuItem");
            // 
            // copyAsImageToolStripMenuItem
            // 
            this.copyAsImageToolStripMenuItem.Name = "copyAsImageToolStripMenuItem";
            resources.ApplyResources(this.copyAsImageToolStripMenuItem, "copyAsImageToolStripMenuItem");
            this.copyAsImageToolStripMenuItem.Click += new System.EventHandler(this.copyAsImageToolStripMenuItem1_Click);
            // 
            // copyAsMetafileToolStripMenuItem
            // 
            this.copyAsMetafileToolStripMenuItem.Name = "copyAsMetafileToolStripMenuItem";
            resources.ApplyResources(this.copyAsMetafileToolStripMenuItem, "copyAsMetafileToolStripMenuItem");
            this.copyAsMetafileToolStripMenuItem.Click += new System.EventHandler(this.copyAsMetafileToolStripMenuItem1_Click);
            // 
            // copyDetectorAreaToolStripMenuItem
            // 
            this.copyDetectorAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDetectorAsImageToolStripMenuItem,
            this.copyDetectorAsMetafileToolStripMenuItem});
            this.copyDetectorAreaToolStripMenuItem.Name = "copyDetectorAreaToolStripMenuItem";
            resources.ApplyResources(this.copyDetectorAreaToolStripMenuItem, "copyDetectorAreaToolStripMenuItem");
            // 
            // copyDetectorAsImageToolStripMenuItem
            // 
            this.copyDetectorAsImageToolStripMenuItem.Name = "copyDetectorAsImageToolStripMenuItem";
            resources.ApplyResources(this.copyDetectorAsImageToolStripMenuItem, "copyDetectorAsImageToolStripMenuItem");
            this.copyDetectorAsImageToolStripMenuItem.Click += new System.EventHandler(this.copyDetectorAsImageWithOverlappeImageToolStripMenuItem_Click);
            // 
            // copyDetectorAsMetafileToolStripMenuItem
            // 
            this.copyDetectorAsMetafileToolStripMenuItem.Name = "copyDetectorAsMetafileToolStripMenuItem";
            resources.ApplyResources(this.copyDetectorAsMetafileToolStripMenuItem, "copyDetectorAsMetafileToolStripMenuItem");
            this.copyDetectorAsMetafileToolStripMenuItem.Click += new System.EventHandler(this.copyDetectorAsMetafileWithOverlappedImageToolStripMenuItem_Click);
            // 
            // copyCBEDPatternToolStripMenuItem
            // 
            this.copyCBEDPatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCBEDasImageToolStripMenuItem,
            this.copyCBEDasMetafileToolStripMenuItem});
            this.copyCBEDPatternToolStripMenuItem.Name = "copyCBEDPatternToolStripMenuItem";
            resources.ApplyResources(this.copyCBEDPatternToolStripMenuItem, "copyCBEDPatternToolStripMenuItem");
            // 
            // copyCBEDasImageToolStripMenuItem
            // 
            this.copyCBEDasImageToolStripMenuItem.Name = "copyCBEDasImageToolStripMenuItem";
            resources.ApplyResources(this.copyCBEDasImageToolStripMenuItem, "copyCBEDasImageToolStripMenuItem");
            this.copyCBEDasImageToolStripMenuItem.Click += new System.EventHandler(this.copyCBEDasImageToolStripMenuItem_Click);
            // 
            // copyCBEDasMetafileToolStripMenuItem
            // 
            this.copyCBEDasMetafileToolStripMenuItem.Name = "copyCBEDasMetafileToolStripMenuItem";
            resources.ApplyResources(this.copyCBEDasMetafileToolStripMenuItem, "copyCBEDasMetafileToolStripMenuItem");
            this.copyCBEDasMetafileToolStripMenuItem.Click += new System.EventHandler(this.copyCBEDasMetafileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            resources.ApplyResources(this.pageSetupToolStripMenuItem, "pageSetupToolStripMenuItem");
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackLaue,
            this.toolStripSeparator4,
            this.dynamicCompressionToolStripMenuItem,
            this.toolStripSeparator5});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            resources.ApplyResources(this.optionToolStripMenuItem, "optionToolStripMenuItem");
            // 
            // toolStripMenuItemBackLaue
            // 
            this.toolStripMenuItemBackLaue.CheckOnClick = true;
            this.toolStripMenuItemBackLaue.Name = "toolStripMenuItemBackLaue";
            resources.ApplyResources(this.toolStripMenuItemBackLaue, "toolStripMenuItemBackLaue");
            this.toolStripMenuItemBackLaue.CheckedChanged += new System.EventHandler(this.backLaueToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // dynamicCompressionToolStripMenuItem
            // 
            this.dynamicCompressionToolStripMenuItem.Name = "dynamicCompressionToolStripMenuItem";
            resources.ApplyResources(this.dynamicCompressionToolStripMenuItem, "dynamicCompressionToolStripMenuItem");
            this.dynamicCompressionToolStripMenuItem.Click += new System.EventHandler(this.dynamicCompressionToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // graphicsBox
            // 
            resources.ApplyResources(this.graphicsBox, "graphicsBox");
            this.graphicsBox.BackColor = System.Drawing.Color.Transparent;
            this.graphicsBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.TabStop = false;
            this.toolTip.SetToolTip(this.graphicsBox, resources.GetString("graphicsBox.ToolTip"));
            this.graphicsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseDown);
            this.graphicsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseMove);
            this.graphicsBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseUp);
            this.graphicsBox.Move += new System.EventHandler(this.graphicsBox_Move);
            this.graphicsBox.Resize += new System.EventHandler(this.FormElectronDiffraction_Resize);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimeForSearchingG,
            this.toolStripStatusLabelTimeForDrawing,
            this.toolStripStatusLabelTimeForBethe,
            this.toolStripStatusLabel3});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseDown);
            // 
            // toolStripStatusLabelTimeForSearchingG
            // 
            this.toolStripStatusLabelTimeForSearchingG.Name = "toolStripStatusLabelTimeForSearchingG";
            resources.ApplyResources(this.toolStripStatusLabelTimeForSearchingG, "toolStripStatusLabelTimeForSearchingG");
            // 
            // toolStripStatusLabelTimeForDrawing
            // 
            this.toolStripStatusLabelTimeForDrawing.Name = "toolStripStatusLabelTimeForDrawing";
            resources.ApplyResources(this.toolStripStatusLabelTimeForDrawing, "toolStripStatusLabelTimeForDrawing");
            // 
            // toolStripStatusLabelTimeForBethe
            // 
            this.toolStripStatusLabelTimeForBethe.Name = "toolStripStatusLabelTimeForBethe";
            resources.ApplyResources(this.toolStripStatusLabelTimeForBethe, "toolStripStatusLabelTimeForBethe");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // labelTwoTheta
            // 
            resources.ApplyResources(this.labelTwoTheta, "labelTwoTheta");
            this.labelTwoTheta.Name = "labelTwoTheta";
            // 
            // checkBoxFixCenter
            // 
            resources.ApplyResources(this.checkBoxFixCenter, "checkBoxFixCenter");
            this.checkBoxFixCenter.Name = "checkBoxFixCenter";
            this.checkBoxFixCenter.UseVisualStyleBackColor = true;
            this.checkBoxFixCenter.CheckedChanged += new System.EventHandler(this.checkBoxFixCenter_CheckedChanged);
            // 
            // labelDinv
            // 
            resources.ApplyResources(this.labelDinv, "labelDinv");
            this.labelDinv.Name = "labelDinv";
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.ShowHelp = true;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // timerBlinkSpot
            // 
            this.timerBlinkSpot.Interval = 400;
            this.timerBlinkSpot.Tag = "true";
            this.timerBlinkSpot.Tick += new System.EventHandler(this.timerBlinkSpot_Tick);
            // 
            // timerBlinkKikuchiLine
            // 
            this.timerBlinkKikuchiLine.Interval = 400;
            this.timerBlinkKikuchiLine.Tick += new System.EventHandler(this.timerBlinkKikuchiLine_Tick);
            // 
            // timerBlinkDebyeRing
            // 
            this.timerBlinkDebyeRing.Interval = 400;
            this.timerBlinkDebyeRing.Tick += new System.EventHandler(this.timerBlinkDebyering_Tick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicConceptOfBethesMethodToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // basicConceptOfBethesMethodToolStripMenuItem
            // 
            this.basicConceptOfBethesMethodToolStripMenuItem.Name = "basicConceptOfBethesMethodToolStripMenuItem";
            resources.ApplyResources(this.basicConceptOfBethesMethodToolStripMenuItem, "basicConceptOfBethesMethodToolStripMenuItem");
            this.basicConceptOfBethesMethodToolStripMenuItem.Click += new System.EventHandler(this.basicConceptOfBethesMethodToolStripMenuItem_Click);
            // 
            // FormDiffractionSimulator
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelMousePointInverse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.buttonResetCenter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.labelTwoTheta);
            this.Controls.Add(this.labelDinv);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelMousePointReal);
            this.Controls.Add(this.graphicsBox);
            this.Controls.Add(this.checkBoxFixCenter);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDiffractionSimulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormElectronDiffraction_FormClosing);
            this.Load += new System.EventHandler(this.FormElectronDiffraction_Load);
            this.VisibleChanged += new System.EventHandler(this.FormElectronDiffraction_VisibleChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormDiffractionSimulator_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormDiffractionSimulator_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDiffractionSimulator_Paint);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebyeRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcessLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForbiddenScrewGlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForbiddenLattice)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinKL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineWidth)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDebyeRingWidth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCamaraLength2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanelPED.ResumeLayout(false);
            this.flowLayoutPanelPED.PerformLayout();
            this.flowLayoutPanelBethe.ResumeLayout(false);
            this.flowLayoutPanelBethe.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensityForPointSpread)).EndInit();
            this.flowLayoutPanelColorScale.ResumeLayout(false);
            this.flowLayoutPanelColorScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpotOpacity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxExtinctionAll;
        private System.Windows.Forms.CheckBox checkBoxExtinctionLattice;
        public System.Windows.Forms.NumericUpDown numericUpDownMinKL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarLineWidth;
        private System.Windows.Forms.TrackBar trackBarStrSize;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numericUpDownCamaraLength2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelExcessLine;
        private System.Windows.Forms.Label label1Origin;
        private System.Windows.Forms.Label labelNoCondition;
        private System.Windows.Forms.Label labelForbiddenScrewGlide;
        private System.Windows.Forms.Label labelForbiddenLattice;
        private System.Windows.Forms.Label labelString;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyImageToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIndexLabels;
        private System.Windows.Forms.ToolStripButton toolStripButtonDspacing;
        private System.Windows.Forms.ToolStripButton toolStripButtonDistance;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonKikuchiLines;
        public System.Windows.Forms.PictureBox pictureBoxNoCondition;
        public System.Windows.Forms.PictureBox pictureBoxExcessLine;
        public System.Windows.Forms.PictureBox pictureBoxDefectLine;
        public System.Windows.Forms.PictureBox pictureBoxOrigin;
        public System.Windows.Forms.PictureBox pictureBoxForbiddenScrewGlide;
        public System.Windows.Forms.PictureBox pictureBoxForbiddenLattice;
        public System.Windows.Forms.PictureBox pictureBoxString;
        public System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcitationError;
        private System.Windows.Forms.ToolStripButton toolStripButtonFg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeForSearchingG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackLaue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBarRotationSpeed;
        private System.Windows.Forms.GroupBox groupBox6;
        public Crystallography.Controls.WaveLengthControl waveLengthControl;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelMousePointReal;
        private System.Windows.Forms.Label labelMousePointInverse;
        private System.Windows.Forms.TrackBar trackBarIntensityForPointSpread;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDetailedGeometry;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCircleArea;
        private System.Windows.Forms.RadioButton radioButtonPointSpread;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonResetCenter;
        public System.Windows.Forms.PictureBox pictureBoxFoot;
        private System.Windows.Forms.Label label14;
        public Crystallography.Controls.NumericBox numericBoxResolution;
        public ImagingSolution.Control.GraphicsBox graphicsBox;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMetafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAsMetafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiffractionSpots;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDebyeRing;
        private System.Windows.Forms.CheckBox checkBoxDebyeRingIgnoreIntensity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarDebyeRingWidth;
        private System.Windows.Forms.RadioButton radioButtonIntensityExcitation;
        private System.Windows.Forms.Label labelDefectLine;
        private Crystallography.Controls.TrackBarAdvanced trackBarAdvancedSpotRadius;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBoxDebyeRing;
        private System.Windows.Forms.Label labelTwoTheta;
        private System.Windows.Forms.Timer timerBlinkSpot;
        private System.Windows.Forms.Timer timerBlinkKikuchiLine;
        private System.Windows.Forms.Timer timerBlinkDebyeRing;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.CheckBox checkBoxDebyeRingLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarSpotOpacity;
        private System.Windows.Forms.ToolStripMenuItem copyAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDetectorAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDetectorAsMetafileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem copyDetectorAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDetectorAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDetectorAsMetafileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveDetectorAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeForDrawing;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.CheckBox checkBoxUseCrystalColor;
        private System.Windows.Forms.CheckBox checkBoxLogScale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBethe;
        private System.Windows.Forms.ToolStripMenuItem dynamicCompressionToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonIntensityKinematical;
        public System.Windows.Forms.RadioButton radioButtonIntensityBethe;
        private System.Windows.Forms.ToolStripMenuItem saveCBEDPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCBEDPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCBEDasPngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCBEDasMetafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCBEDasImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCBEDasMetafileToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxFixCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public Crystallography.Controls.TrackBarAdvanced trackBarAdvancedThickness;
        private System.Windows.Forms.ToolStripMenuItem saveCBEDasTiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeForBethe;
        private System.Windows.Forms.TabPage tabPage2;
        public Crystallography.Controls.NumericBox numericBoxClientHeight;
        public Crystallography.Controls.NumericBox numericBoxClientWidth;
        private System.Windows.Forms.Button button1;
        private Crystallography.Controls.NumericBox numericBoxDev;
        private Crystallography.Controls.NumericBox numericBoxAcc;
        private System.Windows.Forms.Label label16;
        private Crystallography.Controls.NumericBox numericBoxPED_Semiangle;
        private Crystallography.Controls.NumericBox numericBoxPED_Step;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPED;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonBeamParallel;
        private System.Windows.Forms.RadioButton radioButtonBeamPrecession;
        public System.Windows.Forms.RadioButton radioButtonBeamConvergence;
        private System.Windows.Forms.Label labelDinv;
        private System.Windows.Forms.Button buttonDetailsOfSpots;
        public Crystallography.Controls.NumericBox numericBoxNumOfBlochWave;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.ComboBox comboBoxScaleColorScale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColorScale;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicConceptOfBethesMethodToolStripMenuItem;
    }
}