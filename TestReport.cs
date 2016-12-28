using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells;

namespace com.usi.shd1_tools.TestReportCombiner
{
    class TestReport
    {
        private String strPath = "";
        public List<TestResultInfo> lstResultInfo = new List<TestResultInfo>();
        public TestReport(String excelFile,int sheetIndex,int firstRow,String tcid_column,String result_column,String document_column,List<String>other_columns)
        {
            strPath = excelFile;
            SheetIndex = sheetIndex;
            FirstRow = firstRow;
            TCID_Column = tcid_column;
            Result_Column = result_column;
            Document_Column = document_column;
            Other_Columns = other_columns;
            read();
        }

        public EventHandler<MessageEventArgs> ShowMessageEventHandler;

        private int SheetIndex = 1;
        private int FirstRow = 2;
        private String TCID_Column = "";
        private String Result_Column = "";
        private String Document_Column = "";
        private List<String> Other_Columns = new List<String>();

        private void read()
        {
            lstResultInfo.Clear();
            Workbook workBook1;
            Worksheet workSheet1;
            #region Get index numbers of target columns
            int iTCID_Col = convert_column_name_to_integer(TCID_Column);
            int iResult_Col = convert_column_name_to_integer(Result_Column);
            int iDucument_Col = convert_column_name_to_integer(Document_Column);
            int[] iOther_Cols =  new int[Other_Columns.Count];
            for (int i = 0; i < iOther_Cols.Length; i++)
            {
                iOther_Cols[i] = convert_column_name_to_integer(Other_Columns[i]);
            }
            #endregion Get index numbers of target columns
            int rowIndex = FirstRow > 0 ? FirstRow - 1 : 0;
            int sheetIndex = SheetIndex > 0 ? SheetIndex - 1 : 0;
            try
            {
                workBook1 = new Workbook(strPath);
                workSheet1 = workBook1.Worksheets[sheetIndex];                
                for (; rowIndex < workSheet1.Cells.Rows.Count; rowIndex++)
                {
                    TestResultInfo trInfo = new TestResultInfo();
                    Cell cellTcid = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iTCID_Col);
                    Cell cellResult = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iResult_Col);
                    Cell cellDocument = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iDucument_Col);
                    trInfo.TCID = cellTcid == null || cellTcid.Value == null ? "" : cellTcid.Value.ToString();
                    trInfo.TestResult = cellResult == null || cellResult.Value == null ? "" : cellResult.Value.ToString();
                    trInfo.DocumentTitle = cellDocument == null || cellDocument.Value == null ? "" : cellDocument.Value.ToString();
                    for (int i = 0; i < iOther_Cols.Length; i++)
                    {
                        Cell cellOther = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iOther_Cols[i]);
                        String temp = cellOther == null || cellOther.Value == null ? "" : cellOther.Value.ToString();
                        if (temp.Length > 0)
                        {
                            trInfo.OtherColumns.Add(Other_Columns[i], temp);
                        }
                    }
                    lstResultInfo.Add(trInfo);
                }                
            }
            catch (Exception ex)
            {
                throw (new Exception(strPath + " does NOT parse successfully; message = " + ex.Message));
            }
            finally
            {
                workSheet1 = null;
                workBook1 = null;
            }
        }

        internal void Save()
        {
            String combinedPath = "";
            Workbook workBook1;
            Worksheet workSheet1;
            #region Get index numbers of target columns
            int iTCID_Col = convert_column_name_to_integer(TCID_Column);
            int iResult_Col = convert_column_name_to_integer(Result_Column);
            int iDucument_Col = convert_column_name_to_integer(Document_Column);
            int[] iOther_Cols = new int[Other_Columns.Count];
            for (int i = 0; i < iOther_Cols.Length; i++)
            {
                iOther_Cols[i] = convert_column_name_to_integer(Other_Columns[i]);
            }
            #endregion Get index numbers of target columns
            int sheetIndex = SheetIndex > 0 ? SheetIndex - 1 : 0;

            workBook1 = new Workbook(strPath);
            workSheet1 = workBook1.Worksheets[sheetIndex];
            for (int index = 0; index < lstResultInfo.Count; index++)
            {
                bool tcid_found = false;
                Cell cellTcid;
                int rowIndex = FirstRow - 1;
                #region Match the TCID between TestResultInfo and Excel rows
                for (; rowIndex < workSheet1.Cells.Rows.Count; rowIndex++)
                {
                    cellTcid = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iTCID_Col);
                    if (cellTcid != null && cellTcid.Value != null && lstResultInfo[index].TCID == cellTcid.StringValue)
                    {
                        tcid_found = true;
                        break;
                    }
                }
                #endregion Match the TCID between TestResultInfo and Excel rows
                if (tcid_found)
                {
                    Cell cellResult = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iResult_Col);
                    cellResult.Value = lstResultInfo[index].TestResult;
                    for (int i = 0; i < iOther_Cols.Length; i++)
                    {
                        Cell cellOther = workSheet1.Cells.Rows[rowIndex].GetCellOrNull(iOther_Cols[i]);
                        String otherValue = "";
                        if(lstResultInfo[index].OtherColumns.TryGetValue(Other_Columns[i],out otherValue))
                        {
                            cellOther.Value = otherValue;
                        }
                    }
                }
                else
                {
                    if (ShowMessageEventHandler != null)
                    {
                        ShowMessageEventHandler.Invoke(this, new MessageEventArgs("WARNING", "TCID:" + lstResultInfo[index].TCID + "does not match to original file, can't save back to excel"));
                    }
                }
            }
            try
            {
                String timestamp = DateTime.Now.ToString("yyyy_MM_dd_HH");
                combinedPath = strPath.Replace(System.IO.Path.GetExtension(strPath), "") +"_"+timestamp+"_COMBINED" + System.IO.Path.GetExtension(strPath);
                workBook1.Save(combinedPath);
            }
            catch (Exception ex1)
            {
                combinedPath = "";
                ShowMessageEventHandler.Invoke(this, new MessageEventArgs("ERROR", strPath + " does NOT save successfully!! Message= " + ex1.Message));
                //throw (new Exception(strPath + " does NOT save successfully!! Message= " + ex1.Message));
            }
            workSheet1 = null;
            workBook1 = null;
            ShowMessageEventHandler.Invoke(this, new MessageEventArgs("HIGHLIGHT","Excels are combined successfully @" + combinedPath));
        }

        private int convert_column_name_to_integer(String col_name)
        {
            int result = 0;
            int temp = 0;
            col_name = col_name.ToUpper();
            for (int i = 0; i < col_name.Length; i++)
            {
                temp = ((char)col_name[col_name.Length - i - 1]) - 'A' + 1;
                result += Convert.ToInt32(temp * Math.Pow(26, i));
            }
            return result - 1;
        }

        public int TotalCount
        {
            get
            {
                return lstResultInfo.Count;
            }
        }

        public int PassedCount
        {
            get
            {
                var v = lstResultInfo.Where(r => r.TestResult.ToUpper().Equals("PASSED") || r.TestResult.ToUpper().Equals("P"));
                return v.Count();
            }
        }

        public int FailedCount
        {
            get
            {
                var v = lstResultInfo.Where(r => r.TestResult.ToUpper().Equals("FAILED") || r.TestResult.ToUpper().Equals("F"));
                return v.Count();
            }
        }

        public int BlockedCount
        {
            get
            {
                var v = lstResultInfo.Where(r => r.TestResult.ToUpper().Equals("BLOCKED") || r.TestResult.ToUpper().Equals("B"));
                return v.Count();
            }
        }

        public List<TestReportDetails_GroupByDocumentTitle> GetDetails()
        {
            List<TestReportDetails_GroupByDocumentTitle> rtnVal = new List<TestReportDetails_GroupByDocumentTitle>();
            var groups = from doc_group in lstResultInfo
                         group doc_group by doc_group.DocumentTitle;
            foreach (var grp in groups)
            {
                TestReportDetails_GroupByDocumentTitle tg = new TestReportDetails_GroupByDocumentTitle();
                tg.DocumentTitle = grp.Key;
                tg.TotalCount = grp.Count();
                tg.PassedCount = grp.Where(tr => (tr.TestResult.ToUpper().Equals("PASSED") || tr.TestResult.ToUpper().Equals("P"))).Count();
                tg.FailedCount = grp.Where(tr => tr.TestResult.ToUpper().Equals("FAILED") || tr.TestResult.ToUpper().Equals("F")).Count();
                tg.BlockedCount = grp.Where(tr => tr.TestResult.ToUpper().Equals("BLOCKED") || tr.TestResult.ToUpper().Equals("B")).Count();
                rtnVal.Add(tg);
            }
            return rtnVal;
        }    
    }
    class MessageEventArgs : EventArgs{
        public String Tag = "";        
        public String Message ="";        
        public MessageEventArgs(String tag,String message){
            Tag = tag;
            Message = message;
        }
    }

    public class TestReportDetails_GroupByDocumentTitle
    {
        internal String DocumentTitle = "";
        internal int TotalCount = 0;
        internal int PassedCount = 0;
        internal int FailedCount = 0;
        internal int BlockedCount = 0;
    }
}
