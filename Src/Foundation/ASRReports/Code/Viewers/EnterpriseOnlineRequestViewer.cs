﻿using ASR.Interface;
using System.Linq;
using Sitecore.Diagnostics;
using M1CP.Feature.ASRReports.Model;

namespace M1CP.Feature.ASRReports.Viewers
{
    public class EnterpriseOnlineRequestViewer : BaseViewer
    {
        public override string[] AvailableColumns
        {
            get
            {
                EnterpriseOnlineRequest logElement = new EnterpriseOnlineRequest();
                string[] _properties = logElement.GetType().GetProperties().Select(x => x.Name).ToArray();
                return _properties;
            }
        }
        public override void Display(DisplayElement dElement)
        {
            Assert.ArgumentNotNull(dElement, "element");
            dElement.Value = "Element Value";
            dElement.Header = "Element Name";
            EnterpriseOnlineRequest logElement =
                dElement.Element as EnterpriseOnlineRequest;
            int _increase = 0;
            if (logElement != null)
            {
                foreach (var prop in logElement.GetType().GetProperties())
                {
                    if (prop.GetValue(logElement, null) != null && Columns.Count > _increase && Columns[_increase].Header != null && Columns[_increase].Name.ToLower() == prop.Name.ToLower())
                        dElement.AddColumn(Columns[_increase].Header, prop.GetValue(logElement, null).ToString());
                    _increase = _increase + 1;
                }
            }
        }

    }
}