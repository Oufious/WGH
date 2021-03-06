﻿namespace WindowsGlitchHarvester
{
    partial class WGH_MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGH_MainForm));
			this.btnBlastTarget = new System.Windows.Forms.Button();
			this.btnBrowseTarget = new System.Windows.Forms.Button();
			this.lbStashHistory = new System.Windows.Forms.ListBox();
			this.btnLoadStockpile = new System.Windows.Forms.Button();
			this.btnClearStashHistory = new System.Windows.Forms.Button();
			this.btnSaveStockpileAs = new System.Windows.Forms.Button();
			this.btnSaveStockpile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClearStockpile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbTarget = new System.Windows.Forms.Label();
			this.btnStockpileMoveDown = new System.Windows.Forms.Button();
			this.btnStockpileMoveUp = new System.Windows.Forms.Button();
			this.nmIntensity = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.tbIntensity = new System.Windows.Forms.TrackBar();
			this.tbStartingAddress = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.nmStartingAddress = new System.Windows.Forms.NumericUpDown();
			this.tbBlastRange = new System.Windows.Forms.TrackBar();
			this.nmBlastRange = new System.Windows.Forms.NumericUpDown();
			this.btnAddStashToStockpile = new System.Windows.Forms.Button();
			this.cbBlastRange = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnRestoreFileBackup = new System.Windows.Forms.Button();
			this.gbNightmareEngineSettings = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbBlastType = new System.Windows.Forms.ComboBox();
			this.cbCorruptionEngine = new System.Windows.Forms.ComboBox();
			this.rbTargetFile = new System.Windows.Forms.RadioButton();
			this.rbTargetProcess = new System.Windows.Forms.RadioButton();
			this.btnRemoveSelected = new System.Windows.Forms.Button();
			this.btnImportStockpile = new System.Windows.Forms.Button();
			this.btnStockpileUp = new System.Windows.Forms.Button();
			this.btnStockpileDown = new System.Windows.Forms.Button();
			this.btnStashHistoryUp = new System.Windows.Forms.Button();
			this.btnStashHistoryDown = new System.Windows.Forms.Button();
			this.pnTargetPanel = new System.Windows.Forms.Panel();
			this.rbTargetMultipleFiles = new System.Windows.Forms.RadioButton();
			this.btnClearAllBackups = new System.Windows.Forms.Button();
			this.btnResetBackup = new System.Windows.Forms.Button();
			this.cbWriteCopyMode = new System.Windows.Forms.CheckBox();
			this.btnInjectSelected = new System.Windows.Forms.Button();
			this.btnDisableAutoUncorrupt = new System.Windows.Forms.Button();
			this.btnEnableCaching = new System.Windows.Forms.Button();
			this.pnBottom = new System.Windows.Forms.Panel();
			this.btnBlastUntilEffect = new System.Windows.Forms.Button();
			this.cbTerminateOnReExec = new System.Windows.Forms.CheckBox();
			this.rbExecuteWith = new System.Windows.Forms.RadioButton();
			this.rbExecuteScript = new System.Windows.Forms.RadioButton();
			this.rbExecuteOtherProgram = new System.Windows.Forms.RadioButton();
			this.btnRerollInject = new System.Windows.Forms.Button();
			this.rbExecuteCorruptedFile = new System.Windows.Forms.RadioButton();
			this.rbNoExecution = new System.Windows.Forms.RadioButton();
			this.btnEditExec = new System.Windows.Forms.Button();
			this.lbExecution = new System.Windows.Forms.Label();
			this.cbInjectOnSelect = new System.Windows.Forms.CheckBox();
			this.btnRenameSelected = new System.Windows.Forms.Button();
			this.gbVectorEngineSettings = new System.Windows.Forms.GroupBox();
			this.cbBigEndian = new System.Windows.Forms.CheckBox();
			this.cbVectorValueList = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cbVectorLimiterList = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.gbDefaultSettings = new System.Windows.Forms.GroupBox();
			this.pnCorruptionEngine = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.lbStockpile = new WindowsGlitchHarvester.RefreshingListBox();
			((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbStartingAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmStartingAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlastRange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmBlastRange)).BeginInit();
			this.gbNightmareEngineSettings.SuspendLayout();
			this.pnTargetPanel.SuspendLayout();
			this.pnBottom.SuspendLayout();
			this.gbVectorEngineSettings.SuspendLayout();
			this.pnCorruptionEngine.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBlastTarget
			// 
			this.btnBlastTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnBlastTarget.FlatAppearance.BorderSize = 0;
			this.btnBlastTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBlastTarget.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.btnBlastTarget.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnBlastTarget.Location = new System.Drawing.Point(8, 6);
			this.btnBlastTarget.Name = "btnBlastTarget";
			this.btnBlastTarget.Size = new System.Drawing.Size(118, 39);
			this.btnBlastTarget.TabIndex = 0;
			this.btnBlastTarget.TabStop = false;
			this.btnBlastTarget.Tag = "color:darker";
			this.btnBlastTarget.Text = "Blast the target";
			this.btnBlastTarget.UseVisualStyleBackColor = false;
			this.btnBlastTarget.Click += new System.EventHandler(this.btnBlastTarget_Click);
			this.btnBlastTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBlastTarget_MouseDown);
			// 
			// btnBrowseTarget
			// 
			this.btnBrowseTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnBrowseTarget.FlatAppearance.BorderSize = 0;
			this.btnBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnBrowseTarget.ForeColor = System.Drawing.Color.Gold;
			this.btnBrowseTarget.Location = new System.Drawing.Point(10, 34);
			this.btnBrowseTarget.Name = "btnBrowseTarget";
			this.btnBrowseTarget.Size = new System.Drawing.Size(71, 23);
			this.btnBrowseTarget.TabIndex = 1;
			this.btnBrowseTarget.TabStop = false;
			this.btnBrowseTarget.Tag = "color:darker";
			this.btnBrowseTarget.Text = "Browse";
			this.btnBrowseTarget.UseVisualStyleBackColor = false;
			this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
			// 
			// lbStashHistory
			// 
			this.lbStashHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbStashHistory.BackColor = System.Drawing.Color.Gray;
			this.lbStashHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbStashHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbStashHistory.ForeColor = System.Drawing.Color.White;
			this.lbStashHistory.FormattingEnabled = true;
			this.lbStashHistory.IntegralHeight = false;
			this.lbStashHistory.ItemHeight = 17;
			this.lbStashHistory.Location = new System.Drawing.Point(229, 96);
			this.lbStashHistory.Name = "lbStashHistory";
			this.lbStashHistory.ScrollAlwaysVisible = true;
			this.lbStashHistory.Size = new System.Drawing.Size(146, 406);
			this.lbStashHistory.TabIndex = 3;
			this.lbStashHistory.TabStop = false;
			this.lbStashHistory.Tag = "color:normal";
			this.lbStashHistory.SelectedIndexChanged += new System.EventHandler(this.lbStashHistory_SelectedIndexChanged);
			// 
			// btnLoadStockpile
			// 
			this.btnLoadStockpile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadStockpile.BackColor = System.Drawing.Color.Orange;
			this.btnLoadStockpile.FlatAppearance.BorderSize = 0;
			this.btnLoadStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadStockpile.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnLoadStockpile.Location = new System.Drawing.Point(571, 72);
			this.btnLoadStockpile.Name = "btnLoadStockpile";
			this.btnLoadStockpile.Size = new System.Drawing.Size(50, 22);
			this.btnLoadStockpile.TabIndex = 4;
			this.btnLoadStockpile.TabStop = false;
			this.btnLoadStockpile.Text = "Load";
			this.btnLoadStockpile.UseVisualStyleBackColor = false;
			this.btnLoadStockpile.Click += new System.EventHandler(this.btnLoadStockpile_Click);
			// 
			// btnClearStashHistory
			// 
			this.btnClearStashHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClearStashHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnClearStashHistory.FlatAppearance.BorderSize = 0;
			this.btnClearStashHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearStashHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnClearStashHistory.ForeColor = System.Drawing.Color.Black;
			this.btnClearStashHistory.Location = new System.Drawing.Point(229, 504);
			this.btnClearStashHistory.Name = "btnClearStashHistory";
			this.btnClearStashHistory.Size = new System.Drawing.Size(147, 32);
			this.btnClearStashHistory.TabIndex = 5;
			this.btnClearStashHistory.TabStop = false;
			this.btnClearStashHistory.Tag = "color:light";
			this.btnClearStashHistory.Text = "Clear History";
			this.btnClearStashHistory.UseVisualStyleBackColor = false;
			this.btnClearStashHistory.Click += new System.EventHandler(this.btnClearStashHistory_Click);
			// 
			// btnSaveStockpileAs
			// 
			this.btnSaveStockpileAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveStockpileAs.BackColor = System.Drawing.Color.Firebrick;
			this.btnSaveStockpileAs.FlatAppearance.BorderSize = 0;
			this.btnSaveStockpileAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveStockpileAs.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnSaveStockpileAs.Location = new System.Drawing.Point(623, 72);
			this.btnSaveStockpileAs.Name = "btnSaveStockpileAs";
			this.btnSaveStockpileAs.Size = new System.Drawing.Size(59, 22);
			this.btnSaveStockpileAs.TabIndex = 6;
			this.btnSaveStockpileAs.TabStop = false;
			this.btnSaveStockpileAs.Text = "Save as";
			this.btnSaveStockpileAs.UseVisualStyleBackColor = false;
			this.btnSaveStockpileAs.Click += new System.EventHandler(this.btnSaveStockpileAs_Click);
			// 
			// btnSaveStockpile
			// 
			this.btnSaveStockpile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveStockpile.BackColor = System.Drawing.Color.LightGray;
			this.btnSaveStockpile.Enabled = false;
			this.btnSaveStockpile.FlatAppearance.BorderSize = 0;
			this.btnSaveStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveStockpile.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnSaveStockpile.Location = new System.Drawing.Point(684, 72);
			this.btnSaveStockpile.Name = "btnSaveStockpile";
			this.btnSaveStockpile.Size = new System.Drawing.Size(44, 22);
			this.btnSaveStockpile.TabIndex = 8;
			this.btnSaveStockpile.TabStop = false;
			this.btnSaveStockpile.Text = "Save";
			this.btnSaveStockpile.UseVisualStyleBackColor = false;
			this.btnSaveStockpile.Click += new System.EventHandler(this.btnSaveStockpile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(227, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Stash History";
			// 
			// btnClearStockpile
			// 
			this.btnClearStockpile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnClearStockpile.FlatAppearance.BorderSize = 0;
			this.btnClearStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearStockpile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnClearStockpile.ForeColor = System.Drawing.Color.Black;
			this.btnClearStockpile.Location = new System.Drawing.Point(419, 405);
			this.btnClearStockpile.Name = "btnClearStockpile";
			this.btnClearStockpile.Size = new System.Drawing.Size(107, 32);
			this.btnClearStockpile.TabIndex = 10;
			this.btnClearStockpile.TabStop = false;
			this.btnClearStockpile.Tag = "color:light";
			this.btnClearStockpile.Text = "Clear Stockpile";
			this.btnClearStockpile.UseVisualStyleBackColor = false;
			this.btnClearStockpile.Click += new System.EventHandler(this.btnClearStockpile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(419, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 21);
			this.label2.TabIndex = 11;
			this.label2.Text = "Stockpile Manager";
			// 
			// lbTarget
			// 
			this.lbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbTarget.ForeColor = System.Drawing.Color.Gold;
			this.lbTarget.Location = new System.Drawing.Point(85, 34);
			this.lbTarget.Name = "lbTarget";
			this.lbTarget.Padding = new System.Windows.Forms.Padding(3, 6, 1, 1);
			this.lbTarget.Size = new System.Drawing.Size(655, 23);
			this.lbTarget.TabIndex = 12;
			this.lbTarget.Tag = "color:dark";
			this.lbTarget.Text = "No target selected";
			this.lbTarget.Click += new System.EventHandler(this.lbTargetName_Click);
			// 
			// btnStockpileMoveDown
			// 
			this.btnStockpileMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStockpileMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStockpileMoveDown.FlatAppearance.BorderSize = 0;
			this.btnStockpileMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnStockpileMoveDown.Location = new System.Drawing.Point(815, 405);
			this.btnStockpileMoveDown.Name = "btnStockpileMoveDown";
			this.btnStockpileMoveDown.Size = new System.Drawing.Size(39, 32);
			this.btnStockpileMoveDown.TabIndex = 13;
			this.btnStockpileMoveDown.TabStop = false;
			this.btnStockpileMoveDown.Tag = "color:light";
			this.btnStockpileMoveDown.Text = "▼▼";
			this.btnStockpileMoveDown.UseVisualStyleBackColor = false;
			this.btnStockpileMoveDown.Click += new System.EventHandler(this.btnStockpileMoveDown_Click);
			// 
			// btnStockpileMoveUp
			// 
			this.btnStockpileMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStockpileMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStockpileMoveUp.FlatAppearance.BorderSize = 0;
			this.btnStockpileMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnStockpileMoveUp.Location = new System.Drawing.Point(774, 405);
			this.btnStockpileMoveUp.Name = "btnStockpileMoveUp";
			this.btnStockpileMoveUp.Size = new System.Drawing.Size(39, 32);
			this.btnStockpileMoveUp.TabIndex = 14;
			this.btnStockpileMoveUp.TabStop = false;
			this.btnStockpileMoveUp.Tag = "color:light";
			this.btnStockpileMoveUp.Text = "▲▲";
			this.btnStockpileMoveUp.UseVisualStyleBackColor = false;
			this.btnStockpileMoveUp.Click += new System.EventHandler(this.btnStockpileMoveUp_Click);
			// 
			// nmIntensity
			// 
			this.nmIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.nmIntensity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.nmIntensity.ForeColor = System.Drawing.Color.White;
			this.nmIntensity.Location = new System.Drawing.Point(114, 12);
			this.nmIntensity.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
			this.nmIntensity.Name = "nmIntensity";
			this.nmIntensity.Size = new System.Drawing.Size(86, 25);
			this.nmIntensity.TabIndex = 15;
			this.nmIntensity.TabStop = false;
			this.nmIntensity.Tag = "color:dark";
			this.nmIntensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nmIntensity.ValueChanged += new System.EventHandler(this.nmIntensity_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(8, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "Intensity :";
			// 
			// tbIntensity
			// 
			this.tbIntensity.Location = new System.Drawing.Point(9, 41);
			this.tbIntensity.Maximum = 4000000;
			this.tbIntensity.Name = "tbIntensity";
			this.tbIntensity.Size = new System.Drawing.Size(191, 45);
			this.tbIntensity.TabIndex = 17;
			this.tbIntensity.TabStop = false;
			this.tbIntensity.TickFrequency = 0;
			this.tbIntensity.Value = 100;
			this.tbIntensity.Scroll += new System.EventHandler(this.tbIntensity_Scroll);
			// 
			// tbStartingAddress
			// 
			this.tbStartingAddress.Location = new System.Drawing.Point(9, 106);
			this.tbStartingAddress.Maximum = 100;
			this.tbStartingAddress.Name = "tbStartingAddress";
			this.tbStartingAddress.Size = new System.Drawing.Size(191, 45);
			this.tbStartingAddress.TabIndex = 20;
			this.tbStartingAddress.TabStop = false;
			this.tbStartingAddress.TickFrequency = 0;
			this.tbStartingAddress.Value = 100;
			this.tbStartingAddress.Scroll += new System.EventHandler(this.tbStartingAddress_Scroll);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(6, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 17);
			this.label5.TabIndex = 19;
			this.label5.Text = "Starting address:";
			// 
			// nmStartingAddress
			// 
			this.nmStartingAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.nmStartingAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.nmStartingAddress.ForeColor = System.Drawing.Color.White;
			this.nmStartingAddress.Location = new System.Drawing.Point(114, 78);
			this.nmStartingAddress.Name = "nmStartingAddress";
			this.nmStartingAddress.Size = new System.Drawing.Size(86, 25);
			this.nmStartingAddress.TabIndex = 18;
			this.nmStartingAddress.TabStop = false;
			this.nmStartingAddress.Tag = "color:dark";
			this.nmStartingAddress.ValueChanged += new System.EventHandler(this.nmStartingAddress_ValueChanged);
			// 
			// tbBlastRange
			// 
			this.tbBlastRange.Location = new System.Drawing.Point(9, 175);
			this.tbBlastRange.Maximum = 100;
			this.tbBlastRange.Name = "tbBlastRange";
			this.tbBlastRange.Size = new System.Drawing.Size(191, 45);
			this.tbBlastRange.TabIndex = 23;
			this.tbBlastRange.TabStop = false;
			this.tbBlastRange.TickFrequency = 0;
			this.tbBlastRange.Value = 100;
			this.tbBlastRange.Scroll += new System.EventHandler(this.tbBlastRange_Scroll);
			// 
			// nmBlastRange
			// 
			this.nmBlastRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.nmBlastRange.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.nmBlastRange.ForeColor = System.Drawing.Color.White;
			this.nmBlastRange.Location = new System.Drawing.Point(114, 144);
			this.nmBlastRange.Name = "nmBlastRange";
			this.nmBlastRange.Size = new System.Drawing.Size(86, 25);
			this.nmBlastRange.TabIndex = 21;
			this.nmBlastRange.TabStop = false;
			this.nmBlastRange.Tag = "color:dark";
			this.nmBlastRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nmBlastRange.ValueChanged += new System.EventHandler(this.nmBlastRange_ValueChanged);
			// 
			// btnAddStashToStockpile
			// 
			this.btnAddStashToStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAddStashToStockpile.FlatAppearance.BorderSize = 0;
			this.btnAddStashToStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddStashToStockpile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.btnAddStashToStockpile.Location = new System.Drawing.Point(383, 187);
			this.btnAddStashToStockpile.Name = "btnAddStashToStockpile";
			this.btnAddStashToStockpile.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
			this.btnAddStashToStockpile.Size = new System.Drawing.Size(28, 112);
			this.btnAddStashToStockpile.TabIndex = 24;
			this.btnAddStashToStockpile.TabStop = false;
			this.btnAddStashToStockpile.Tag = "color:light";
			this.btnAddStashToStockpile.Text = "⏵";
			this.btnAddStashToStockpile.UseVisualStyleBackColor = false;
			this.btnAddStashToStockpile.Click += new System.EventHandler(this.btnAddStashToStockpile_Click);
			// 
			// cbBlastRange
			// 
			this.cbBlastRange.AutoSize = true;
			this.cbBlastRange.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbBlastRange.ForeColor = System.Drawing.Color.White;
			this.cbBlastRange.Location = new System.Drawing.Point(9, 145);
			this.cbBlastRange.Name = "cbBlastRange";
			this.cbBlastRange.Size = new System.Drawing.Size(95, 21);
			this.cbBlastRange.TabIndex = 25;
			this.cbBlastRange.TabStop = false;
			this.cbBlastRange.Text = "Blast range:";
			this.cbBlastRange.UseVisualStyleBackColor = true;
			this.cbBlastRange.CheckedChanged += new System.EventHandler(this.cbBlastRange_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(12, 328);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 19);
			this.label7.TabIndex = 26;
			this.label7.Text = "Corruption Engine";
			// 
			// btnRestoreFileBackup
			// 
			this.btnRestoreFileBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestoreFileBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnRestoreFileBackup.FlatAppearance.BorderSize = 0;
			this.btnRestoreFileBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestoreFileBackup.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnRestoreFileBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRestoreFileBackup.Location = new System.Drawing.Point(633, 7);
			this.btnRestoreFileBackup.Name = "btnRestoreFileBackup";
			this.btnRestoreFileBackup.Size = new System.Drawing.Size(107, 23);
			this.btnRestoreFileBackup.TabIndex = 27;
			this.btnRestoreFileBackup.TabStop = false;
			this.btnRestoreFileBackup.Tag = "color:darker";
			this.btnRestoreFileBackup.Text = "Restore Backup";
			this.btnRestoreFileBackup.UseVisualStyleBackColor = false;
			this.btnRestoreFileBackup.Click += new System.EventHandler(this.btnRestoreFileBackup_Click);
			// 
			// gbNightmareEngineSettings
			// 
			this.gbNightmareEngineSettings.Controls.Add(this.label3);
			this.gbNightmareEngineSettings.Controls.Add(this.cbBlastType);
			this.gbNightmareEngineSettings.ForeColor = System.Drawing.Color.White;
			this.gbNightmareEngineSettings.Location = new System.Drawing.Point(885, 228);
			this.gbNightmareEngineSettings.Name = "gbNightmareEngineSettings";
			this.gbNightmareEngineSettings.Size = new System.Drawing.Size(190, 130);
			this.gbNightmareEngineSettings.TabIndex = 28;
			this.gbNightmareEngineSettings.TabStop = false;
			this.gbNightmareEngineSettings.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(7, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 41;
			this.label3.Text = "Blast Type:";
			// 
			// cbBlastType
			// 
			this.cbBlastType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cbBlastType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBlastType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbBlastType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbBlastType.ForeColor = System.Drawing.Color.White;
			this.cbBlastType.FormattingEnabled = true;
			this.cbBlastType.Items.AddRange(new object[] {
            "RANDOM",
            "RANDOMTILT",
            "TILT"});
			this.cbBlastType.Location = new System.Drawing.Point(77, 20);
			this.cbBlastType.Name = "cbBlastType";
			this.cbBlastType.Size = new System.Drawing.Size(97, 25);
			this.cbBlastType.TabIndex = 40;
			this.cbBlastType.TabStop = false;
			this.cbBlastType.Tag = "color:dark";
			this.cbBlastType.SelectedIndexChanged += new System.EventHandler(this.cbBlastType_SelectedIndexChanged);
			// 
			// cbCorruptionEngine
			// 
			this.cbCorruptionEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cbCorruptionEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCorruptionEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCorruptionEngine.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbCorruptionEngine.ForeColor = System.Drawing.Color.White;
			this.cbCorruptionEngine.FormattingEnabled = true;
			this.cbCorruptionEngine.Items.AddRange(new object[] {
            "Nightmare Engine",
            "Vector Engine"});
			this.cbCorruptionEngine.Location = new System.Drawing.Point(10, 12);
			this.cbCorruptionEngine.Name = "cbCorruptionEngine";
			this.cbCorruptionEngine.Size = new System.Drawing.Size(190, 25);
			this.cbCorruptionEngine.TabIndex = 29;
			this.cbCorruptionEngine.TabStop = false;
			this.cbCorruptionEngine.Tag = "color:dark";
			this.cbCorruptionEngine.SelectedIndexChanged += new System.EventHandler(this.cbCorruptionEngine_SelectedIndexChanged);
			// 
			// rbTargetFile
			// 
			this.rbTargetFile.AutoSize = true;
			this.rbTargetFile.Checked = true;
			this.rbTargetFile.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbTargetFile.ForeColor = System.Drawing.Color.White;
			this.rbTargetFile.Location = new System.Drawing.Point(9, 9);
			this.rbTargetFile.Name = "rbTargetFile";
			this.rbTargetFile.Size = new System.Drawing.Size(77, 17);
			this.rbTargetFile.TabIndex = 30;
			this.rbTargetFile.TabStop = true;
			this.rbTargetFile.Text = "Target File";
			this.rbTargetFile.UseVisualStyleBackColor = true;
			this.rbTargetFile.CheckedChanged += new System.EventHandler(this.rbTargetFile_CheckedChanged);
			// 
			// rbTargetProcess
			// 
			this.rbTargetProcess.AutoSize = true;
			this.rbTargetProcess.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbTargetProcess.ForeColor = System.Drawing.Color.White;
			this.rbTargetProcess.Location = new System.Drawing.Point(237, 9);
			this.rbTargetProcess.Name = "rbTargetProcess";
			this.rbTargetProcess.Size = new System.Drawing.Size(180, 17);
			this.rbTargetProcess.TabIndex = 31;
			this.rbTargetProcess.Text = "Target Process (EXPERIMENTAL)";
			this.rbTargetProcess.UseVisualStyleBackColor = true;
			this.rbTargetProcess.CheckedChanged += new System.EventHandler(this.rbTargetProcess_CheckedChanged);
			// 
			// btnRemoveSelected
			// 
			this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRemoveSelected.FlatAppearance.BorderSize = 0;
			this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnRemoveSelected.ForeColor = System.Drawing.Color.Black;
			this.btnRemoveSelected.Location = new System.Drawing.Point(540, 405);
			this.btnRemoveSelected.Name = "btnRemoveSelected";
			this.btnRemoveSelected.Size = new System.Drawing.Size(117, 32);
			this.btnRemoveSelected.TabIndex = 33;
			this.btnRemoveSelected.TabStop = false;
			this.btnRemoveSelected.Tag = "color:light";
			this.btnRemoveSelected.Text = "Remove Item";
			this.btnRemoveSelected.UseVisualStyleBackColor = false;
			this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
			// 
			// btnImportStockpile
			// 
			this.btnImportStockpile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnImportStockpile.FlatAppearance.BorderSize = 0;
			this.btnImportStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportStockpile.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnImportStockpile.Location = new System.Drawing.Point(739, 72);
			this.btnImportStockpile.Name = "btnImportStockpile";
			this.btnImportStockpile.Size = new System.Drawing.Size(50, 22);
			this.btnImportStockpile.TabIndex = 34;
			this.btnImportStockpile.TabStop = false;
			this.btnImportStockpile.Text = "Import";
			this.btnImportStockpile.UseVisualStyleBackColor = false;
			this.btnImportStockpile.Click += new System.EventHandler(this.btnImportStockpile_Click);
			// 
			// btnStockpileUp
			// 
			this.btnStockpileUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStockpileUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStockpileUp.FlatAppearance.BorderSize = 0;
			this.btnStockpileUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileUp.ForeColor = System.Drawing.Color.Black;
			this.btnStockpileUp.Location = new System.Drawing.Point(802, 71);
			this.btnStockpileUp.Name = "btnStockpileUp";
			this.btnStockpileUp.Size = new System.Drawing.Size(25, 23);
			this.btnStockpileUp.TabIndex = 36;
			this.btnStockpileUp.TabStop = false;
			this.btnStockpileUp.Tag = "color:light";
			this.btnStockpileUp.Text = "▲";
			this.btnStockpileUp.UseVisualStyleBackColor = false;
			this.btnStockpileUp.Click += new System.EventHandler(this.btnStockpileUp_Click);
			// 
			// btnStockpileDown
			// 
			this.btnStockpileDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStockpileDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStockpileDown.FlatAppearance.BorderSize = 0;
			this.btnStockpileDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileDown.ForeColor = System.Drawing.Color.Black;
			this.btnStockpileDown.Location = new System.Drawing.Point(829, 71);
			this.btnStockpileDown.Name = "btnStockpileDown";
			this.btnStockpileDown.Size = new System.Drawing.Size(25, 23);
			this.btnStockpileDown.TabIndex = 35;
			this.btnStockpileDown.TabStop = false;
			this.btnStockpileDown.Tag = "color:light";
			this.btnStockpileDown.Text = "▼";
			this.btnStockpileDown.UseVisualStyleBackColor = false;
			this.btnStockpileDown.Click += new System.EventHandler(this.btnStockpileDown_Click);
			// 
			// btnStashHistoryUp
			// 
			this.btnStashHistoryUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStashHistoryUp.FlatAppearance.BorderSize = 0;
			this.btnStashHistoryUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStashHistoryUp.ForeColor = System.Drawing.Color.Black;
			this.btnStashHistoryUp.Location = new System.Drawing.Point(324, 71);
			this.btnStashHistoryUp.Name = "btnStashHistoryUp";
			this.btnStashHistoryUp.Size = new System.Drawing.Size(25, 23);
			this.btnStashHistoryUp.TabIndex = 38;
			this.btnStashHistoryUp.TabStop = false;
			this.btnStashHistoryUp.Tag = "color:light";
			this.btnStashHistoryUp.Text = "▲";
			this.btnStashHistoryUp.UseVisualStyleBackColor = false;
			this.btnStashHistoryUp.Click += new System.EventHandler(this.btnStashHistoryUp_Click);
			// 
			// btnStashHistoryDown
			// 
			this.btnStashHistoryDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStashHistoryDown.FlatAppearance.BorderSize = 0;
			this.btnStashHistoryDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStashHistoryDown.ForeColor = System.Drawing.Color.Black;
			this.btnStashHistoryDown.Location = new System.Drawing.Point(351, 71);
			this.btnStashHistoryDown.Name = "btnStashHistoryDown";
			this.btnStashHistoryDown.Size = new System.Drawing.Size(25, 23);
			this.btnStashHistoryDown.TabIndex = 37;
			this.btnStashHistoryDown.TabStop = false;
			this.btnStashHistoryDown.Tag = "color:light";
			this.btnStashHistoryDown.Text = "▼";
			this.btnStashHistoryDown.UseVisualStyleBackColor = false;
			this.btnStashHistoryDown.Click += new System.EventHandler(this.btnStashHistoryDown_Click);
			// 
			// pnTargetPanel
			// 
			this.pnTargetPanel.BackColor = System.Drawing.Color.Gray;
			this.pnTargetPanel.Controls.Add(this.rbTargetMultipleFiles);
			this.pnTargetPanel.Controls.Add(this.btnClearAllBackups);
			this.pnTargetPanel.Controls.Add(this.btnResetBackup);
			this.pnTargetPanel.Controls.Add(this.rbTargetFile);
			this.pnTargetPanel.Controls.Add(this.rbTargetProcess);
			this.pnTargetPanel.Controls.Add(this.btnBrowseTarget);
			this.pnTargetPanel.Controls.Add(this.lbTarget);
			this.pnTargetPanel.Controls.Add(this.btnRestoreFileBackup);
			this.pnTargetPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTargetPanel.Location = new System.Drawing.Point(0, 0);
			this.pnTargetPanel.Name = "pnTargetPanel";
			this.pnTargetPanel.Size = new System.Drawing.Size(864, 64);
			this.pnTargetPanel.TabIndex = 39;
			this.pnTargetPanel.Tag = "color:normal";
			// 
			// rbTargetMultipleFiles
			// 
			this.rbTargetMultipleFiles.AutoSize = true;
			this.rbTargetMultipleFiles.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbTargetMultipleFiles.ForeColor = System.Drawing.Color.White;
			this.rbTargetMultipleFiles.Location = new System.Drawing.Point(101, 9);
			this.rbTargetMultipleFiles.Name = "rbTargetMultipleFiles";
			this.rbTargetMultipleFiles.Size = new System.Drawing.Size(128, 17);
			this.rbTargetMultipleFiles.TabIndex = 34;
			this.rbTargetMultipleFiles.Text = "Target Multiple Files";
			this.rbTargetMultipleFiles.UseVisualStyleBackColor = true;
			this.rbTargetMultipleFiles.CheckedChanged += new System.EventHandler(this.rbTargetMultipleFiles_CheckedChanged);
			// 
			// btnClearAllBackups
			// 
			this.btnClearAllBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearAllBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnClearAllBackups.FlatAppearance.BorderSize = 0;
			this.btnClearAllBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearAllBackups.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnClearAllBackups.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnClearAllBackups.Location = new System.Drawing.Point(745, 34);
			this.btnClearAllBackups.Name = "btnClearAllBackups";
			this.btnClearAllBackups.Size = new System.Drawing.Size(108, 23);
			this.btnClearAllBackups.TabIndex = 33;
			this.btnClearAllBackups.TabStop = false;
			this.btnClearAllBackups.Tag = "color:darker";
			this.btnClearAllBackups.Text = "Clear all Backups";
			this.btnClearAllBackups.UseVisualStyleBackColor = false;
			this.btnClearAllBackups.Click += new System.EventHandler(this.btnClearAllBackups_Click);
			// 
			// btnResetBackup
			// 
			this.btnResetBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnResetBackup.FlatAppearance.BorderSize = 0;
			this.btnResetBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResetBackup.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnResetBackup.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnResetBackup.Location = new System.Drawing.Point(745, 7);
			this.btnResetBackup.Name = "btnResetBackup";
			this.btnResetBackup.Size = new System.Drawing.Size(108, 23);
			this.btnResetBackup.TabIndex = 32;
			this.btnResetBackup.TabStop = false;
			this.btnResetBackup.Tag = "color:darker";
			this.btnResetBackup.Text = "Reset Backup";
			this.btnResetBackup.UseVisualStyleBackColor = false;
			this.btnResetBackup.Click += new System.EventHandler(this.btnResetBackup_Click);
			// 
			// cbWriteCopyMode
			// 
			this.cbWriteCopyMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbWriteCopyMode.AutoSize = true;
			this.cbWriteCopyMode.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.cbWriteCopyMode.ForeColor = System.Drawing.Color.White;
			this.cbWriteCopyMode.Location = new System.Drawing.Point(356, 57);
			this.cbWriteCopyMode.Name = "cbWriteCopyMode";
			this.cbWriteCopyMode.Size = new System.Drawing.Size(126, 17);
			this.cbWriteCopyMode.TabIndex = 34;
			this.cbWriteCopyMode.TabStop = false;
			this.cbWriteCopyMode.Text = "Write in copy mode";
			this.cbWriteCopyMode.UseVisualStyleBackColor = true;
			this.cbWriteCopyMode.CheckedChanged += new System.EventHandler(this.cbWriteCopyMode_CheckedChanged);
			// 
			// btnInjectSelected
			// 
			this.btnInjectSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnInjectSelected.FlatAppearance.BorderSize = 0;
			this.btnInjectSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInjectSelected.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnInjectSelected.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnInjectSelected.Location = new System.Drawing.Point(8, 48);
			this.btnInjectSelected.Name = "btnInjectSelected";
			this.btnInjectSelected.Size = new System.Drawing.Size(118, 24);
			this.btnInjectSelected.TabIndex = 40;
			this.btnInjectSelected.TabStop = false;
			this.btnInjectSelected.Tag = "color:darker";
			this.btnInjectSelected.Text = "Inject selected item";
			this.btnInjectSelected.UseVisualStyleBackColor = false;
			this.btnInjectSelected.Click += new System.EventHandler(this.btnInjectSelected_Click);
			// 
			// btnDisableAutoUncorrupt
			// 
			this.btnDisableAutoUncorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnDisableAutoUncorrupt.FlatAppearance.BorderSize = 0;
			this.btnDisableAutoUncorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDisableAutoUncorrupt.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnDisableAutoUncorrupt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnDisableAutoUncorrupt.Location = new System.Drawing.Point(8, 11);
			this.btnDisableAutoUncorrupt.Name = "btnDisableAutoUncorrupt";
			this.btnDisableAutoUncorrupt.Size = new System.Drawing.Size(103, 41);
			this.btnDisableAutoUncorrupt.TabIndex = 36;
			this.btnDisableAutoUncorrupt.TabStop = false;
			this.btnDisableAutoUncorrupt.Tag = "color:darker";
			this.btnDisableAutoUncorrupt.Text = "Disable Auto-Uncorrupt";
			this.btnDisableAutoUncorrupt.UseVisualStyleBackColor = false;
			this.btnDisableAutoUncorrupt.Click += new System.EventHandler(this.btnDisableAutoUncorrupt_Click);
			// 
			// btnEnableCaching
			// 
			this.btnEnableCaching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnEnableCaching.FlatAppearance.BorderSize = 0;
			this.btnEnableCaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnableCaching.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnEnableCaching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnEnableCaching.Location = new System.Drawing.Point(120, 11);
			this.btnEnableCaching.Name = "btnEnableCaching";
			this.btnEnableCaching.Size = new System.Drawing.Size(107, 40);
			this.btnEnableCaching.TabIndex = 35;
			this.btnEnableCaching.TabStop = false;
			this.btnEnableCaching.Tag = "color:darker";
			this.btnEnableCaching.Text = "Enable caching on current target";
			this.btnEnableCaching.UseVisualStyleBackColor = false;
			this.btnEnableCaching.Click += new System.EventHandler(this.btnEnableCaching_Click);
			// 
			// pnBottom
			// 
			this.pnBottom.BackColor = System.Drawing.Color.Gray;
			this.pnBottom.Controls.Add(this.btnBlastUntilEffect);
			this.pnBottom.Controls.Add(this.cbTerminateOnReExec);
			this.pnBottom.Controls.Add(this.cbWriteCopyMode);
			this.pnBottom.Controls.Add(this.rbExecuteWith);
			this.pnBottom.Controls.Add(this.rbExecuteScript);
			this.pnBottom.Controls.Add(this.rbExecuteOtherProgram);
			this.pnBottom.Controls.Add(this.btnRerollInject);
			this.pnBottom.Controls.Add(this.rbExecuteCorruptedFile);
			this.pnBottom.Controls.Add(this.rbNoExecution);
			this.pnBottom.Controls.Add(this.btnEditExec);
			this.pnBottom.Controls.Add(this.lbExecution);
			this.pnBottom.Controls.Add(this.cbInjectOnSelect);
			this.pnBottom.Controls.Add(this.btnBlastTarget);
			this.pnBottom.Controls.Add(this.btnInjectSelected);
			this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnBottom.Location = new System.Drawing.Point(0, 545);
			this.pnBottom.Name = "pnBottom";
			this.pnBottom.Size = new System.Drawing.Size(864, 80);
			this.pnBottom.TabIndex = 40;
			this.pnBottom.Tag = "color:normal";
			// 
			// btnBlastUntilEffect
			// 
			this.btnBlastUntilEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnBlastUntilEffect.FlatAppearance.BorderSize = 0;
			this.btnBlastUntilEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBlastUntilEffect.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.btnBlastUntilEffect.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnBlastUntilEffect.Location = new System.Drawing.Point(129, 7);
			this.btnBlastUntilEffect.Name = "btnBlastUntilEffect";
			this.btnBlastUntilEffect.Size = new System.Drawing.Size(100, 39);
			this.btnBlastUntilEffect.TabIndex = 50;
			this.btnBlastUntilEffect.TabStop = false;
			this.btnBlastUntilEffect.Tag = "color:darker";
			this.btnBlastUntilEffect.Text = "Blast until effect";
			this.btnBlastUntilEffect.UseVisualStyleBackColor = false;
			this.btnBlastUntilEffect.Click += new System.EventHandler(this.btnBlastUntilEffect_Click);
			this.btnBlastUntilEffect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBlastUntilEffect_MouseDown);
			// 
			// cbTerminateOnReExec
			// 
			this.cbTerminateOnReExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTerminateOnReExec.AutoSize = true;
			this.cbTerminateOnReExec.Checked = true;
			this.cbTerminateOnReExec.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTerminateOnReExec.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.cbTerminateOnReExec.ForeColor = System.Drawing.Color.White;
			this.cbTerminateOnReExec.Location = new System.Drawing.Point(489, 57);
			this.cbTerminateOnReExec.Name = "cbTerminateOnReExec";
			this.cbTerminateOnReExec.Size = new System.Drawing.Size(196, 17);
			this.cbTerminateOnReExec.TabIndex = 48;
			this.cbTerminateOnReExec.TabStop = false;
			this.cbTerminateOnReExec.Text = "Terminate Target on Re-Execution";
			this.cbTerminateOnReExec.UseVisualStyleBackColor = true;
			// 
			// rbExecuteWith
			// 
			this.rbExecuteWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExecuteWith.AutoSize = true;
			this.rbExecuteWith.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbExecuteWith.ForeColor = System.Drawing.Color.White;
			this.rbExecuteWith.Location = new System.Drawing.Point(501, 7);
			this.rbExecuteWith.Name = "rbExecuteWith";
			this.rbExecuteWith.Size = new System.Drawing.Size(90, 17);
			this.rbExecuteWith.TabIndex = 47;
			this.rbExecuteWith.Text = "Execute with";
			this.rbExecuteWith.UseVisualStyleBackColor = true;
			// 
			// rbExecuteScript
			// 
			this.rbExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExecuteScript.AutoSize = true;
			this.rbExecuteScript.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbExecuteScript.ForeColor = System.Drawing.Color.White;
			this.rbExecuteScript.Location = new System.Drawing.Point(757, 7);
			this.rbExecuteScript.Name = "rbExecuteScript";
			this.rbExecuteScript.Size = new System.Drawing.Size(54, 17);
			this.rbExecuteScript.TabIndex = 46;
			this.rbExecuteScript.Text = "Script";
			this.rbExecuteScript.UseVisualStyleBackColor = true;
			this.rbExecuteScript.Visible = false;
			this.rbExecuteScript.CheckedChanged += new System.EventHandler(this.rbExecuteScript_CheckedChanged);
			// 
			// rbExecuteOtherProgram
			// 
			this.rbExecuteOtherProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExecuteOtherProgram.AutoSize = true;
			this.rbExecuteOtherProgram.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbExecuteOtherProgram.ForeColor = System.Drawing.Color.White;
			this.rbExecuteOtherProgram.Location = new System.Drawing.Point(601, 7);
			this.rbExecuteOtherProgram.Name = "rbExecuteOtherProgram";
			this.rbExecuteOtherProgram.Size = new System.Drawing.Size(142, 17);
			this.rbExecuteOtherProgram.TabIndex = 45;
			this.rbExecuteOtherProgram.Text = "Execute other program";
			this.rbExecuteOtherProgram.UseVisualStyleBackColor = true;
			this.rbExecuteOtherProgram.CheckedChanged += new System.EventHandler(this.rbExecuteOtherProgram_CheckedChanged);
			// 
			// btnRerollInject
			// 
			this.btnRerollInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnRerollInject.FlatAppearance.BorderSize = 0;
			this.btnRerollInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRerollInject.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.btnRerollInject.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnRerollInject.Location = new System.Drawing.Point(129, 48);
			this.btnRerollInject.Name = "btnRerollInject";
			this.btnRerollInject.Size = new System.Drawing.Size(100, 24);
			this.btnRerollInject.TabIndex = 49;
			this.btnRerollInject.TabStop = false;
			this.btnRerollInject.Tag = "color:darker";
			this.btnRerollInject.Text = "Reroll + Inject";
			this.btnRerollInject.UseVisualStyleBackColor = false;
			this.btnRerollInject.Click += new System.EventHandler(this.btnRerollInject_Click);
			// 
			// rbExecuteCorruptedFile
			// 
			this.rbExecuteCorruptedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExecuteCorruptedFile.AutoSize = true;
			this.rbExecuteCorruptedFile.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbExecuteCorruptedFile.ForeColor = System.Drawing.Color.White;
			this.rbExecuteCorruptedFile.Location = new System.Drawing.Point(355, 7);
			this.rbExecuteCorruptedFile.Name = "rbExecuteCorruptedFile";
			this.rbExecuteCorruptedFile.Size = new System.Drawing.Size(137, 17);
			this.rbExecuteCorruptedFile.TabIndex = 44;
			this.rbExecuteCorruptedFile.Text = "Execute corrupted file";
			this.rbExecuteCorruptedFile.UseVisualStyleBackColor = true;
			this.rbExecuteCorruptedFile.CheckedChanged += new System.EventHandler(this.rbExecuteCorruptedFile_CheckedChanged);
			// 
			// rbNoExecution
			// 
			this.rbNoExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbNoExecution.AutoSize = true;
			this.rbNoExecution.Checked = true;
			this.rbNoExecution.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.rbNoExecution.ForeColor = System.Drawing.Color.White;
			this.rbNoExecution.Location = new System.Drawing.Point(245, 7);
			this.rbNoExecution.Name = "rbNoExecution";
			this.rbNoExecution.Size = new System.Drawing.Size(93, 17);
			this.rbNoExecution.TabIndex = 43;
			this.rbNoExecution.TabStop = true;
			this.rbNoExecution.Text = "No execution";
			this.rbNoExecution.UseVisualStyleBackColor = true;
			this.rbNoExecution.CheckedChanged += new System.EventHandler(this.rbNoExecution_CheckedChanged);
			// 
			// btnEditExec
			// 
			this.btnEditExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnEditExec.FlatAppearance.BorderSize = 0;
			this.btnEditExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditExec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnEditExec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnEditExec.Location = new System.Drawing.Point(691, 29);
			this.btnEditExec.Name = "btnEditExec";
			this.btnEditExec.Size = new System.Drawing.Size(160, 43);
			this.btnEditExec.TabIndex = 35;
			this.btnEditExec.TabStop = false;
			this.btnEditExec.Tag = "color:darker";
			this.btnEditExec.Text = "Edit Exec";
			this.btnEditExec.UseVisualStyleBackColor = false;
			this.btnEditExec.Click += new System.EventHandler(this.btnEditExec_Click);
			// 
			// lbExecution
			// 
			this.lbExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbExecution.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbExecution.ForeColor = System.Drawing.Color.Gold;
			this.lbExecution.Location = new System.Drawing.Point(242, 29);
			this.lbExecution.Name = "lbExecution";
			this.lbExecution.Padding = new System.Windows.Forms.Padding(2, 5, 1, 1);
			this.lbExecution.Size = new System.Drawing.Size(440, 23);
			this.lbExecution.TabIndex = 42;
			this.lbExecution.Tag = "color:dark";
			this.lbExecution.Text = "No execution set";
			// 
			// cbInjectOnSelect
			// 
			this.cbInjectOnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbInjectOnSelect.AutoSize = true;
			this.cbInjectOnSelect.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.cbInjectOnSelect.ForeColor = System.Drawing.Color.White;
			this.cbInjectOnSelect.Location = new System.Drawing.Point(243, 57);
			this.cbInjectOnSelect.Name = "cbInjectOnSelect";
			this.cbInjectOnSelect.Size = new System.Drawing.Size(103, 17);
			this.cbInjectOnSelect.TabIndex = 41;
			this.cbInjectOnSelect.TabStop = false;
			this.cbInjectOnSelect.Text = "Inject on select";
			this.cbInjectOnSelect.UseVisualStyleBackColor = true;
			// 
			// btnRenameSelected
			// 
			this.btnRenameSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRenameSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRenameSelected.FlatAppearance.BorderSize = 0;
			this.btnRenameSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRenameSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnRenameSelected.ForeColor = System.Drawing.Color.Black;
			this.btnRenameSelected.Location = new System.Drawing.Point(659, 405);
			this.btnRenameSelected.Name = "btnRenameSelected";
			this.btnRenameSelected.Size = new System.Drawing.Size(99, 32);
			this.btnRenameSelected.TabIndex = 42;
			this.btnRenameSelected.TabStop = false;
			this.btnRenameSelected.Tag = "color:light";
			this.btnRenameSelected.Text = "Rename Item";
			this.btnRenameSelected.UseVisualStyleBackColor = false;
			this.btnRenameSelected.Click += new System.EventHandler(this.btnRenameSelected_Click);
			// 
			// gbVectorEngineSettings
			// 
			this.gbVectorEngineSettings.Controls.Add(this.cbBigEndian);
			this.gbVectorEngineSettings.Controls.Add(this.cbVectorValueList);
			this.gbVectorEngineSettings.Controls.Add(this.label18);
			this.gbVectorEngineSettings.Controls.Add(this.cbVectorLimiterList);
			this.gbVectorEngineSettings.Controls.Add(this.label13);
			this.gbVectorEngineSettings.ForeColor = System.Drawing.Color.White;
			this.gbVectorEngineSettings.Location = new System.Drawing.Point(885, 85);
			this.gbVectorEngineSettings.Name = "gbVectorEngineSettings";
			this.gbVectorEngineSettings.Size = new System.Drawing.Size(190, 130);
			this.gbVectorEngineSettings.TabIndex = 42;
			this.gbVectorEngineSettings.TabStop = false;
			this.gbVectorEngineSettings.Visible = false;
			// 
			// cbBigEndian
			// 
			this.cbBigEndian.AutoSize = true;
			this.cbBigEndian.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbBigEndian.ForeColor = System.Drawing.Color.White;
			this.cbBigEndian.Location = new System.Drawing.Point(23, 104);
			this.cbBigEndian.Name = "cbBigEndian";
			this.cbBigEndian.Size = new System.Drawing.Size(112, 21);
			this.cbBigEndian.TabIndex = 86;
			this.cbBigEndian.TabStop = false;
			this.cbBigEndian.Text = "use Big Endian";
			this.cbBigEndian.UseVisualStyleBackColor = true;
			this.cbBigEndian.CheckedChanged += new System.EventHandler(this.cbBigEndian_CheckedChanged);
			// 
			// cbVectorValueList
			// 
			this.cbVectorValueList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cbVectorValueList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVectorValueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbVectorValueList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbVectorValueList.ForeColor = System.Drawing.Color.White;
			this.cbVectorValueList.FormattingEnabled = true;
			this.cbVectorValueList.Items.AddRange(new object[] {
            "Extended",
            "Extended+",
            "Extended-",
            "Whole",
            "Whole+",
            "Tiny",
            "One",
            "One*",
            "Two",
            "AnyFloat"});
			this.cbVectorValueList.Location = new System.Drawing.Point(16, 76);
			this.cbVectorValueList.Name = "cbVectorValueList";
			this.cbVectorValueList.Size = new System.Drawing.Size(158, 25);
			this.cbVectorValueList.TabIndex = 85;
			this.cbVectorValueList.TabStop = false;
			this.cbVectorValueList.Tag = "color:dark";
			this.cbVectorValueList.SelectedIndexChanged += new System.EventHandler(this.cbVectorValueList_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label18.Location = new System.Drawing.Point(15, 57);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(59, 17);
			this.label18.TabIndex = 84;
			this.label18.Text = "Value list";
			// 
			// cbVectorLimiterList
			// 
			this.cbVectorLimiterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cbVectorLimiterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVectorLimiterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbVectorLimiterList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.cbVectorLimiterList.ForeColor = System.Drawing.Color.White;
			this.cbVectorLimiterList.FormattingEnabled = true;
			this.cbVectorLimiterList.Items.AddRange(new object[] {
            "Extended",
            "Extended+",
            "Extended-",
            "Whole",
            "Whole+",
            "Tiny",
            "One",
            "One*",
            "Two"});
			this.cbVectorLimiterList.Location = new System.Drawing.Point(16, 28);
			this.cbVectorLimiterList.Name = "cbVectorLimiterList";
			this.cbVectorLimiterList.Size = new System.Drawing.Size(158, 25);
			this.cbVectorLimiterList.TabIndex = 82;
			this.cbVectorLimiterList.TabStop = false;
			this.cbVectorLimiterList.Tag = "color:dark";
			this.cbVectorLimiterList.SelectedIndexChanged += new System.EventHandler(this.cbVectorLimiterList_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label13.Location = new System.Drawing.Point(15, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 17);
			this.label13.TabIndex = 83;
			this.label13.Text = "Limiter list";
			// 
			// gbDefaultSettings
			// 
			this.gbDefaultSettings.ForeColor = System.Drawing.Color.White;
			this.gbDefaultSettings.Location = new System.Drawing.Point(10, 43);
			this.gbDefaultSettings.Name = "gbDefaultSettings";
			this.gbDefaultSettings.Size = new System.Drawing.Size(190, 130);
			this.gbDefaultSettings.TabIndex = 42;
			this.gbDefaultSettings.TabStop = false;
			this.gbDefaultSettings.Visible = false;
			// 
			// pnCorruptionEngine
			// 
			this.pnCorruptionEngine.BackColor = System.Drawing.Color.Gray;
			this.pnCorruptionEngine.Controls.Add(this.cbCorruptionEngine);
			this.pnCorruptionEngine.Controls.Add(this.gbDefaultSettings);
			this.pnCorruptionEngine.Location = new System.Drawing.Point(9, 352);
			this.pnCorruptionEngine.Name = "pnCorruptionEngine";
			this.pnCorruptionEngine.Size = new System.Drawing.Size(210, 184);
			this.pnCorruptionEngine.TabIndex = 114;
			this.pnCorruptionEngine.Tag = "color:normal";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.nmIntensity);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.nmStartingAddress);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.nmBlastRange);
			this.panel1.Controls.Add(this.tbBlastRange);
			this.panel1.Controls.Add(this.cbBlastRange);
			this.panel1.Controls.Add(this.tbIntensity);
			this.panel1.Controls.Add(this.tbStartingAddress);
			this.panel1.Location = new System.Drawing.Point(9, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 216);
			this.panel1.TabIndex = 114;
			this.panel1.Tag = "color:normal";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(14, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 19);
			this.label6.TabIndex = 115;
			this.label6.Text = "General Parameters";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.Gray;
			this.panel3.Controls.Add(this.btnDisableAutoUncorrupt);
			this.panel3.Controls.Add(this.btnEnableCaching);
			this.panel3.Location = new System.Drawing.Point(418, 475);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(436, 61);
			this.panel3.TabIndex = 115;
			this.panel3.Tag = "color:normal";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(421, 451);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 19);
			this.label8.TabIndex = 116;
			this.label8.Text = "Experimental stuff";
			// 
			// lbStockpile
			// 
			this.lbStockpile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbStockpile.BackColor = System.Drawing.Color.Gray;
			this.lbStockpile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbStockpile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbStockpile.ForeColor = System.Drawing.Color.White;
			this.lbStockpile.FormattingEnabled = true;
			this.lbStockpile.IntegralHeight = false;
			this.lbStockpile.ItemHeight = 17;
			this.lbStockpile.Location = new System.Drawing.Point(419, 96);
			this.lbStockpile.Name = "lbStockpile";
			this.lbStockpile.ScrollAlwaysVisible = true;
			this.lbStockpile.Size = new System.Drawing.Size(435, 306);
			this.lbStockpile.TabIndex = 2;
			this.lbStockpile.TabStop = false;
			this.lbStockpile.Tag = "color:normal";
			this.lbStockpile.SelectedIndexChanged += new System.EventHandler(this.lbStockpile_SelectedIndexChanged);
			// 
			// WGH_MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(864, 625);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnCorruptionEngine);
			this.Controls.Add(this.gbVectorEngineSettings);
			this.Controls.Add(this.btnRenameSelected);
			this.Controls.Add(this.pnBottom);
			this.Controls.Add(this.pnTargetPanel);
			this.Controls.Add(this.btnStashHistoryUp);
			this.Controls.Add(this.btnStashHistoryDown);
			this.Controls.Add(this.btnStockpileUp);
			this.Controls.Add(this.btnStockpileDown);
			this.Controls.Add(this.btnImportStockpile);
			this.Controls.Add(this.btnRemoveSelected);
			this.Controls.Add(this.gbNightmareEngineSettings);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnAddStashToStockpile);
			this.Controls.Add(this.btnStockpileMoveUp);
			this.Controls.Add(this.btnStockpileMoveDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClearStockpile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSaveStockpile);
			this.Controls.Add(this.btnSaveStockpileAs);
			this.Controls.Add(this.btnClearStashHistory);
			this.Controls.Add(this.btnLoadStockpile);
			this.Controls.Add(this.lbStashHistory);
			this.Controls.Add(this.lbStockpile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(880, 664);
			this.Name = "WGH_MainForm";
			this.Tag = "color:dark";
			this.Text = "Windows Glitch Harvester";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WGH_MainForm_FormClosing);
			this.Load += new System.EventHandler(this.WGH_MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbStartingAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmStartingAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlastRange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmBlastRange)).EndInit();
			this.gbNightmareEngineSettings.ResumeLayout(false);
			this.gbNightmareEngineSettings.PerformLayout();
			this.pnTargetPanel.ResumeLayout(false);
			this.pnTargetPanel.PerformLayout();
			this.pnBottom.ResumeLayout(false);
			this.pnBottom.PerformLayout();
			this.gbVectorEngineSettings.ResumeLayout(false);
			this.gbVectorEngineSettings.PerformLayout();
			this.pnCorruptionEngine.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlastTarget;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.Button btnLoadStockpile;
        private System.Windows.Forms.Button btnClearStashHistory;
        private System.Windows.Forms.Button btnSaveStockpileAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearStockpile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStockpileMoveDown;
        private System.Windows.Forms.Button btnStockpileMoveUp;
        private System.Windows.Forms.NumericUpDown nmIntensity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbIntensity;
        private System.Windows.Forms.TrackBar tbStartingAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmStartingAddress;
        private System.Windows.Forms.TrackBar tbBlastRange;
        private System.Windows.Forms.NumericUpDown nmBlastRange;
        private System.Windows.Forms.Button btnAddStashToStockpile;
        private System.Windows.Forms.CheckBox cbBlastRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRestoreFileBackup;
        private System.Windows.Forms.GroupBox gbNightmareEngineSettings;
        private System.Windows.Forms.ComboBox cbCorruptionEngine;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnImportStockpile;
        private System.Windows.Forms.Button btnStockpileUp;
        private System.Windows.Forms.Button btnStockpileDown;
        private System.Windows.Forms.Button btnStashHistoryUp;
        private System.Windows.Forms.Button btnStashHistoryDown;
        public RefreshingListBox lbStockpile;
        public System.Windows.Forms.ListBox lbStashHistory;
        public System.Windows.Forms.Button btnSaveStockpile;
        public System.Windows.Forms.RadioButton rbTargetFile;
        public System.Windows.Forms.RadioButton rbTargetProcess;
        private System.Windows.Forms.Panel pnTargetPanel;
        public System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Button btnClearAllBackups;
        private System.Windows.Forms.Button btnResetBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBlastType;
        private System.Windows.Forms.CheckBox cbWriteCopyMode;
        private System.Windows.Forms.Button btnInjectSelected;
        private System.Windows.Forms.CheckBox cbInjectOnSelect;
        public System.Windows.Forms.RadioButton rbExecuteOtherProgram;
        public System.Windows.Forms.RadioButton rbExecuteCorruptedFile;
        public System.Windows.Forms.RadioButton rbNoExecution;
        private System.Windows.Forms.Button btnEditExec;
        public System.Windows.Forms.Label lbExecution;
        public System.Windows.Forms.RadioButton rbExecuteScript;
        public System.Windows.Forms.RadioButton rbExecuteWith;
        private System.Windows.Forms.CheckBox cbTerminateOnReExec;
        public System.Windows.Forms.RadioButton rbTargetMultipleFiles;
        private System.Windows.Forms.Button btnEnableCaching;
        private System.Windows.Forms.Button btnDisableAutoUncorrupt;
		private System.Windows.Forms.Button btnRenameSelected;
		private System.Windows.Forms.Button btnRerollInject;
		private System.Windows.Forms.GroupBox gbVectorEngineSettings;
		public System.Windows.Forms.ComboBox cbVectorValueList;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.ComboBox cbVectorLimiterList;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox gbDefaultSettings;
		private System.Windows.Forms.Panel pnCorruptionEngine;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnBlastUntilEffect;
		private System.Windows.Forms.CheckBox cbBigEndian;
		public System.Windows.Forms.Panel pnBottom;
	}
}

