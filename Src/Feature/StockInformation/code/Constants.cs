using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.StockInformation
{
    public class Constants
    {
        public static class Views
        {
            public const string StockInformation = "~/Views/M1CP/StockInformation/StockInformation.cshtml";
            public const string StockInformationQuotes = "~/Views/M1CP/StockInformationQuotes/StockInformationQuotes.cshtml";
        }

        public static class URL
        {
            public const string APIUrl = "http://www.sgx.com/services1/xmlsubscription?subcode=B2F";
        }
    }
}