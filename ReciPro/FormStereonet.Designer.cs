﻿using System;

namespace ReciPro
{
    partial class FormStereonet
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
            if (strFont != null)
                strFont.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStereonet));
            this.trackBarStrSize = new System.Windows.Forms.TrackBar();
            this.trackBarPointSize = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonWulff = new System.Windows.Forms.RadioButton();
            this.radioButtonSchmidt = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonAxes = new System.Windows.Forms.RadioButton();
            this.radioButtonPlanes = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelYpos = new System.Windows.Forms.Label();
            this.labelXpos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1DegLine = new System.Windows.Forms.CheckBox();
            this.radioButtonOutlinePole = new System.Windows.Forms.RadioButton();
            this.radioButtonOutlineEquator = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorControlSmallCircle = new Crystallography.Controls.ColorControl();
            this.colorControlGreatCircle = new Crystallography.Controls.ColorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.colorControlString = new Crystallography.Controls.ColorControl();
            this.colorControlUniqueAxis = new Crystallography.Controls.ColorControl();
            this.colorControlUniquePlane = new Crystallography.Controls.ColorControl();
            this.labelUniqueAxis = new System.Windows.Forms.Label();
            this.colorControlGeneralAxis = new Crystallography.Controls.ColorControl();
            this.labelGeneralAxis = new System.Windows.Forms.Label();
            this.labelUniquePlane = new System.Windows.Forms.Label();
            this.labelGeneralPlane = new System.Windows.Forms.Label();
            this.colorControlGeneralPlane = new Crystallography.Controls.ColorControl();
            this.colorControlBackGround = new Crystallography.Controls.ColorControl();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.colorControl90DegLine = new Crystallography.Controls.ColorControl();
            this.label90DegLine = new System.Windows.Forms.Label();
            this.label10DegLine = new System.Windows.Forms.Label();
            this.colorControl10DegLine = new Crystallography.Controls.ColorControl();
            this.label1DegLine = new System.Windows.Forms.Label();
            this.colorControl1DegLine = new Crystallography.Controls.ColorControl();
            this.labelString = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPlanes = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownCircleH1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleH2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleL2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownCircleL1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleK1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleK2 = new System.Windows.Forms.NumericUpDown();
            this.panelAxis = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCircleU = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleV = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleW = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCircleByPlanes = new System.Windows.Forms.RadioButton();
            this.radioButtonCircleByAxis = new System.Windows.Forms.RadioButton();
            this.buttonAddCircle = new System.Windows.Forms.Button();
            this.buttonDeleteCircle = new System.Windows.Forms.Button();
            this.checkedListBoxCircles = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonYusaModeStop = new System.Windows.Forms.Button();
            this.buttonYusaModeStart = new System.Windows.Forms.Button();
            this.radioButtonRotationalScan = new System.Windows.Forms.RadioButton();
            this.radioButtonZigzagScan = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numericBoxRxSpeed = new Crystallography.Controls.NumericBox();
            this.numericBoxRySpeed = new Crystallography.Controls.NumericBox();
            this.numericBoxRzSpeed = new Crystallography.Controls.NumericBox();
            this.numericBoxTotalTime = new Crystallography.Controls.NumericBox();
            this.numericBoxAngularSpeed = new Crystallography.Controls.NumericBox();
            this.numericBoxRyStep = new Crystallography.Controls.NumericBox();
            this.numericBoxRadialAngle = new Crystallography.Controls.NumericBox();
            this.numericBoxRyOscillation = new Crystallography.Controls.NumericBox();
            this.numericBoxRzOscillation = new Crystallography.Controls.NumericBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asMetafileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asMetafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelHU = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelSpecifiedIndices = new System.Windows.Forms.Panel();
            this.buttonRemoveIndex = new System.Windows.Forms.Button();
            this.buttonAddIndex = new System.Windows.Forms.Button();
            this.listBoxSpecifiedIndices = new System.Windows.Forms.ListBox();
            this.checkBoxIncludingEquivalentPlanes = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericBox3 = new Crystallography.Controls.NumericBox();
            this.numericBox2 = new Crystallography.Controls.NumericBox();
            this.numericBox1 = new Crystallography.Controls.NumericBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonRange = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecifiedIndices = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.graphicsBox = new ImagingSolution.Control.GraphicsBox(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.scalablePictureBoxAdvanced1 = new Crystallography.Controls.ScalablePictureBoxAdvanced();
            this.scalablePictureBoxAdvanced2 = new Crystallography.Controls.ScalablePictureBoxAdvanced();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleK2)).BeginInit();
            this.panelAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleW)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelSpecifiedIndices.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarStrSize
            // 
            resources.ApplyResources(this.trackBarStrSize, "trackBarStrSize");
            this.trackBarStrSize.Maximum = 300;
            this.trackBarStrSize.Minimum = 1;
            this.trackBarStrSize.Name = "trackBarStrSize";
            this.trackBarStrSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackBarStrSize, resources.GetString("trackBarStrSize.ToolTip"));
            this.trackBarStrSize.Value = 80;
            this.trackBarStrSize.Scroll += new System.EventHandler(this.trackBarStrSize_Scroll);
            // 
            // trackBarPointSize
            // 
            resources.ApplyResources(this.trackBarPointSize, "trackBarPointSize");
            this.trackBarPointSize.Maximum = 20;
            this.trackBarPointSize.Minimum = 1;
            this.trackBarPointSize.Name = "trackBarPointSize";
            this.trackBarPointSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackBarPointSize, resources.GetString("trackBarPointSize.ToolTip"));
            this.trackBarPointSize.Value = 5;
            this.trackBarPointSize.Scroll += new System.EventHandler(this.trackBarStrSize_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.radioButtonWulff);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonSchmidt);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // radioButtonWulff
            // 
            resources.ApplyResources(this.radioButtonWulff, "radioButtonWulff");
            this.radioButtonWulff.Checked = true;
            this.radioButtonWulff.Name = "radioButtonWulff";
            this.radioButtonWulff.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonWulff, resources.GetString("radioButtonWulff.ToolTip"));
            this.radioButtonWulff.CheckedChanged += new System.EventHandler(this.radioButtonAxes_CheckedChanged);
            // 
            // radioButtonSchmidt
            // 
            resources.ApplyResources(this.radioButtonSchmidt, "radioButtonSchmidt");
            this.radioButtonSchmidt.Name = "radioButtonSchmidt";
            this.toolTip1.SetToolTip(this.radioButtonSchmidt, resources.GetString("radioButtonSchmidt.ToolTip"));
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.radioButtonAxes);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonPlanes);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // radioButtonAxes
            // 
            resources.ApplyResources(this.radioButtonAxes, "radioButtonAxes");
            this.radioButtonAxes.Checked = true;
            this.radioButtonAxes.Name = "radioButtonAxes";
            this.radioButtonAxes.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonAxes, resources.GetString("radioButtonAxes.ToolTip"));
            this.radioButtonAxes.CheckedChanged += new System.EventHandler(this.radioButtonAxes_CheckedChanged);
            // 
            // radioButtonPlanes
            // 
            resources.ApplyResources(this.radioButtonPlanes, "radioButtonPlanes");
            this.radioButtonPlanes.Name = "radioButtonPlanes";
            this.toolTip1.SetToolTip(this.radioButtonPlanes, resources.GetString("radioButtonPlanes.ToolTip"));
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // labelYpos
            // 
            resources.ApplyResources(this.labelYpos, "labelYpos");
            this.labelYpos.Name = "labelYpos";
            // 
            // labelXpos
            // 
            resources.ApplyResources(this.labelXpos, "labelXpos");
            this.labelXpos.Name = "labelXpos";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1DegLine);
            this.groupBox3.Controls.Add(this.radioButtonOutlinePole);
            this.groupBox3.Controls.Add(this.radioButtonOutlineEquator);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // checkBox1DegLine
            // 
            resources.ApplyResources(this.checkBox1DegLine, "checkBox1DegLine");
            this.checkBox1DegLine.Name = "checkBox1DegLine";
            this.checkBox1DegLine.CheckedChanged += new System.EventHandler(this.checkBox1DegLine_CheckedChanged);
            // 
            // radioButtonOutlinePole
            // 
            resources.ApplyResources(this.radioButtonOutlinePole, "radioButtonOutlinePole");
            this.radioButtonOutlinePole.Name = "radioButtonOutlinePole";
            this.toolTip1.SetToolTip(this.radioButtonOutlinePole, resources.GetString("radioButtonOutlinePole.ToolTip"));
            // 
            // radioButtonOutlineEquator
            // 
            this.radioButtonOutlineEquator.Checked = true;
            resources.ApplyResources(this.radioButtonOutlineEquator, "radioButtonOutlineEquator");
            this.radioButtonOutlineEquator.Name = "radioButtonOutlineEquator";
            this.radioButtonOutlineEquator.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonOutlineEquator, resources.GetString("radioButtonOutlineEquator.ToolTip"));
            this.radioButtonOutlineEquator.CheckedChanged += new System.EventHandler(this.radioButtonOutlineEquator_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarPointSize);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.trackBarStrSize);
            this.groupBox4.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorControlSmallCircle);
            this.groupBox1.Controls.Add(this.colorControlGreatCircle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.colorControlString);
            this.groupBox1.Controls.Add(this.colorControlUniqueAxis);
            this.groupBox1.Controls.Add(this.colorControlUniquePlane);
            this.groupBox1.Controls.Add(this.labelUniqueAxis);
            this.groupBox1.Controls.Add(this.colorControlGeneralAxis);
            this.groupBox1.Controls.Add(this.labelGeneralAxis);
            this.groupBox1.Controls.Add(this.labelUniquePlane);
            this.groupBox1.Controls.Add(this.labelGeneralPlane);
            this.groupBox1.Controls.Add(this.colorControlGeneralPlane);
            this.groupBox1.Controls.Add(this.colorControlBackGround);
            this.groupBox1.Controls.Add(this.labelBackGround);
            this.groupBox1.Controls.Add(this.colorControl90DegLine);
            this.groupBox1.Controls.Add(this.label90DegLine);
            this.groupBox1.Controls.Add(this.label10DegLine);
            this.groupBox1.Controls.Add(this.colorControl10DegLine);
            this.groupBox1.Controls.Add(this.label1DegLine);
            this.groupBox1.Controls.Add(this.colorControl1DegLine);
            this.groupBox1.Controls.Add(this.labelString);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // colorControlSmallCircle
            // 
            this.colorControlSmallCircle.Argb = -16256;
            resources.ApplyResources(this.colorControlSmallCircle, "colorControlSmallCircle");
            this.colorControlSmallCircle.Blue = 128;
            this.colorControlSmallCircle.BlueF = 0.5019608F;
            this.colorControlSmallCircle.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlSmallCircle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colorControlSmallCircle.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlSmallCircle.Green = 192;
            this.colorControlSmallCircle.GreenF = 0.7529412F;
            this.colorControlSmallCircle.Name = "colorControlSmallCircle";
            this.colorControlSmallCircle.Red = 255;
            this.colorControlSmallCircle.RedF = 1F;
            this.colorControlSmallCircle.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // colorControlGreatCircle
            // 
            this.colorControlGreatCircle.Argb = -32768;
            resources.ApplyResources(this.colorControlGreatCircle, "colorControlGreatCircle");
            this.colorControlGreatCircle.Blue = 0;
            this.colorControlGreatCircle.BlueF = 0F;
            this.colorControlGreatCircle.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlGreatCircle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorControlGreatCircle.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlGreatCircle.Green = 128;
            this.colorControlGreatCircle.GreenF = 0.5019608F;
            this.colorControlGreatCircle.Name = "colorControlGreatCircle";
            this.colorControlGreatCircle.Red = 255;
            this.colorControlGreatCircle.RedF = 1F;
            this.colorControlGreatCircle.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // colorControlString
            // 
            this.colorControlString.Argb = -16777216;
            resources.ApplyResources(this.colorControlString, "colorControlString");
            this.colorControlString.BackColor = System.Drawing.Color.Black;
            this.colorControlString.Blue = 0;
            this.colorControlString.BlueF = 0F;
            this.colorControlString.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlString.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorControlString.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControlString.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlString.Green = 0;
            this.colorControlString.GreenF = 0F;
            this.colorControlString.Name = "colorControlString";
            this.colorControlString.Red = 0;
            this.colorControlString.RedF = 0F;
            this.colorControlString.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControlString, resources.GetString("colorControlString.ToolTip"));
            this.colorControlString.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // colorControlUniqueAxis
            // 
            this.colorControlUniqueAxis.Argb = -7667712;
            resources.ApplyResources(this.colorControlUniqueAxis, "colorControlUniqueAxis");
            this.colorControlUniqueAxis.BackColor = System.Drawing.Color.Red;
            this.colorControlUniqueAxis.Blue = 0;
            this.colorControlUniqueAxis.BlueF = 0F;
            this.colorControlUniqueAxis.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlUniqueAxis.Color = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorControlUniqueAxis.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControlUniqueAxis.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlUniqueAxis.Green = 0;
            this.colorControlUniqueAxis.GreenF = 0F;
            this.colorControlUniqueAxis.Name = "colorControlUniqueAxis";
            this.colorControlUniqueAxis.Red = 139;
            this.colorControlUniqueAxis.RedF = 0.5450981F;
            this.colorControlUniqueAxis.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControlUniqueAxis, resources.GetString("colorControlUniqueAxis.ToolTip"));
            this.colorControlUniqueAxis.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // colorControlUniquePlane
            // 
            this.colorControlUniquePlane.Argb = -16751616;
            resources.ApplyResources(this.colorControlUniquePlane, "colorControlUniquePlane");
            this.colorControlUniquePlane.BackColor = System.Drawing.Color.Lime;
            this.colorControlUniquePlane.Blue = 0;
            this.colorControlUniquePlane.BlueF = 0F;
            this.colorControlUniquePlane.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlUniquePlane.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.colorControlUniquePlane.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControlUniquePlane.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlUniquePlane.Green = 100;
            this.colorControlUniquePlane.GreenF = 0.3921569F;
            this.colorControlUniquePlane.Name = "colorControlUniquePlane";
            this.colorControlUniquePlane.Red = 0;
            this.colorControlUniquePlane.RedF = 0F;
            this.colorControlUniquePlane.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControlUniquePlane, resources.GetString("colorControlUniquePlane.ToolTip"));
            this.colorControlUniquePlane.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // labelUniqueAxis
            // 
            resources.ApplyResources(this.labelUniqueAxis, "labelUniqueAxis");
            this.labelUniqueAxis.Name = "labelUniqueAxis";
            this.toolTip1.SetToolTip(this.labelUniqueAxis, resources.GetString("labelUniqueAxis.ToolTip"));
            // 
            // colorControlGeneralAxis
            // 
            this.colorControlGeneralAxis.Argb = -65536;
            resources.ApplyResources(this.colorControlGeneralAxis, "colorControlGeneralAxis");
            this.colorControlGeneralAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorControlGeneralAxis.Blue = 0;
            this.colorControlGeneralAxis.BlueF = 0F;
            this.colorControlGeneralAxis.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlGeneralAxis.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorControlGeneralAxis.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControlGeneralAxis.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlGeneralAxis.Green = 0;
            this.colorControlGeneralAxis.GreenF = 0F;
            this.colorControlGeneralAxis.Name = "colorControlGeneralAxis";
            this.colorControlGeneralAxis.Red = 255;
            this.colorControlGeneralAxis.RedF = 1F;
            this.colorControlGeneralAxis.TabStop = false;
            this.colorControlGeneralAxis.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // labelGeneralAxis
            // 
            resources.ApplyResources(this.labelGeneralAxis, "labelGeneralAxis");
            this.labelGeneralAxis.Name = "labelGeneralAxis";
            this.toolTip1.SetToolTip(this.labelGeneralAxis, resources.GetString("labelGeneralAxis.ToolTip"));
            // 
            // labelUniquePlane
            // 
            resources.ApplyResources(this.labelUniquePlane, "labelUniquePlane");
            this.labelUniquePlane.Name = "labelUniquePlane";
            this.toolTip1.SetToolTip(this.labelUniquePlane, resources.GetString("labelUniquePlane.ToolTip"));
            // 
            // labelGeneralPlane
            // 
            resources.ApplyResources(this.labelGeneralPlane, "labelGeneralPlane");
            this.labelGeneralPlane.Name = "labelGeneralPlane";
            this.toolTip1.SetToolTip(this.labelGeneralPlane, resources.GetString("labelGeneralPlane.ToolTip"));
            // 
            // colorControlGeneralPlane
            // 
            this.colorControlGeneralPlane.Argb = -14578910;
            resources.ApplyResources(this.colorControlGeneralPlane, "colorControlGeneralPlane");
            this.colorControlGeneralPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colorControlGeneralPlane.Blue = 34;
            this.colorControlGeneralPlane.BlueF = 0.1333333F;
            this.colorControlGeneralPlane.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlGeneralPlane.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.colorControlGeneralPlane.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControlGeneralPlane.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlGeneralPlane.Green = 139;
            this.colorControlGeneralPlane.GreenF = 0.5450981F;
            this.colorControlGeneralPlane.Name = "colorControlGeneralPlane";
            this.colorControlGeneralPlane.Red = 33;
            this.colorControlGeneralPlane.RedF = 0.1294118F;
            this.colorControlGeneralPlane.TabStop = false;
            this.colorControlGeneralPlane.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // colorControlBackGround
            // 
            this.colorControlBackGround.Argb = -1;
            resources.ApplyResources(this.colorControlBackGround, "colorControlBackGround");
            this.colorControlBackGround.BackColor = System.Drawing.Color.White;
            this.colorControlBackGround.Blue = 255;
            this.colorControlBackGround.BlueF = 1F;
            this.colorControlBackGround.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControlBackGround.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorControlBackGround.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControlBackGround.Green = 255;
            this.colorControlBackGround.GreenF = 1F;
            this.colorControlBackGround.Name = "colorControlBackGround";
            this.colorControlBackGround.Red = 255;
            this.colorControlBackGround.RedF = 1F;
            this.colorControlBackGround.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControlBackGround, resources.GetString("colorControlBackGround.ToolTip"));
            this.colorControlBackGround.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // labelBackGround
            // 
            resources.ApplyResources(this.labelBackGround, "labelBackGround");
            this.labelBackGround.Name = "labelBackGround";
            this.toolTip1.SetToolTip(this.labelBackGround, resources.GetString("labelBackGround.ToolTip"));
            // 
            // colorControl90DegLine
            // 
            this.colorControl90DegLine.Argb = -16776961;
            resources.ApplyResources(this.colorControl90DegLine, "colorControl90DegLine");
            this.colorControl90DegLine.BackColor = System.Drawing.Color.Blue;
            this.colorControl90DegLine.Blue = 255;
            this.colorControl90DegLine.BlueF = 1F;
            this.colorControl90DegLine.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControl90DegLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.colorControl90DegLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControl90DegLine.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControl90DegLine.Green = 0;
            this.colorControl90DegLine.GreenF = 0F;
            this.colorControl90DegLine.Name = "colorControl90DegLine";
            this.colorControl90DegLine.Red = 0;
            this.colorControl90DegLine.RedF = 0F;
            this.colorControl90DegLine.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControl90DegLine, resources.GetString("colorControl90DegLine.ToolTip"));
            this.colorControl90DegLine.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // label90DegLine
            // 
            resources.ApplyResources(this.label90DegLine, "label90DegLine");
            this.label90DegLine.Name = "label90DegLine";
            this.toolTip1.SetToolTip(this.label90DegLine, resources.GetString("label90DegLine.ToolTip"));
            // 
            // label10DegLine
            // 
            resources.ApplyResources(this.label10DegLine, "label10DegLine");
            this.label10DegLine.Name = "label10DegLine";
            this.toolTip1.SetToolTip(this.label10DegLine, resources.GetString("label10DegLine.ToolTip"));
            // 
            // colorControl10DegLine
            // 
            this.colorControl10DegLine.Argb = -8355585;
            resources.ApplyResources(this.colorControl10DegLine, "colorControl10DegLine");
            this.colorControl10DegLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorControl10DegLine.Blue = 255;
            this.colorControl10DegLine.BlueF = 1F;
            this.colorControl10DegLine.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControl10DegLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorControl10DegLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControl10DegLine.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControl10DegLine.Green = 128;
            this.colorControl10DegLine.GreenF = 0.5019608F;
            this.colorControl10DegLine.Name = "colorControl10DegLine";
            this.colorControl10DegLine.Red = 128;
            this.colorControl10DegLine.RedF = 0.5019608F;
            this.colorControl10DegLine.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControl10DegLine, resources.GetString("colorControl10DegLine.ToolTip"));
            this.colorControl10DegLine.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // label1DegLine
            // 
            resources.ApplyResources(this.label1DegLine, "label1DegLine");
            this.label1DegLine.Name = "label1DegLine";
            this.toolTip1.SetToolTip(this.label1DegLine, resources.GetString("label1DegLine.ToolTip"));
            // 
            // colorControl1DegLine
            // 
            this.colorControl1DegLine.Argb = -4144897;
            resources.ApplyResources(this.colorControl1DegLine, "colorControl1DegLine");
            this.colorControl1DegLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorControl1DegLine.Blue = 255;
            this.colorControl1DegLine.BlueF = 1F;
            this.colorControl1DegLine.BoxSize = new System.Drawing.Size(20, 20);
            this.colorControl1DegLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorControl1DegLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorControl1DegLine.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.colorControl1DegLine.Green = 192;
            this.colorControl1DegLine.GreenF = 0.7529412F;
            this.colorControl1DegLine.Name = "colorControl1DegLine";
            this.colorControl1DegLine.Red = 192;
            this.colorControl1DegLine.RedF = 0.7529412F;
            this.colorControl1DegLine.TabStop = false;
            this.toolTip1.SetToolTip(this.colorControl1DegLine, resources.GetString("colorControl1DegLine.ToolTip"));
            this.colorControl1DegLine.ColorChanged += new System.EventHandler(this.colorControl_ColorChanged);
            // 
            // labelString
            // 
            resources.ApplyResources(this.labelString, "labelString");
            this.labelString.Name = "labelString";
            this.toolTip1.SetToolTip(this.labelString, resources.GetString("labelString.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panelPlanes);
            this.tabPage2.Controls.Add(this.panelAxis);
            this.tabPage2.Controls.Add(this.radioButtonCircleByPlanes);
            this.tabPage2.Controls.Add(this.radioButtonCircleByAxis);
            this.tabPage2.Controls.Add(this.buttonAddCircle);
            this.tabPage2.Controls.Add(this.buttonDeleteCircle);
            this.tabPage2.Controls.Add(this.checkedListBoxCircles);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // panelPlanes
            // 
            this.panelPlanes.Controls.Add(this.label12);
            this.panelPlanes.Controls.Add(this.label13);
            this.panelPlanes.Controls.Add(this.label16);
            this.panelPlanes.Controls.Add(this.label14);
            this.panelPlanes.Controls.Add(this.label17);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleH1);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleH2);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleL2);
            this.panelPlanes.Controls.Add(this.label15);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleL1);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleK1);
            this.panelPlanes.Controls.Add(this.numericUpDownCircleK2);
            resources.ApplyResources(this.panelPlanes, "panelPlanes");
            this.panelPlanes.Name = "panelPlanes";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // numericUpDownCircleH1
            // 
            resources.ApplyResources(this.numericUpDownCircleH1, "numericUpDownCircleH1");
            this.numericUpDownCircleH1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleH1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleH1.Name = "numericUpDownCircleH1";
            this.numericUpDownCircleH1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleH2
            // 
            resources.ApplyResources(this.numericUpDownCircleH2, "numericUpDownCircleH2");
            this.numericUpDownCircleH2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleH2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleH2.Name = "numericUpDownCircleH2";
            this.numericUpDownCircleH2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleL2
            // 
            resources.ApplyResources(this.numericUpDownCircleL2, "numericUpDownCircleL2");
            this.numericUpDownCircleL2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleL2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleL2.Name = "numericUpDownCircleL2";
            this.numericUpDownCircleL2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // numericUpDownCircleL1
            // 
            resources.ApplyResources(this.numericUpDownCircleL1, "numericUpDownCircleL1");
            this.numericUpDownCircleL1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleL1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleL1.Name = "numericUpDownCircleL1";
            this.numericUpDownCircleL1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleK1
            // 
            resources.ApplyResources(this.numericUpDownCircleK1, "numericUpDownCircleK1");
            this.numericUpDownCircleK1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleK1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleK1.Name = "numericUpDownCircleK1";
            this.numericUpDownCircleK1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleK2
            // 
            resources.ApplyResources(this.numericUpDownCircleK2, "numericUpDownCircleK2");
            this.numericUpDownCircleK2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleK2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleK2.Name = "numericUpDownCircleK2";
            this.numericUpDownCircleK2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // panelAxis
            // 
            this.panelAxis.Controls.Add(this.label11);
            this.panelAxis.Controls.Add(this.label5);
            this.panelAxis.Controls.Add(this.label7);
            this.panelAxis.Controls.Add(this.numericUpDownCircleU);
            this.panelAxis.Controls.Add(this.numericUpDownCircleV);
            this.panelAxis.Controls.Add(this.numericUpDownCircleW);
            resources.ApplyResources(this.panelAxis, "panelAxis");
            this.panelAxis.Name = "panelAxis";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numericUpDownCircleU
            // 
            resources.ApplyResources(this.numericUpDownCircleU, "numericUpDownCircleU");
            this.numericUpDownCircleU.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleU.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleU.Name = "numericUpDownCircleU";
            this.numericUpDownCircleU.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleV
            // 
            resources.ApplyResources(this.numericUpDownCircleV, "numericUpDownCircleV");
            this.numericUpDownCircleV.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleV.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleV.Name = "numericUpDownCircleV";
            this.numericUpDownCircleV.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownCircleW
            // 
            resources.ApplyResources(this.numericUpDownCircleW, "numericUpDownCircleW");
            this.numericUpDownCircleW.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCircleW.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownCircleW.Name = "numericUpDownCircleW";
            this.numericUpDownCircleW.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // radioButtonCircleByPlanes
            // 
            resources.ApplyResources(this.radioButtonCircleByPlanes, "radioButtonCircleByPlanes");
            this.radioButtonCircleByPlanes.Name = "radioButtonCircleByPlanes";
            this.radioButtonCircleByPlanes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircleByAxis
            // 
            resources.ApplyResources(this.radioButtonCircleByAxis, "radioButtonCircleByAxis");
            this.radioButtonCircleByAxis.Checked = true;
            this.radioButtonCircleByAxis.Name = "radioButtonCircleByAxis";
            this.radioButtonCircleByAxis.TabStop = true;
            this.radioButtonCircleByAxis.UseVisualStyleBackColor = true;
            this.radioButtonCircleByAxis.CheckedChanged += new System.EventHandler(this.radioButtonCircleByAxis_CheckedChanged);
            // 
            // buttonAddCircle
            // 
            resources.ApplyResources(this.buttonAddCircle, "buttonAddCircle");
            this.buttonAddCircle.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddCircle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddCircle.Name = "buttonAddCircle";
            this.buttonAddCircle.UseVisualStyleBackColor = false;
            this.buttonAddCircle.Click += new System.EventHandler(this.buttonAddCircle_Click);
            // 
            // buttonDeleteCircle
            // 
            resources.ApplyResources(this.buttonDeleteCircle, "buttonDeleteCircle");
            this.buttonDeleteCircle.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteCircle.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteCircle.Name = "buttonDeleteCircle";
            this.buttonDeleteCircle.UseVisualStyleBackColor = false;
            this.buttonDeleteCircle.Click += new System.EventHandler(this.buttonDeleteCircle_Click);
            // 
            // checkedListBoxCircles
            // 
            resources.ApplyResources(this.checkedListBoxCircles, "checkedListBoxCircles");
            this.checkedListBoxCircles.FormattingEnabled = true;
            this.checkedListBoxCircles.Name = "checkedListBoxCircles";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonYusaModeStop);
            this.tabPage3.Controls.Add(this.buttonYusaModeStart);
            this.tabPage3.Controls.Add(this.radioButtonRotationalScan);
            this.tabPage3.Controls.Add(this.radioButtonZigzagScan);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.numericBoxRxSpeed);
            this.tabPage3.Controls.Add(this.numericBoxRySpeed);
            this.tabPage3.Controls.Add(this.numericBoxRzSpeed);
            this.tabPage3.Controls.Add(this.numericBoxTotalTime);
            this.tabPage3.Controls.Add(this.numericBoxAngularSpeed);
            this.tabPage3.Controls.Add(this.numericBoxRyStep);
            this.tabPage3.Controls.Add(this.numericBoxRadialAngle);
            this.tabPage3.Controls.Add(this.numericBoxRyOscillation);
            this.tabPage3.Controls.Add(this.numericBoxRzOscillation);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonYusaModeStop
            // 
            resources.ApplyResources(this.buttonYusaModeStop, "buttonYusaModeStop");
            this.buttonYusaModeStop.Name = "buttonYusaModeStop";
            this.buttonYusaModeStop.UseVisualStyleBackColor = true;
            this.buttonYusaModeStop.Click += new System.EventHandler(this.buttonYusaModeStop_Click);
            // 
            // buttonYusaModeStart
            // 
            resources.ApplyResources(this.buttonYusaModeStart, "buttonYusaModeStart");
            this.buttonYusaModeStart.Name = "buttonYusaModeStart";
            this.buttonYusaModeStart.UseVisualStyleBackColor = true;
            this.buttonYusaModeStart.Click += new System.EventHandler(this.buttonYusaModeStart_Click);
            // 
            // radioButtonRotationalScan
            // 
            resources.ApplyResources(this.radioButtonRotationalScan, "radioButtonRotationalScan");
            this.radioButtonRotationalScan.Name = "radioButtonRotationalScan";
            this.radioButtonRotationalScan.UseVisualStyleBackColor = true;
            // 
            // radioButtonZigzagScan
            // 
            resources.ApplyResources(this.radioButtonZigzagScan, "radioButtonZigzagScan");
            this.radioButtonZigzagScan.Checked = true;
            this.radioButtonZigzagScan.Name = "radioButtonZigzagScan";
            this.radioButtonZigzagScan.TabStop = true;
            this.radioButtonZigzagScan.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // numericBoxRxSpeed
            // 
            resources.ApplyResources(this.numericBoxRxSpeed, "numericBoxRxSpeed");
            this.numericBoxRxSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRxSpeed.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRxSpeed.Name = "numericBoxRxSpeed";
            this.numericBoxRxSpeed.RadianValue = 0.31415926535897931D;
            
            this.numericBoxRxSpeed.RestrictLimitValue = true;
            
                        this.numericBoxRxSpeed.SkipEventDuringInput = false;
            this.numericBoxRxSpeed.SmartIncrement = true;
                                    this.numericBoxRxSpeed.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRxSpeed.ThonsandsSeparator = true;
            this.numericBoxRxSpeed.UpDown_Increment = 1D;
            this.numericBoxRxSpeed.Value = 18D;
            this.numericBoxRxSpeed.WordWrap = true;
            // 
            // numericBoxRySpeed
            // 
            resources.ApplyResources(this.numericBoxRySpeed, "numericBoxRySpeed");
            this.numericBoxRySpeed.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRySpeed.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRySpeed.Name = "numericBoxRySpeed";
            this.numericBoxRySpeed.RadianValue = 0.017453292519943295D;
            
            this.numericBoxRySpeed.RestrictLimitValue = true;
            
                        this.numericBoxRySpeed.SkipEventDuringInput = false;
            this.numericBoxRySpeed.SmartIncrement = true;
                                    this.numericBoxRySpeed.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRySpeed.ThonsandsSeparator = true;
            this.numericBoxRySpeed.UpDown_Increment = 1D;
            this.numericBoxRySpeed.Value = 1D;
            this.numericBoxRySpeed.WordWrap = true;
            // 
            // numericBoxRzSpeed
            // 
            resources.ApplyResources(this.numericBoxRzSpeed, "numericBoxRzSpeed");
            this.numericBoxRzSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRzSpeed.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRzSpeed.Name = "numericBoxRzSpeed";
            this.numericBoxRzSpeed.RadianValue = 0.034906585039886591D;
            
            this.numericBoxRzSpeed.RestrictLimitValue = true;
            
                        this.numericBoxRzSpeed.SkipEventDuringInput = false;
            this.numericBoxRzSpeed.SmartIncrement = true;
                                    this.numericBoxRzSpeed.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRzSpeed.ThonsandsSeparator = true;
            this.numericBoxRzSpeed.UpDown_Increment = 1D;
            this.numericBoxRzSpeed.Value = 2D;
            this.numericBoxRzSpeed.WordWrap = true;
            // 
            // numericBoxTotalTime
            // 
            resources.ApplyResources(this.numericBoxTotalTime, "numericBoxTotalTime");
            this.numericBoxTotalTime.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxTotalTime.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxTotalTime.Name = "numericBoxTotalTime";
            this.numericBoxTotalTime.RadianValue = 1.7453292519943295D;
            
            this.numericBoxTotalTime.RestrictLimitValue = true;
            
                        this.numericBoxTotalTime.SkipEventDuringInput = false;
            this.numericBoxTotalTime.SmartIncrement = true;
                                    this.numericBoxTotalTime.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxTotalTime.ThonsandsSeparator = true;
            this.numericBoxTotalTime.UpDown_Increment = 1D;
            this.numericBoxTotalTime.Value = 100D;
            this.numericBoxTotalTime.WordWrap = true;
            // 
            // numericBoxAngularSpeed
            // 
            resources.ApplyResources(this.numericBoxAngularSpeed, "numericBoxAngularSpeed");
            this.numericBoxAngularSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAngularSpeed.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxAngularSpeed.Name = "numericBoxAngularSpeed";
            this.numericBoxAngularSpeed.RadianValue = 0.52359877559829882D;
            
            this.numericBoxAngularSpeed.RestrictLimitValue = true;
            
                        this.numericBoxAngularSpeed.SkipEventDuringInput = false;
            this.numericBoxAngularSpeed.SmartIncrement = true;
                                    this.numericBoxAngularSpeed.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxAngularSpeed.ThonsandsSeparator = true;
            this.numericBoxAngularSpeed.UpDown_Increment = 1D;
            this.numericBoxAngularSpeed.Value = 30D;
            this.numericBoxAngularSpeed.WordWrap = true;
            // 
            // numericBoxRyStep
            // 
            resources.ApplyResources(this.numericBoxRyStep, "numericBoxRyStep");
            this.numericBoxRyStep.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRyStep.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRyStep.Name = "numericBoxRyStep";
            this.numericBoxRyStep.RadianValue = 0.0034906585039886592D;
            
            this.numericBoxRyStep.RestrictLimitValue = true;
            
                        this.numericBoxRyStep.SkipEventDuringInput = false;
            this.numericBoxRyStep.SmartIncrement = true;
                                    this.numericBoxRyStep.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRyStep.ThonsandsSeparator = true;
            this.numericBoxRyStep.UpDown_Increment = 1D;
            this.numericBoxRyStep.Value = 0.2D;
            this.numericBoxRyStep.WordWrap = true;
            // 
            // numericBoxRadialAngle
            // 
            resources.ApplyResources(this.numericBoxRadialAngle, "numericBoxRadialAngle");
            this.numericBoxRadialAngle.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRadialAngle.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRadialAngle.Name = "numericBoxRadialAngle";
            this.numericBoxRadialAngle.RadianValue = 0.13962634015954636D;
            
            this.numericBoxRadialAngle.RestrictLimitValue = true;
            
                        this.numericBoxRadialAngle.SkipEventDuringInput = false;
            this.numericBoxRadialAngle.SmartIncrement = true;
                                    this.numericBoxRadialAngle.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRadialAngle.ThonsandsSeparator = true;
            this.numericBoxRadialAngle.UpDown_Increment = 1D;
            this.numericBoxRadialAngle.Value = 8D;
            this.numericBoxRadialAngle.WordWrap = true;
            // 
            // numericBoxRyOscillation
            // 
            resources.ApplyResources(this.numericBoxRyOscillation, "numericBoxRyOscillation");
            this.numericBoxRyOscillation.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRyOscillation.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRyOscillation.Name = "numericBoxRyOscillation";
            this.numericBoxRyOscillation.RadianValue = 0.13962634015954636D;
            
            this.numericBoxRyOscillation.RestrictLimitValue = true;
            
                        this.numericBoxRyOscillation.SkipEventDuringInput = false;
            this.numericBoxRyOscillation.SmartIncrement = true;
                                    this.numericBoxRyOscillation.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRyOscillation.ThonsandsSeparator = true;
            this.numericBoxRyOscillation.UpDown_Increment = 1D;
            this.numericBoxRyOscillation.Value = 8D;
            this.numericBoxRyOscillation.WordWrap = true;
            // 
            // numericBoxRzOscillation
            // 
            resources.ApplyResources(this.numericBoxRzOscillation, "numericBoxRzOscillation");
            this.numericBoxRzOscillation.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxRzOscillation.DecimalPlaces = -1;
            
            
            
            
                                                           this.numericBoxRzOscillation.Name = "numericBoxRzOscillation";
            this.numericBoxRzOscillation.RadianValue = 0.13962634015954636D;
            
            this.numericBoxRzOscillation.RestrictLimitValue = true;
            
                        this.numericBoxRzOscillation.SkipEventDuringInput = false;
            this.numericBoxRzOscillation.SmartIncrement = true;
                                    this.numericBoxRzOscillation.TextFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxRzOscillation.ThonsandsSeparator = true;
            this.numericBoxRzOscillation.UpDown_Increment = 1D;
            this.numericBoxRzOscillation.Value = 8D;
            this.numericBoxRzOscillation.WordWrap = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asImageToolStripMenuItem,
            this.asMetafileToolStripMenuItem1});
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            resources.ApplyResources(this.saveImageToolStripMenuItem, "saveImageToolStripMenuItem");
            // 
            // asImageToolStripMenuItem
            // 
            this.asImageToolStripMenuItem.Name = "asImageToolStripMenuItem";
            resources.ApplyResources(this.asImageToolStripMenuItem, "asImageToolStripMenuItem");
            this.asImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // asMetafileToolStripMenuItem1
            // 
            resources.ApplyResources(this.asMetafileToolStripMenuItem1, "asMetafileToolStripMenuItem1");
            this.asMetafileToolStripMenuItem1.Name = "asMetafileToolStripMenuItem1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asBitmapToolStripMenuItem,
            this.asMetafileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // asBitmapToolStripMenuItem
            // 
            this.asBitmapToolStripMenuItem.Name = "asBitmapToolStripMenuItem";
            resources.ApplyResources(this.asBitmapToolStripMenuItem, "asBitmapToolStripMenuItem");
            this.asBitmapToolStripMenuItem.Click += new System.EventHandler(this.copyImageToClipboardToolStripMenuItem_Click);
            // 
            // asMetafileToolStripMenuItem
            // 
            this.asMetafileToolStripMenuItem.Name = "asMetafileToolStripMenuItem";
            resources.ApplyResources(this.asMetafileToolStripMenuItem, "asMetafileToolStripMenuItem");
            this.asMetafileToolStripMenuItem.Click += new System.EventHandler(this.copyMetafileToClipboardToolStripMenuItem_Click);
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
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // labelHU
            // 
            resources.ApplyResources(this.labelHU, "labelHU");
            this.labelHU.Name = "labelHU";
            this.toolTip1.SetToolTip(this.labelHU, resources.GetString("labelHU.ToolTip"));
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panelSpecifiedIndices);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.flowLayoutPanel3);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // panelSpecifiedIndices
            // 
            this.panelSpecifiedIndices.Controls.Add(this.buttonRemoveIndex);
            this.panelSpecifiedIndices.Controls.Add(this.buttonAddIndex);
            this.panelSpecifiedIndices.Controls.Add(this.listBoxSpecifiedIndices);
            this.panelSpecifiedIndices.Controls.Add(this.checkBoxIncludingEquivalentPlanes);
            resources.ApplyResources(this.panelSpecifiedIndices, "panelSpecifiedIndices");
            this.panelSpecifiedIndices.Name = "panelSpecifiedIndices";
            // 
            // buttonRemoveIndex
            // 
            resources.ApplyResources(this.buttonRemoveIndex, "buttonRemoveIndex");
            this.buttonRemoveIndex.Name = "buttonRemoveIndex";
            this.buttonRemoveIndex.UseVisualStyleBackColor = true;
            this.buttonRemoveIndex.Click += new System.EventHandler(this.buttonRemoveIndex_Click);
            // 
            // buttonAddIndex
            // 
            resources.ApplyResources(this.buttonAddIndex, "buttonAddIndex");
            this.buttonAddIndex.Name = "buttonAddIndex";
            this.buttonAddIndex.UseVisualStyleBackColor = true;
            this.buttonAddIndex.Click += new System.EventHandler(this.buttonAddIndex_Click);
            // 
            // listBoxSpecifiedIndices
            // 
            resources.ApplyResources(this.listBoxSpecifiedIndices, "listBoxSpecifiedIndices");
            this.listBoxSpecifiedIndices.FormattingEnabled = true;
            this.listBoxSpecifiedIndices.Name = "listBoxSpecifiedIndices";
            // 
            // checkBoxIncludingEquivalentPlanes
            // 
            resources.ApplyResources(this.checkBoxIncludingEquivalentPlanes, "checkBoxIncludingEquivalentPlanes");
            this.checkBoxIncludingEquivalentPlanes.Name = "checkBoxIncludingEquivalentPlanes";
            this.checkBoxIncludingEquivalentPlanes.UseVisualStyleBackColor = true;
            this.checkBoxIncludingEquivalentPlanes.CheckedChanged += new System.EventHandler(this.checkBoxIncludingEquivalentPlanes_CheckedChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.numericBox3);
            this.panel2.Controls.Add(this.numericBox2);
            this.panel2.Controls.Add(this.numericBox1);
            this.panel2.Controls.Add(this.labelHU);
            this.panel2.Name = "panel2";
            // 
            // numericBox3
            // 
            resources.ApplyResources(this.numericBox3, "numericBox3");
            this.numericBox3.BackColor = System.Drawing.Color.Transparent;
            this.numericBox3.DecimalPlaces = -2;
                                                                       this.numericBox3.Maximum = 20D;
            this.numericBox3.Minimum = 0D;
                        this.numericBox3.Name = "numericBox3";
            this.numericBox3.RadianValue = 0.034906585039886591D;
                        this.numericBox3.RestrictLimitValue = true;
                                    this.numericBox3.ShowUpDown = true;
            this.numericBox3.SkipEventDuringInput = false;
            this.numericBox3.SmartIncrement = false;
                                    this.numericBox3.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.numericBox3.ThonsandsSeparator = true;
                        this.numericBox3.Value = 2D;
                        this.numericBox3.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericBox2
            // 
            resources.ApplyResources(this.numericBox2, "numericBox2");
            this.numericBox2.BackColor = System.Drawing.Color.Transparent;
            this.numericBox2.DecimalPlaces = -2;
                                                                       this.numericBox2.Maximum = 20D;
            this.numericBox2.Minimum = 0D;
                        this.numericBox2.Name = "numericBox2";
            this.numericBox2.RadianValue = 0.034906585039886591D;
                        this.numericBox2.RestrictLimitValue = true;
                                    this.numericBox2.ShowUpDown = true;
            this.numericBox2.SkipEventDuringInput = false;
            this.numericBox2.SmartIncrement = false;
                                    this.numericBox2.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.numericBox2.ThonsandsSeparator = true;
                        this.numericBox2.Value = 2D;
                        this.numericBox2.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericBox1
            // 
            resources.ApplyResources(this.numericBox1, "numericBox1");
            this.numericBox1.BackColor = System.Drawing.Color.Transparent;
            this.numericBox1.DecimalPlaces = -2;
                                                                       this.numericBox1.Maximum = 20D;
            this.numericBox1.Minimum = 0D;
                        this.numericBox1.Name = "numericBox1";
            this.numericBox1.RadianValue = 0.034906585039886591D;
                        this.numericBox1.RestrictLimitValue = true;
                                    this.numericBox1.ShowUpDown = true;
            this.numericBox1.SkipEventDuringInput = false;
            this.numericBox1.SmartIncrement = false;
                                    this.numericBox1.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.numericBox1.ThonsandsSeparator = true;
                        this.numericBox1.Value = 2D;
                        this.numericBox1.ValueChanged += new Crystallography.Controls.NumericBox.MyEventHandler(this.numericUpDown_ValueChanged);
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.radioButtonRange);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonSpecifiedIndices);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // radioButtonRange
            // 
            resources.ApplyResources(this.radioButtonRange, "radioButtonRange");
            this.radioButtonRange.Checked = true;
            this.radioButtonRange.Name = "radioButtonRange";
            this.radioButtonRange.TabStop = true;
            this.radioButtonRange.UseVisualStyleBackColor = true;
            this.radioButtonRange.CheckedChanged += new System.EventHandler(this.radioButtonRange_CheckedChanged);
            // 
            // radioButtonSpecifiedIndices
            // 
            resources.ApplyResources(this.radioButtonSpecifiedIndices, "radioButtonSpecifiedIndices");
            this.radioButtonSpecifiedIndices.Name = "radioButtonSpecifiedIndices";
            this.radioButtonSpecifiedIndices.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // graphicsBox
            // 
            resources.ApplyResources(this.graphicsBox, "graphicsBox");
            this.graphicsBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.TabStop = false;
            this.graphicsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseDown);
            this.graphicsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseMove);
            this.graphicsBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseUp);
            this.graphicsBox.Resize += new System.EventHandler(this.formStereonet_Resize);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // scalablePictureBoxAdvanced1
            // 
            this.scalablePictureBoxAdvanced1.CopyButtonVisible = true;
            this.scalablePictureBoxAdvanced1.FixZoomAndCenter = false;
            resources.ApplyResources(this.scalablePictureBoxAdvanced1, "scalablePictureBoxAdvanced1");
            this.scalablePictureBoxAdvanced1.FrequencyGraphVisible = true;
            this.scalablePictureBoxAdvanced1.ImageFilter_DustAndScratches = false;
            this.scalablePictureBoxAdvanced1.ImageFilter_DustAndScratchesRadius = 1D;
            this.scalablePictureBoxAdvanced1.ImageFilter_DustAndScratchesThreshold = 3D;
            this.scalablePictureBoxAdvanced1.ImageFilter_DustAndScratchesVisible = true;
            this.scalablePictureBoxAdvanced1.ImageFilter_GaussianBlur = false;
            this.scalablePictureBoxAdvanced1.ImageFilter_GaussianBlurRadius = 1D;
            this.scalablePictureBoxAdvanced1.ImageFilter_GaussianBlurVisible = true;
            this.scalablePictureBoxAdvanced1.ImageFilterVisible = true;
            this.scalablePictureBoxAdvanced1.LogScaleBar = false;
            this.scalablePictureBoxAdvanced1.LowerIntensity = 0D;
            this.scalablePictureBoxAdvanced1.MaximumIntensity = 255D;
            this.scalablePictureBoxAdvanced1.MinimumIntensity = 0D;
            this.scalablePictureBoxAdvanced1.MousePositionLabelVisible = true;
            this.scalablePictureBoxAdvanced1.Name = "scalablePictureBoxAdvanced1";
            this.scalablePictureBoxAdvanced1.PictureSize = new System.Drawing.Size(410, -814);
            this.scalablePictureBoxAdvanced1.ShowGradiaent = true;
            this.scalablePictureBoxAdvanced1.StatusLabel = " ";
            this.scalablePictureBoxAdvanced1.StatusProgress = 0D;
            this.scalablePictureBoxAdvanced1.StatusVisible = true;
            this.scalablePictureBoxAdvanced1.TrackBarVisible = true;
            this.scalablePictureBoxAdvanced1.UpperIntensity = 255D;
            this.scalablePictureBoxAdvanced1.VisibleGradient = true;
            // 
            // scalablePictureBoxAdvanced2
            // 
            this.scalablePictureBoxAdvanced2.CopyButtonVisible = true;
            this.scalablePictureBoxAdvanced2.FixZoomAndCenter = false;
            resources.ApplyResources(this.scalablePictureBoxAdvanced2, "scalablePictureBoxAdvanced2");
            this.scalablePictureBoxAdvanced2.FrequencyGraphVisible = true;
            this.scalablePictureBoxAdvanced2.ImageFilter_DustAndScratches = false;
            this.scalablePictureBoxAdvanced2.ImageFilter_DustAndScratchesRadius = 1D;
            this.scalablePictureBoxAdvanced2.ImageFilter_DustAndScratchesThreshold = 3D;
            this.scalablePictureBoxAdvanced2.ImageFilter_DustAndScratchesVisible = true;
            this.scalablePictureBoxAdvanced2.ImageFilter_GaussianBlur = false;
            this.scalablePictureBoxAdvanced2.ImageFilter_GaussianBlurRadius = 1D;
            this.scalablePictureBoxAdvanced2.ImageFilter_GaussianBlurVisible = true;
            this.scalablePictureBoxAdvanced2.ImageFilterVisible = true;
            this.scalablePictureBoxAdvanced2.LogScaleBar = false;
            this.scalablePictureBoxAdvanced2.LowerIntensity = 0D;
            this.scalablePictureBoxAdvanced2.MaximumIntensity = 255D;
            this.scalablePictureBoxAdvanced2.MinimumIntensity = 0D;
            this.scalablePictureBoxAdvanced2.MousePositionLabelVisible = true;
            this.scalablePictureBoxAdvanced2.Name = "scalablePictureBoxAdvanced2";
            this.scalablePictureBoxAdvanced2.PictureSize = new System.Drawing.Size(410, -814);
            this.scalablePictureBoxAdvanced2.ShowGradiaent = true;
            this.scalablePictureBoxAdvanced2.StatusLabel = " ";
            this.scalablePictureBoxAdvanced2.StatusProgress = 0D;
            this.scalablePictureBoxAdvanced2.StatusVisible = true;
            this.scalablePictureBoxAdvanced2.TrackBarVisible = true;
            this.scalablePictureBoxAdvanced2.UpperIntensity = 255D;
            this.scalablePictureBoxAdvanced2.VisibleGradient = true;
            // 
            // FormStereonet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelYpos);
            this.Controls.Add(this.labelXpos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.graphicsBox);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStereonet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStereonet_FormClosing);
            this.Load += new System.EventHandler(this.FormStereonet_Load);
            this.VisibleChanged += new System.EventHandler(this.FormStereonet_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStereonet_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelPlanes.ResumeLayout(false);
            this.panelPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleK2)).EndInit();
            this.panelAxis.ResumeLayout(false);
            this.panelAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleW)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panelSpecifiedIndices.ResumeLayout(false);
            this.panelSpecifiedIndices.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarStrSize;
        private System.Windows.Forms.TrackBar trackBarPointSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAxes;
        private System.Windows.Forms.RadioButton radioButtonPlanes;
        private System.Windows.Forms.Label labelYpos;
        private System.Windows.Forms.Label labelXpos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1DegLine;
        private System.Windows.Forms.RadioButton radioButtonOutlinePole;
        private System.Windows.Forms.RadioButton radioButtonOutlineEquator;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelUniqueAxis;
        private System.Windows.Forms.Label labelGeneralAxis;
        private System.Windows.Forms.Label labelUniquePlane;
        private System.Windows.Forms.Label labelGeneralPlane;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.Label label90DegLine;
        private System.Windows.Forms.Label label10DegLine;
        private System.Windows.Forms.Label label1DegLine;
        private System.Windows.Forms.Label labelString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleW;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleV;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddCircle;
        private System.Windows.Forms.Button buttonDeleteCircle;
        private System.Windows.Forms.RadioButton radioButtonCircleByAxis;
        private System.Windows.Forms.RadioButton radioButtonCircleByPlanes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleL2;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleL1;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleK2;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleK1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleH2;
        public System.Windows.Forms.NumericUpDown numericUpDownCircleH1;
        private System.Windows.Forms.CheckedListBox checkedListBoxCircles;
        private System.Windows.Forms.Panel panelPlanes;
        private System.Windows.Forms.Panel panelAxis;
        public Crystallography.Controls.ColorControl colorControlString;
        public Crystallography.Controls.ColorControl colorControlUniqueAxis;
        public Crystallography.Controls.ColorControl colorControlUniquePlane;
        public Crystallography.Controls.ColorControl colorControlGeneralAxis;
        public Crystallography.Controls.ColorControl colorControlGeneralPlane;
        public Crystallography.Controls.ColorControl colorControlBackGround;
        public Crystallography.Controls.ColorControl colorControl90DegLine;
        public Crystallography.Controls.ColorControl colorControl10DegLine;
        public Crystallography.Controls.ColorControl colorControl1DegLine;
        public Crystallography.Controls.ColorControl colorControlGreatCircle;
        public Crystallography.Controls.ColorControl colorControlSmallCircle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonSchmidt;
        private System.Windows.Forms.RadioButton radioButtonWulff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonYusaModeStop;
        private System.Windows.Forms.Button buttonYusaModeStart;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        public Crystallography.Controls.NumericBox numericBoxRxSpeed;
        public Crystallography.Controls.NumericBox numericBoxRySpeed;
        public Crystallography.Controls.NumericBox numericBoxRzSpeed;
        public Crystallography.Controls.NumericBox numericBoxRyOscillation;
        public Crystallography.Controls.NumericBox numericBoxRzOscillation;
        public Crystallography.Controls.NumericBox numericBoxRyStep;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHU;
        private System.Windows.Forms.RadioButton radioButtonRange;
        private System.Windows.Forms.RadioButton radioButtonSpecifiedIndices;
        private System.Windows.Forms.Panel panelSpecifiedIndices;
        private System.Windows.Forms.Button buttonRemoveIndex;
        private System.Windows.Forms.Button buttonAddIndex;
        private System.Windows.Forms.ListBox listBoxSpecifiedIndices;
        private System.Windows.Forms.CheckBox checkBoxIncludingEquivalentPlanes;
        public Crystallography.Controls.NumericBox numericBoxTotalTime;
        public Crystallography.Controls.NumericBox numericBoxAngularSpeed;
        public Crystallography.Controls.NumericBox numericBoxRadialAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RadioButton radioButtonRotationalScan;
        public System.Windows.Forms.RadioButton radioButtonZigzagScan;
        private System.Windows.Forms.Panel panel3;
        private Crystallography.Controls.ScalablePictureBoxAdvanced scalablePictureBoxAdvanced1;
        private Crystallography.Controls.ScalablePictureBoxAdvanced scalablePictureBoxAdvanced2;
        public ImagingSolution.Control.GraphicsBox graphicsBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asMetafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asMetafileToolStripMenuItem1;
        private Crystallography.Controls.NumericBox numericBox3;
        private Crystallography.Controls.NumericBox numericBox2;
        private Crystallography.Controls.NumericBox numericBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}