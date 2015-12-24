namespace NPNDAutoVNC
{
    partial class Form1
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
            this.gridlist = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGetPoint = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.labpoint = new System.Windows.Forms.Label();
            this.txtslapp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.timerphut = new System.Windows.Forms.Timer(this.components);
            this.txt1to24 = new System.Windows.Forms.TextBox();
            this.timerGiay = new System.Windows.Forms.Timer(this.components);
            this.timer5p = new System.Windows.Forms.Timer(this.components);
            this.timer10p = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxStartAndClose = new System.Windows.Forms.CheckBox();
            this.numTick = new System.Windows.Forms.NumericUpDown();
            this.txthight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxIsStartApp = new System.Windows.Forms.CheckBox();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtmouseX = new System.Windows.Forms.NumericUpDown();
            this.txtmouseY = new System.Windows.Forms.NumericUpDown();
            this.btsetmouse = new System.Windows.Forms.Button();
            this.btleftclick = new System.Windows.Forms.Button();
            this.btdoubleLeftclick = new System.Windows.Forms.Button();
            this.btRightClick = new System.Windows.Forms.Button();
            this.btdoublerightClcik = new System.Windows.Forms.Button();
            this.checkResetAd = new System.Windows.Forms.CheckBox();
            this.txtTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmouseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmouseY)).BeginInit();
            this.SuspendLayout();
            // 
            // gridlist
            // 
            this.gridlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Status,
            this.Action});
            this.gridlist.Location = new System.Drawing.Point(333, -2);
            this.gridlist.Name = "gridlist";
            this.gridlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridlist.Size = new System.Drawing.Size(357, 398);
            this.gridlist.TabIndex = 0;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // btGetPoint
            // 
            this.btGetPoint.Location = new System.Drawing.Point(109, 373);
            this.btGetPoint.Name = "btGetPoint";
            this.btGetPoint.Size = new System.Drawing.Size(75, 23);
            this.btGetPoint.TabIndex = 1;
            this.btGetPoint.Text = "GetPoint";
            this.btGetPoint.UseVisualStyleBackColor = true;
            this.btGetPoint.Click += new System.EventHandler(this.btGetPoint_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(15, 373);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // labpoint
            // 
            this.labpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpoint.Location = new System.Drawing.Point(381, 399);
            this.labpoint.Name = "labpoint";
            this.labpoint.Size = new System.Drawing.Size(109, 23);
            this.labpoint.TabIndex = 2;
            this.labpoint.Text = "label1";
            this.labpoint.Visible = false;
            // 
            // txtslapp
            // 
            this.txtslapp.Location = new System.Drawing.Point(64, 12);
            this.txtslapp.Name = "txtslapp";
            this.txtslapp.Size = new System.Drawing.Size(26, 20);
            this.txtslapp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count App";
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(147, 12);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(26, 20);
            this.txtwidth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(98, 236);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 47);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // timerphut
            // 
            this.timerphut.Interval = 60000;
            this.timerphut.Tick += new System.EventHandler(this.timerphut_Tick);
            // 
            // txt1to24
            // 
            this.txt1to24.Location = new System.Drawing.Point(4, 164);
            this.txt1to24.Multiline = true;
            this.txt1to24.Name = "txt1to24";
            this.txt1to24.Size = new System.Drawing.Size(198, 66);
            this.txt1to24.TabIndex = 5;
            this.txt1to24.Text = "10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10";
            // 
            // timerGiay
            // 
            this.timerGiay.Interval = 1000;
            this.timerGiay.Tick += new System.EventHandler(this.timerGiay_Tick);
            // 
            // timer5p
            // 
            this.timer5p.Interval = 300000;
            this.timer5p.Tick += new System.EventHandler(this.timer5p_Tick);
            // 
            // timer10p
            // 
            this.timer10p.Interval = 600000;
            this.timer10p.Tick += new System.EventHandler(this.timer10p_Tick);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(17, 236);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 47);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "[F1]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "[F2]";
            // 
            // checkBoxStartAndClose
            // 
            this.checkBoxStartAndClose.AutoSize = true;
            this.checkBoxStartAndClose.Checked = true;
            this.checkBoxStartAndClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartAndClose.Location = new System.Drawing.Point(4, 63);
            this.checkBoxStartAndClose.Name = "checkBoxStartAndClose";
            this.checkBoxStartAndClose.Size = new System.Drawing.Size(99, 17);
            this.checkBoxStartAndClose.TabIndex = 7;
            this.checkBoxStartAndClose.Text = "Start And Close";
            this.checkBoxStartAndClose.UseVisualStyleBackColor = true;
            this.checkBoxStartAndClose.CheckedChanged += new System.EventHandler(this.checkBoxStartAndClose_CheckedChanged);
            // 
            // numTick
            // 
            this.numTick.Enabled = false;
            this.numTick.Location = new System.Drawing.Point(115, 60);
            this.numTick.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTick.Name = "numTick";
            this.numTick.Size = new System.Drawing.Size(87, 20);
            this.numTick.TabIndex = 8;
            this.numTick.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txthight
            // 
            this.txthight.Location = new System.Drawing.Point(245, 15);
            this.txthight.Name = "txthight";
            this.txthight.Size = new System.Drawing.Size(26, 20);
            this.txthight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "[F3]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hight";
            // 
            // checkBoxIsStartApp
            // 
            this.checkBoxIsStartApp.AutoSize = true;
            this.checkBoxIsStartApp.Location = new System.Drawing.Point(4, 109);
            this.checkBoxIsStartApp.Name = "checkBoxIsStartApp";
            this.checkBoxIsStartApp.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIsStartApp.TabIndex = 9;
            this.checkBoxIsStartApp.Text = "Start app";
            this.checkBoxIsStartApp.UseVisualStyleBackColor = true;
            // 
            // timerCount
            // 
            this.timerCount.Interval = 1000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SetMouse";
            // 
            // txtmouseX
            // 
            this.txtmouseX.Location = new System.Drawing.Point(64, 310);
            this.txtmouseX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtmouseX.Name = "txtmouseX";
            this.txtmouseX.Size = new System.Drawing.Size(39, 20);
            this.txtmouseX.TabIndex = 11;
            // 
            // txtmouseY
            // 
            this.txtmouseY.Location = new System.Drawing.Point(115, 310);
            this.txtmouseY.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtmouseY.Name = "txtmouseY";
            this.txtmouseY.Size = new System.Drawing.Size(39, 20);
            this.txtmouseY.TabIndex = 11;
            // 
            // btsetmouse
            // 
            this.btsetmouse.Location = new System.Drawing.Point(167, 310);
            this.btsetmouse.Name = "btsetmouse";
            this.btsetmouse.Size = new System.Drawing.Size(45, 23);
            this.btsetmouse.TabIndex = 12;
            this.btsetmouse.Text = "Set";
            this.btsetmouse.UseVisualStyleBackColor = true;
            this.btsetmouse.Click += new System.EventHandler(this.btsetmouse_Click);
            // 
            // btleftclick
            // 
            this.btleftclick.Location = new System.Drawing.Point(13, 333);
            this.btleftclick.Name = "btleftclick";
            this.btleftclick.Size = new System.Drawing.Size(45, 21);
            this.btleftclick.TabIndex = 12;
            this.btleftclick.Text = "Left";
            this.btleftclick.UseVisualStyleBackColor = true;
            this.btleftclick.Click += new System.EventHandler(this.btleftclick_Click);
            // 
            // btdoubleLeftclick
            // 
            this.btdoubleLeftclick.Location = new System.Drawing.Point(64, 333);
            this.btdoubleLeftclick.Name = "btdoubleLeftclick";
            this.btdoubleLeftclick.Size = new System.Drawing.Size(45, 21);
            this.btdoubleLeftclick.TabIndex = 12;
            this.btdoubleLeftclick.Text = "dLeft";
            this.btdoubleLeftclick.UseVisualStyleBackColor = true;
            this.btdoubleLeftclick.Click += new System.EventHandler(this.btdoubleLeftclick_Click);
            // 
            // btRightClick
            // 
            this.btRightClick.Location = new System.Drawing.Point(116, 333);
            this.btRightClick.Name = "btRightClick";
            this.btRightClick.Size = new System.Drawing.Size(45, 21);
            this.btRightClick.TabIndex = 12;
            this.btRightClick.Text = "Right";
            this.btRightClick.UseVisualStyleBackColor = true;
            this.btRightClick.Click += new System.EventHandler(this.btRightClick_Click);
            // 
            // btdoublerightClcik
            // 
            this.btdoublerightClcik.Location = new System.Drawing.Point(167, 333);
            this.btdoublerightClcik.Name = "btdoublerightClcik";
            this.btdoublerightClcik.Size = new System.Drawing.Size(45, 21);
            this.btdoublerightClcik.TabIndex = 12;
            this.btdoublerightClcik.Text = "dRight";
            this.btdoublerightClcik.UseVisualStyleBackColor = true;
            this.btdoublerightClcik.Click += new System.EventHandler(this.btdoublerightClcik_Click);
            // 
            // checkResetAd
            // 
            this.checkResetAd.AutoSize = true;
            this.checkResetAd.Location = new System.Drawing.Point(4, 141);
            this.checkResetAd.Name = "checkResetAd";
            this.checkResetAd.Size = new System.Drawing.Size(70, 17);
            this.checkResetAd.TabIndex = 13;
            this.checkResetAd.Text = "Reset Ad";
            this.checkResetAd.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(213, 260);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(75, 23);
            this.txtTest.TabIndex = 14;
            this.txtTest.Text = "Test";
            this.txtTest.UseVisualStyleBackColor = true;
            this.txtTest.Click += new System.EventHandler(this.txtTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 431);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.checkResetAd);
            this.Controls.Add(this.btdoublerightClcik);
            this.Controls.Add(this.btRightClick);
            this.Controls.Add(this.btdoubleLeftclick);
            this.Controls.Add(this.btleftclick);
            this.Controls.Add(this.btsetmouse);
            this.Controls.Add(this.txtmouseY);
            this.Controls.Add(this.txtmouseX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxIsStartApp);
            this.Controls.Add(this.numTick);
            this.Controls.Add(this.checkBoxStartAndClose);
            this.Controls.Add(this.txt1to24);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthight);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.txtslapp);
            this.Controls.Add(this.labpoint);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btGetPoint);
            this.Controls.Add(this.gridlist);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmouseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmouseY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridlist;
        private System.Windows.Forms.Button btGetPoint;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label labpoint;
        private System.Windows.Forms.TextBox txtslapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timerphut;
        private System.Windows.Forms.TextBox txt1to24;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Timer timerGiay;
        private System.Windows.Forms.Timer timer5p;
        private System.Windows.Forms.Timer timer10p;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxStartAndClose;
        private System.Windows.Forms.NumericUpDown numTick;
        private System.Windows.Forms.TextBox txthight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxIsStartApp;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtmouseX;
        private System.Windows.Forms.NumericUpDown txtmouseY;
        private System.Windows.Forms.Button btsetmouse;
        private System.Windows.Forms.Button btleftclick;
        private System.Windows.Forms.Button btdoubleLeftclick;
        private System.Windows.Forms.Button btRightClick;
        private System.Windows.Forms.Button btdoublerightClcik;
        private System.Windows.Forms.CheckBox checkResetAd;
        private System.Windows.Forms.Button txtTest;
    }
}

