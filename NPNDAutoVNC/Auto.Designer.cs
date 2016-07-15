namespace NPNDAutoVNC
{
    partial class Auto
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
            this.btStart = new System.Windows.Forms.Button();
            this.cbClickAd = new System.Windows.Forms.CheckBox();
            this.gridlist = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btSaveList = new System.Windows.Forms.Button();
            this.labpoint = new System.Windows.Forms.Label();
            this.btGetPoint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbStartWindows = new System.Windows.Forms.CheckBox();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRandom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumRoundReset = new System.Windows.Forms.TextBox();
            this.checkResetHomescreen = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoundClick = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoundClickWaiting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListIPCopy = new System.Windows.Forms.Button();
            this.txtListIP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtwaitVNC = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btSaveConfig = new System.Windows.Forms.Button();
            this.WaitEachRound = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btSaveNumberRoundClickAd = new System.Windows.Forms.Button();
            this.txtNumberRoundClickAd = new System.Windows.Forms.TextBox();
            this.btSaveVNCName = new System.Windows.Forms.Button();
            this.txtVNCName = new System.Windows.Forms.TextBox();
            this.txtVNCPointY = new System.Windows.Forms.TextBox();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.txtPointY = new System.Windows.Forms.TextBox();
            this.btSaveAppPoint2 = new System.Windows.Forms.Button();
            this.btResetAppPoint2 = new System.Windows.Forms.Button();
            this.btResetPoint1 = new System.Windows.Forms.Button();
            this.btSaveResetAppPoint = new System.Windows.Forms.Button();
            this.btSaveCloseAdPoint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVNCPointX = new System.Windows.Forms.TextBox();
            this.btSaveAdPoint = new System.Windows.Forms.Button();
            this.btSaveAppPoint = new System.Windows.Forms.Button();
            this.btSaveVNCPoint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRounds = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btCoverSSH = new System.Windows.Forms.Button();
            this.btForceClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandom)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtwaitVNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitEachRound)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btStart.Location = new System.Drawing.Point(419, 407);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(127, 47);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // cbClickAd
            // 
            this.cbClickAd.AutoSize = true;
            this.cbClickAd.Checked = true;
            this.cbClickAd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClickAd.Location = new System.Drawing.Point(10, 9);
            this.cbClickAd.Name = "cbClickAd";
            this.cbClickAd.Size = new System.Drawing.Size(65, 17);
            this.cbClickAd.TabIndex = 16;
            this.cbClickAd.Text = "Click Ad";
            this.cbClickAd.UseVisualStyleBackColor = true;
            // 
            // gridlist
            // 
            this.gridlist.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Status,
            this.Action,
            this.Run});
            this.gridlist.Location = new System.Drawing.Point(289, 38);
            this.gridlist.Name = "gridlist";
            this.gridlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridlist.Size = new System.Drawing.Size(251, 298);
            this.gridlist.TabIndex = 18;
            this.gridlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridlist_CellContentClick);
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.Width = 50;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Width = 50;
            // 
            // Run
            // 
            this.Run.HeaderText = "Test";
            this.Run.Name = "Run";
            this.Run.Text = "Run";
            this.Run.Width = 50;
            // 
            // btSaveList
            // 
            this.btSaveList.Location = new System.Drawing.Point(462, 347);
            this.btSaveList.Name = "btSaveList";
            this.btSaveList.Size = new System.Drawing.Size(75, 27);
            this.btSaveList.TabIndex = 20;
            this.btSaveList.Text = "Save List";
            this.btSaveList.UseVisualStyleBackColor = true;
            this.btSaveList.Click += new System.EventHandler(this.btSaveList_Click);
            // 
            // labpoint
            // 
            this.labpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpoint.Location = new System.Drawing.Point(87, 19);
            this.labpoint.Name = "labpoint";
            this.labpoint.Size = new System.Drawing.Size(109, 23);
            this.labpoint.TabIndex = 21;
            // 
            // btGetPoint
            // 
            this.btGetPoint.Location = new System.Drawing.Point(6, 16);
            this.btGetPoint.Name = "btGetPoint";
            this.btGetPoint.Size = new System.Drawing.Size(75, 23);
            this.btGetPoint.TabIndex = 22;
            this.btGetPoint.Text = "GetPoint";
            this.btGetPoint.UseVisualStyleBackColor = true;
            this.btGetPoint.Click += new System.EventHandler(this.btGetPoint_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 403);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStartWindows);
            this.tabPage1.Controls.Add(this.cbAutoStart);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.gridlist);
            this.tabPage1.Controls.Add(this.btSaveList);
            this.tabPage1.Controls.Add(this.ListIPCopy);
            this.tabPage1.Controls.Add(this.txtListIP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbStartWindows
            // 
            this.cbStartWindows.AutoSize = true;
            this.cbStartWindows.Location = new System.Drawing.Point(81, 319);
            this.cbStartWindows.Name = "cbStartWindows";
            this.cbStartWindows.Size = new System.Drawing.Size(92, 17);
            this.cbStartWindows.TabIndex = 54;
            this.cbStartWindows.Text = "Start with Win";
            this.cbStartWindows.UseVisualStyleBackColor = true;
            this.cbStartWindows.CheckedChanged += new System.EventHandler(this.cbStartWindows_CheckedChanged);
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(10, 319);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(73, 17);
            this.cbAutoStart.TabIndex = 53;
            this.cbAutoStart.Text = "Auto Start";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.cbAutoStart_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRandom);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtNumRoundReset);
            this.panel2.Controls.Add(this.checkResetHomescreen);
            this.panel2.Location = new System.Drawing.Point(12, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 123);
            this.panel2.TabIndex = 45;
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(6, 85);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(120, 20);
            this.txtRandom.TabIndex = 49;
            this.txtRandom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Random App";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Num round reset";
            // 
            // txtNumRoundReset
            // 
            this.txtNumRoundReset.Location = new System.Drawing.Point(5, 39);
            this.txtNumRoundReset.Name = "txtNumRoundReset";
            this.txtNumRoundReset.Size = new System.Drawing.Size(65, 20);
            this.txtNumRoundReset.TabIndex = 47;
            this.txtNumRoundReset.Text = "3";
            // 
            // checkResetHomescreen
            // 
            this.checkResetHomescreen.AutoSize = true;
            this.checkResetHomescreen.Checked = true;
            this.checkResetHomescreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkResetHomescreen.Location = new System.Drawing.Point(3, 3);
            this.checkResetHomescreen.Name = "checkResetHomescreen";
            this.checkResetHomescreen.Size = new System.Drawing.Size(73, 17);
            this.checkResetHomescreen.TabIndex = 47;
            this.checkResetHomescreen.Text = "Reset Ad ";
            this.checkResetHomescreen.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "IP Text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRoundClick);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRoundClickWaiting);
            this.panel1.Controls.Add(this.cbClickAd);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 140);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Num Round Click";
            // 
            // txtRoundClick
            // 
            this.txtRoundClick.Location = new System.Drawing.Point(10, 94);
            this.txtRoundClick.Name = "txtRoundClick";
            this.txtRoundClick.Size = new System.Drawing.Size(65, 20);
            this.txtRoundClick.TabIndex = 45;
            this.txtRoundClick.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Round Wait time";
            // 
            // txtRoundClickWaiting
            // 
            this.txtRoundClickWaiting.Location = new System.Drawing.Point(10, 48);
            this.txtRoundClickWaiting.Name = "txtRoundClickWaiting";
            this.txtRoundClickWaiting.Size = new System.Drawing.Size(65, 20);
            this.txtRoundClickWaiting.TabIndex = 43;
            this.txtRoundClickWaiting.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "IP List";
            // 
            // ListIPCopy
            // 
            this.ListIPCopy.Location = new System.Drawing.Point(179, 343);
            this.ListIPCopy.Name = "ListIPCopy";
            this.ListIPCopy.Size = new System.Drawing.Size(104, 32);
            this.ListIPCopy.TabIndex = 41;
            this.ListIPCopy.Text = "Copy List to IP List";
            this.ListIPCopy.UseVisualStyleBackColor = true;
            this.ListIPCopy.Click += new System.EventHandler(this.ListIPCopy_Click);
            // 
            // txtListIP
            // 
            this.txtListIP.Location = new System.Drawing.Point(179, 38);
            this.txtListIP.Multiline = true;
            this.txtListIP.Name = "txtListIP";
            this.txtListIP.Size = new System.Drawing.Size(104, 297);
            this.txtListIP.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtwaitVNC);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btSaveConfig);
            this.tabPage2.Controls.Add(this.WaitEachRound);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btSaveNumberRoundClickAd);
            this.tabPage2.Controls.Add(this.txtNumberRoundClickAd);
            this.tabPage2.Controls.Add(this.btSaveVNCName);
            this.tabPage2.Controls.Add(this.txtVNCName);
            this.tabPage2.Controls.Add(this.txtVNCPointY);
            this.tabPage2.Controls.Add(this.txtPointX);
            this.tabPage2.Controls.Add(this.txtPointY);
            this.tabPage2.Controls.Add(this.btSaveAppPoint2);
            this.tabPage2.Controls.Add(this.btResetAppPoint2);
            this.tabPage2.Controls.Add(this.btResetPoint1);
            this.tabPage2.Controls.Add(this.btSaveResetAppPoint);
            this.tabPage2.Controls.Add(this.btSaveCloseAdPoint);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtVNCPointX);
            this.tabPage2.Controls.Add(this.btSaveAdPoint);
            this.tabPage2.Controls.Add(this.btSaveAppPoint);
            this.tabPage2.Controls.Add(this.btSaveVNCPoint);
            this.tabPage2.Controls.Add(this.btGetPoint);
            this.tabPage2.Controls.Add(this.labpoint);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtwaitVNC
            // 
            this.txtwaitVNC.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtwaitVNC.Location = new System.Drawing.Point(156, 351);
            this.txtwaitVNC.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.txtwaitVNC.Name = "txtwaitVNC";
            this.txtwaitVNC.Size = new System.Drawing.Size(120, 20);
            this.txtwaitVNC.TabIndex = 57;
            this.txtwaitVNC.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Wait time open VNC";
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.Location = new System.Drawing.Point(407, 335);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(130, 36);
            this.btSaveConfig.TabIndex = 55;
            this.btSaveConfig.Text = "Save config";
            this.btSaveConfig.UseVisualStyleBackColor = true;
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveWaitEachRound_Click);
            // 
            // WaitEachRound
            // 
            this.WaitEachRound.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WaitEachRound.Location = new System.Drawing.Point(12, 351);
            this.WaitEachRound.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.WaitEachRound.Name = "WaitEachRound";
            this.WaitEachRound.Size = new System.Drawing.Size(120, 20);
            this.WaitEachRound.TabIndex = 54;
            this.WaitEachRound.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Wait each Round";
            // 
            // btSaveNumberRoundClickAd
            // 
            this.btSaveNumberRoundClickAd.Location = new System.Drawing.Point(6, 307);
            this.btSaveNumberRoundClickAd.Name = "btSaveNumberRoundClickAd";
            this.btSaveNumberRoundClickAd.Size = new System.Drawing.Size(130, 23);
            this.btSaveNumberRoundClickAd.TabIndex = 45;
            this.btSaveNumberRoundClickAd.Text = "NumberRoundClickAd";
            this.btSaveNumberRoundClickAd.UseVisualStyleBackColor = true;
            this.btSaveNumberRoundClickAd.Click += new System.EventHandler(this.btSaveNumberRoundClickAd_Click);
            // 
            // txtNumberRoundClickAd
            // 
            this.txtNumberRoundClickAd.Location = new System.Drawing.Point(156, 309);
            this.txtNumberRoundClickAd.Name = "txtNumberRoundClickAd";
            this.txtNumberRoundClickAd.Size = new System.Drawing.Size(100, 20);
            this.txtNumberRoundClickAd.TabIndex = 44;
            // 
            // btSaveVNCName
            // 
            this.btSaveVNCName.Location = new System.Drawing.Point(6, 281);
            this.btSaveVNCName.Name = "btSaveVNCName";
            this.btSaveVNCName.Size = new System.Drawing.Size(130, 23);
            this.btSaveVNCName.TabIndex = 43;
            this.btSaveVNCName.Text = "Save VNC Name";
            this.btSaveVNCName.UseVisualStyleBackColor = true;
            this.btSaveVNCName.Click += new System.EventHandler(this.btSaveVNCName_Click);
            // 
            // txtVNCName
            // 
            this.txtVNCName.Location = new System.Drawing.Point(156, 283);
            this.txtVNCName.Name = "txtVNCName";
            this.txtVNCName.Size = new System.Drawing.Size(288, 20);
            this.txtVNCName.TabIndex = 42;
            this.txtVNCName.Text = "vncviewer";
            // 
            // txtVNCPointY
            // 
            this.txtVNCPointY.Location = new System.Drawing.Point(220, 85);
            this.txtVNCPointY.Name = "txtVNCPointY";
            this.txtVNCPointY.Size = new System.Drawing.Size(58, 20);
            this.txtVNCPointY.TabIndex = 39;
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(15, 85);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(47, 20);
            this.txtPointX.TabIndex = 38;
            // 
            // txtPointY
            // 
            this.txtPointY.Location = new System.Drawing.Point(68, 85);
            this.txtPointY.Name = "txtPointY";
            this.txtPointY.Size = new System.Drawing.Size(47, 20);
            this.txtPointY.TabIndex = 37;
            // 
            // btSaveAppPoint2
            // 
            this.btSaveAppPoint2.Location = new System.Drawing.Point(7, 176);
            this.btSaveAppPoint2.Name = "btSaveAppPoint2";
            this.btSaveAppPoint2.Size = new System.Drawing.Size(130, 23);
            this.btSaveAppPoint2.TabIndex = 36;
            this.btSaveAppPoint2.Text = "Save App Point 2";
            this.btSaveAppPoint2.UseVisualStyleBackColor = true;
            this.btSaveAppPoint2.Click += new System.EventHandler(this.btSaveAppPoint2_Click);
            // 
            // btResetAppPoint2
            // 
            this.btResetAppPoint2.Location = new System.Drawing.Point(156, 176);
            this.btResetAppPoint2.Name = "btResetAppPoint2";
            this.btResetAppPoint2.Size = new System.Drawing.Size(130, 23);
            this.btResetAppPoint2.TabIndex = 33;
            this.btResetAppPoint2.Text = "Save Ad Point 2";
            this.btResetAppPoint2.UseVisualStyleBackColor = true;
            this.btResetAppPoint2.Click += new System.EventHandler(this.btResetAppPoint2_Click);
            // 
            // btResetPoint1
            // 
            this.btResetPoint1.Location = new System.Drawing.Point(156, 147);
            this.btResetPoint1.Name = "btResetPoint1";
            this.btResetPoint1.Size = new System.Drawing.Size(130, 23);
            this.btResetPoint1.TabIndex = 32;
            this.btResetPoint1.Text = "Save Ad Point 1";
            this.btResetPoint1.UseVisualStyleBackColor = true;
            this.btResetPoint1.Click += new System.EventHandler(this.btResetPoint1_Click);
            // 
            // btSaveResetAppPoint
            // 
            this.btSaveResetAppPoint.Location = new System.Drawing.Point(156, 118);
            this.btSaveResetAppPoint.Name = "btSaveResetAppPoint";
            this.btSaveResetAppPoint.Size = new System.Drawing.Size(130, 23);
            this.btSaveResetAppPoint.TabIndex = 31;
            this.btSaveResetAppPoint.Text = "Save Ad Point";
            this.btSaveResetAppPoint.UseVisualStyleBackColor = true;
            this.btSaveResetAppPoint.Click += new System.EventHandler(this.btSaveResetAppPoint_Click);
            // 
            // btSaveCloseAdPoint
            // 
            this.btSaveCloseAdPoint.Location = new System.Drawing.Point(6, 234);
            this.btSaveCloseAdPoint.Name = "btSaveCloseAdPoint";
            this.btSaveCloseAdPoint.Size = new System.Drawing.Size(130, 23);
            this.btSaveCloseAdPoint.TabIndex = 30;
            this.btSaveCloseAdPoint.Text = "Save Close App Point";
            this.btSaveCloseAdPoint.UseVisualStyleBackColor = true;
            this.btSaveCloseAdPoint.Click += new System.EventHandler(this.btSaveCloseAdPoint_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Point form VNC";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "System Point";
            // 
            // txtVNCPointX
            // 
            this.txtVNCPointX.Location = new System.Drawing.Point(156, 85);
            this.txtVNCPointX.Name = "txtVNCPointX";
            this.txtVNCPointX.Size = new System.Drawing.Size(58, 20);
            this.txtVNCPointX.TabIndex = 27;
            // 
            // btSaveAdPoint
            // 
            this.btSaveAdPoint.Location = new System.Drawing.Point(6, 205);
            this.btSaveAdPoint.Name = "btSaveAdPoint";
            this.btSaveAdPoint.Size = new System.Drawing.Size(130, 23);
            this.btSaveAdPoint.TabIndex = 26;
            this.btSaveAdPoint.Text = "Save Ad Point";
            this.btSaveAdPoint.UseVisualStyleBackColor = true;
            this.btSaveAdPoint.Click += new System.EventHandler(this.btSaveAdPoint_Click);
            // 
            // btSaveAppPoint
            // 
            this.btSaveAppPoint.Location = new System.Drawing.Point(6, 147);
            this.btSaveAppPoint.Name = "btSaveAppPoint";
            this.btSaveAppPoint.Size = new System.Drawing.Size(130, 23);
            this.btSaveAppPoint.TabIndex = 25;
            this.btSaveAppPoint.Text = "Save App Point";
            this.btSaveAppPoint.UseVisualStyleBackColor = true;
            this.btSaveAppPoint.Click += new System.EventHandler(this.btSaveAppPoint_Click);
            // 
            // btSaveVNCPoint
            // 
            this.btSaveVNCPoint.Location = new System.Drawing.Point(9, 118);
            this.btSaveVNCPoint.Name = "btSaveVNCPoint";
            this.btSaveVNCPoint.Size = new System.Drawing.Size(127, 23);
            this.btSaveVNCPoint.TabIndex = 24;
            this.btSaveVNCPoint.Text = "Save VNC Point";
            this.btSaveVNCPoint.UseVisualStyleBackColor = true;
            this.btSaveVNCPoint.Click += new System.EventHandler(this.btSaveVNCPoint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rounds:";
            // 
            // lbRounds
            // 
            this.lbRounds.AutoSize = true;
            this.lbRounds.Location = new System.Drawing.Point(63, 411);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(13, 13);
            this.lbRounds.TabIndex = 26;
            this.lbRounds.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "v 1.07";
            // 
            // btCoverSSH
            // 
            this.btCoverSSH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btCoverSSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCoverSSH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCoverSSH.Location = new System.Drawing.Point(198, 407);
            this.btCoverSSH.Name = "btCoverSSH";
            this.btCoverSSH.Size = new System.Drawing.Size(204, 47);
            this.btCoverSSH.TabIndex = 28;
            this.btCoverSSH.Text = "Cover SSH";
            this.btCoverSSH.UseVisualStyleBackColor = false;
            this.btCoverSSH.Click += new System.EventHandler(this.btCoverSSH_Click);
            // 
            // btForceClose
            // 
            this.btForceClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btForceClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForceClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btForceClose.Location = new System.Drawing.Point(66, 407);
            this.btForceClose.Name = "btForceClose";
            this.btForceClose.Size = new System.Drawing.Size(127, 47);
            this.btForceClose.TabIndex = 29;
            this.btForceClose.Text = "Force Close";
            this.btForceClose.UseVisualStyleBackColor = false;
            this.btForceClose.Click += new System.EventHandler(this.btForceClose_Click);
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 476);
            this.Controls.Add(this.btForceClose);
            this.Controls.Add(this.btCoverSSH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbRounds);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btStart);
            this.Name = "Auto";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Auto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtwaitVNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitEachRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.CheckBox cbClickAd;
        private System.Windows.Forms.DataGridView gridlist;
        private System.Windows.Forms.Button btSaveList;
        private System.Windows.Forms.Label labpoint;
        private System.Windows.Forms.Button btGetPoint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btSaveResetAppPoint;
        private System.Windows.Forms.Button btSaveCloseAdPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVNCPointX;
        private System.Windows.Forms.Button btSaveAdPoint;
        private System.Windows.Forms.Button btSaveAppPoint;
        private System.Windows.Forms.Button btSaveVNCPoint;
        private System.Windows.Forms.Button btResetAppPoint2;
        private System.Windows.Forms.Button btResetPoint1;
        private System.Windows.Forms.Button btSaveAppPoint2;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.TextBox txtPointY;
        private System.Windows.Forms.TextBox txtVNCPointY;
        private System.Windows.Forms.Button ListIPCopy;
        private System.Windows.Forms.TextBox txtListIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRounds;
        private System.Windows.Forms.Button btSaveVNCName;
        private System.Windows.Forms.TextBox txtVNCName;
        private System.Windows.Forms.Button btSaveNumberRoundClickAd;
        private System.Windows.Forms.TextBox txtNumberRoundClickAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoundClickWaiting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoundClick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.CheckBox checkResetHomescreen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumRoundReset;
        private System.Windows.Forms.NumericUpDown txtRandom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.CheckBox cbStartWindows;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btCoverSSH;
        public System.Windows.Forms.NumericUpDown WaitEachRound;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btSaveConfig;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown txtwaitVNC;
        private System.Windows.Forms.Button btForceClose;
    }
}