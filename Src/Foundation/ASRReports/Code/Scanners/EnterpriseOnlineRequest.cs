using M1CP.Feature.ASRReports.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace M1CP.Feature.ASRReports.Scanners
{
    public class EnterpriseOnlineRequestScanner : ASR.Interface.BaseScanner
    {
        public override ICollection Scan()
        {
            List<EnterpriseOnlineRequest> items = new List<EnterpriseOnlineRequest>();
            string storeProc = Constants.EnterpriseOnlineRequest;
            using (DataHelper conn = new DataHelper())
            {
                var dataSet = conn.ExecDataSetProc(storeProc);
                var dataTable = new DataTable();
                dataTable = dataSet.Tables[0];
                items = conn.ConvertDataTable<EnterpriseOnlineRequest>(dataTable);
            }
            return items;
        }
    }
}