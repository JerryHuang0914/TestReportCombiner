namespace com.usi.shd1_tools.TestReportCombiner
{
    partial class FormDetails
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
            this.lsvDetails = new System.Windows.Forms.ListView();
            this.chDetail_DocumentTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetail_TotalCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetail_PassCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetail_FailCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetail_BlockCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvDetails
            // 
            this.lsvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDetail_DocumentTitle,
            this.chDetail_TotalCount,
            this.chDetail_PassCount,
            this.chDetail_FailCount,
            this.chDetail_BlockCount});
            this.lsvDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDetails.FullRowSelect = true;
            this.lsvDetails.Location = new System.Drawing.Point(0, 0);
            this.lsvDetails.Name = "lsvDetails";
            this.lsvDetails.Size = new System.Drawing.Size(794, 398);
            this.lsvDetails.TabIndex = 0;
            this.lsvDetails.UseCompatibleStateImageBehavior = false;
            this.lsvDetails.View = System.Windows.Forms.View.Details;
            // 
            // chDetail_DocumentTitle
            // 
            this.chDetail_DocumentTitle.Text = "Document Title";
            this.chDetail_DocumentTitle.Width = 360;
            // 
            // chDetail_TotalCount
            // 
            this.chDetail_TotalCount.Text = "Total";
            this.chDetail_TotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDetail_TotalCount.Width = 100;
            // 
            // chDetail_PassCount
            // 
            this.chDetail_PassCount.Text = "Passed";
            this.chDetail_PassCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDetail_PassCount.Width = 100;
            // 
            // chDetail_FailCount
            // 
            this.chDetail_FailCount.Text = "Failed";
            this.chDetail_FailCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDetail_FailCount.Width = 100;
            // 
            // chDetail_BlockCount
            // 
            this.chDetail_BlockCount.Text = "Blocked";
            this.chDetail_BlockCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDetail_BlockCount.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            // 
            // tsmCopy
            // 
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.Size = new System.Drawing.Size(152, 22);
            this.tsmCopy.Text = "Copy";
            this.tsmCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 398);
            this.Controls.Add(this.lsvDetails);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.TopMost = true;
            this.SizeChanged += new System.EventHandler(this.FormDetails_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvDetails;
        private System.Windows.Forms.ColumnHeader chDetail_DocumentTitle;
        private System.Windows.Forms.ColumnHeader chDetail_TotalCount;
        private System.Windows.Forms.ColumnHeader chDetail_PassCount;
        private System.Windows.Forms.ColumnHeader chDetail_FailCount;
        private System.Windows.Forms.ColumnHeader chDetail_BlockCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCopy;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}