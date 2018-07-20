using Sitecore.Data;

namespace M1CP.Feature.AnnualReports
{
    public class Templates
    {
        public struct AnnualReportListConstants
        {
            public const string TemplateIdString = "efa7de1b-b828-41bc-b72c-33715ab57d05";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Annual Report List";

            public struct Fields
            {
                public static readonly ID SelectAnnualReportsFieldId = new ID("35281d39-dd5e-4e34-977f-19c79faa6739");
                public const string SelectAnnualReportsFieldName = "Select  Annual Reports";
            }
        }

        public struct AnnualReportByDatesConstants
        {
            public const string TemplateIdString = "e20e9a5c-197f-4aaa-91de-d83d557c6704";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "AnnualReportByDates";

            public struct Fields
            {
                public static readonly ID Annual_Report_PDFFieldId = new ID("59f7e3a6-3684-41b3-81c8-7c3871473a94");
                public const string Annual_Report_PDFFieldName = "Annual Report PDF";

                public static readonly ID ImagesFieldId = new ID("90367a34-a5a9-4728-bfe8-355abd93e866");
                public const string ImagesFieldName = "Images";

                public static readonly ID Notice_Of_AGDM_PDFFieldId = new ID("95f90df4-fd4b-4342-a27b-2d74bd53ff7a");
                public const string Notice_Of_AGDM_PDFFieldName = "Notice Of AGDM PDF";

                public static readonly ID YearFieldId = new ID("61e794c7-847e-4a75-8259-2a3c0231963a");
                public const string YearFieldName = "Year";
            }
        }

        public struct InvestorContentPageConstants
        {
            public const string TemplateIdString = "43959f8f-7f42-45e7-ac39-63a1af57d9e5";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Investor Content Page";

            public struct Fields
            {
                public static readonly ID Select__Annual_ReportsFieldId = new ID("35281d39-dd5e-4e34-977f-19c79faa6739");
                public const string Select__Annual_ReportsFieldName = "Select  Annual Reports";
            }
        }
    }
}