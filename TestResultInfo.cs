using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.usi.shd1_tools.TestReportCombiner
{
    class TestResultInfo
    {
        public String DocumentTitle = "";
        public String TCID = "";
        public String TestResult = "";
        public Dictionary<String, String> OtherColumns = new Dictionary<string, string>();
                
        //public String GetOthersValueByColumn(String column)
        //{
        //    if (otherColumns.ContainsKey(column))
        //    {
        //        return otherColumns[column];
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
        //public void SetOthersValueByColumn(String column,String value)
        //{
        //    otherColumns.Add(column, value);
        //}
                
        public bool isDocumentTitleEquals(String title)
        {
            return DocumentTitle.Equals(title);
        }
    }
}
