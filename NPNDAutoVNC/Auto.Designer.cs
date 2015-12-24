﻿namespace NPNDAutoVNC
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
            this.checkResetAd = new System.Windows.Forms.CheckBox();
            this.cbClickAd = new System.Windows.Forms.CheckBox();
            this.numTick = new System.Windows.Forms.NumericUpDown();
            this.checkBoxStartAndClose = new System.Windows.Forms.CheckBox();
            this.gridlist = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.btSaveList = new System.Windows.Forms.Button();
            this.labpoint = new System.Windows.Forms.Label();
            this.btGetPoint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVNCPointY = new System.Windows.Forms.TextBox();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.txtPointY = new System.Windows.Forms.TextBox();
            this.btSaveAppPoint2 = new System.Windows.Forms.Button();
            this.btResetAppPoint3 = new System.Windows.Forms.Button();
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
            this.txtListIP = new System.Windows.Forms.TextBox();
            this.ListIPCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(697, 502);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 47);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // checkResetAd
            // 
            this.checkResetAd.AutoSize = true;
            this.checkResetAd.Location = new System.Drawing.Point(6, 56);
            this.checkResetAd.Name = "checkResetAd";
            this.checkResetAd.Size = new System.Drawing.Size(84, 17);
            this.checkResetAd.TabIndex = 17;
            this.checkResetAd.Text = "Reset Ad ID";
            this.checkResetAd.UseVisualStyleBackColor = true;
            // 
            // cbClickAd
            // 
            this.cbClickAd.AutoSize = true;
            this.cbClickAd.Location = new System.Drawing.Point(7, 33);
            this.cbClickAd.Name = "cbClickAd";
            this.cbClickAd.Size = new System.Drawing.Size(65, 17);
            this.cbClickAd.TabIndex = 16;
            this.cbClickAd.Text = "Click Ad";
            this.cbClickAd.UseVisualStyleBackColor = true;
            // 
            // numTick
            // 
            this.numTick.Enabled = false;
            this.numTick.Location = new System.Drawing.Point(118, 7);
            this.numTick.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTick.Name = "numTick";
            this.numTick.Size = new System.Drawing.Size(87, 20);
            this.numTick.TabIndex = 15;
            this.numTick.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBoxStartAndClose
            // 
            this.checkBoxStartAndClose.AutoSize = true;
            this.checkBoxStartAndClose.Checked = true;
            this.checkBoxStartAndClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartAndClose.Location = new System.Drawing.Point(7, 10);
            this.checkBoxStartAndClose.Name = "checkBoxStartAndClose";
            this.checkBoxStartAndClose.Size = new System.Drawing.Size(99, 17);
            this.checkBoxStartAndClose.TabIndex = 14;
            this.checkBoxStartAndClose.Text = "Start And Close";
            this.checkBoxStartAndClose.UseVisualStyleBackColor = true;
            // 
            // gridlist
            // 
            this.gridlist.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Status,
            this.Action});
            this.gridlist.Location = new System.Drawing.Point(0, 79);
            this.gridlist.Name = "gridlist";
            this.gridlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridlist.Size = new System.Drawing.Size(747, 213);
            this.gridlist.TabIndex = 18;
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
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(616, 502);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 47);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSaveList
            // 
            this.btSaveList.Location = new System.Drawing.Point(7, 298);
            this.btSaveList.Name = "btSaveList";
            this.btSaveList.Size = new System.Drawing.Size(75, 47);
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
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 473);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridlist);
            this.tabPage1.Controls.Add(this.btSaveList);
            this.tabPage1.Controls.Add(this.checkResetAd);
            this.tabPage1.Controls.Add(this.checkBoxStartAndClose);
            this.tabPage1.Controls.Add(this.numTick);
            this.tabPage1.Controls.Add(this.cbClickAd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListIPCopy);
            this.tabPage2.Controls.Add(this.txtListIP);
            this.tabPage2.Controls.Add(this.txtVNCPointY);
            this.tabPage2.Controls.Add(this.txtPointX);
            this.tabPage2.Controls.Add(this.txtPointY);
            this.tabPage2.Controls.Add(this.btSaveAppPoint2);
            this.tabPage2.Controls.Add(this.btResetAppPoint3);
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
            this.tabPage2.Size = new System.Drawing.Size(753, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btSaveAppPoint2.Location = new System.Drawing.Point(9, 176);
            this.btSaveAppPoint2.Name = "btSaveAppPoint2";
            this.btSaveAppPoint2.Size = new System.Drawing.Size(130, 23);
            this.btSaveAppPoint2.TabIndex = 36;
            this.btSaveAppPoint2.Text = "Save App Point 2";
            this.btSaveAppPoint2.UseVisualStyleBackColor = true;
            this.btSaveAppPoint2.Click += new System.EventHandler(this.btSaveAppPoint2_Click);
            // 
            // btResetAppPoint3
            // 
            this.btResetAppPoint3.Location = new System.Drawing.Point(156, 205);
            this.btResetAppPoint3.Name = "btResetAppPoint3";
            this.btResetAppPoint3.Size = new System.Drawing.Size(130, 23);
            this.btResetAppPoint3.TabIndex = 34;
            this.btResetAppPoint3.Text = "Save Reset Point 3";
            this.btResetAppPoint3.UseVisualStyleBackColor = true;
            this.btResetAppPoint3.Click += new System.EventHandler(this.btResetAppPoint3_Click);
            // 
            // btResetAppPoint2
            // 
            this.btResetAppPoint2.Location = new System.Drawing.Point(156, 176);
            this.btResetAppPoint2.Name = "btResetAppPoint2";
            this.btResetAppPoint2.Size = new System.Drawing.Size(130, 23);
            this.btResetAppPoint2.TabIndex = 33;
            this.btResetAppPoint2.Text = "Save Reset Point 2";
            this.btResetAppPoint2.UseVisualStyleBackColor = true;
            this.btResetAppPoint2.Click += new System.EventHandler(this.btResetAppPoint2_Click);
            // 
            // btResetPoint1
            // 
            this.btResetPoint1.Location = new System.Drawing.Point(156, 147);
            this.btResetPoint1.Name = "btResetPoint1";
            this.btResetPoint1.Size = new System.Drawing.Size(130, 23);
            this.btResetPoint1.TabIndex = 32;
            this.btResetPoint1.Text = "Save Reset Point 1";
            this.btResetPoint1.UseVisualStyleBackColor = true;
            this.btResetPoint1.Click += new System.EventHandler(this.btResetPoint1_Click);
            // 
            // btSaveResetAppPoint
            // 
            this.btSaveResetAppPoint.Location = new System.Drawing.Point(156, 118);
            this.btSaveResetAppPoint.Name = "btSaveResetAppPoint";
            this.btSaveResetAppPoint.Size = new System.Drawing.Size(130, 23);
            this.btSaveResetAppPoint.TabIndex = 31;
            this.btSaveResetAppPoint.Text = "Save Rest App Point";
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
            // txtListIP
            // 
            this.txtListIP.Location = new System.Drawing.Point(455, 18);
            this.txtListIP.Multiline = true;
            this.txtListIP.Name = "txtListIP";
            this.txtListIP.Size = new System.Drawing.Size(292, 328);
            this.txtListIP.TabIndex = 40;
            // 
            // ListIPCopy
            // 
            this.ListIPCopy.Location = new System.Drawing.Point(617, 362);
            this.ListIPCopy.Name = "ListIPCopy";
            this.ListIPCopy.Size = new System.Drawing.Size(130, 23);
            this.ListIPCopy.TabIndex = 41;
            this.ListIPCopy.Text = "Copy List to IP List";
            this.ListIPCopy.UseVisualStyleBackColor = true;
            this.ListIPCopy.Click += new System.EventHandler(this.ListIPCopy_Click);
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btStart);
            this.Name = "Auto";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Auto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.CheckBox checkResetAd;
        private System.Windows.Forms.CheckBox cbClickAd;
        private System.Windows.Forms.NumericUpDown numTick;
        private System.Windows.Forms.CheckBox checkBoxStartAndClose;
        private System.Windows.Forms.DataGridView gridlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Button btSave;
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
        private System.Windows.Forms.Button btResetAppPoint3;
        private System.Windows.Forms.Button btResetAppPoint2;
        private System.Windows.Forms.Button btResetPoint1;
        private System.Windows.Forms.Button btSaveAppPoint2;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.TextBox txtPointY;
        private System.Windows.Forms.TextBox txtVNCPointY;
        private System.Windows.Forms.Button ListIPCopy;
        private System.Windows.Forms.TextBox txtListIP;
    }
}