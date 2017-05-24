using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace com.usi.shd1_tools.TestReportCombiner
{
    public partial class FormMain : Form
    {
        public string Title
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title.Length > 0)
                        return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public Version Version
        {
            get { return Assembly.GetCallingAssembly().GetName().Version; }
        }
        private String strConfigPath = System.AppDomain.CurrentDomain.BaseDirectory + "settings.xml";
        private String strBaseReport = "";
        private List<String> lstOthersReport = new List<String>();
        internal int SheetIndex = 1;
        internal int FirstRow = 2;
        internal String TCID_Column = "B";
        internal String Result_Column = "O";
        internal String Document_Column = "Q";
        internal List<String> Other_Columns = new List<String>(new String[] { "P" });
        private TestReport trMain;//Main Test report Excel;
        private List<String> warning_msg = new List<string>();
        private double progress = 0.0;
        private Timer tmr_ProgerssBar;
        private bool auto_import = true;

        private String CHMFile = System.AppDomain.CurrentDomain.BaseDirectory + "TestReportCombinerUserManual.chm";

        public FormMain()
        {
            InitializeComponent();
            this.Text = Title + " - V" + Version.ToString(3);
            readConfig();
        }       

        private void openOthersReport_byFolder(String folder)
        {
            lstOthersReport.Clear();
            if (auto_import)
            {
                DirectoryInfo directory = new DirectoryInfo(folder);
                FileInfo[] files = directory.GetFiles();
                var filtered = from f in files
                               where !f.Attributes.HasFlag(FileAttributes.Hidden) && !f.Name.Contains("COMBINED") && (f.Extension.Equals(".xlsx") || f.Extension.Equals(".xls"))
                               select f.FullName;
                lstOthersReport.AddRange(filtered);
                lstOthersReport.Remove(strBaseReport);
            }
            refresh_ListView_OthersReport();
        }

        private void readConfig()
        {
            try
            {
                if (File.Exists(strConfigPath))
                {
                    Other_Columns.Clear();
                    XElement xeConfig = XElement.Load(strConfigPath);
                    XElement xeExcel_settings = xeConfig.Element("excel_settins");
                    if (xeExcel_settings != null)
                    {
                        XElement xeSheetIndex = new XElement("sheet_index");
                        XElement xeFirstRow = new XElement("first_row");
                        SheetIndex = Convert.ToInt32(xeExcel_settings.Element("sheet_index").Value);
                        FirstRow = Convert.ToInt32(xeExcel_settings.Element("first_row").Value);
                        TCID_Column = xeExcel_settings.Element("id_column").Value;
                        Document_Column = xeExcel_settings.Element("document_column").Value;
                        Result_Column = xeExcel_settings.Element("result_column").Value;
                        foreach (XElement xeOthers in xeExcel_settings.Element("other_columns").Elements("other_column"))
                        {
                            Other_Columns.Add(xeOthers.Value);
                        }
                    }
                    try
                    {
                        XElement xeUI_settings = xeConfig.Element("ui_settins");
                        XElement xeAutoImport = xeUI_settings.Element("auto_import_others_report");
                        auto_import = Convert.ToBoolean(xeAutoImport.Value);
                        ckbAutoImport.Checked = auto_import;
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }

        private void updateConfig()
        {
            XElement xeConfig = new XElement("config");
            XElement xeExcel_settings = new XElement("excel_settins");
            XElement xeSheetIndex = new XElement("sheet_index");
            XElement xeFirstRow = new XElement("first_row");
            XElement xeIdColumn = new XElement("id_column");
            XElement xeDocumentColumn = new XElement("document_column");
            XElement xeResultColumn = new XElement("result_column");
            XElement xeOtherColumns = new XElement("other_columns");
            XElement xeUI_settings = new XElement("ui_settins");
            XElement xeAutoImport = new XElement("auto_import_others_report");
            xeSheetIndex.Value = SheetIndex.ToString();
            xeFirstRow.Value = FirstRow.ToString();
            xeIdColumn.Value = TCID_Column;
            xeDocumentColumn.Value = Document_Column;
            xeResultColumn.Value = Result_Column;
            foreach (String other_col in Other_Columns)
            {
                XElement xe = new XElement("other_column");
                xe.Value = other_col;
                xeOtherColumns.Add(xe);
            }
            xeExcel_settings.Add(xeSheetIndex);
            xeExcel_settings.Add(xeFirstRow);
            xeExcel_settings.Add(xeIdColumn);
            xeExcel_settings.Add(xeDocumentColumn);
            xeExcel_settings.Add(xeResultColumn);
            xeExcel_settings.Add(xeOtherColumns);
            xeAutoImport.Value = auto_import.ToString();
            xeUI_settings.Add(xeAutoImport);
            xeConfig.Add(xeExcel_settings);
            xeConfig.Add(xeUI_settings);
            xeConfig.Save(strConfigPath);
        }

        private void combine(String excelFile)
        {
            try
            {
                TestReport trTemp = new TestReport(excelFile,SheetIndex,FirstRow,TCID_Column,Result_Column,Document_Column,Other_Columns);

                var v = from trM in trMain.lstResultInfo
                        from trT in trTemp.lstResultInfo
                        where trM.TestResult.Length == 0 && trM.TCID==trT.TCID
                        select new {trM,trT};
                foreach (var v1 in v)
                {
                    if (v1.trT.TestResult.Length > 0 && v1.trM.OtherColumns.Count==0)
                    {
                        v1.trM.TestResult = v1.trT.TestResult;                       
                    }
                    foreach (KeyValuePair<String, String> kp in v1.trT.OtherColumns)
                    {
                        if (!v1.trM.OtherColumns.ContainsKey(kp.Key))
                        {
                            v1.trM.OtherColumns.Add(kp.Key, kp.Value);
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, msg_levels.Error);
            }
        }
        
        private enum msg_levels{
            Normal=0,
            Highlight=2,
            Warning=3,
            Error=4            
        }
        private void showMessage(String str)
        {
            showMessage(str, msg_levels.Normal);
        }

        private void showMessage(String str, msg_levels msg_level)
        {
            ListViewItem li = new ListViewItem(str);
            switch (msg_level)
            {
                case msg_levels.Warning:
                    li.ForeColor = Color.Orange;
                    break;
                case msg_levels.Error:
                    li.ForeColor = Color.Crimson;
                    break;
                case msg_levels.Highlight:
                    li.ForeColor = SystemColors.HotTrack;
                    break;
            }
            lsvMessages.Items.Insert(0,li);
            if (lsvMessages.Items.Count > 200)
            {
                lsvMessages.Items.RemoveAt(lsvMessages.Items.Count-1);
            }    
        }        

        private void clearMessage()
        {
            lsvMessages.Items.Clear();
        }

        #region UI control

        private void frmMain_Load(object sender, EventArgs e)
        {
            uiResized();            
        }

        private void btnOpenBaseReport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                txtBaseReport.Text = openFileDialog1.SafeFileName;
                strBaseReport = openFileDialog1.FileName;
                openOthersReport_byFolder(Path.GetDirectoryName(strBaseReport));                
                openBaseReport();
            }
        }

        private void openBaseReport()
        {
            if (trMain != null)
            {
                if (trMain.ShowMessageEventHandler != null)
                {
                    trMain.ShowMessageEventHandler -= new EventHandler<MessageEventArgs>(TestReport_ShowMessage);
                    trMain = null;
                }
            }
            try
            {
                trMain = new TestReport(strBaseReport, SheetIndex, FirstRow, TCID_Column, Result_Column, Document_Column, Other_Columns);
                trMain.ShowMessageEventHandler += new EventHandler<MessageEventArgs>(TestReport_ShowMessage);
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, msg_levels.Error);
            }
        }



        private void TestReport_ShowMessage(object sender, MessageEventArgs mea)
        {
            switch (mea.Tag)
            {
                case "WARNING":
                    showMessage(mea.Message, msg_levels.Warning);
                    break;
                case "ERROR":
                    showMessage(mea.Message, msg_levels.Error);
                    break;
                case "HIGHLIGHT":
                    showMessage(mea.Message, msg_levels.Highlight);
                    break;
                default:
                    showMessage(mea.Message, msg_levels.Warning);
                    break;
            }

        }

        private void lsvReports_Click(object sender, EventArgs e)
        {
            Point mousePos = lsvReports.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = lsvReports.HitTest(mousePos);
            int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
            if (columnIndex == chControl.Index)
            {
                lstOthersReport.RemoveAt(hitTest.Item.Index);
                hitTest.Item.Remove();
            }
        }

        private void excelColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormSettings.Display(SheetIndex,FirstRow,TCID_Column,Document_Column,Result_Column,Other_Columns).Equals(DialogResult.OK))
            {
                SheetIndex = FormSettings.Sheet_Index;
                FirstRow = FormSettings.First_Row;
                TCID_Column = FormSettings.ID_Column;
                Result_Column = FormSettings.Result_Column;
                Document_Column = FormSettings.Document_Column;
                Other_Columns.Clear();
                Other_Columns = FormSettings.Other_Columns;
                updateConfig();
                if (strBaseReport.Length > 0 && trMain != null)
                {
                    openBaseReport();
                }
            }
        }

        private void lsvReports_SizeChanged(object sender, EventArgs e)
        {
            uiResized();
        }

        private void uiResized()
        {
            //lsvReports.Width = btnOpenOthersReport.Location.X - lsvReports.Location.X - 2 * btnOpenOthersReport.Margin.All;
            //lsvReports.Height = lsvMessages.Location.Y - lsvReports.Location.Y - 2 * btnRun.Margin.All;
            //lsvMessages.Width = btnOpenOthersReport.Location.X - lsvMessages.Location.X - 2 * btnOpenOthersReport.Margin.All;
            int temp = Convert.ToInt32(this.Width * 0.3);
            tsProgressBar.Width = temp > 160 ? temp : 160;
            chName.Width = lsvReports.Width - chControl.Width - 2 * lsvReports.Margin.All;
            chMessage.Width = lsvMessages.Width - 2 * lsvMessages.Margin.All;
            int tempX = btnOpenBaseReport.PointToScreen(btnOpenBaseReport.Location).X;
            txtBaseReport.Width = tempX - txtBaseReport.Location.X - 2 * txtBaseReport.Margin.All;
        }


        private void refresh_ListView_OthersReport()
        {
            lsvReports.Items.Clear();
            for (int i = 0; i < lstOthersReport.Count; i++)
            {
                ListViewItem li = new ListViewItem(Path.GetFileName(lstOthersReport[i]));
                li.ToolTipText = lstOthersReport[i];
                li.UseItemStyleForSubItems = false;
                ListViewItem.ListViewSubItem lsi = new ListViewItem.ListViewSubItem(li, "Remove");
                lsi.ForeColor = Color.IndianRed;
                lsi.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                li.SubItems.Add(lsi);
                lsvReports.Items.Add(li);
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            uiResized();
        }

        private void btnOpenOthersReport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    if (!lstOthersReport.Exists(s => s.Equals(file)))
                    {
                        lstOthersReport.Add(file);
                    }
                }
                refresh_ListView_OthersReport();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lstOthersReport.Count > 0)
            {
                progress = 0.0;
                tsProgressBar.Value = 0;
                try
                {
                    int count = lstOthersReport.Count;
                    double partiProgress = 100 / count;
                    for (int i = 0; i < count; i++)
                    {
                        combine(lstOthersReport[i]);
                        progress+=partiProgress;
                        updateProgress(progress);
                    }
                    updateProgress(100);
                    trMain.Save();
                    int total = trMain.TotalCount;
                    int pass = trMain.PassedCount;
                    int fail = trMain.FailedCount;
                    int block = trMain.BlockedCount;
                    txtTotal.Text = total.ToString();
                    txtPassedCount.Text = pass.ToString();
                    txtFailedCount.Text = fail.ToString();
                    txtBlockedCount.Text = block.ToString();
                    txtOthersCount.Text = (total - pass - fail - block).ToString();
                    btnResultDetail.Enabled = true;
                }
                catch (Exception ex)
                {
                    showMessage(ex.Message, msg_levels.Error);
                }
            }
        }

        
        private void updateProgress(double progress)
        {
            if (tsProgressBar.Value < 100)
            {
                tsProgressBar.Visible = true;
                tsProgressBar.Value = (int)progress;
                if (progress >= 100)
                {
                    tmr_ProgerssBar = new Timer();
                    tmr_ProgerssBar.Tick += new EventHandler(progerssBarTimer_Tick);
                    tmr_ProgerssBar.Interval = 2500;
                    tmr_ProgerssBar.Start();
                }
            }
        }

        
        private void progerssBarTimer_Tick(object sender,EventArgs ea)
        {
            tmr_ProgerssBar.Tick -= new EventHandler(progerssBarTimer_Tick);
            tmr_ProgerssBar.Stop();         
            tmr_ProgerssBar = null;
            tsProgressBar.Visible = false;
        }
        
        private void btnResultDetail_Click(object sender, EventArgs e)
        {
            new FormDetails(trMain.GetDetails()).ShowDialog();
        }

        #endregion UI control

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, CHMFile, HelpNavigator.Topic);
        }

        private void ckbAutoImport_CheckedChanged(object sender, EventArgs e)
        {
            auto_import = ckbAutoImport.Checked;
            updateConfig();
        }
    }
}
