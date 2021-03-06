﻿using System;

namespace ReciPro
{
    partial class FormImageSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                scaleImage.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageSimulator));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMousePositionValue = new System.Windows.Forms.Label();
            this.labelMousePositionY = new System.Windows.Forms.Label();
            this.labelMousePositionX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxScaleOfIntensity = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelGaussianBlur2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxGaussianBlur = new System.Windows.Forms.CheckBox();
            this.numericBoxGaussianRadius = new Crystallography.Controls.NumericBox();
            this.label25 = new System.Windows.Forms.Label();
            this.trackBarAdvancedMax = new Crystallography.Controls.TrackBarAdvanced();
            this.comboBoxScaleColorScale = new System.Windows.Forms.ComboBox();
            this.trackBarAdvancedMin = new Crystallography.Controls.TrackBarAdvanced();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowUnitcell = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.numericBoxLabelFontSize = new Crystallography.Controls.NumericBox();
            this.colorControlLabel = new Crystallography.Controls.ColorControl();
            this.checkBoxShowLabel = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelScale = new System.Windows.Forms.FlowLayoutPanel();
            this.numericBoxScaleLength = new Crystallography.Controls.NumericBox();
            this.colorControlScale = new Crystallography.Controls.ColorControl();
            this.checkBoxShowScale = new System.Windows.Forms.CheckBox();
            this.checkBoxRealTimeCalculation = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonProjectedPotential = new System.Windows.Forms.RadioButton();
            this.radioButtonSTEM = new System.Windows.Forms.RadioButton();
            this.radioButtonHRTEM = new System.Windows.Forms.RadioButton();
            this.groupBoxSampleProperty = new System.Windows.Forms.GroupBox();
            this.numericBoxThickness = new Crystallography.Controls.NumericBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericBoxAccVol = new Crystallography.Controls.NumericBox();
            this.numericBoxDefocus = new Crystallography.Controls.NumericBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRambda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxScherzer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxInherentProperty = new System.Windows.Forms.GroupBox();
            this.numericBoxCs = new Crystallography.Controls.NumericBox();
            this.numericBoxCc = new Crystallography.Controls.NumericBox();
            this.numericBoxDeltaV = new Crystallography.Controls.NumericBox();
            this.numericBoxBetaAgnle = new Crystallography.Controls.NumericBox();
            this.panelDummy1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxLenzFunction = new System.Windows.Forms.GroupBox();
            this.graphControl = new Crystallography.Controls.GraphControl();
            this.panelGraphOption = new System.Windows.Forms.Panel();
            this.buttonCopyGraph = new System.Windows.Forms.Button();
            this.numericBoxMaxU1 = new Crystallography.Controls.NumericBox();
            this.checkBoxGraphAll = new System.Windows.Forms.CheckBox();
            this.checkBoxGraphEc = new System.Windows.Forms.CheckBox();
            this.checkBoxGraphPCTF = new System.Windows.Forms.CheckBox();
            this.checkBoxGraphEs = new System.Windows.Forms.CheckBox();
            this.buttonPanel = new System.Windows.Forms.Button();
            this.groupBoxObjectAperture = new System.Windows.Forms.GroupBox();
            this.numericBoxObjAperX = new Crystallography.Controls.NumericBox();
            this.numericBoxObjAperRadius = new Crystallography.Controls.NumericBox();
            this.numericBoxObjAperY = new Crystallography.Controls.NumericBox();
            this.checkBoxOpenAperture = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxNumOfSpots = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxApertureRadius = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDetailsOfSpots = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericBoxNumOfBlochWave = new Crystallography.Controls.NumericBox();
            this.panelDummy2 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericBoxWidth = new Crystallography.Controls.NumericBox();
            this.numericBoxHeight = new Crystallography.Controls.NumericBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericBoxResolution = new Crystallography.Controls.NumericBox();
            this.groupBoxNormalizeIntensity = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxNormalizeHigh = new System.Windows.Forms.CheckBox();
            this.checkBoxNormalizeLow = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButtonSingleMode = new System.Windows.Forms.RadioButton();
            this.radioButtonSerialMode = new System.Windows.Forms.RadioButton();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.panelSerialDefocus = new System.Windows.Forms.Panel();
            this.textBoxDefocusList = new System.Windows.Forms.TextBox();
            this.numericBoxDefocusNum = new Crystallography.Controls.NumericBox();
            this.numericBoxDefocusStep = new Crystallography.Controls.NumericBox();
            this.numericBoxDefocusStart = new Crystallography.Controls.NumericBox();
            this.flowLayoutPanelHorizontalDirection = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonHorizontalDefocus = new System.Windows.Forms.RadioButton();
            this.radioButtonHorizontalThickness = new System.Windows.Forms.RadioButton();
            this.panelSerialThickness = new System.Windows.Forms.Panel();
            this.numericBoxThicknessNum = new Crystallography.Controls.NumericBox();
            this.numericBoxThicknessStep = new Crystallography.Controls.NumericBox();
            this.textBoxThicknessList = new System.Windows.Forms.TextBox();
            this.numericBoxThicknessStart = new Crystallography.Controls.NumericBox();
            this.checkBoxSerialThickness = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialDefocus = new System.Windows.Forms.CheckBox();
            this.groupBoxPartialCoherencyModel = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonModeQuasiCoherent = new System.Windows.Forms.RadioButton();
            this.radioButtonModeTransmissionCrossCoefficient = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonPotentialModeMagAndPhase = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelMagAndPhase = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonPotentialShowMagAndPhase = new System.Windows.Forms.RadioButton();
            this.radioButtonPotentialShowMag = new System.Windows.Forms.RadioButton();
            this.radioButtonPotentialShowPhase = new System.Windows.Forms.RadioButton();
            this.panelPhaseScale = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBoxPhaseScale = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonPotentialModeRealAndImag = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelRealAndImaiginary = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonPotentialShowRealAndImag = new System.Windows.Forms.RadioButton();
            this.radioButtonPotentialShowReal = new System.Windows.Forms.RadioButton();
            this.radioButtonPotentialShowImag = new System.Windows.Forms.RadioButton();
            this.checkBoxPotentialUgPrime = new System.Windows.Forms.CheckBox();
            this.checkBoxPotentialUg = new System.Windows.Forms.CheckBox();
            this.buttonSimulateHRTEM = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSavePNG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveTIFF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveMetafile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveIndividually = new System.Windows.Forms.ToolStripMenuItem();
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyMetafile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverprintSymbols = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.readTEMParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTEMParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsOfHRTEMSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.calculationLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxCaclulationLibrary = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScaleOfIntensity)).BeginInit();
            this.flowLayoutPanelGaussianBlur2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanelLabel.SuspendLayout();
            this.flowLayoutPanelScale.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxSampleProperty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBoxInherentProperty.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxLenzFunction.SuspendLayout();
            this.panelGraphOption.SuspendLayout();
            this.groupBoxObjectAperture.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.groupBoxNormalizeIntensity.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panelSerial.SuspendLayout();
            this.panelSerialDefocus.SuspendLayout();
            this.flowLayoutPanelHorizontalDirection.SuspendLayout();
            this.panelSerialThickness.SuspendLayout();
            this.groupBoxPartialCoherencyModel.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanelMagAndPhase.SuspendLayout();
            this.panelPhaseScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhaseScale)).BeginInit();
            this.flowLayoutPanelRealAndImaiginary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.toolTip.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxRealTimeCalculation);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSampleProperty);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSimulateHRTEM);
            this.toolTip.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.toolTip.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel.CausesValidation = false;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.toolTip.SetToolTip(this.tableLayoutPanel, resources.GetString("tableLayoutPanel.ToolTip"));
            this.tableLayoutPanel.Enter += new System.EventHandler(this.tableLayoutPanel_Enter);
            this.tableLayoutPanel.Leave += new System.EventHandler(this.tableLayoutPanel_Leave);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.labelMousePositionValue);
            this.panel1.Controls.Add(this.labelMousePositionY);
            this.panel1.Controls.Add(this.labelMousePositionX);
            this.panel1.Name = "panel1";
            this.toolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // labelMousePositionValue
            // 
            resources.ApplyResources(this.labelMousePositionValue, "labelMousePositionValue");
            this.labelMousePositionValue.Name = "labelMousePositionValue";
            this.toolTip.SetToolTip(this.labelMousePositionValue, resources.GetString("labelMousePositionValue.ToolTip"));
            // 
            // labelMousePositionY
            // 
            resources.ApplyResources(this.labelMousePositionY, "labelMousePositionY");
            this.labelMousePositionY.Name = "labelMousePositionY";
            this.toolTip.SetToolTip(this.labelMousePositionY, resources.GetString("labelMousePositionY.ToolTip"));
            // 
            // labelMousePositionX
            // 
            resources.ApplyResources(this.labelMousePositionX, "labelMousePositionX");
            this.labelMousePositionX.Name = "labelMousePositionX";
            this.toolTip.SetToolTip(this.labelMousePositionX, resources.GetString("labelMousePositionX.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.pictureBoxScaleOfIntensity);
            this.panel2.Controls.Add(this.flowLayoutPanelGaussianBlur2);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.trackBarAdvancedMax);
            this.panel2.Controls.Add(this.comboBoxScaleColorScale);
            this.panel2.Controls.Add(this.trackBarAdvancedMin);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Name = "panel2";
            this.toolTip.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // pictureBoxScaleOfIntensity
            // 
            resources.ApplyResources(this.pictureBoxScaleOfIntensity, "pictureBoxScaleOfIntensity");
            this.pictureBoxScaleOfIntensity.Name = "pictureBoxScaleOfIntensity";
            this.pictureBoxScaleOfIntensity.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxScaleOfIntensity, resources.GetString("pictureBoxScaleOfIntensity.ToolTip"));
            // 
            // flowLayoutPanelGaussianBlur2
            // 
            resources.ApplyResources(this.flowLayoutPanelGaussianBlur2, "flowLayoutPanelGaussianBlur2");
            this.flowLayoutPanelGaussianBlur2.Controls.Add(this.checkBoxGaussianBlur);
            this.flowLayoutPanelGaussianBlur2.Controls.Add(this.numericBoxGaussianRadius);
            this.flowLayoutPanelGaussianBlur2.Name = "flowLayoutPanelGaussianBlur2";
            this.toolTip.SetToolTip(this.flowLayoutPanelGaussianBlur2, resources.GetString("flowLayoutPanelGaussianBlur2.ToolTip"));
            // 
            // checkBoxGaussianBlur
            // 
            resources.ApplyResources(this.checkBoxGaussianBlur, "checkBoxGaussianBlur");
            this.checkBoxGaussianBlur.Name = "checkBoxGaussianBlur";
            this.toolTip.SetToolTip(this.checkBoxGaussianBlur, resources.GetString("checkBoxGaussianBlur.ToolTip"));
            this.checkBoxGaussianBlur.UseVisualStyleBackColor = true;
            this.checkBoxGaussianBlur.CheckedChanged += new System.EventHandler(this.CheckBoxGaussianBlur_CheckedChanged);
            // 
            // numericBoxGaussianRadius
            // 
            resources.ApplyResources(this.numericBoxGaussianRadius, "numericBoxGaussianRadius");
            this.numericBoxGaussianRadius.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxGaussianRadius.DecimalPlaces = 1;
            this.numericBoxGaussianRadius.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxGaussianRadius.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxGaussianRadius.Maximum = 100D;
            this.numericBoxGaussianRadius.Minimum = 0D;
            this.numericBoxGaussianRadius.Name = "numericBoxGaussianRadius";
            this.numericBoxGaussianRadius.RadianValue = 0.017453292519943295D;
            this.numericBoxGaussianRadius.ShowUpDown = true;
            this.numericBoxGaussianRadius.SkipEventDuringInput = false;
            this.numericBoxGaussianRadius.SmartIncrement = true;
            this.numericBoxGaussianRadius.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxGaussianRadius, resources.GetString("numericBoxGaussianRadius.ToolTip"));
            this.numericBoxGaussianRadius.Value = 1D;
            this.numericBoxGaussianRadius.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.CheckBoxGaussianBlur_CheckedChanged);
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            this.toolTip.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            // 
            // trackBarAdvancedMax
            // 
            resources.ApplyResources(this.trackBarAdvancedMax, "trackBarAdvancedMax");
            this.trackBarAdvancedMax.ControlHeight = 27;
            this.trackBarAdvancedMax.DecimalPlaces = -1;
            this.trackBarAdvancedMax.LogScrollBar = false;
            this.trackBarAdvancedMax.Maximum = 65535D;
            this.trackBarAdvancedMax.Minimum = 0D;
            this.trackBarAdvancedMax.Name = "trackBarAdvancedMax";
            this.trackBarAdvancedMax.NumericBoxSize = 100;
            this.trackBarAdvancedMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAdvancedMax.Smart_Increment = true;
            this.trackBarAdvancedMax.TickStyle = System.Windows.Forms.TickStyle.BottomRight;
            this.toolTip.SetToolTip(this.trackBarAdvancedMax, resources.GetString("trackBarAdvancedMax.ToolTip"));
            this.trackBarAdvancedMax.UpDown_Increment = 1D;
            this.trackBarAdvancedMax.Value = 65535D;
            this.trackBarAdvancedMax.ValueChanged += new Crystallography.Controls.TrackBarAdvanced.ValueChangedDelegate(this.TrackBarAdvancedMin_ValueChanged);
            // 
            // comboBoxScaleColorScale
            // 
            resources.ApplyResources(this.comboBoxScaleColorScale, "comboBoxScaleColorScale");
            this.comboBoxScaleColorScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScaleColorScale.FormattingEnabled = true;
            this.comboBoxScaleColorScale.Items.AddRange(new object[] {
            resources.GetString("comboBoxScaleColorScale.Items"),
            resources.GetString("comboBoxScaleColorScale.Items1")});
            this.comboBoxScaleColorScale.Name = "comboBoxScaleColorScale";
            this.toolTip.SetToolTip(this.comboBoxScaleColorScale, resources.GetString("comboBoxScaleColorScale.ToolTip"));
            this.comboBoxScaleColorScale.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScaleColorScale_SelectedIndexChanged);
            // 
            // trackBarAdvancedMin
            // 
            resources.ApplyResources(this.trackBarAdvancedMin, "trackBarAdvancedMin");
            this.trackBarAdvancedMin.ControlHeight = 27;
            this.trackBarAdvancedMin.DecimalPlaces = -1;
            this.trackBarAdvancedMin.LogScrollBar = false;
            this.trackBarAdvancedMin.Maximum = 65535D;
            this.trackBarAdvancedMin.Minimum = 0D;
            this.trackBarAdvancedMin.Name = "trackBarAdvancedMin";
            this.trackBarAdvancedMin.NumericBoxSize = 97;
            this.trackBarAdvancedMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAdvancedMin.Smart_Increment = true;
            this.trackBarAdvancedMin.TickStyle = System.Windows.Forms.TickStyle.BottomRight;
            this.toolTip.SetToolTip(this.trackBarAdvancedMin, resources.GetString("trackBarAdvancedMin.ToolTip"));
            this.trackBarAdvancedMin.UpDown_Increment = 1D;
            this.trackBarAdvancedMin.Value = 0D;
            this.trackBarAdvancedMin.ValueChanged += new Crystallography.Controls.TrackBarAdvanced.ValueChangedDelegate(this.TrackBarAdvancedMin_ValueChanged);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            this.toolTip.SetToolTip(this.label27, resources.GetString("label27.ToolTip"));
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            this.toolTip.SetToolTip(this.label30, resources.GetString("label30.ToolTip"));
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            this.toolTip.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            this.toolTip.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            this.toolTip.SetToolTip(this.label29, resources.GetString("label29.ToolTip"));
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            this.toolTip.SetToolTip(this.label31, resources.GetString("label31.ToolTip"));
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            this.toolTip.SetToolTip(this.label33, resources.GetString("label33.ToolTip"));
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.checkBoxShowUnitcell);
            this.groupBox5.Controls.Add(this.flowLayoutPanelLabel);
            this.groupBox5.Controls.Add(this.checkBoxShowLabel);
            this.groupBox5.Controls.Add(this.flowLayoutPanelScale);
            this.groupBox5.Controls.Add(this.checkBoxShowScale);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // checkBoxShowUnitcell
            // 
            resources.ApplyResources(this.checkBoxShowUnitcell, "checkBoxShowUnitcell");
            this.checkBoxShowUnitcell.Checked = true;
            this.checkBoxShowUnitcell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowUnitcell.Name = "checkBoxShowUnitcell";
            this.toolTip.SetToolTip(this.checkBoxShowUnitcell, resources.GetString("checkBoxShowUnitcell.ToolTip"));
            this.checkBoxShowUnitcell.UseVisualStyleBackColor = true;
            this.checkBoxShowUnitcell.CheckedChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // flowLayoutPanelLabel
            // 
            resources.ApplyResources(this.flowLayoutPanelLabel, "flowLayoutPanelLabel");
            this.flowLayoutPanelLabel.Controls.Add(this.numericBoxLabelFontSize);
            this.flowLayoutPanelLabel.Controls.Add(this.colorControlLabel);
            this.flowLayoutPanelLabel.Name = "flowLayoutPanelLabel";
            this.toolTip.SetToolTip(this.flowLayoutPanelLabel, resources.GetString("flowLayoutPanelLabel.ToolTip"));
            // 
            // numericBoxLabelFontSize
            // 
            resources.ApplyResources(this.numericBoxLabelFontSize, "numericBoxLabelFontSize");
            this.numericBoxLabelFontSize.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxLabelFontSize.DecimalPlaces = 0;
            this.numericBoxLabelFontSize.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxLabelFontSize.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxLabelFontSize.Maximum = 20D;
            this.numericBoxLabelFontSize.Minimum = 1D;
            this.numericBoxLabelFontSize.Name = "numericBoxLabelFontSize";
            this.numericBoxLabelFontSize.RadianValue = 0.15707963267948966D;
            this.numericBoxLabelFontSize.ShowUpDown = true;
            this.numericBoxLabelFontSize.SkipEventDuringInput = false;
            this.numericBoxLabelFontSize.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxLabelFontSize, resources.GetString("numericBoxLabelFontSize.ToolTip"));
            this.numericBoxLabelFontSize.Value = 9D;
            this.numericBoxLabelFontSize.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // colorControlLabel
            // 
            resources.ApplyResources(this.colorControlLabel, "colorControlLabel");
            this.colorControlLabel.Argb = -5374161;
            this.colorControlLabel.Blue = 47;
            this.colorControlLabel.BlueF = 0.1843137F;
            this.colorControlLabel.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlLabel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
            this.colorControlLabel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlLabel.Green = 255;
            this.colorControlLabel.GreenF = 1F;
            this.colorControlLabel.Name = "colorControlLabel";
            this.colorControlLabel.Red = 173;
            this.colorControlLabel.RedF = 0.6784314F;
            this.toolTip.SetToolTip(this.colorControlLabel, resources.GetString("colorControlLabel.ToolTip1"));
            this.colorControlLabel.ColorChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // checkBoxShowLabel
            // 
            resources.ApplyResources(this.checkBoxShowLabel, "checkBoxShowLabel");
            this.checkBoxShowLabel.Checked = true;
            this.checkBoxShowLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLabel.Name = "checkBoxShowLabel";
            this.toolTip.SetToolTip(this.checkBoxShowLabel, resources.GetString("checkBoxShowLabel.ToolTip"));
            this.checkBoxShowLabel.UseVisualStyleBackColor = true;
            this.checkBoxShowLabel.CheckedChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // flowLayoutPanelScale
            // 
            resources.ApplyResources(this.flowLayoutPanelScale, "flowLayoutPanelScale");
            this.flowLayoutPanelScale.Controls.Add(this.numericBoxScaleLength);
            this.flowLayoutPanelScale.Controls.Add(this.colorControlScale);
            this.flowLayoutPanelScale.Name = "flowLayoutPanelScale";
            this.toolTip.SetToolTip(this.flowLayoutPanelScale, resources.GetString("flowLayoutPanelScale.ToolTip"));
            // 
            // numericBoxScaleLength
            // 
            resources.ApplyResources(this.numericBoxScaleLength, "numericBoxScaleLength");
            this.numericBoxScaleLength.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxScaleLength.DecimalPlaces = 1;
            this.numericBoxScaleLength.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxScaleLength.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxScaleLength.Maximum = 100D;
            this.numericBoxScaleLength.Minimum = 0.2D;
            this.numericBoxScaleLength.Name = "numericBoxScaleLength";
            this.numericBoxScaleLength.RadianValue = 0.0087266462599716477D;
            this.numericBoxScaleLength.ShowUpDown = true;
            this.numericBoxScaleLength.SkipEventDuringInput = false;
            this.numericBoxScaleLength.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxScaleLength, resources.GetString("numericBoxScaleLength.ToolTip"));
            this.numericBoxScaleLength.UpDown_Increment = 0.2D;
            this.numericBoxScaleLength.Value = 0.5D;
            this.numericBoxScaleLength.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // colorControlScale
            // 
            resources.ApplyResources(this.colorControlScale, "colorControlScale");
            this.colorControlScale.Argb = -7877126;
            this.colorControlScale.Blue = 250;
            this.colorControlScale.BlueF = 0.9803922F;
            this.colorControlScale.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlScale.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.colorControlScale.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlScale.Green = 205;
            this.colorControlScale.GreenF = 0.8039216F;
            this.colorControlScale.Name = "colorControlScale";
            this.colorControlScale.Red = 135;
            this.colorControlScale.RedF = 0.5294118F;
            this.toolTip.SetToolTip(this.colorControlScale, resources.GetString("colorControlScale.ToolTip1"));
            this.colorControlScale.ColorChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // checkBoxShowScale
            // 
            resources.ApplyResources(this.checkBoxShowScale, "checkBoxShowScale");
            this.checkBoxShowScale.Checked = true;
            this.checkBoxShowScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowScale.Name = "checkBoxShowScale";
            this.toolTip.SetToolTip(this.checkBoxShowScale, resources.GetString("checkBoxShowScale.ToolTip"));
            this.checkBoxShowScale.UseVisualStyleBackColor = true;
            this.checkBoxShowScale.CheckedChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // checkBoxRealTimeCalculation
            // 
            resources.ApplyResources(this.checkBoxRealTimeCalculation, "checkBoxRealTimeCalculation");
            this.checkBoxRealTimeCalculation.Name = "checkBoxRealTimeCalculation";
            this.toolTip.SetToolTip(this.checkBoxRealTimeCalculation, resources.GetString("checkBoxRealTimeCalculation.ToolTip"));
            this.checkBoxRealTimeCalculation.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.radioButtonProjectedPotential);
            this.groupBox6.Controls.Add(this.radioButtonSTEM);
            this.groupBox6.Controls.Add(this.radioButtonHRTEM);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
            // 
            // radioButtonProjectedPotential
            // 
            resources.ApplyResources(this.radioButtonProjectedPotential, "radioButtonProjectedPotential");
            this.radioButtonProjectedPotential.Name = "radioButtonProjectedPotential";
            this.toolTip.SetToolTip(this.radioButtonProjectedPotential, resources.GetString("radioButtonProjectedPotential.ToolTip"));
            this.radioButtonProjectedPotential.UseVisualStyleBackColor = true;
            this.radioButtonProjectedPotential.CheckedChanged += new System.EventHandler(this.RadioButtonHRTEM_CheckedChanged);
            // 
            // radioButtonSTEM
            // 
            resources.ApplyResources(this.radioButtonSTEM, "radioButtonSTEM");
            this.radioButtonSTEM.Name = "radioButtonSTEM";
            this.toolTip.SetToolTip(this.radioButtonSTEM, resources.GetString("radioButtonSTEM.ToolTip"));
            this.radioButtonSTEM.UseVisualStyleBackColor = true;
            this.radioButtonSTEM.CheckedChanged += new System.EventHandler(this.RadioButtonHRTEM_CheckedChanged);
            // 
            // radioButtonHRTEM
            // 
            resources.ApplyResources(this.radioButtonHRTEM, "radioButtonHRTEM");
            this.radioButtonHRTEM.Checked = true;
            this.radioButtonHRTEM.Name = "radioButtonHRTEM";
            this.radioButtonHRTEM.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonHRTEM, resources.GetString("radioButtonHRTEM.ToolTip"));
            this.radioButtonHRTEM.UseVisualStyleBackColor = true;
            this.radioButtonHRTEM.CheckedChanged += new System.EventHandler(this.RadioButtonHRTEM_CheckedChanged);
            // 
            // groupBoxSampleProperty
            // 
            resources.ApplyResources(this.groupBoxSampleProperty, "groupBoxSampleProperty");
            this.groupBoxSampleProperty.Controls.Add(this.numericBoxThickness);
            this.groupBoxSampleProperty.Name = "groupBoxSampleProperty";
            this.groupBoxSampleProperty.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxSampleProperty, resources.GetString("groupBoxSampleProperty.ToolTip"));
            // 
            // numericBoxThickness
            // 
            resources.ApplyResources(this.numericBoxThickness, "numericBoxThickness");
            this.numericBoxThickness.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThickness.DecimalPlaces = 3;
            this.numericBoxThickness.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThickness.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThickness.Maximum = 1000D;
            this.numericBoxThickness.Minimum = 0.001D;
            this.numericBoxThickness.Name = "numericBoxThickness";
            this.numericBoxThickness.RadianValue = 0.3490658503988659D;
            this.numericBoxThickness.ShowUpDown = true;
            this.numericBoxThickness.SmartIncrement = true;
            this.numericBoxThickness.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxThickness, resources.GetString("numericBoxThickness.ToolTip"));
            this.numericBoxThickness.Value = 20D;
            this.numericBoxThickness.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxThickness_ValueChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBoxInherentProperty);
            this.groupBox2.Controls.Add(this.panelDummy1);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.numericBoxAccVol);
            this.groupBox4.Controls.Add(this.numericBoxDefocus);
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Controls.Add(this.flowLayoutPanel3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // numericBoxAccVol
            // 
            resources.ApplyResources(this.numericBoxAccVol, "numericBoxAccVol");
            this.numericBoxAccVol.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAccVol.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAccVol.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAccVol.Maximum = 1000D;
            this.numericBoxAccVol.Minimum = 1D;
            this.numericBoxAccVol.Name = "numericBoxAccVol";
            this.numericBoxAccVol.RadianValue = 3.4906585039886591D;
            this.numericBoxAccVol.ShowUpDown = true;
            this.numericBoxAccVol.SmartIncrement = true;
            this.numericBoxAccVol.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxAccVol, resources.GetString("numericBoxAccVol.ToolTip"));
            this.numericBoxAccVol.Value = 200D;
            this.numericBoxAccVol.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxAccVol_ValueChanged);
            // 
            // numericBoxDefocus
            // 
            resources.ApplyResources(this.numericBoxDefocus, "numericBoxDefocus");
            this.numericBoxDefocus.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocus.DecimalPlaces = 1;
            this.numericBoxDefocus.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocus.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocus.Maximum = 1000D;
            this.numericBoxDefocus.Minimum = -1000D;
            this.numericBoxDefocus.Name = "numericBoxDefocus";
            this.numericBoxDefocus.RadianValue = -1.2217304763960306D;
            this.numericBoxDefocus.ShowUpDown = true;
            this.numericBoxDefocus.SmartIncrement = true;
            this.numericBoxDefocus.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxDefocus, resources.GetString("numericBoxDefocus.ToolTip"));
            this.numericBoxDefocus.Value = -70D;
            this.numericBoxDefocus.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxDefocus_ValueChanged);
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.textBoxRambda);
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.toolTip.SetToolTip(this.flowLayoutPanel4, resources.GetString("flowLayoutPanel4.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // textBoxRambda
            // 
            resources.ApplyResources(this.textBoxRambda, "textBoxRambda");
            this.textBoxRambda.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxRambda.Name = "textBoxRambda";
            this.textBoxRambda.ReadOnly = true;
            this.toolTip.SetToolTip(this.textBoxRambda, resources.GetString("textBoxRambda.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            this.toolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.textBoxScherzer);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.toolTip.SetToolTip(this.flowLayoutPanel3, resources.GetString("flowLayoutPanel3.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // textBoxScherzer
            // 
            resources.ApplyResources(this.textBoxScherzer, "textBoxScherzer");
            this.textBoxScherzer.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxScherzer.Name = "textBoxScherzer";
            this.textBoxScherzer.ReadOnly = true;
            this.toolTip.SetToolTip(this.textBoxScherzer, resources.GetString("textBoxScherzer.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // groupBoxInherentProperty
            // 
            resources.ApplyResources(this.groupBoxInherentProperty, "groupBoxInherentProperty");
            this.groupBoxInherentProperty.Controls.Add(this.numericBoxCs);
            this.groupBoxInherentProperty.Controls.Add(this.numericBoxCc);
            this.groupBoxInherentProperty.Controls.Add(this.numericBoxDeltaV);
            this.groupBoxInherentProperty.Controls.Add(this.numericBoxBetaAgnle);
            this.groupBoxInherentProperty.Name = "groupBoxInherentProperty";
            this.groupBoxInherentProperty.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxInherentProperty, resources.GetString("groupBoxInherentProperty.ToolTip"));
            // 
            // numericBoxCs
            // 
            resources.ApplyResources(this.numericBoxCs, "numericBoxCs");
            this.numericBoxCs.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCs.DecimalPlaces = 2;
            this.numericBoxCs.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCs.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCs.Maximum = 20D;
            this.numericBoxCs.Minimum = -20D;
            this.numericBoxCs.Name = "numericBoxCs";
            this.numericBoxCs.RadianValue = 0.022689280275926284D;
            this.numericBoxCs.ShowUpDown = true;
            this.numericBoxCs.SmartIncrement = true;
            this.numericBoxCs.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxCs, resources.GetString("numericBoxCs.ToolTip"));
            this.numericBoxCs.UpDown_Increment = 0.1D;
            this.numericBoxCs.Value = 1.3D;
            this.numericBoxCs.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxCs_ValueChanged);
            // 
            // numericBoxCc
            // 
            resources.ApplyResources(this.numericBoxCc, "numericBoxCc");
            this.numericBoxCc.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCc.DecimalPlaces = 2;
            this.numericBoxCc.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCc.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCc.Maximum = 10D;
            this.numericBoxCc.Minimum = 0D;
            this.numericBoxCc.Name = "numericBoxCc";
            this.numericBoxCc.RadianValue = 0.027925268031909273D;
            this.numericBoxCc.RestrictLimitValue = false;
            this.numericBoxCc.ShowUpDown = true;
            this.numericBoxCc.SmartIncrement = true;
            this.numericBoxCc.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxCc, resources.GetString("numericBoxCc.ToolTip"));
            this.numericBoxCc.UpDown_Increment = 0.1D;
            this.numericBoxCc.Value = 1.6D;
            this.numericBoxCc.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // numericBoxDeltaV
            // 
            resources.ApplyResources(this.numericBoxDeltaV, "numericBoxDeltaV");
            this.numericBoxDeltaV.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDeltaV.DecimalPlaces = 2;
            this.numericBoxDeltaV.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDeltaV.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDeltaV.Maximum = 10D;
            this.numericBoxDeltaV.Minimum = 0D;
            this.numericBoxDeltaV.Name = "numericBoxDeltaV";
            this.numericBoxDeltaV.RadianValue = 0.012217304763960307D;
            this.numericBoxDeltaV.RestrictLimitValue = false;
            this.numericBoxDeltaV.ShowUpDown = true;
            this.numericBoxDeltaV.SmartIncrement = true;
            this.numericBoxDeltaV.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxDeltaV, resources.GetString("numericBoxDeltaV.ToolTip"));
            this.numericBoxDeltaV.UpDown_Increment = 0.1D;
            this.numericBoxDeltaV.Value = 0.7D;
            this.numericBoxDeltaV.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // numericBoxBetaAgnle
            // 
            resources.ApplyResources(this.numericBoxBetaAgnle, "numericBoxBetaAgnle");
            this.numericBoxBetaAgnle.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxBetaAgnle.DecimalPlaces = 2;
            this.numericBoxBetaAgnle.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxBetaAgnle.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxBetaAgnle.Maximum = 100D;
            this.numericBoxBetaAgnle.Minimum = 0D;
            this.numericBoxBetaAgnle.Name = "numericBoxBetaAgnle";
            this.numericBoxBetaAgnle.RadianValue = 0.013089969389957471D;
            this.numericBoxBetaAgnle.ShowUpDown = true;
            this.numericBoxBetaAgnle.SmartIncrement = true;
            this.numericBoxBetaAgnle.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxBetaAgnle, resources.GetString("numericBoxBetaAgnle.ToolTip"));
            this.numericBoxBetaAgnle.UpDown_Increment = 0.05D;
            this.numericBoxBetaAgnle.Value = 0.75D;
            this.numericBoxBetaAgnle.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // panelDummy1
            // 
            resources.ApplyResources(this.panelDummy1, "panelDummy1");
            this.panelDummy1.Name = "panelDummy1";
            this.toolTip.SetToolTip(this.panelDummy1, resources.GetString("panelDummy1.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.toolTip.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.groupBoxLenzFunction);
            this.tabPage3.Controls.Add(this.groupBoxObjectAperture);
            this.tabPage3.Name = "tabPage3";
            this.toolTip.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxLenzFunction
            // 
            resources.ApplyResources(this.groupBoxLenzFunction, "groupBoxLenzFunction");
            this.groupBoxLenzFunction.Controls.Add(this.graphControl);
            this.groupBoxLenzFunction.Controls.Add(this.panelGraphOption);
            this.groupBoxLenzFunction.Controls.Add(this.buttonPanel);
            this.groupBoxLenzFunction.Name = "groupBoxLenzFunction";
            this.groupBoxLenzFunction.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxLenzFunction, resources.GetString("groupBoxLenzFunction.ToolTip"));
            // 
            // graphControl
            // 
            resources.ApplyResources(this.graphControl, "graphControl");
            this.graphControl.AllowMouseOperation = true;
            this.graphControl.BackgroundColor = System.Drawing.Color.White;
            this.graphControl.BottomMargin = 0D;
            this.graphControl.DivisionLineColor = System.Drawing.Color.Gray;
            this.graphControl.DivisionSubLineColor = System.Drawing.Color.LightGray;
            this.graphControl.FixRangeHorizontal = false;
            this.graphControl.FixRangeVertical = false;
            this.graphControl.GraphName = "";
            this.graphControl.HorizontalGradiationTextVisivle = true;
            this.graphControl.Interpolation = false;
            this.graphControl.IsIntegerX = false;
            this.graphControl.IsIntegerY = false;
            this.graphControl.LabelX = "X:";
            this.graphControl.LabelY = "Y:";
            this.graphControl.LeftMargin = 0F;
            this.graphControl.LineColor = System.Drawing.Color.Red;
            this.graphControl.LineWidth = 1F;
            this.graphControl.LowerX = 0D;
            this.graphControl.LowerY = 0D;
            this.graphControl.MaximalX = 1D;
            this.graphControl.MaximalY = 1D;
            this.graphControl.MinimalX = 0D;
            this.graphControl.MinimalY = 0D;
            this.graphControl.Mode = Crystallography.Controls.GraphControl.DrawingMode.Line;
            this.graphControl.MousePositionVisible = false;
            this.graphControl.Name = "graphControl";
            this.graphControl.OriginPosition = new System.Drawing.Point(20, 20);
            this.graphControl.Smoothing = false;
            this.graphControl.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip.SetToolTip(this.graphControl, resources.GetString("graphControl.ToolTip"));
            this.graphControl.UnitX = "";
            this.graphControl.UnitY = "";
            this.graphControl.UpperText = "";
            this.graphControl.UpperTextVisible = false;
            this.graphControl.UpperX = 1D;
            this.graphControl.UpperY = 1D;
            this.graphControl.UseLineWidth = true;
            this.graphControl.VerticalGradiationTextVisivle = true;
            this.graphControl.XLog = false;
            this.graphControl.XScaleLineVisible = true;
            this.graphControl.YLog = false;
            this.graphControl.YScaleLineVisible = true;
            // 
            // panelGraphOption
            // 
            resources.ApplyResources(this.panelGraphOption, "panelGraphOption");
            this.panelGraphOption.Controls.Add(this.buttonCopyGraph);
            this.panelGraphOption.Controls.Add(this.numericBoxMaxU1);
            this.panelGraphOption.Controls.Add(this.checkBoxGraphAll);
            this.panelGraphOption.Controls.Add(this.checkBoxGraphEc);
            this.panelGraphOption.Controls.Add(this.checkBoxGraphPCTF);
            this.panelGraphOption.Controls.Add(this.checkBoxGraphEs);
            this.panelGraphOption.Name = "panelGraphOption";
            this.toolTip.SetToolTip(this.panelGraphOption, resources.GetString("panelGraphOption.ToolTip"));
            // 
            // buttonCopyGraph
            // 
            resources.ApplyResources(this.buttonCopyGraph, "buttonCopyGraph");
            this.buttonCopyGraph.Name = "buttonCopyGraph";
            this.toolTip.SetToolTip(this.buttonCopyGraph, resources.GetString("buttonCopyGraph.ToolTip"));
            this.buttonCopyGraph.UseVisualStyleBackColor = true;
            this.buttonCopyGraph.Click += new System.EventHandler(this.ButtonCopyGraph_Click);
            // 
            // numericBoxMaxU1
            // 
            resources.ApplyResources(this.numericBoxMaxU1, "numericBoxMaxU1");
            this.numericBoxMaxU1.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxU1.DecimalPlaces = 1;
            this.numericBoxMaxU1.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxU1.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxU1.Maximum = 20D;
            this.numericBoxMaxU1.Minimum = 0D;
            this.numericBoxMaxU1.Name = "numericBoxMaxU1";
            this.numericBoxMaxU1.RadianValue = 0.10471975511965977D;
            this.numericBoxMaxU1.ShowUpDown = true;
            this.numericBoxMaxU1.SmartIncrement = true;
            this.numericBoxMaxU1.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.numericBoxMaxU1.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxMaxU1, resources.GetString("numericBoxMaxU1.ToolTip"));
            this.numericBoxMaxU1.Value = 6D;
            this.numericBoxMaxU1.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // checkBoxGraphAll
            // 
            resources.ApplyResources(this.checkBoxGraphAll, "checkBoxGraphAll");
            this.checkBoxGraphAll.Checked = true;
            this.checkBoxGraphAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraphAll.Name = "checkBoxGraphAll";
            this.toolTip.SetToolTip(this.checkBoxGraphAll, resources.GetString("checkBoxGraphAll.ToolTip"));
            this.checkBoxGraphAll.UseVisualStyleBackColor = true;
            this.checkBoxGraphAll.CheckedChanged += new System.EventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // checkBoxGraphEc
            // 
            resources.ApplyResources(this.checkBoxGraphEc, "checkBoxGraphEc");
            this.checkBoxGraphEc.Checked = true;
            this.checkBoxGraphEc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraphEc.Name = "checkBoxGraphEc";
            this.toolTip.SetToolTip(this.checkBoxGraphEc, resources.GetString("checkBoxGraphEc.ToolTip"));
            this.checkBoxGraphEc.UseVisualStyleBackColor = true;
            this.checkBoxGraphEc.CheckedChanged += new System.EventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // checkBoxGraphPCTF
            // 
            resources.ApplyResources(this.checkBoxGraphPCTF, "checkBoxGraphPCTF");
            this.checkBoxGraphPCTF.Checked = true;
            this.checkBoxGraphPCTF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraphPCTF.Name = "checkBoxGraphPCTF";
            this.toolTip.SetToolTip(this.checkBoxGraphPCTF, resources.GetString("checkBoxGraphPCTF.ToolTip"));
            this.checkBoxGraphPCTF.UseVisualStyleBackColor = true;
            this.checkBoxGraphPCTF.CheckedChanged += new System.EventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // checkBoxGraphEs
            // 
            resources.ApplyResources(this.checkBoxGraphEs, "checkBoxGraphEs");
            this.checkBoxGraphEs.Checked = true;
            this.checkBoxGraphEs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraphEs.Name = "checkBoxGraphEs";
            this.toolTip.SetToolTip(this.checkBoxGraphEs, resources.GetString("checkBoxGraphEs.ToolTip"));
            this.checkBoxGraphEs.UseVisualStyleBackColor = true;
            this.checkBoxGraphEs.CheckedChanged += new System.EventHandler(this.NumericBoxTEMproperty_ValueChanged);
            // 
            // buttonPanel
            // 
            resources.ApplyResources(this.buttonPanel, "buttonPanel");
            this.buttonPanel.Name = "buttonPanel";
            this.toolTip.SetToolTip(this.buttonPanel, resources.GetString("buttonPanel.ToolTip"));
            this.buttonPanel.UseVisualStyleBackColor = true;
            this.buttonPanel.Click += new System.EventHandler(this.ButtonPanel_Click);
            // 
            // groupBoxObjectAperture
            // 
            resources.ApplyResources(this.groupBoxObjectAperture, "groupBoxObjectAperture");
            this.groupBoxObjectAperture.Controls.Add(this.numericBoxObjAperX);
            this.groupBoxObjectAperture.Controls.Add(this.numericBoxObjAperRadius);
            this.groupBoxObjectAperture.Controls.Add(this.numericBoxObjAperY);
            this.groupBoxObjectAperture.Controls.Add(this.checkBoxOpenAperture);
            this.groupBoxObjectAperture.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxObjectAperture.Controls.Add(this.flowLayoutPanel5);
            this.groupBoxObjectAperture.Controls.Add(this.buttonDetailsOfSpots);
            this.groupBoxObjectAperture.Controls.Add(this.label8);
            this.groupBoxObjectAperture.Name = "groupBoxObjectAperture";
            this.groupBoxObjectAperture.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxObjectAperture, resources.GetString("groupBoxObjectAperture.ToolTip"));
            // 
            // numericBoxObjAperX
            // 
            resources.ApplyResources(this.numericBoxObjAperX, "numericBoxObjAperX");
            this.numericBoxObjAperX.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperX.DecimalPlaces = 1;
            this.numericBoxObjAperX.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperX.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperX.Maximum = 100D;
            this.numericBoxObjAperX.Minimum = -100D;
            this.numericBoxObjAperX.Name = "numericBoxObjAperX";
            this.numericBoxObjAperX.ShowUpDown = true;
            this.numericBoxObjAperX.SmartIncrement = true;
            this.numericBoxObjAperX.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxObjAperX, resources.GetString("numericBoxObjAperX.ToolTip"));
            this.numericBoxObjAperX.UpDown_Increment = 0.5D;
            this.numericBoxObjAperX.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxObjAperRadius_ValueChanged);
            // 
            // numericBoxObjAperRadius
            // 
            resources.ApplyResources(this.numericBoxObjAperRadius, "numericBoxObjAperRadius");
            this.numericBoxObjAperRadius.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperRadius.DecimalPlaces = 1;
            this.numericBoxObjAperRadius.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperRadius.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperRadius.Maximum = 500D;
            this.numericBoxObjAperRadius.Minimum = 0.5D;
            this.numericBoxObjAperRadius.Name = "numericBoxObjAperRadius";
            this.numericBoxObjAperRadius.RadianValue = 0.20943951023931953D;
            this.numericBoxObjAperRadius.ShowUpDown = true;
            this.numericBoxObjAperRadius.SmartIncrement = true;
            this.numericBoxObjAperRadius.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxObjAperRadius, resources.GetString("numericBoxObjAperRadius.ToolTip"));
            this.numericBoxObjAperRadius.UpDown_Increment = 0.5D;
            this.numericBoxObjAperRadius.Value = 12D;
            this.numericBoxObjAperRadius.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxObjAperRadius_ValueChanged);
            // 
            // numericBoxObjAperY
            // 
            resources.ApplyResources(this.numericBoxObjAperY, "numericBoxObjAperY");
            this.numericBoxObjAperY.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperY.DecimalPlaces = 1;
            this.numericBoxObjAperY.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperY.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxObjAperY.Maximum = 100D;
            this.numericBoxObjAperY.Minimum = -100D;
            this.numericBoxObjAperY.Name = "numericBoxObjAperY";
            this.numericBoxObjAperY.ShowUpDown = true;
            this.numericBoxObjAperY.SmartIncrement = true;
            this.numericBoxObjAperY.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxObjAperY, resources.GetString("numericBoxObjAperY.ToolTip"));
            this.numericBoxObjAperY.UpDown_Increment = 0.5D;
            this.numericBoxObjAperY.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxObjAperRadius_ValueChanged);
            // 
            // checkBoxOpenAperture
            // 
            resources.ApplyResources(this.checkBoxOpenAperture, "checkBoxOpenAperture");
            this.checkBoxOpenAperture.Name = "checkBoxOpenAperture";
            this.toolTip.SetToolTip(this.checkBoxOpenAperture, resources.GetString("checkBoxOpenAperture.ToolTip"));
            this.checkBoxOpenAperture.UseVisualStyleBackColor = true;
            this.checkBoxOpenAperture.CheckedChanged += new System.EventHandler(this.NumericBoxObjAperRadius_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.textBoxNumOfSpots);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // textBoxNumOfSpots
            // 
            resources.ApplyResources(this.textBoxNumOfSpots, "textBoxNumOfSpots");
            this.textBoxNumOfSpots.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNumOfSpots.Name = "textBoxNumOfSpots";
            this.textBoxNumOfSpots.ReadOnly = true;
            this.toolTip.SetToolTip(this.textBoxNumOfSpots, resources.GetString("textBoxNumOfSpots.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            this.toolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Controls.Add(this.textBoxApertureRadius);
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.toolTip.SetToolTip(this.flowLayoutPanel5, resources.GetString("flowLayoutPanel5.ToolTip"));
            // 
            // textBoxApertureRadius
            // 
            resources.ApplyResources(this.textBoxApertureRadius, "textBoxApertureRadius");
            this.textBoxApertureRadius.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxApertureRadius.Name = "textBoxApertureRadius";
            this.textBoxApertureRadius.ReadOnly = true;
            this.toolTip.SetToolTip(this.textBoxApertureRadius, resources.GetString("textBoxApertureRadius.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            this.toolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // buttonDetailsOfSpots
            // 
            resources.ApplyResources(this.buttonDetailsOfSpots, "buttonDetailsOfSpots");
            this.buttonDetailsOfSpots.Name = "buttonDetailsOfSpots";
            this.toolTip.SetToolTip(this.buttonDetailsOfSpots, resources.GetString("buttonDetailsOfSpots.ToolTip"));
            this.buttonDetailsOfSpots.UseVisualStyleBackColor = true;
            this.buttonDetailsOfSpots.Click += new System.EventHandler(this.ButtonDetailsOfSpots_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Name = "label8";
            this.toolTip.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.toolTip.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.panelDummy2);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBoxNormalizeIntensity);
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.numericBoxNumOfBlochWave);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox7, resources.GetString("groupBox7.ToolTip"));
            // 
            // numericBoxNumOfBlochWave
            // 
            resources.ApplyResources(this.numericBoxNumOfBlochWave, "numericBoxNumOfBlochWave");
            this.numericBoxNumOfBlochWave.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumOfBlochWave.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumOfBlochWave.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumOfBlochWave.Maximum = 1000D;
            this.numericBoxNumOfBlochWave.Minimum = 8D;
            this.numericBoxNumOfBlochWave.Name = "numericBoxNumOfBlochWave";
            this.numericBoxNumOfBlochWave.RadianValue = 8.7266462599716466D;
            this.numericBoxNumOfBlochWave.ShowUpDown = true;
            this.numericBoxNumOfBlochWave.SmartIncrement = true;
            this.numericBoxNumOfBlochWave.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxNumOfBlochWave, resources.GetString("numericBoxNumOfBlochWave.ToolTip"));
            this.numericBoxNumOfBlochWave.Value = 500D;
            this.numericBoxNumOfBlochWave.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxNumOfBlochWave_ValueChanged);
            // 
            // panelDummy2
            // 
            resources.ApplyResources(this.panelDummy2, "panelDummy2");
            this.panelDummy2.Name = "panelDummy2";
            this.toolTip.SetToolTip(this.panelDummy2, resources.GetString("panelDummy2.ToolTip"));
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.flowLayoutPanel9);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox8, resources.GetString("groupBox8.ToolTip"));
            // 
            // flowLayoutPanel9
            // 
            resources.ApplyResources(this.flowLayoutPanel9, "flowLayoutPanel9");
            this.flowLayoutPanel9.Controls.Add(this.numericBoxWidth);
            this.flowLayoutPanel9.Controls.Add(this.numericBoxHeight);
            this.flowLayoutPanel9.Controls.Add(this.label2);
            this.flowLayoutPanel9.Controls.Add(this.numericBoxResolution);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.toolTip.SetToolTip(this.flowLayoutPanel9, resources.GetString("flowLayoutPanel9.ToolTip"));
            // 
            // numericBoxWidth
            // 
            resources.ApplyResources(this.numericBoxWidth, "numericBoxWidth");
            this.numericBoxWidth.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxWidth.DecimalPlaces = 0;
            this.numericBoxWidth.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxWidth.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxWidth.Maximum = 2048D;
            this.numericBoxWidth.Minimum = 8D;
            this.numericBoxWidth.Name = "numericBoxWidth";
            this.numericBoxWidth.RadianValue = 8.9360857702109673D;
            this.numericBoxWidth.ShowUpDown = true;
            this.numericBoxWidth.SmartIncrement = true;
            this.numericBoxWidth.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxWidth, resources.GetString("numericBoxWidth.ToolTip"));
            this.numericBoxWidth.Value = 512D;
            // 
            // numericBoxHeight
            // 
            resources.ApplyResources(this.numericBoxHeight, "numericBoxHeight");
            this.numericBoxHeight.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxHeight.DecimalPlaces = 0;
            this.numericBoxHeight.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxHeight.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxHeight.Maximum = 2048D;
            this.numericBoxHeight.Minimum = 8D;
            this.numericBoxHeight.Name = "numericBoxHeight";
            this.numericBoxHeight.RadianValue = 8.9360857702109673D;
            this.numericBoxHeight.ShowUpDown = true;
            this.numericBoxHeight.SmartIncrement = true;
            this.numericBoxHeight.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxHeight, resources.GetString("numericBoxHeight.ToolTip"));
            this.numericBoxHeight.Value = 512D;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // numericBoxResolution
            // 
            resources.ApplyResources(this.numericBoxResolution, "numericBoxResolution");
            this.numericBoxResolution.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxResolution.DecimalPlaces = 2;
            this.numericBoxResolution.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxResolution.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxResolution.Maximum = 100D;
            this.numericBoxResolution.Minimum = 0.01D;
            this.numericBoxResolution.Name = "numericBoxResolution";
            this.numericBoxResolution.RadianValue = 0.069813170079773182D;
            this.numericBoxResolution.ShowUpDown = true;
            this.numericBoxResolution.SmartIncrement = true;
            this.numericBoxResolution.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxResolution, resources.GetString("numericBoxResolution.ToolTip"));
            this.numericBoxResolution.Value = 4D;
            // 
            // groupBoxNormalizeIntensity
            // 
            resources.ApplyResources(this.groupBoxNormalizeIntensity, "groupBoxNormalizeIntensity");
            this.groupBoxNormalizeIntensity.Controls.Add(this.flowLayoutPanel7);
            this.groupBoxNormalizeIntensity.Name = "groupBoxNormalizeIntensity";
            this.groupBoxNormalizeIntensity.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxNormalizeIntensity, resources.GetString("groupBoxNormalizeIntensity.ToolTip"));
            // 
            // flowLayoutPanel7
            // 
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.Controls.Add(this.checkBoxNormalizeHigh);
            this.flowLayoutPanel7.Controls.Add(this.checkBoxNormalizeLow);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.toolTip.SetToolTip(this.flowLayoutPanel7, resources.GetString("flowLayoutPanel7.ToolTip"));
            // 
            // checkBoxNormalizeHigh
            // 
            resources.ApplyResources(this.checkBoxNormalizeHigh, "checkBoxNormalizeHigh");
            this.checkBoxNormalizeHigh.Checked = true;
            this.checkBoxNormalizeHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNormalizeHigh.Name = "checkBoxNormalizeHigh";
            this.toolTip.SetToolTip(this.checkBoxNormalizeHigh, resources.GetString("checkBoxNormalizeHigh.ToolTip"));
            this.checkBoxNormalizeHigh.UseVisualStyleBackColor = true;
            this.checkBoxNormalizeHigh.CheckedChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // checkBoxNormalizeLow
            // 
            resources.ApplyResources(this.checkBoxNormalizeLow, "checkBoxNormalizeLow");
            this.checkBoxNormalizeLow.Checked = true;
            this.checkBoxNormalizeLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNormalizeLow.Name = "checkBoxNormalizeLow";
            this.toolTip.SetToolTip(this.checkBoxNormalizeLow, resources.GetString("checkBoxNormalizeLow.ToolTip"));
            this.checkBoxNormalizeLow.UseVisualStyleBackColor = true;
            this.checkBoxNormalizeLow.CheckedChanged += new System.EventHandler(this.CheckBoxShowLabel_CheckedChanged);
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.toolTip.SetToolTip(this.tabControl2, resources.GetString("tabControl2.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBoxPartialCoherencyModel);
            this.tabPage1.Name = "tabPage1";
            this.toolTip.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.radioButtonSingleMode);
            this.groupBox9.Controls.Add(this.radioButtonSerialMode);
            this.groupBox9.Controls.Add(this.panelSerial);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox9, resources.GetString("groupBox9.ToolTip"));
            // 
            // radioButtonSingleMode
            // 
            resources.ApplyResources(this.radioButtonSingleMode, "radioButtonSingleMode");
            this.radioButtonSingleMode.Checked = true;
            this.radioButtonSingleMode.Name = "radioButtonSingleMode";
            this.radioButtonSingleMode.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonSingleMode, resources.GetString("radioButtonSingleMode.ToolTip"));
            this.radioButtonSingleMode.UseVisualStyleBackColor = true;
            this.radioButtonSingleMode.CheckedChanged += new System.EventHandler(this.RadioButtonSingleMode_CheckedChanged);
            // 
            // radioButtonSerialMode
            // 
            resources.ApplyResources(this.radioButtonSerialMode, "radioButtonSerialMode");
            this.radioButtonSerialMode.Name = "radioButtonSerialMode";
            this.toolTip.SetToolTip(this.radioButtonSerialMode, resources.GetString("radioButtonSerialMode.ToolTip"));
            this.radioButtonSerialMode.UseVisualStyleBackColor = true;
            // 
            // panelSerial
            // 
            resources.ApplyResources(this.panelSerial, "panelSerial");
            this.panelSerial.Controls.Add(this.panelSerialDefocus);
            this.panelSerial.Controls.Add(this.flowLayoutPanelHorizontalDirection);
            this.panelSerial.Controls.Add(this.panelSerialThickness);
            this.panelSerial.Controls.Add(this.checkBoxSerialThickness);
            this.panelSerial.Controls.Add(this.checkBoxSerialDefocus);
            this.panelSerial.Name = "panelSerial";
            this.toolTip.SetToolTip(this.panelSerial, resources.GetString("panelSerial.ToolTip"));
            // 
            // panelSerialDefocus
            // 
            resources.ApplyResources(this.panelSerialDefocus, "panelSerialDefocus");
            this.panelSerialDefocus.Controls.Add(this.textBoxDefocusList);
            this.panelSerialDefocus.Controls.Add(this.numericBoxDefocusNum);
            this.panelSerialDefocus.Controls.Add(this.numericBoxDefocusStep);
            this.panelSerialDefocus.Controls.Add(this.numericBoxDefocusStart);
            this.panelSerialDefocus.Name = "panelSerialDefocus";
            this.toolTip.SetToolTip(this.panelSerialDefocus, resources.GetString("panelSerialDefocus.ToolTip"));
            // 
            // textBoxDefocusList
            // 
            resources.ApplyResources(this.textBoxDefocusList, "textBoxDefocusList");
            this.textBoxDefocusList.Name = "textBoxDefocusList";
            this.toolTip.SetToolTip(this.textBoxDefocusList, resources.GetString("textBoxDefocusList.ToolTip"));
            // 
            // numericBoxDefocusNum
            // 
            resources.ApplyResources(this.numericBoxDefocusNum, "numericBoxDefocusNum");
            this.numericBoxDefocusNum.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusNum.DecimalPlaces = 0;
            this.numericBoxDefocusNum.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusNum.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusNum.Maximum = 20D;
            this.numericBoxDefocusNum.Minimum = 1D;
            this.numericBoxDefocusNum.Name = "numericBoxDefocusNum";
            this.numericBoxDefocusNum.RadianValue = 0.069813170079773182D;
            this.numericBoxDefocusNum.ShowUpDown = true;
            this.numericBoxDefocusNum.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxDefocusNum, resources.GetString("numericBoxDefocusNum.ToolTip"));
            this.numericBoxDefocusNum.Value = 4D;
            this.numericBoxDefocusNum.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxDefocusSerial_ValueChanged);
            // 
            // numericBoxDefocusStep
            // 
            resources.ApplyResources(this.numericBoxDefocusStep, "numericBoxDefocusStep");
            this.numericBoxDefocusStep.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStep.DecimalPlaces = 2;
            this.numericBoxDefocusStep.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStep.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStep.Maximum = 100D;
            this.numericBoxDefocusStep.Minimum = -100D;
            this.numericBoxDefocusStep.Name = "numericBoxDefocusStep";
            this.numericBoxDefocusStep.RadianValue = -0.3490658503988659D;
            this.numericBoxDefocusStep.ShowUpDown = true;
            this.numericBoxDefocusStep.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxDefocusStep, resources.GetString("numericBoxDefocusStep.ToolTip"));
            this.numericBoxDefocusStep.UpDown_Increment = 10D;
            this.numericBoxDefocusStep.Value = -20D;
            this.numericBoxDefocusStep.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxDefocusSerial_ValueChanged);
            // 
            // numericBoxDefocusStart
            // 
            resources.ApplyResources(this.numericBoxDefocusStart, "numericBoxDefocusStart");
            this.numericBoxDefocusStart.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStart.DecimalPlaces = 2;
            this.numericBoxDefocusStart.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStart.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDefocusStart.Maximum = 1000D;
            this.numericBoxDefocusStart.Minimum = -1000D;
            this.numericBoxDefocusStart.Name = "numericBoxDefocusStart";
            this.numericBoxDefocusStart.RadianValue = -1.2217304763960306D;
            this.numericBoxDefocusStart.ShowUpDown = true;
            this.numericBoxDefocusStart.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxDefocusStart, resources.GetString("numericBoxDefocusStart.ToolTip"));
            this.numericBoxDefocusStart.UpDown_Increment = 10D;
            this.numericBoxDefocusStart.Value = -70D;
            this.numericBoxDefocusStart.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxDefocusSerial_ValueChanged);
            // 
            // flowLayoutPanelHorizontalDirection
            // 
            resources.ApplyResources(this.flowLayoutPanelHorizontalDirection, "flowLayoutPanelHorizontalDirection");
            this.flowLayoutPanelHorizontalDirection.Controls.Add(this.label6);
            this.flowLayoutPanelHorizontalDirection.Controls.Add(this.radioButtonHorizontalDefocus);
            this.flowLayoutPanelHorizontalDirection.Controls.Add(this.radioButtonHorizontalThickness);
            this.flowLayoutPanelHorizontalDirection.Name = "flowLayoutPanelHorizontalDirection";
            this.toolTip.SetToolTip(this.flowLayoutPanelHorizontalDirection, resources.GetString("flowLayoutPanelHorizontalDirection.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            this.toolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // radioButtonHorizontalDefocus
            // 
            resources.ApplyResources(this.radioButtonHorizontalDefocus, "radioButtonHorizontalDefocus");
            this.radioButtonHorizontalDefocus.Checked = true;
            this.radioButtonHorizontalDefocus.Name = "radioButtonHorizontalDefocus";
            this.radioButtonHorizontalDefocus.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonHorizontalDefocus, resources.GetString("radioButtonHorizontalDefocus.ToolTip"));
            this.radioButtonHorizontalDefocus.UseVisualStyleBackColor = true;
            // 
            // radioButtonHorizontalThickness
            // 
            resources.ApplyResources(this.radioButtonHorizontalThickness, "radioButtonHorizontalThickness");
            this.radioButtonHorizontalThickness.Name = "radioButtonHorizontalThickness";
            this.toolTip.SetToolTip(this.radioButtonHorizontalThickness, resources.GetString("radioButtonHorizontalThickness.ToolTip"));
            this.radioButtonHorizontalThickness.UseVisualStyleBackColor = true;
            // 
            // panelSerialThickness
            // 
            resources.ApplyResources(this.panelSerialThickness, "panelSerialThickness");
            this.panelSerialThickness.Controls.Add(this.numericBoxThicknessNum);
            this.panelSerialThickness.Controls.Add(this.numericBoxThicknessStep);
            this.panelSerialThickness.Controls.Add(this.textBoxThicknessList);
            this.panelSerialThickness.Controls.Add(this.numericBoxThicknessStart);
            this.panelSerialThickness.Name = "panelSerialThickness";
            this.toolTip.SetToolTip(this.panelSerialThickness, resources.GetString("panelSerialThickness.ToolTip"));
            // 
            // numericBoxThicknessNum
            // 
            resources.ApplyResources(this.numericBoxThicknessNum, "numericBoxThicknessNum");
            this.numericBoxThicknessNum.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessNum.DecimalPlaces = 0;
            this.numericBoxThicknessNum.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessNum.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessNum.Maximum = 20D;
            this.numericBoxThicknessNum.Minimum = 0.1D;
            this.numericBoxThicknessNum.Name = "numericBoxThicknessNum";
            this.numericBoxThicknessNum.RadianValue = 0.069813170079773182D;
            this.numericBoxThicknessNum.ShowUpDown = true;
            this.numericBoxThicknessNum.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxThicknessNum, resources.GetString("numericBoxThicknessNum.ToolTip"));
            this.numericBoxThicknessNum.Value = 4D;
            this.numericBoxThicknessNum.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxThicknessSerial_ValueChanged);
            // 
            // numericBoxThicknessStep
            // 
            resources.ApplyResources(this.numericBoxThicknessStep, "numericBoxThicknessStep");
            this.numericBoxThicknessStep.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStep.DecimalPlaces = 2;
            this.numericBoxThicknessStep.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStep.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStep.Maximum = 1000D;
            this.numericBoxThicknessStep.Minimum = 1D;
            this.numericBoxThicknessStep.Name = "numericBoxThicknessStep";
            this.numericBoxThicknessStep.RadianValue = 0.3490658503988659D;
            this.numericBoxThicknessStep.ShowUpDown = true;
            this.numericBoxThicknessStep.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxThicknessStep, resources.GetString("numericBoxThicknessStep.ToolTip"));
            this.numericBoxThicknessStep.UpDown_Increment = 10D;
            this.numericBoxThicknessStep.Value = 20D;
            this.numericBoxThicknessStep.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxThicknessSerial_ValueChanged);
            // 
            // textBoxThicknessList
            // 
            resources.ApplyResources(this.textBoxThicknessList, "textBoxThicknessList");
            this.textBoxThicknessList.Name = "textBoxThicknessList";
            this.toolTip.SetToolTip(this.textBoxThicknessList, resources.GetString("textBoxThicknessList.ToolTip"));
            // 
            // numericBoxThicknessStart
            // 
            resources.ApplyResources(this.numericBoxThicknessStart, "numericBoxThicknessStart");
            this.numericBoxThicknessStart.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStart.DecimalPlaces = 2;
            this.numericBoxThicknessStart.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStart.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxThicknessStart.Maximum = 1000D;
            this.numericBoxThicknessStart.Minimum = 0.1D;
            this.numericBoxThicknessStart.Name = "numericBoxThicknessStart";
            this.numericBoxThicknessStart.RadianValue = 0.3490658503988659D;
            this.numericBoxThicknessStart.ShowUpDown = true;
            this.numericBoxThicknessStart.ThonsandsSeparator = true;
            this.toolTip.SetToolTip(this.numericBoxThicknessStart, resources.GetString("numericBoxThicknessStart.ToolTip"));
            this.numericBoxThicknessStart.UpDown_Increment = 10D;
            this.numericBoxThicknessStart.Value = 20D;
            this.numericBoxThicknessStart.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.NumericBoxThicknessSerial_ValueChanged);
            // 
            // checkBoxSerialThickness
            // 
            resources.ApplyResources(this.checkBoxSerialThickness, "checkBoxSerialThickness");
            this.checkBoxSerialThickness.Checked = true;
            this.checkBoxSerialThickness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialThickness.Name = "checkBoxSerialThickness";
            this.toolTip.SetToolTip(this.checkBoxSerialThickness, resources.GetString("checkBoxSerialThickness.ToolTip"));
            this.checkBoxSerialThickness.UseVisualStyleBackColor = true;
            this.checkBoxSerialThickness.CheckedChanged += new System.EventHandler(this.CheckBoxSerialDefocus_CheckedChanged);
            // 
            // checkBoxSerialDefocus
            // 
            resources.ApplyResources(this.checkBoxSerialDefocus, "checkBoxSerialDefocus");
            this.checkBoxSerialDefocus.Checked = true;
            this.checkBoxSerialDefocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialDefocus.Name = "checkBoxSerialDefocus";
            this.toolTip.SetToolTip(this.checkBoxSerialDefocus, resources.GetString("checkBoxSerialDefocus.ToolTip"));
            this.checkBoxSerialDefocus.UseVisualStyleBackColor = true;
            this.checkBoxSerialDefocus.CheckedChanged += new System.EventHandler(this.CheckBoxSerialDefocus_CheckedChanged);
            // 
            // groupBoxPartialCoherencyModel
            // 
            resources.ApplyResources(this.groupBoxPartialCoherencyModel, "groupBoxPartialCoherencyModel");
            this.groupBoxPartialCoherencyModel.Controls.Add(this.flowLayoutPanel8);
            this.groupBoxPartialCoherencyModel.Name = "groupBoxPartialCoherencyModel";
            this.groupBoxPartialCoherencyModel.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxPartialCoherencyModel, resources.GetString("groupBoxPartialCoherencyModel.ToolTip"));
            // 
            // flowLayoutPanel8
            // 
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.Controls.Add(this.radioButtonModeQuasiCoherent);
            this.flowLayoutPanel8.Controls.Add(this.radioButtonModeTransmissionCrossCoefficient);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.toolTip.SetToolTip(this.flowLayoutPanel8, resources.GetString("flowLayoutPanel8.ToolTip"));
            // 
            // radioButtonModeQuasiCoherent
            // 
            resources.ApplyResources(this.radioButtonModeQuasiCoherent, "radioButtonModeQuasiCoherent");
            this.radioButtonModeQuasiCoherent.Checked = true;
            this.radioButtonModeQuasiCoherent.Name = "radioButtonModeQuasiCoherent";
            this.radioButtonModeQuasiCoherent.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonModeQuasiCoherent, resources.GetString("radioButtonModeQuasiCoherent.ToolTip"));
            this.radioButtonModeQuasiCoherent.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeTransmissionCrossCoefficient
            // 
            resources.ApplyResources(this.radioButtonModeTransmissionCrossCoefficient, "radioButtonModeTransmissionCrossCoefficient");
            this.radioButtonModeTransmissionCrossCoefficient.Name = "radioButtonModeTransmissionCrossCoefficient";
            this.toolTip.SetToolTip(this.radioButtonModeTransmissionCrossCoefficient, resources.GetString("radioButtonModeTransmissionCrossCoefficient.ToolTip"));
            this.radioButtonModeTransmissionCrossCoefficient.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Name = "tabPage2";
            this.toolTip.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.flowLayoutPanel11);
            this.groupBox3.Controls.Add(this.checkBoxPotentialUgPrime);
            this.groupBox3.Controls.Add(this.checkBoxPotentialUg);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // flowLayoutPanel11
            // 
            resources.ApplyResources(this.flowLayoutPanel11, "flowLayoutPanel11");
            this.flowLayoutPanel11.Controls.Add(this.radioButtonPotentialModeMagAndPhase);
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanelMagAndPhase);
            this.flowLayoutPanel11.Controls.Add(this.panelPhaseScale);
            this.flowLayoutPanel11.Controls.Add(this.radioButtonPotentialModeRealAndImag);
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanelRealAndImaiginary);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.toolTip.SetToolTip(this.flowLayoutPanel11, resources.GetString("flowLayoutPanel11.ToolTip"));
            // 
            // radioButtonPotentialModeMagAndPhase
            // 
            resources.ApplyResources(this.radioButtonPotentialModeMagAndPhase, "radioButtonPotentialModeMagAndPhase");
            this.radioButtonPotentialModeMagAndPhase.Checked = true;
            this.radioButtonPotentialModeMagAndPhase.Name = "radioButtonPotentialModeMagAndPhase";
            this.radioButtonPotentialModeMagAndPhase.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonPotentialModeMagAndPhase, resources.GetString("radioButtonPotentialModeMagAndPhase.ToolTip"));
            this.radioButtonPotentialModeMagAndPhase.UseVisualStyleBackColor = true;
            this.radioButtonPotentialModeMagAndPhase.CheckedChanged += new System.EventHandler(this.RadioButtonPotentialAsMagnitudeAndPhase_CheckedChanged);
            // 
            // flowLayoutPanelMagAndPhase
            // 
            resources.ApplyResources(this.flowLayoutPanelMagAndPhase, "flowLayoutPanelMagAndPhase");
            this.flowLayoutPanelMagAndPhase.Controls.Add(this.radioButtonPotentialShowMagAndPhase);
            this.flowLayoutPanelMagAndPhase.Controls.Add(this.radioButtonPotentialShowMag);
            this.flowLayoutPanelMagAndPhase.Controls.Add(this.radioButtonPotentialShowPhase);
            this.flowLayoutPanelMagAndPhase.Name = "flowLayoutPanelMagAndPhase";
            this.toolTip.SetToolTip(this.flowLayoutPanelMagAndPhase, resources.GetString("flowLayoutPanelMagAndPhase.ToolTip"));
            // 
            // radioButtonPotentialShowMagAndPhase
            // 
            resources.ApplyResources(this.radioButtonPotentialShowMagAndPhase, "radioButtonPotentialShowMagAndPhase");
            this.radioButtonPotentialShowMagAndPhase.Checked = true;
            this.radioButtonPotentialShowMagAndPhase.Name = "radioButtonPotentialShowMagAndPhase";
            this.radioButtonPotentialShowMagAndPhase.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonPotentialShowMagAndPhase, resources.GetString("radioButtonPotentialShowMagAndPhase.ToolTip"));
            this.radioButtonPotentialShowMagAndPhase.UseVisualStyleBackColor = true;
            // 
            // radioButtonPotentialShowMag
            // 
            resources.ApplyResources(this.radioButtonPotentialShowMag, "radioButtonPotentialShowMag");
            this.radioButtonPotentialShowMag.Name = "radioButtonPotentialShowMag";
            this.toolTip.SetToolTip(this.radioButtonPotentialShowMag, resources.GetString("radioButtonPotentialShowMag.ToolTip"));
            this.radioButtonPotentialShowMag.UseVisualStyleBackColor = true;
            // 
            // radioButtonPotentialShowPhase
            // 
            resources.ApplyResources(this.radioButtonPotentialShowPhase, "radioButtonPotentialShowPhase");
            this.radioButtonPotentialShowPhase.Name = "radioButtonPotentialShowPhase";
            this.toolTip.SetToolTip(this.radioButtonPotentialShowPhase, resources.GetString("radioButtonPotentialShowPhase.ToolTip"));
            this.radioButtonPotentialShowPhase.UseVisualStyleBackColor = true;
            // 
            // panelPhaseScale
            // 
            resources.ApplyResources(this.panelPhaseScale, "panelPhaseScale");
            this.panelPhaseScale.Controls.Add(this.label24);
            this.panelPhaseScale.Controls.Add(this.label23);
            this.panelPhaseScale.Controls.Add(this.label22);
            this.panelPhaseScale.Controls.Add(this.label21);
            this.panelPhaseScale.Controls.Add(this.label20);
            this.panelPhaseScale.Controls.Add(this.label19);
            this.panelPhaseScale.Controls.Add(this.label18);
            this.panelPhaseScale.Controls.Add(this.pictureBoxPhaseScale);
            this.panelPhaseScale.Controls.Add(this.label17);
            this.panelPhaseScale.Controls.Add(this.label16);
            this.panelPhaseScale.Controls.Add(this.label15);
            this.panelPhaseScale.Controls.Add(this.label14);
            this.panelPhaseScale.Controls.Add(this.label11);
            this.panelPhaseScale.Controls.Add(this.label12);
            this.panelPhaseScale.Controls.Add(this.label13);
            this.panelPhaseScale.Controls.Add(this.label10);
            this.panelPhaseScale.Name = "panelPhaseScale";
            this.toolTip.SetToolTip(this.panelPhaseScale, resources.GetString("panelPhaseScale.ToolTip"));
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.toolTip.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            this.toolTip.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.toolTip.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.toolTip.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.toolTip.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.toolTip.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            // 
            // pictureBoxPhaseScale
            // 
            resources.ApplyResources(this.pictureBoxPhaseScale, "pictureBoxPhaseScale");
            this.pictureBoxPhaseScale.Name = "pictureBoxPhaseScale";
            this.pictureBoxPhaseScale.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxPhaseScale, resources.GetString("pictureBoxPhaseScale.ToolTip"));
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.toolTip.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.toolTip.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // radioButtonPotentialModeRealAndImag
            // 
            resources.ApplyResources(this.radioButtonPotentialModeRealAndImag, "radioButtonPotentialModeRealAndImag");
            this.radioButtonPotentialModeRealAndImag.Name = "radioButtonPotentialModeRealAndImag";
            this.toolTip.SetToolTip(this.radioButtonPotentialModeRealAndImag, resources.GetString("radioButtonPotentialModeRealAndImag.ToolTip"));
            this.radioButtonPotentialModeRealAndImag.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelRealAndImaiginary
            // 
            resources.ApplyResources(this.flowLayoutPanelRealAndImaiginary, "flowLayoutPanelRealAndImaiginary");
            this.flowLayoutPanelRealAndImaiginary.Controls.Add(this.radioButtonPotentialShowRealAndImag);
            this.flowLayoutPanelRealAndImaiginary.Controls.Add(this.radioButtonPotentialShowReal);
            this.flowLayoutPanelRealAndImaiginary.Controls.Add(this.radioButtonPotentialShowImag);
            this.flowLayoutPanelRealAndImaiginary.Name = "flowLayoutPanelRealAndImaiginary";
            this.toolTip.SetToolTip(this.flowLayoutPanelRealAndImaiginary, resources.GetString("flowLayoutPanelRealAndImaiginary.ToolTip"));
            // 
            // radioButtonPotentialShowRealAndImag
            // 
            resources.ApplyResources(this.radioButtonPotentialShowRealAndImag, "radioButtonPotentialShowRealAndImag");
            this.radioButtonPotentialShowRealAndImag.Checked = true;
            this.radioButtonPotentialShowRealAndImag.Name = "radioButtonPotentialShowRealAndImag";
            this.radioButtonPotentialShowRealAndImag.TabStop = true;
            this.toolTip.SetToolTip(this.radioButtonPotentialShowRealAndImag, resources.GetString("radioButtonPotentialShowRealAndImag.ToolTip"));
            this.radioButtonPotentialShowRealAndImag.UseVisualStyleBackColor = true;
            // 
            // radioButtonPotentialShowReal
            // 
            resources.ApplyResources(this.radioButtonPotentialShowReal, "radioButtonPotentialShowReal");
            this.radioButtonPotentialShowReal.Name = "radioButtonPotentialShowReal";
            this.toolTip.SetToolTip(this.radioButtonPotentialShowReal, resources.GetString("radioButtonPotentialShowReal.ToolTip"));
            this.radioButtonPotentialShowReal.UseVisualStyleBackColor = true;
            // 
            // radioButtonPotentialShowImag
            // 
            resources.ApplyResources(this.radioButtonPotentialShowImag, "radioButtonPotentialShowImag");
            this.radioButtonPotentialShowImag.Name = "radioButtonPotentialShowImag";
            this.toolTip.SetToolTip(this.radioButtonPotentialShowImag, resources.GetString("radioButtonPotentialShowImag.ToolTip"));
            this.radioButtonPotentialShowImag.UseVisualStyleBackColor = true;
            // 
            // checkBoxPotentialUgPrime
            // 
            resources.ApplyResources(this.checkBoxPotentialUgPrime, "checkBoxPotentialUgPrime");
            this.checkBoxPotentialUgPrime.Checked = true;
            this.checkBoxPotentialUgPrime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPotentialUgPrime.Name = "checkBoxPotentialUgPrime";
            this.toolTip.SetToolTip(this.checkBoxPotentialUgPrime, resources.GetString("checkBoxPotentialUgPrime.ToolTip"));
            this.checkBoxPotentialUgPrime.UseVisualStyleBackColor = true;
            // 
            // checkBoxPotentialUg
            // 
            resources.ApplyResources(this.checkBoxPotentialUg, "checkBoxPotentialUg");
            this.checkBoxPotentialUg.Checked = true;
            this.checkBoxPotentialUg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPotentialUg.Name = "checkBoxPotentialUg";
            this.toolTip.SetToolTip(this.checkBoxPotentialUg, resources.GetString("checkBoxPotentialUg.ToolTip"));
            this.checkBoxPotentialUg.UseVisualStyleBackColor = true;
            // 
            // buttonSimulateHRTEM
            // 
            resources.ApplyResources(this.buttonSimulateHRTEM, "buttonSimulateHRTEM");
            this.buttonSimulateHRTEM.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSimulateHRTEM.ForeColor = System.Drawing.Color.White;
            this.buttonSimulateHRTEM.Name = "buttonSimulateHRTEM";
            this.toolTip.SetToolTip(this.buttonSimulateHRTEM, resources.GetString("buttonSimulateHRTEM.ToolTip"));
            this.buttonSimulateHRTEM.UseVisualStyleBackColor = false;
            this.buttonSimulateHRTEM.Click += new System.EventHandler(this.ButtonSimulate_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.copyImageToolStripMenuItem,
            this.toolStripMenuItemOverprintSymbols,
            this.toolStripSeparator1,
            this.readTEMParameterToolStripMenuItem,
            this.saveTEMParametersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // toolStripMenuItemSave
            // 
            resources.ApplyResources(this.toolStripMenuItemSave, "toolStripMenuItemSave");
            this.toolStripMenuItemSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSavePNG,
            this.toolStripMenuItemSaveTIFF,
            this.toolStripMenuItemSaveMetafile,
            this.toolStripMenuItemSaveIndividually});
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            // 
            // toolStripMenuItemSavePNG
            // 
            resources.ApplyResources(this.toolStripMenuItemSavePNG, "toolStripMenuItemSavePNG");
            this.toolStripMenuItemSavePNG.Name = "toolStripMenuItemSavePNG";
            this.toolStripMenuItemSavePNG.Click += new System.EventHandler(this.ToolStripMenuItemSavePNG_Click);
            // 
            // toolStripMenuItemSaveTIFF
            // 
            resources.ApplyResources(this.toolStripMenuItemSaveTIFF, "toolStripMenuItemSaveTIFF");
            this.toolStripMenuItemSaveTIFF.Name = "toolStripMenuItemSaveTIFF";
            this.toolStripMenuItemSaveTIFF.Click += new System.EventHandler(this.ToolStripMenuItemSaveTIFF_Click);
            // 
            // toolStripMenuItemSaveMetafile
            // 
            resources.ApplyResources(this.toolStripMenuItemSaveMetafile, "toolStripMenuItemSaveMetafile");
            this.toolStripMenuItemSaveMetafile.Name = "toolStripMenuItemSaveMetafile";
            this.toolStripMenuItemSaveMetafile.Click += new System.EventHandler(this.ToolStripMenuItemSaveMetafile_Click);
            // 
            // toolStripMenuItemSaveIndividually
            // 
            resources.ApplyResources(this.toolStripMenuItemSaveIndividually, "toolStripMenuItemSaveIndividually");
            this.toolStripMenuItemSaveIndividually.Checked = true;
            this.toolStripMenuItemSaveIndividually.CheckOnClick = true;
            this.toolStripMenuItemSaveIndividually.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSaveIndividually.Name = "toolStripMenuItemSaveIndividually";
            // 
            // copyImageToolStripMenuItem
            // 
            resources.ApplyResources(this.copyImageToolStripMenuItem, "copyImageToolStripMenuItem");
            this.copyImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyImage,
            this.toolStripMenuItemCopyMetafile});
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            // 
            // toolStripMenuItemCopyImage
            // 
            resources.ApplyResources(this.toolStripMenuItemCopyImage, "toolStripMenuItemCopyImage");
            this.toolStripMenuItemCopyImage.Name = "toolStripMenuItemCopyImage";
            this.toolStripMenuItemCopyImage.Click += new System.EventHandler(this.ToolStripMenuItemCopyImage_Click);
            // 
            // toolStripMenuItemCopyMetafile
            // 
            resources.ApplyResources(this.toolStripMenuItemCopyMetafile, "toolStripMenuItemCopyMetafile");
            this.toolStripMenuItemCopyMetafile.Name = "toolStripMenuItemCopyMetafile";
            this.toolStripMenuItemCopyMetafile.Click += new System.EventHandler(this.ToolStripMenuItemCopyMetafile_Click);
            // 
            // toolStripMenuItemOverprintSymbols
            // 
            resources.ApplyResources(this.toolStripMenuItemOverprintSymbols, "toolStripMenuItemOverprintSymbols");
            this.toolStripMenuItemOverprintSymbols.Checked = true;
            this.toolStripMenuItemOverprintSymbols.CheckOnClick = true;
            this.toolStripMenuItemOverprintSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemOverprintSymbols.Name = "toolStripMenuItemOverprintSymbols";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // readTEMParameterToolStripMenuItem
            // 
            resources.ApplyResources(this.readTEMParameterToolStripMenuItem, "readTEMParameterToolStripMenuItem");
            this.readTEMParameterToolStripMenuItem.Name = "readTEMParameterToolStripMenuItem";
            // 
            // saveTEMParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.saveTEMParametersToolStripMenuItem, "saveTEMParametersToolStripMenuItem");
            this.saveTEMParametersToolStripMenuItem.Name = "saveTEMParametersToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsOfHRTEMSimulationToolStripMenuItem,
            this.toolStripSeparator2,
            this.calculationLibraryToolStripMenuItem,
            this.toolStripComboBoxCaclulationLibrary});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // detailsOfHRTEMSimulationToolStripMenuItem
            // 
            resources.ApplyResources(this.detailsOfHRTEMSimulationToolStripMenuItem, "detailsOfHRTEMSimulationToolStripMenuItem");
            this.detailsOfHRTEMSimulationToolStripMenuItem.Name = "detailsOfHRTEMSimulationToolStripMenuItem";
            this.detailsOfHRTEMSimulationToolStripMenuItem.Click += new System.EventHandler(this.DetailsOfHRTEMSimulationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // calculationLibraryToolStripMenuItem
            // 
            resources.ApplyResources(this.calculationLibraryToolStripMenuItem, "calculationLibraryToolStripMenuItem");
            this.calculationLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculationLibraryToolStripMenuItem.Name = "calculationLibraryToolStripMenuItem";
            // 
            // toolStripComboBoxCaclulationLibrary
            // 
            resources.ApplyResources(this.toolStripComboBoxCaclulationLibrary, "toolStripComboBoxCaclulationLibrary");
            this.toolStripComboBoxCaclulationLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCaclulationLibrary.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBoxCaclulationLibrary.Items"),
            resources.GetString("toolStripComboBoxCaclulationLibrary.Items1")});
            this.toolStripComboBoxCaclulationLibrary.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.toolStripComboBoxCaclulationLibrary.Name = "toolStripComboBoxCaclulationLibrary";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // toolStripProgressBar1
            // 
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            // 
            // FormImageSimulator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormImageSimulator";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImageSimulator_FormClosing);
            this.Load += new System.EventHandler(this.FormImageSimulator_Load);
            this.VisibleChanged += new System.EventHandler(this.FormImageSimulator_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImageSimulator_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScaleOfIntensity)).EndInit();
            this.flowLayoutPanelGaussianBlur2.ResumeLayout(false);
            this.flowLayoutPanelGaussianBlur2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.flowLayoutPanelLabel.ResumeLayout(false);
            this.flowLayoutPanelLabel.PerformLayout();
            this.flowLayoutPanelScale.ResumeLayout(false);
            this.flowLayoutPanelScale.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxSampleProperty.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBoxInherentProperty.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxLenzFunction.ResumeLayout(false);
            this.panelGraphOption.ResumeLayout(false);
            this.panelGraphOption.PerformLayout();
            this.groupBoxObjectAperture.ResumeLayout(false);
            this.groupBoxObjectAperture.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.groupBoxNormalizeIntensity.ResumeLayout(false);
            this.groupBoxNormalizeIntensity.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panelSerial.ResumeLayout(false);
            this.panelSerial.PerformLayout();
            this.panelSerialDefocus.ResumeLayout(false);
            this.panelSerialDefocus.PerformLayout();
            this.flowLayoutPanelHorizontalDirection.ResumeLayout(false);
            this.flowLayoutPanelHorizontalDirection.PerformLayout();
            this.panelSerialThickness.ResumeLayout(false);
            this.panelSerialThickness.PerformLayout();
            this.groupBoxPartialCoherencyModel.ResumeLayout(false);
            this.groupBoxPartialCoherencyModel.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanelMagAndPhase.ResumeLayout(false);
            this.flowLayoutPanelMagAndPhase.PerformLayout();
            this.panelPhaseScale.ResumeLayout(false);
            this.panelPhaseScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhaseScale)).EndInit();
            this.flowLayoutPanelRealAndImaiginary.ResumeLayout(false);
            this.flowLayoutPanelRealAndImaiginary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonHRTEM;
        private Crystallography.Controls.NumericBox numericBoxNumOfBlochWave;
        private Crystallography.Controls.NumericBox numericBoxObjAperRadius;
        private Crystallography.Controls.NumericBox numericBoxThickness;
        private System.Windows.Forms.RadioButton radioButtonSTEM;
        private System.Windows.Forms.Button buttonSimulateHRTEM;
        private Crystallography.Controls.NumericBox numericBoxAccVol;
        private Crystallography.Controls.NumericBox numericBoxWidth;
        private Crystallography.Controls.NumericBox numericBoxHeight;
        private Crystallography.Controls.NumericBox numericBoxResolution;
        private Crystallography.Controls.NumericBox numericBoxDefocus;
        private Crystallography.Controls.NumericBox numericBoxCs;
        private Crystallography.Controls.NumericBox numericBoxBetaAgnle;
        private Crystallography.Controls.NumericBox numericBoxDeltaV;
        private Crystallography.Controls.NumericBox numericBoxCc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxSampleProperty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSingleMode;
        private System.Windows.Forms.RadioButton radioButtonSerialMode;
        private Crystallography.Controls.NumericBox numericBoxDefocusStart;
        private Crystallography.Controls.NumericBox numericBoxDefocusStep;
        private Crystallography.Controls.NumericBox numericBoxDefocusNum;
        private System.Windows.Forms.TextBox textBoxDefocusList;
        private Crystallography.Controls.NumericBox numericBoxThicknessStart;
        private Crystallography.Controls.NumericBox numericBoxThicknessNum;
        private Crystallography.Controls.NumericBox numericBoxThicknessStep;
        private System.Windows.Forms.CheckBox checkBoxSerialDefocus;
        private System.Windows.Forms.CheckBox checkBoxSerialThickness;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBoxPartialCoherencyModel;
        private System.Windows.Forms.RadioButton radioButtonModeTransmissionCrossCoefficient;
        private System.Windows.Forms.RadioButton radioButtonModeQuasiCoherent;
        private System.Windows.Forms.CheckBox checkBoxShowLabel;
        private Crystallography.Controls.GraphControl graphControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Crystallography.Controls.NumericBox numericBoxObjAperY;
        private Crystallography.Controls.NumericBox numericBoxObjAperX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScherzer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRambda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCopyGraph;
        private Crystallography.Controls.NumericBox numericBoxMaxU1;
        private System.Windows.Forms.GroupBox groupBoxInherentProperty;
        private System.Windows.Forms.GroupBox groupBoxObjectAperture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxApertureRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxShowUnitcell;
        private System.Windows.Forms.RadioButton radioButtonHorizontalThickness;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHorizontalDirection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonHorizontalDefocus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.CheckBox checkBoxShowScale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelScale;
        private Crystallography.Controls.NumericBox numericBoxScaleLength;
        private System.Windows.Forms.TextBox textBoxThicknessList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLabel;
        private Crystallography.Controls.NumericBox numericBoxLabelFontSize;
        private Crystallography.Controls.ColorControl colorControlLabel;
        private Crystallography.Controls.ColorControl colorControlScale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSavePNG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveTIFF;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveMetafile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveIndividually;
        private System.Windows.Forms.ToolStripMenuItem copyImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyMetafile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOverprintSymbols;
        private System.Windows.Forms.CheckBox checkBoxNormalizeLow;
        private System.Windows.Forms.CheckBox checkBoxNormalizeHigh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem readTEMParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTEMParametersToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxGraphAll;
        private System.Windows.Forms.CheckBox checkBoxGraphEc;
        private System.Windows.Forms.CheckBox checkBoxGraphEs;
        private System.Windows.Forms.CheckBox checkBoxGraphPCTF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNumOfSpots;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDetailsOfSpots;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsOfHRTEMSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem calculationLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCaclulationLibrary;
        private System.Windows.Forms.CheckBox checkBoxOpenAperture;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxLenzFunction;
        private System.Windows.Forms.RadioButton radioButtonProjectedPotential;
        private System.Windows.Forms.GroupBox groupBoxNormalizeIntensity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.Panel panelSerialDefocus;
        private System.Windows.Forms.Panel panelSerialThickness;
        private System.Windows.Forms.Panel panelDummy2;
        private System.Windows.Forms.CheckBox checkBoxPotentialUg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxPotentialUgPrime;
        private System.Windows.Forms.RadioButton radioButtonPotentialModeRealAndImag;
        private System.Windows.Forms.RadioButton radioButtonPotentialModeMagAndPhase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelGraphOption;
        private System.Windows.Forms.Button buttonPanel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panelDummy1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxPhaseScale;
        private System.Windows.Forms.Panel panelPhaseScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private Crystallography.Controls.TrackBarAdvanced trackBarAdvancedMax;
        private Crystallography.Controls.TrackBarAdvanced trackBarAdvancedMin;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.ComboBox comboBoxScaleColorScale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGaussianBlur2;
        private System.Windows.Forms.CheckBox checkBoxGaussianBlur;
        private Crystallography.Controls.NumericBox numericBoxGaussianRadius;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMagAndPhase;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowMagAndPhase;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowMag;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowPhase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRealAndImaiginary;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowRealAndImag;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowReal;
        private System.Windows.Forms.RadioButton radioButtonPotentialShowImag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBoxScaleOfIntensity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label labelMousePositionValue;
        private System.Windows.Forms.Label labelMousePositionY;
        private System.Windows.Forms.Label labelMousePositionX;
        private System.Windows.Forms.CheckBox checkBoxRealTimeCalculation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}