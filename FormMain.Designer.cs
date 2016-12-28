namespace com.usi.shd1_tools.TestReportCombiner
{
    partial class FormMain
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
            this.btnOpenOthersReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lsvReports = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chControl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseReport = new System.Windows.Forms.TextBox();
            this.btnOpenBaseReport = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsvMessages = new System.Windows.Forms.ListView();
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOthersCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResultDetail = new System.Windows.Forms.Button();
            this.txtBlockedCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFailedCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassedCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcelSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenOthersReport
            // 
            this.btnOpenOthersReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOthersReport.Location = new System.Drawing.Point(6, 3);
            this.btnOpenOthersReport.Name = "btnOpenOthersReport";
            this.btnOpenOthersReport.Size = new System.Drawing.Size(27, 27);
            this.btnOpenOthersReport.TabIndex = 5;
            this.btnOpenOthersReport.Text = "+";
            this.btnOpenOthersReport.UseVisualStyleBackColor = true;
            this.btnOpenOthersReport.Click += new System.EventHandler(this.btnOpenOthersReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Report files (Others) :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.AutoSize = false;
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(220, 16);
            this.tsProgressBar.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lsvReports
            // 
            this.lsvReports.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lsvReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chControl});
            this.lsvReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvReports.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvReports.FullRowSelect = true;
            this.lsvReports.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvReports.Location = new System.Drawing.Point(166, 0);
            this.lsvReports.Name = "lsvReports";
            this.lsvReports.ShowItemToolTips = true;
            this.lsvReports.Size = new System.Drawing.Size(645, 316);
            this.lsvReports.TabIndex = 8;
            this.lsvReports.UseCompatibleStateImageBehavior = false;
            this.lsvReports.View = System.Windows.Forms.View.Details;
            this.lsvReports.SizeChanged += new System.EventHandler(this.lsvReports_SizeChanged);
            this.lsvReports.Click += new System.EventHandler(this.lsvReports_Click);
            // 
            // chName
            // 
            this.chName.Text = "";
            this.chName.Width = 380;
            // 
            // chControl
            // 
            this.chControl.Text = "";
            this.chControl.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report file (Base) :";
            // 
            // txtBaseReport
            // 
            this.txtBaseReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseReport.Location = new System.Drawing.Point(172, 9);
            this.txtBaseReport.Name = "txtBaseReport";
            this.txtBaseReport.ReadOnly = true;
            this.txtBaseReport.Size = new System.Drawing.Size(634, 25);
            this.txtBaseReport.TabIndex = 1;
            // 
            // btnOpenBaseReport
            // 
            this.btnOpenBaseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBaseReport.Location = new System.Drawing.Point(6, 9);
            this.btnOpenBaseReport.Name = "btnOpenBaseReport";
            this.btnOpenBaseReport.Size = new System.Drawing.Size(27, 27);
            this.btnOpenBaseReport.TabIndex = 2;
            this.btnOpenBaseReport.Text = "..";
            this.btnOpenBaseReport.UseVisualStyleBackColor = true;
            this.btnOpenBaseReport.Click += new System.EventHandler(this.btnOpenBaseReport_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(723, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(83, 36);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Combine";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files|*.xlsx;*.xls";
            // 
            // lsvMessages
            // 
            this.lsvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMessage});
            this.lsvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvMessages.Location = new System.Drawing.Point(166, 0);
            this.lsvMessages.Name = "lsvMessages";
            this.lsvMessages.Size = new System.Drawing.Size(645, 182);
            this.lsvMessages.TabIndex = 10;
            this.lsvMessages.UseCompatibleStateImageBehavior = false;
            this.lsvMessages.View = System.Windows.Forms.View.Details;
            // 
            // chMessage
            // 
            this.chMessage.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Messages :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOthersCount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnResultDetail);
            this.panel2.Controls.Add(this.txtBlockedCount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFailedCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPassedCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 40);
            this.panel2.TabIndex = 13;
            // 
            // txtOthersCount
            // 
            this.txtOthersCount.ForeColor = System.Drawing.Color.Indigo;
            this.txtOthersCount.Location = new System.Drawing.Point(532, 8);
            this.txtOthersCount.Name = "txtOthersCount";
            this.txtOthersCount.ReadOnly = true;
            this.txtOthersCount.Size = new System.Drawing.Size(46, 27);
            this.txtOthersCount.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(463, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Others:";
            // 
            // btnResultDetail
            // 
            this.btnResultDetail.Enabled = false;
            this.btnResultDetail.Location = new System.Drawing.Point(596, 7);
            this.btnResultDetail.Name = "btnResultDetail";
            this.btnResultDetail.Size = new System.Drawing.Size(27, 27);
            this.btnResultDetail.TabIndex = 18;
            this.btnResultDetail.Text = "..";
            this.btnResultDetail.UseVisualStyleBackColor = true;
            this.btnResultDetail.Click += new System.EventHandler(this.btnResultDetail_Click);
            // 
            // txtBlockedCount
            // 
            this.txtBlockedCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtBlockedCount.Location = new System.Drawing.Point(411, 8);
            this.txtBlockedCount.Name = "txtBlockedCount";
            this.txtBlockedCount.ReadOnly = true;
            this.txtBlockedCount.Size = new System.Drawing.Size(46, 27);
            this.txtBlockedCount.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(342, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Blocked:";
            // 
            // txtFailedCount
            // 
            this.txtFailedCount.ForeColor = System.Drawing.Color.Crimson;
            this.txtFailedCount.Location = new System.Drawing.Point(290, 8);
            this.txtFailedCount.Name = "txtFailedCount";
            this.txtFailedCount.ReadOnly = true;
            this.txtFailedCount.Size = new System.Drawing.Size(46, 27);
            this.txtFailedCount.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(232, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Failed:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(62, 8);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(46, 27);
            this.txtTotal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total:";
            // 
            // txtPassedCount
            // 
            this.txtPassedCount.ForeColor = System.Drawing.Color.Green;
            this.txtPassedCount.Location = new System.Drawing.Point(180, 8);
            this.txtPassedCount.Name = "txtPassedCount";
            this.txtPassedCount.ReadOnly = true;
            this.txtPassedCount.Size = new System.Drawing.Size(46, 27);
            this.txtPassedCount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(115, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passed:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvReports);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvMessages);
            this.splitContainer1.Panel2.Controls.Add(this.panel8);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Size = new System.Drawing.Size(853, 502);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 316);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOpenOthersReport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(811, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 316);
            this.panel4.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(166, 182);
            this.panel8.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(811, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 182);
            this.panel7.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtBaseReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 42);
            this.panel1.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnOpenBaseReport);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(811, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 42);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 42);
            this.panel5.TabIndex = 4;
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiHelp.Image = global::com.usi.shd1_tools.TestReportCombiner.Properties.Resources.help_16;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(63, 20);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExcelSettings});
            this.tsmiSettings.Image = global::com.usi.shd1_tools.TestReportCombiner.Properties.Resources.settings_16;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(81, 20);
            this.tsmiSettings.Text = "Settings";
            // 
            // tsmiExcelSettings
            // 
            this.tsmiExcelSettings.Name = "tsmiExcelSettings";
            this.tsmiExcelSettings.Size = new System.Drawing.Size(153, 22);
            this.tsmiExcelSettings.Text = "Excel Settings";
            this.tsmiExcelSettings.Click += new System.EventHandler(this.excelColumnsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 630);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenOthersReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ListView lsvReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseReport;
        private System.Windows.Forms.Button btnOpenBaseReport;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader chControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcelSettings;
        private System.Windows.Forms.ListView lsvMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassedCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFailedCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBlockedCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResultDetail;
        private System.Windows.Forms.TextBox txtOthersCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
    }
}

