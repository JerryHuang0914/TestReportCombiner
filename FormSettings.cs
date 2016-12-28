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
    public partial class FormSettings : Form
    {
        private static FormSettings me;

        public static int Sheet_Index
        {
            get
            {
                return Convert.ToInt32(me.numSheetIndex.Value);
            }            
        }

        public static String ID_Column
        {
            get
            {
                return me.cbbIDColumn.Text;
            }
        }

        public static String Document_Column
        {
            get
            {
                return me.cbbDocumentColumn.Text;
            }
        }

        public static String Result_Column
        {
            get
            {
                return me.cbbResultColumn.Text;
            }
        }

        public static List<String> Other_Columns
        {
            get
            {
                List<String> rtnVal = new List<String>();
                foreach (String other_col in me.txtOthersColumn.Text.Split(','))
                {
                    rtnVal.Add(other_col.Trim());
                }
                return rtnVal;
            }
        }

        public static int First_Row
        {
            get
            {
                return Convert.ToInt32(me.numFirstRow.Value);
            }
        }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dataValidateion())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public static DialogResult Display(int sheet_index,int first_row,String ID_col, String document_col, String result_col, List<String> other_cols)
        {
            if (me == null)
            {
                me = new FormSettings();
            }
            me.numSheetIndex.Value = sheet_index;
            me.numFirstRow.Value = first_row;
            me.cbbIDColumn.Text = ID_col;
            me.cbbDocumentColumn.Text = document_col;
            me.cbbResultColumn.Text = result_col;
            String othersTemp = "";
            foreach (String other_col in other_cols)
            {
                othersTemp += other_col.Trim() + ",";
            }
            me.txtOthersColumn.Text = othersTemp.TrimEnd(',');

            return me.ShowDialog();
        }

        private bool dataValidateion()
        {
            cbbIDColumn.BackColor = SystemColors.Window;
            cbbResultColumn.BackColor = SystemColors.Window;
            txtOthersColumn.BackColor = SystemColors.Window;
            String rgxSingleColumn = "^[a-zA-Z]{1,2}$";
            Regex rx = new Regex(rgxSingleColumn);
            bool result = true;    
            if (!rx.Match(cbbIDColumn.Text).Success)
            {
                cbbIDColumn.BackColor = Color.IndianRed;
                result = false;
            }
            if (!rx.Match(cbbDocumentColumn.Text).Success)
            {
                cbbDocumentColumn.BackColor = Color.IndianRed;
                result = false;
            }
            if (!rx.Match(cbbResultColumn.Text).Success)
            {
                cbbResultColumn.BackColor = Color.IndianRed;
                result = false;
            }
            foreach (String subString in txtOthersColumn.Text.Split(','))
            {
                if (!rx.Match(subString).Success)
                {
                    result = false;
                    txtOthersColumn.BackColor = Color.IndianRed;
                    break;
                }
            }
            return result;
        }
    }
}
