using M1CP.Feature.ASRReports.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace M1CP.Feature.ASRReports.Scanners
{
    public class SmartHomeSolutionScanner : ASR.Interface.BaseScanner
    {
        public override ICollection Scan()
        {
            List<SmartHomeSolution> items = new List<SmartHomeSolution>();
            string storeProc = Constants.SmartHomeSolutions;
            using (DataHelper conn = new DataHelper())
            {
                var dataSet = conn.ExecDataSetProc(storeProc);
                var dataTable = new DataTable();
                dataTable = dataSet.Tables[0];
                items = conn.ConvertDataTable<SmartHomeSolution>(dataTable);
            }
            return items;
        }
    }
}