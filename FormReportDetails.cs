using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace com.usi.shd1_tools.TestReportCombiner
{
    public partial class FormDetails : Form
    {
        List<TestReportDetails_GroupByDocumentTitle> testreport_details;
        public FormDetails(List<TestReportDetails_GroupByDocumentTitle> testreport_details)
        {
            InitializeComponent();
            this.testreport_details = testreport_details;
            showData();
        }

        private void FormDetails_SizeChanged(object sender, EventArgs e)
        {
            chDetail_DocumentTitle.Width = this.Width - chDetail_TotalCount.Width - chDetail_PassCount.Width - chDetail_FailCount.Width - chDetail_BlockCount.Width - 2 * lsvDetails.Margin.All;
        }

        private void showData()
        {
            lsvDetails.Items.Clear();
            foreach (TestReportDetails_GroupByDocumentTitle trg in testreport_details)
            {
                ListViewItem li = new ListViewItem(trg.DocumentTitle);
                li.UseItemStyleForSubItems = false;
                ListViewItem.ListViewSubItem lsiTotal = new ListViewItem.ListViewSubItem(li, trg.TotalCount.ToString());             
                ListViewItem.ListViewSubItem lsiPass = new ListViewItem.ListViewSubItem(li, trg.PassedCount.ToString());
                ListViewItem.ListViewSubItem lsiFail = new ListViewItem.ListViewSubItem(li, trg.FailedCount.ToString());
                ListViewItem.ListViewSubItem lsiBlock = new ListViewItem.ListViewSubItem(li, trg.BlockedCount.ToString());
                lsiPass.ForeColor = Color.Green;
                lsiFail.ForeColor = Color.Crimson;
                lsiBlock.ForeColor = Color.OrangeRed;
                li.SubItems.Add(lsiTotal);
                li.SubItems.Add(lsiPass);
                li.SubItems.Add(lsiFail);
                li.SubItems.Add(lsiBlock);
                lsvDetails.Items.Add(li);
            }
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            //ListView.SelectedListViewItemCollection selectedItems =
            //lsvDetails.SelectedItems;
            //String text = "";
            //foreach (ListViewItem item in selectedItems)
            //{
            //    text += item.SubItems[1].Text;
            //}
            //Clipboard.SetText(text);

            Clipboard.Clear();
            StringBuilder buffer = new StringBuilder();

            // Setup the columns

            for (int i = 0; i < this.lsvDetails.Columns.Count; i++)
            {
                buffer.Append(this.lsvDetails.Columns[i].Text);
                buffer.Append("\t");
            }
            buffer.Append("\n");

            // Build the data row by row

            for (int i = 0; i < this.lsvDetails.Items.Count; i++)
            {

                for (int j = 0; j < this.lsvDetails.Columns.Count; j++)
                {
                    buffer.Append(this.lsvDetails.Items[i].SubItems[j].Text);
                    buffer.Append("\t");
                }
                buffer.Append("\n");
            }

            Clipboard.SetText(buffer.ToString());
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lsvDetails.Items)
            {
                li.Selected = true;
            }
        }
    }
}
