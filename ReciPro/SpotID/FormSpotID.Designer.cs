﻿using System;

namespace ReciPro
{
    partial class FormSpotID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpotID));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scalablePictureBoxAdvanced = new Crystallography.Controls.ScalablePictureBoxAdvanced();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPixelToPixel = new System.Windows.Forms.Button();
            this.buttonCopyMetafile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericBoxNumberOfSpots = new Crystallography.Controls.NumericBox();
            this.buttonResetRangeForAllSpots = new System.Windows.Forms.Button();
            this.numericBoxFittingRange = new Crystallography.Controls.NumericBox();
            this.numericBoxNearestNeighbor = new Crystallography.Controls.NumericBox();
            this.numericBoxDonut = new Crystallography.Controls.NumericBox();
            this.checkBoxDetailsSpot = new System.Windows.Forms.CheckBox();
            this.dataGridViewSpots = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.θ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.η = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hkl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceObsSpots = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new ReciPro.DataSetReciPro();
            this.checkBoxShowObsSpotSymbol = new System.Windows.Forms.CheckBox();
            this.checkBoxShowObsSpotLabel = new System.Windows.Forms.CheckBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonCopyToClipboad = new System.Windows.Forms.Button();
            this.buttonFindSpots = new System.Windows.Forms.Button();
            this.buttonDonut = new System.Windows.Forms.Button();
            this.buttonGlobalFit = new System.Windows.Forms.Button();
            this.buttonCopmprehensiveFitting = new System.Windows.Forms.Button();
            this.buttonClearSpots = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericBoxSemiangle = new Crystallography.Controls.NumericBox();
            this.numericBoxMaxNumOfG = new Crystallography.Controls.NumericBox();
            this.numericBoxAcceptableError = new Crystallography.Controls.NumericBox();
            this.numericBoxMaxGrainNum = new Crystallography.Controls.NumericBox();
            this.checkBoxShowCalcSpotSymbol = new System.Windows.Forms.CheckBox();
            this.radioButtonMultiGrain = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleGrain = new System.Windows.Forms.RadioButton();
            this.checkBoxShowCalcSpotLabel = new System.Windows.Forms.CheckBox();
            this.dataGridViewGrains = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrystalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedSpotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceGrains = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCandidates = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedSpots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCandidates = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxIgnoreMultipleDiffraction = new System.Windows.Forms.CheckBox();
            this.buttonRefineThicknessAndDirection = new System.Windows.Forms.Button();
            this.buttonIdentifySpots = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericBoxCameraLength = new Crystallography.Controls.NumericBox();
            this.numericBoxPixelSize = new Crystallography.Controls.NumericBox();
            this.waveLengthControl1 = new Crystallography.Controls.WaveLengthControl();
            this.checkBoxShowDebyeRing = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutHintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleClickAddSpotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelImageFilter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFindSpot = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelIdentifySpot = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRefine = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorkerSpotID = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceObsSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidates)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.scalablePictureBoxAdvanced);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxShowDebyeRing);
            // 
            // scalablePictureBoxAdvanced
            // 
            resources.ApplyResources(this.scalablePictureBoxAdvanced, "scalablePictureBoxAdvanced");
            this.scalablePictureBoxAdvanced.CopyButtonVisible = true;
            this.scalablePictureBoxAdvanced.FixZoomAndCenter = false;
            this.scalablePictureBoxAdvanced.FrequencyGraphVisible = false;
            this.scalablePictureBoxAdvanced.ImageFilter_DustAndScratches = true;
            this.scalablePictureBoxAdvanced.ImageFilter_DustAndScratchesRadius = 1.5D;
            this.scalablePictureBoxAdvanced.ImageFilter_DustAndScratchesThreshold = 3D;
            this.scalablePictureBoxAdvanced.ImageFilter_DustAndScratchesVisible = true;
            this.scalablePictureBoxAdvanced.ImageFilter_GaussianBlur = true;
            this.scalablePictureBoxAdvanced.ImageFilter_GaussianBlurRadius = 3D;
            this.scalablePictureBoxAdvanced.ImageFilter_GaussianBlurVisible = true;
            this.scalablePictureBoxAdvanced.ImageFilterVisible = true;
            this.scalablePictureBoxAdvanced.LogScaleBar = true;
            this.scalablePictureBoxAdvanced.LowerIntensity = 0D;
            this.scalablePictureBoxAdvanced.MaximumIntensity = 18285.576171875D;
            this.scalablePictureBoxAdvanced.MinimumIntensity = -2306.3408203125D;
            this.scalablePictureBoxAdvanced.MousePositionLabelVisible = true;
            this.scalablePictureBoxAdvanced.Name = "scalablePictureBoxAdvanced";
            this.scalablePictureBoxAdvanced.PictureSize = new System.Drawing.Size(524, 593);
            this.scalablePictureBoxAdvanced.ShowGradiaent = true;
            this.scalablePictureBoxAdvanced.StatusLabel = "Elapsed time:    Dust && Scratches: 0.123msec.  Gaussian Blur: 0.205msec.  ";
            this.scalablePictureBoxAdvanced.StatusProgress = 0D;
            this.scalablePictureBoxAdvanced.StatusVisible = false;
            this.scalablePictureBoxAdvanced.TrackBarVisible = true;
            this.scalablePictureBoxAdvanced.UpperIntensity = 255D;
            this.scalablePictureBoxAdvanced.VisibleGradient = true;
            this.scalablePictureBoxAdvanced.MouseDown2 += new Crystallography.Controls.ScalablePictureBoxAdvanced.MouseEvent(this.scalablePictureBoxAdvanced1_MouseDown2);
            this.scalablePictureBoxAdvanced.StatusChanged += new System.EventHandler(this.scalablePictureBoxAdvanced_StatusChanged);
            this.scalablePictureBoxAdvanced.FilterChanged += new System.EventHandler(this.ScalablePictureBoxAdvanced_FilterChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonPixelToPixel);
            this.panel1.Controls.Add(this.buttonCopyMetafile);
            this.panel1.Name = "panel1";
            // 
            // buttonPixelToPixel
            // 
            resources.ApplyResources(this.buttonPixelToPixel, "buttonPixelToPixel");
            this.buttonPixelToPixel.Name = "buttonPixelToPixel";
            this.buttonPixelToPixel.UseVisualStyleBackColor = true;
            this.buttonPixelToPixel.Click += new System.EventHandler(this.buttonPixelToPixel_Click);
            // 
            // buttonCopyMetafile
            // 
            resources.ApplyResources(this.buttonCopyMetafile, "buttonCopyMetafile");
            this.buttonCopyMetafile.Name = "buttonCopyMetafile";
            this.buttonCopyMetafile.UseVisualStyleBackColor = true;
            this.buttonCopyMetafile.Click += new System.EventHandler(this.buttonCopyMetafile_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.numericBoxDonut);
            this.groupBox1.Controls.Add(this.checkBoxDetailsSpot);
            this.groupBox1.Controls.Add(this.dataGridViewSpots);
            this.groupBox1.Controls.Add(this.checkBoxShowObsSpotSymbol);
            this.groupBox1.Controls.Add(this.checkBoxShowObsSpotLabel);
            this.groupBox1.Controls.Add(this.buttonSaveToFile);
            this.groupBox1.Controls.Add(this.buttonCopyToClipboad);
            this.groupBox1.Controls.Add(this.buttonFindSpots);
            this.groupBox1.Controls.Add(this.buttonDonut);
            this.groupBox1.Controls.Add(this.buttonGlobalFit);
            this.groupBox1.Controls.Add(this.buttonCopmprehensiveFitting);
            this.groupBox1.Controls.Add(this.buttonClearSpots);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.numericBoxNumberOfSpots);
            this.groupBox4.Controls.Add(this.buttonResetRangeForAllSpots);
            this.groupBox4.Controls.Add(this.numericBoxFittingRange);
            this.groupBox4.Controls.Add(this.numericBoxNearestNeighbor);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // numericBoxNumberOfSpots
            // 
            resources.ApplyResources(this.numericBoxNumberOfSpots, "numericBoxNumberOfSpots");
            this.numericBoxNumberOfSpots.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumberOfSpots.DecimalPlaces = 0;
            this.numericBoxNumberOfSpots.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumberOfSpots.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNumberOfSpots.Maximum = 1000D;
            this.numericBoxNumberOfSpots.Minimum = 1D;
            this.numericBoxNumberOfSpots.Name = "numericBoxNumberOfSpots";
            this.numericBoxNumberOfSpots.RadianValue = 0.52359877559829882D;
            this.numericBoxNumberOfSpots.ShowUpDown = true;
            this.numericBoxNumberOfSpots.SkipEventDuringInput = false;
            this.numericBoxNumberOfSpots.SmartIncrement = true;
            this.numericBoxNumberOfSpots.ThonsandsSeparator = true;
            this.numericBoxNumberOfSpots.Value = 30D;
            // 
            // buttonResetRangeForAllSpots
            // 
            resources.ApplyResources(this.buttonResetRangeForAllSpots, "buttonResetRangeForAllSpots");
            this.buttonResetRangeForAllSpots.Name = "buttonResetRangeForAllSpots";
            this.buttonResetRangeForAllSpots.UseVisualStyleBackColor = true;
            this.buttonResetRangeForAllSpots.Click += new System.EventHandler(this.ButtonResetRangeForAllSpots_Click);
            // 
            // numericBoxFittingRange
            // 
            resources.ApplyResources(this.numericBoxFittingRange, "numericBoxFittingRange");
            this.numericBoxFittingRange.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxFittingRange.DecimalPlaces = 1;
            this.numericBoxFittingRange.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxFittingRange.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxFittingRange.Maximum = 100D;
            this.numericBoxFittingRange.Minimum = 0D;
            this.numericBoxFittingRange.Name = "numericBoxFittingRange";
            this.numericBoxFittingRange.RadianValue = 0.3490658503988659D;
            this.numericBoxFittingRange.ShowUpDown = true;
            this.numericBoxFittingRange.SkipEventDuringInput = false;
            this.numericBoxFittingRange.SmartIncrement = true;
            this.numericBoxFittingRange.ThonsandsSeparator = true;
            this.numericBoxFittingRange.Value = 20D;
            this.numericBoxFittingRange.Load += new System.EventHandler(this.numericBoxFittingRange_Load);
            // 
            // numericBoxNearestNeighbor
            // 
            resources.ApplyResources(this.numericBoxNearestNeighbor, "numericBoxNearestNeighbor");
            this.numericBoxNearestNeighbor.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNearestNeighbor.DecimalPlaces = 0;
            this.numericBoxNearestNeighbor.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNearestNeighbor.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxNearestNeighbor.Maximum = 1000D;
            this.numericBoxNearestNeighbor.Minimum = 1D;
            this.numericBoxNearestNeighbor.Name = "numericBoxNearestNeighbor";
            this.numericBoxNearestNeighbor.RadianValue = 0.17453292519943295D;
            this.numericBoxNearestNeighbor.ShowUpDown = true;
            this.numericBoxNearestNeighbor.SkipEventDuringInput = false;
            this.numericBoxNearestNeighbor.SmartIncrement = true;
            this.numericBoxNearestNeighbor.ThonsandsSeparator = true;
            this.numericBoxNearestNeighbor.Value = 10D;
            // 
            // numericBoxDonut
            // 
            resources.ApplyResources(this.numericBoxDonut, "numericBoxDonut");
            this.numericBoxDonut.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDonut.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDonut.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxDonut.Maximum = 100D;
            this.numericBoxDonut.Minimum = 1D;
            this.numericBoxDonut.Name = "numericBoxDonut";
            this.numericBoxDonut.RadianValue = 0.087266462599716474D;
            this.numericBoxDonut.ShowUpDown = true;
            this.numericBoxDonut.SkipEventDuringInput = false;
            this.numericBoxDonut.SmartIncrement = true;
            this.numericBoxDonut.TextFont = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.numericBoxDonut.ThonsandsSeparator = true;
            this.numericBoxDonut.Value = 5D;
            // 
            // checkBoxDetailsSpot
            // 
            resources.ApplyResources(this.checkBoxDetailsSpot, "checkBoxDetailsSpot");
            this.checkBoxDetailsSpot.Name = "checkBoxDetailsSpot";
            this.checkBoxDetailsSpot.UseVisualStyleBackColor = true;
            this.checkBoxDetailsSpot.CheckedChanged += new System.EventHandler(this.checkBoxDetailsSpot_CheckedChanged);
            // 
            // dataGridViewSpots
            // 
            resources.ApplyResources(this.dataGridViewSpots, "dataGridViewSpots");
            this.dataGridViewSpots.AllowUserToDeleteRows = false;
            this.dataGridViewSpots.AllowUserToResizeRows = false;
            this.dataGridViewSpots.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.noDataGridViewTextBoxColumn,
            this.Range,
            this.x0,
            this.y0,
            this.H1,
            this.H2,
            this.θ,
            this.η,
            this.A,
            this.B0,
            this.Bx,
            this.By,
            this.R,
            this.d,
            this.hkl,
            this.Column1});
            this.dataGridViewSpots.DataSource = this.bindingSourceObsSpots;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpots.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewSpots.MultiSelect = false;
            this.dataGridViewSpots.Name = "dataGridViewSpots";
            this.dataGridViewSpots.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSpots.RowTemplate.Height = 21;
            this.dataGridViewSpots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpots_CellContentClick);
            this.dataGridViewSpots.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSpots_RowHeaderMouseDoubleClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Direct";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.noDataGridViewTextBoxColumn, "noDataGridViewTextBoxColumn");
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.Range.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Range, "Range");
            this.Range.Name = "Range";
            // 
            // x0
            // 
            this.x0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.x0.DataPropertyName = "x0";
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = null;
            this.x0.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.x0, "x0");
            this.x0.Name = "x0";
            // 
            // y0
            // 
            this.y0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.y0.DataPropertyName = "y0";
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = null;
            this.y0.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.y0, "y0");
            this.y0.Name = "y0";
            // 
            // H1
            // 
            this.H1.DataPropertyName = "H1";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.H1.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.H1, "H1");
            this.H1.Name = "H1";
            // 
            // H2
            // 
            this.H2.DataPropertyName = "H2";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.H2.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.H2, "H2");
            this.H2.Name = "H2";
            // 
            // θ
            // 
            this.θ.DataPropertyName = "θ";
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = null;
            this.θ.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.θ, "θ");
            this.θ.Name = "θ";
            // 
            // η
            // 
            this.η.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.η.DataPropertyName = "η";
            resources.ApplyResources(this.η, "η");
            this.η.Name = "η";
            // 
            // A
            // 
            this.A.DataPropertyName = "A";
            dataGridViewCellStyle9.Format = "0.0000E0";
            dataGridViewCellStyle9.NullValue = null;
            this.A.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.A, "A");
            this.A.Name = "A";
            // 
            // B0
            // 
            this.B0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.B0.DataPropertyName = "B0";
            resources.ApplyResources(this.B0, "B0");
            this.B0.Name = "B0";
            // 
            // Bx
            // 
            this.Bx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bx.DataPropertyName = "Bx";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.Bx.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.Bx, "Bx");
            this.Bx.Name = "Bx";
            // 
            // By
            // 
            this.By.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.By.DataPropertyName = "By";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.By.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.By, "By");
            this.By.Name = "By";
            // 
            // R
            // 
            this.R.DataPropertyName = "R";
            resources.ApplyResources(this.R, "R");
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // d
            // 
            this.d.DataPropertyName = "d";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N4";
            dataGridViewCellStyle12.NullValue = null;
            this.d.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.d, "d");
            this.d.Name = "d";
            this.d.ReadOnly = true;
            // 
            // hkl
            // 
            this.hkl.DataPropertyName = "HKL";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.hkl.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.hkl, "hkl");
            this.hkl.Name = "hkl";
            this.hkl.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.Text = "Fit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // bindingSourceObsSpots
            // 
            this.bindingSourceObsSpots.DataMember = "DataTableSpot";
            this.bindingSourceObsSpots.DataSource = this.dataSet;
            this.bindingSourceObsSpots.CurrentChanged += new System.EventHandler(this.bindingSourceSpot_CurrentChanged);
            this.bindingSourceObsSpots.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceObsSpots_ListChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxShowObsSpotSymbol
            // 
            resources.ApplyResources(this.checkBoxShowObsSpotSymbol, "checkBoxShowObsSpotSymbol");
            this.checkBoxShowObsSpotSymbol.Checked = true;
            this.checkBoxShowObsSpotSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowObsSpotSymbol.Name = "checkBoxShowObsSpotSymbol";
            this.checkBoxShowObsSpotSymbol.UseVisualStyleBackColor = true;
            this.checkBoxShowObsSpotSymbol.CheckedChanged += new System.EventHandler(this.checkBoxShowObsSpots_CheckedChanged);
            // 
            // checkBoxShowObsSpotLabel
            // 
            resources.ApplyResources(this.checkBoxShowObsSpotLabel, "checkBoxShowObsSpotLabel");
            this.checkBoxShowObsSpotLabel.Checked = true;
            this.checkBoxShowObsSpotLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowObsSpotLabel.Name = "checkBoxShowObsSpotLabel";
            this.checkBoxShowObsSpotLabel.UseVisualStyleBackColor = true;
            this.checkBoxShowObsSpotLabel.CheckedChanged += new System.EventHandler(this.checkBoxShowObsSpots_CheckedChanged);
            // 
            // buttonSaveToFile
            // 
            resources.ApplyResources(this.buttonSaveToFile, "buttonSaveToFile");
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonCopyToClipboad_Click);
            // 
            // buttonCopyToClipboad
            // 
            resources.ApplyResources(this.buttonCopyToClipboad, "buttonCopyToClipboad");
            this.buttonCopyToClipboad.Name = "buttonCopyToClipboad";
            this.buttonCopyToClipboad.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboad.Click += new System.EventHandler(this.buttonCopyToClipboad_Click);
            // 
            // buttonFindSpots
            // 
            resources.ApplyResources(this.buttonFindSpots, "buttonFindSpots");
            this.buttonFindSpots.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFindSpots.ForeColor = System.Drawing.Color.White;
            this.buttonFindSpots.Name = "buttonFindSpots";
            this.buttonFindSpots.UseVisualStyleBackColor = false;
            this.buttonFindSpots.Click += new System.EventHandler(this.buttonFindSpots_Click);
            // 
            // buttonDonut
            // 
            resources.ApplyResources(this.buttonDonut, "buttonDonut");
            this.buttonDonut.Name = "buttonDonut";
            this.buttonDonut.UseVisualStyleBackColor = true;
            this.buttonDonut.Click += new System.EventHandler(this.buttonDonut_Click);
            // 
            // buttonGlobalFit
            // 
            resources.ApplyResources(this.buttonGlobalFit, "buttonGlobalFit");
            this.buttonGlobalFit.Name = "buttonGlobalFit";
            this.buttonGlobalFit.UseVisualStyleBackColor = true;
            this.buttonGlobalFit.Click += new System.EventHandler(this.ButtonGlobalFit_Click);
            // 
            // buttonCopmprehensiveFitting
            // 
            resources.ApplyResources(this.buttonCopmprehensiveFitting, "buttonCopmprehensiveFitting");
            this.buttonCopmprehensiveFitting.Name = "buttonCopmprehensiveFitting";
            this.buttonCopmprehensiveFitting.UseVisualStyleBackColor = true;
            this.buttonCopmprehensiveFitting.Click += new System.EventHandler(this.buttonRefit_Click);
            // 
            // buttonClearSpots
            // 
            resources.ApplyResources(this.buttonClearSpots, "buttonClearSpots");
            this.buttonClearSpots.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClearSpots.ForeColor = System.Drawing.Color.White;
            this.buttonClearSpots.Name = "buttonClearSpots";
            this.buttonClearSpots.UseVisualStyleBackColor = false;
            this.buttonClearSpots.Click += new System.EventHandler(this.buttonClearSpots_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ReciPro.Properties.Resources.TwoDimensionalPseudoVoigt;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.numericBoxSemiangle);
            this.groupBox3.Controls.Add(this.numericBoxMaxNumOfG);
            this.groupBox3.Controls.Add(this.numericBoxAcceptableError);
            this.groupBox3.Controls.Add(this.numericBoxMaxGrainNum);
            this.groupBox3.Controls.Add(this.checkBoxShowCalcSpotSymbol);
            this.groupBox3.Controls.Add(this.radioButtonMultiGrain);
            this.groupBox3.Controls.Add(this.radioButtonSingleGrain);
            this.groupBox3.Controls.Add(this.checkBoxShowCalcSpotLabel);
            this.groupBox3.Controls.Add(this.dataGridViewGrains);
            this.groupBox3.Controls.Add(this.dataGridViewCandidates);
            this.groupBox3.Controls.Add(this.checkBoxIgnoreMultipleDiffraction);
            this.groupBox3.Controls.Add(this.buttonRefineThicknessAndDirection);
            this.groupBox3.Controls.Add(this.buttonIdentifySpots);
            this.groupBox3.Controls.Add(this.buttonStop);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // numericBoxSemiangle
            // 
            resources.ApplyResources(this.numericBoxSemiangle, "numericBoxSemiangle");
            this.numericBoxSemiangle.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxSemiangle.DecimalPlaces = 1;
            this.numericBoxSemiangle.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxSemiangle.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxSemiangle.Maximum = 10D;
            this.numericBoxSemiangle.Minimum = 1D;
            this.numericBoxSemiangle.Name = "numericBoxSemiangle";
            this.numericBoxSemiangle.RadianValue = 0.034906585039886591D;
            this.numericBoxSemiangle.ShowUpDown = true;
            this.numericBoxSemiangle.SmartIncrement = true;
            this.numericBoxSemiangle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.numericBoxSemiangle.ThonsandsSeparator = true;
            this.numericBoxSemiangle.Value = 2D;
            // 
            // numericBoxMaxNumOfG
            // 
            resources.ApplyResources(this.numericBoxMaxNumOfG, "numericBoxMaxNumOfG");
            this.numericBoxMaxNumOfG.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxNumOfG.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxNumOfG.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxNumOfG.Maximum = 2048D;
            this.numericBoxMaxNumOfG.Minimum = 1D;
            this.numericBoxMaxNumOfG.Name = "numericBoxMaxNumOfG";
            this.numericBoxMaxNumOfG.RadianValue = 6.9813170079773181D;
            this.numericBoxMaxNumOfG.ShowUpDown = true;
            this.numericBoxMaxNumOfG.SmartIncrement = true;
            this.numericBoxMaxNumOfG.TextFont = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.numericBoxMaxNumOfG.ThonsandsSeparator = true;
            this.numericBoxMaxNumOfG.Value = 400D;
            // 
            // numericBoxAcceptableError
            // 
            resources.ApplyResources(this.numericBoxAcceptableError, "numericBoxAcceptableError");
            this.numericBoxAcceptableError.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAcceptableError.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAcceptableError.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxAcceptableError.Maximum = 10D;
            this.numericBoxAcceptableError.Minimum = 0.1D;
            this.numericBoxAcceptableError.Name = "numericBoxAcceptableError";
            this.numericBoxAcceptableError.RadianValue = 0.034906585039886591D;
            this.numericBoxAcceptableError.ShowUpDown = true;
            this.numericBoxAcceptableError.SkipEventDuringInput = false;
            this.numericBoxAcceptableError.SmartIncrement = true;
            this.numericBoxAcceptableError.ThonsandsSeparator = true;
            this.numericBoxAcceptableError.Value = 2D;
            // 
            // numericBoxMaxGrainNum
            // 
            resources.ApplyResources(this.numericBoxMaxGrainNum, "numericBoxMaxGrainNum");
            this.numericBoxMaxGrainNum.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxGrainNum.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxGrainNum.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxMaxGrainNum.Maximum = 10D;
            this.numericBoxMaxGrainNum.Minimum = 0.1D;
            this.numericBoxMaxGrainNum.Name = "numericBoxMaxGrainNum";
            this.numericBoxMaxGrainNum.RadianValue = 0.034906585039886591D;
            this.numericBoxMaxGrainNum.ShowUpDown = true;
            this.numericBoxMaxGrainNum.SkipEventDuringInput = false;
            this.numericBoxMaxGrainNum.ThonsandsSeparator = true;
            this.numericBoxMaxGrainNum.Value = 2D;
            // 
            // checkBoxShowCalcSpotSymbol
            // 
            resources.ApplyResources(this.checkBoxShowCalcSpotSymbol, "checkBoxShowCalcSpotSymbol");
            this.checkBoxShowCalcSpotSymbol.Checked = true;
            this.checkBoxShowCalcSpotSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowCalcSpotSymbol.Name = "checkBoxShowCalcSpotSymbol";
            this.checkBoxShowCalcSpotSymbol.UseVisualStyleBackColor = true;
            this.checkBoxShowCalcSpotSymbol.CheckedChanged += new System.EventHandler(this.checkBoxShowObsSpots_CheckedChanged);
            // 
            // radioButtonMultiGrain
            // 
            resources.ApplyResources(this.radioButtonMultiGrain, "radioButtonMultiGrain");
            this.radioButtonMultiGrain.Name = "radioButtonMultiGrain";
            this.radioButtonMultiGrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleGrain
            // 
            resources.ApplyResources(this.radioButtonSingleGrain, "radioButtonSingleGrain");
            this.radioButtonSingleGrain.Checked = true;
            this.radioButtonSingleGrain.Name = "radioButtonSingleGrain";
            this.radioButtonSingleGrain.TabStop = true;
            this.radioButtonSingleGrain.UseVisualStyleBackColor = true;
            this.radioButtonSingleGrain.CheckedChanged += new System.EventHandler(this.radioButtonSingleGrain_CheckedChanged);
            // 
            // checkBoxShowCalcSpotLabel
            // 
            resources.ApplyResources(this.checkBoxShowCalcSpotLabel, "checkBoxShowCalcSpotLabel");
            this.checkBoxShowCalcSpotLabel.Name = "checkBoxShowCalcSpotLabel";
            this.checkBoxShowCalcSpotLabel.UseVisualStyleBackColor = true;
            this.checkBoxShowCalcSpotLabel.CheckedChanged += new System.EventHandler(this.checkBoxShowObsSpots_CheckedChanged);
            // 
            // dataGridViewGrains
            // 
            resources.ApplyResources(this.dataGridViewGrains, "dataGridViewGrains");
            this.dataGridViewGrains.AllowUserToAddRows = false;
            this.dataGridViewGrains.AllowUserToDeleteRows = false;
            this.dataGridViewGrains.AllowUserToResizeRows = false;
            this.dataGridViewGrains.AutoGenerateColumns = false;
            this.dataGridViewGrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn2,
            this.CrystalName,
            this.assignedSpotsDataGridViewTextBoxColumn});
            this.dataGridViewGrains.DataSource = this.bindingSourceGrains;
            this.dataGridViewGrains.Name = "dataGridViewGrains";
            this.dataGridViewGrains.ReadOnly = true;
            this.dataGridViewGrains.RowHeadersVisible = false;
            this.dataGridViewGrains.RowTemplate.Height = 21;
            this.dataGridViewGrains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // noDataGridViewTextBoxColumn2
            // 
            this.noDataGridViewTextBoxColumn2.DataPropertyName = "No";
            resources.ApplyResources(this.noDataGridViewTextBoxColumn2, "noDataGridViewTextBoxColumn2");
            this.noDataGridViewTextBoxColumn2.Name = "noDataGridViewTextBoxColumn2";
            this.noDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CrystalName
            // 
            this.CrystalName.DataPropertyName = "CrystalName";
            resources.ApplyResources(this.CrystalName, "CrystalName");
            this.CrystalName.Name = "CrystalName";
            this.CrystalName.ReadOnly = true;
            // 
            // assignedSpotsDataGridViewTextBoxColumn
            // 
            this.assignedSpotsDataGridViewTextBoxColumn.DataPropertyName = "AssignedSpots";
            resources.ApplyResources(this.assignedSpotsDataGridViewTextBoxColumn, "assignedSpotsDataGridViewTextBoxColumn");
            this.assignedSpotsDataGridViewTextBoxColumn.Name = "assignedSpotsDataGridViewTextBoxColumn";
            this.assignedSpotsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceGrains
            // 
            this.bindingSourceGrains.DataMember = "DataTableGrain";
            this.bindingSourceGrains.DataSource = this.dataSet;
            this.bindingSourceGrains.CurrentChanged += new System.EventHandler(this.bindingSourceGrains_CurrentChanged);
            // 
            // dataGridViewCandidates
            // 
            resources.ApplyResources(this.dataGridViewCandidates, "dataGridViewCandidates");
            this.dataGridViewCandidates.AllowUserToAddRows = false;
            this.dataGridViewCandidates.AllowUserToDeleteRows = false;
            this.dataGridViewCandidates.AllowUserToResizeRows = false;
            this.dataGridViewCandidates.AutoGenerateColumns = false;
            this.dataGridViewCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn1,
            this.AssignedSpots});
            this.dataGridViewCandidates.DataSource = this.bindingSourceCandidates;
            this.dataGridViewCandidates.MultiSelect = false;
            this.dataGridViewCandidates.Name = "dataGridViewCandidates";
            this.dataGridViewCandidates.ReadOnly = true;
            this.dataGridViewCandidates.RowHeadersVisible = false;
            this.dataGridViewCandidates.RowTemplate.Height = 21;
            this.dataGridViewCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // noDataGridViewTextBoxColumn1
            // 
            this.noDataGridViewTextBoxColumn1.DataPropertyName = "No";
            resources.ApplyResources(this.noDataGridViewTextBoxColumn1, "noDataGridViewTextBoxColumn1");
            this.noDataGridViewTextBoxColumn1.Name = "noDataGridViewTextBoxColumn1";
            this.noDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AssignedSpots
            // 
            this.AssignedSpots.DataPropertyName = "AssignedSpots";
            resources.ApplyResources(this.AssignedSpots, "AssignedSpots");
            this.AssignedSpots.Name = "AssignedSpots";
            this.AssignedSpots.ReadOnly = true;
            // 
            // bindingSourceCandidates
            // 
            this.bindingSourceCandidates.DataMember = "DataTableCandidate";
            this.bindingSourceCandidates.DataSource = this.dataSet;
            this.bindingSourceCandidates.CurrentChanged += new System.EventHandler(this.bindingSourceCandidates_CurrentChanged);
            // 
            // checkBoxIgnoreMultipleDiffraction
            // 
            resources.ApplyResources(this.checkBoxIgnoreMultipleDiffraction, "checkBoxIgnoreMultipleDiffraction");
            this.checkBoxIgnoreMultipleDiffraction.Name = "checkBoxIgnoreMultipleDiffraction";
            this.checkBoxIgnoreMultipleDiffraction.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreMultipleDiffraction.CheckedChanged += new System.EventHandler(this.checkBoxShowObsSpots_CheckedChanged);
            // 
            // buttonRefineThicknessAndDirection
            // 
            resources.ApplyResources(this.buttonRefineThicknessAndDirection, "buttonRefineThicknessAndDirection");
            this.buttonRefineThicknessAndDirection.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRefineThicknessAndDirection.ForeColor = System.Drawing.Color.White;
            this.buttonRefineThicknessAndDirection.Name = "buttonRefineThicknessAndDirection";
            this.buttonRefineThicknessAndDirection.UseVisualStyleBackColor = false;
            this.buttonRefineThicknessAndDirection.Click += new System.EventHandler(this.ButtonRefineThicknessAndDirection_Click);
            // 
            // buttonIdentifySpots
            // 
            resources.ApplyResources(this.buttonIdentifySpots, "buttonIdentifySpots");
            this.buttonIdentifySpots.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIdentifySpots.ForeColor = System.Drawing.Color.White;
            this.buttonIdentifySpots.Name = "buttonIdentifySpots";
            this.buttonIdentifySpots.UseVisualStyleBackColor = false;
            this.buttonIdentifySpots.Click += new System.EventHandler(this.buttonIdentifySpots_Click);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.BackColor = System.Drawing.Color.IndianRed;
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.numericBoxCameraLength);
            this.groupBox2.Controls.Add(this.numericBoxPixelSize);
            this.groupBox2.Controls.Add(this.waveLengthControl1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // numericBoxCameraLength
            // 
            resources.ApplyResources(this.numericBoxCameraLength, "numericBoxCameraLength");
            this.numericBoxCameraLength.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCameraLength.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCameraLength.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxCameraLength.Maximum = 10000D;
            this.numericBoxCameraLength.Minimum = 0D;
            this.numericBoxCameraLength.Name = "numericBoxCameraLength";
            this.numericBoxCameraLength.RadianValue = 17.453292519943293D;
            this.numericBoxCameraLength.SkipEventDuringInput = false;
            this.numericBoxCameraLength.SmartIncrement = true;
            this.numericBoxCameraLength.ThonsandsSeparator = true;
            this.numericBoxCameraLength.Value = 1000D;
            // 
            // numericBoxPixelSize
            // 
            resources.ApplyResources(this.numericBoxPixelSize, "numericBoxPixelSize");
            this.numericBoxPixelSize.BackColor = System.Drawing.SystemColors.Control;
            this.numericBoxPixelSize.FooterBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxPixelSize.HeaderBackColor = System.Drawing.SystemColors.Control;
            this.numericBoxPixelSize.Maximum = 100D;
            this.numericBoxPixelSize.Minimum = 0D;
            this.numericBoxPixelSize.Name = "numericBoxPixelSize";
            this.numericBoxPixelSize.RadianValue = 0.0008726646259971648D;
            this.numericBoxPixelSize.SkipEventDuringInput = false;
            this.numericBoxPixelSize.SmartIncrement = true;
            this.numericBoxPixelSize.ThonsandsSeparator = true;
            this.numericBoxPixelSize.Value = 0.05D;
            // 
            // waveLengthControl1
            // 
            resources.ApplyResources(this.waveLengthControl1, "waveLengthControl1");
            this.waveLengthControl1.Energy = 199.99999999999997D;
            this.waveLengthControl1.Name = "waveLengthControl1";
            this.waveLengthControl1.ShowWaveSource = true;
            this.waveLengthControl1.TextFont = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.waveLengthControl1.WaveLength = 0.00250793474552456D;
            this.waveLengthControl1.WaveSource = Crystallography.WaveSource.Electron;
            this.waveLengthControl1.XrayWaveSourceElementNumber = 0;
            this.waveLengthControl1.XrayWaveSourceLine = Crystallography.XrayLine.Ka1;
            // 
            // checkBoxShowDebyeRing
            // 
            resources.ApplyResources(this.checkBoxShowDebyeRing, "checkBoxShowDebyeRing");
            this.checkBoxShowDebyeRing.Name = "checkBoxShowDebyeRing";
            this.checkBoxShowDebyeRing.UseVisualStyleBackColor = true;
            this.checkBoxShowDebyeRing.CheckedChanged += new System.EventHandler(this.checkBoxShowDebyeRing_CheckedChanged);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shortcutHintsToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // readToolStripMenuItem
            // 
            resources.ApplyResources(this.readToolStripMenuItem, "readToolStripMenuItem");
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            // 
            // shortcutHintsToolStripMenuItem
            // 
            resources.ApplyResources(this.shortcutHintsToolStripMenuItem, "shortcutHintsToolStripMenuItem");
            this.shortcutHintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doubleClickAddSpotToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3});
            this.shortcutHintsToolStripMenuItem.Name = "shortcutHintsToolStripMenuItem";
            // 
            // doubleClickAddSpotToolStripMenuItem
            // 
            resources.ApplyResources(this.doubleClickAddSpotToolStripMenuItem, "doubleClickAddSpotToolStripMenuItem");
            this.doubleClickAddSpotToolStripMenuItem.Name = "doubleClickAddSpotToolStripMenuItem";
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabelImageFilter,
            this.toolStripStatusLabelFindSpot,
            this.toolStripStatusLabelIdentifySpot,
            this.toolStripStatusLabelRefine});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            resources.ApplyResources(this.toolStripProgressBar, "toolStripProgressBar");
            this.toolStripProgressBar.Maximum = 10000;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            // 
            // toolStripStatusLabelImageFilter
            // 
            resources.ApplyResources(this.toolStripStatusLabelImageFilter, "toolStripStatusLabelImageFilter");
            this.toolStripStatusLabelImageFilter.Name = "toolStripStatusLabelImageFilter";
            // 
            // toolStripStatusLabelFindSpot
            // 
            resources.ApplyResources(this.toolStripStatusLabelFindSpot, "toolStripStatusLabelFindSpot");
            this.toolStripStatusLabelFindSpot.Name = "toolStripStatusLabelFindSpot";
            // 
            // toolStripStatusLabelIdentifySpot
            // 
            resources.ApplyResources(this.toolStripStatusLabelIdentifySpot, "toolStripStatusLabelIdentifySpot");
            this.toolStripStatusLabelIdentifySpot.Name = "toolStripStatusLabelIdentifySpot";
            // 
            // toolStripStatusLabelRefine
            // 
            resources.ApplyResources(this.toolStripStatusLabelRefine, "toolStripStatusLabelRefine");
            this.toolStripStatusLabelRefine.Name = "toolStripStatusLabelRefine";
            // 
            // backgroundWorkerSpotID
            // 
            this.backgroundWorkerSpotID.WorkerReportsProgress = true;
            this.backgroundWorkerSpotID.WorkerSupportsCancellation = true;
            this.backgroundWorkerSpotID.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSpotID_DoWork);
            this.backgroundWorkerSpotID.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSpotID_ProgressChanged);
            this.backgroundWorkerSpotID.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSpotID_RunWorkerCompleted);
            // 
            // FormSpotID
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSpotID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSpotID_FormClosing);
            this.Load += new System.EventHandler(this.FormSpotID_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormSpotID_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormSpotID_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceObsSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidates)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private Crystallography.Controls.WaveLengthControl waveLengthControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Crystallography.Controls.NumericBox numericBoxCameraLength;
        private Crystallography.Controls.NumericBox numericBoxPixelSize;
        private System.Windows.Forms.Button buttonIdentifySpots;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCandidates;
        private System.Windows.Forms.BindingSource bindingSourceCandidates;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFindSpot;
        private Crystallography.Controls.NumericBox numericBoxAcceptableError;
        private System.Windows.Forms.RadioButton radioButtonMultiGrain;
        private System.Windows.Forms.RadioButton radioButtonSingleGrain;
        private System.Windows.Forms.DataGridView dataGridViewGrains;
        private System.Windows.Forms.BindingSource bindingSourceGrains;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedSpots;
        private Crystallography.Controls.NumericBox numericBoxMaxGrainNum;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSpotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrystalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedSpotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxIgnoreMultipleDiffraction;
        private System.Windows.Forms.Button buttonPixelToPixel;
        private System.Windows.Forms.CheckBox checkBoxShowDebyeRing;
        private System.Windows.Forms.Button buttonCopyMetafile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIdentifySpot;
        public System.Windows.Forms.BindingSource bindingSourceObsSpots;
        public DataSetReciPro dataSet;
        public Crystallography.Controls.ScalablePictureBoxAdvanced scalablePictureBoxAdvanced;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem shortcutHintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleClickAddSpotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxShowCalcSpotSymbol;
        private System.Windows.Forms.CheckBox checkBoxShowCalcSpotLabel;
        private System.Windows.Forms.Button buttonRefineThicknessAndDirection;
        private Crystallography.Controls.NumericBox numericBoxMaxNumOfG;
        private Crystallography.Controls.NumericBox numericBoxSemiangle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImageFilter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRefine;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxDetailsSpot;
        private System.Windows.Forms.DataGridView dataGridViewSpots;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn x0;
        private System.Windows.Forms.DataGridViewTextBoxColumn y0;
        private System.Windows.Forms.DataGridViewTextBoxColumn H1;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2;
        private System.Windows.Forms.DataGridViewTextBoxColumn θ;
        private System.Windows.Forms.DataGridViewTextBoxColumn η;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bx;
        private System.Windows.Forms.DataGridViewTextBoxColumn By;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn hkl;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.CheckBox checkBoxShowObsSpotSymbol;
        private System.Windows.Forms.CheckBox checkBoxShowObsSpotLabel;
        private System.Windows.Forms.Button buttonSaveToFile;
        private Crystallography.Controls.NumericBox numericBoxNearestNeighbor;
        private Crystallography.Controls.NumericBox numericBoxNumberOfSpots;
        public Crystallography.Controls.NumericBox numericBoxFittingRange;
        private System.Windows.Forms.Button buttonCopyToClipboad;
        private System.Windows.Forms.Button buttonFindSpots;
        private System.Windows.Forms.Button buttonGlobalFit;
        private System.Windows.Forms.Button buttonResetRangeForAllSpots;
        private System.Windows.Forms.Button buttonCopmprehensiveFitting;
        private System.Windows.Forms.Button buttonClearSpots;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDonut;
        private Crystallography.Controls.NumericBox numericBoxDonut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
    }
}