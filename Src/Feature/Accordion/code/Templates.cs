using Sitecore.Data;

namespace M1CP.Feature.Accordion
{
    public struct Templates
    {
        public struct FinancialReleaseFiles
        {            
            public const string TemplateIdString = "8681C903-1C44-4121-AFD3-3066831EA335";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_FinancialReleaseFiles";

            public struct Fields
            {                               
                public static readonly ID ReleaseTitleFieldId = new ID("3EC5C073-4186-4E44-8CC8-0D9A8396D75B");
                public const string ReleaseTitleFieldName = "Release Title";

                public static readonly ID ReleaseImageFieldId = new ID("A7D6B987-75F8-4CD1-B11D-8B1779053C59");
                public const string ReleaseImageFieldName = "Release Image";

                public static readonly ID ReleaseFileFieldId = new ID("EA4B37DC-C889-4607-A314-10EE86057E6D");
                public const string ReleaseFileFieldName = "Release File";
            }
        }
        public struct FinancialResultsFolder
        {
            public const string TemplateIdString = "{E7743769-1B67-4AE3-B698-8665232A15C3}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FinancialResults";           
        }


        public struct FinancialResults
        {
            public const string TemplateIdString = "4903E9AA-5A6A-4D13-AB54-A1BF7B734258";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_FinancialResults";

            public struct Fields
            {
                public static readonly ID YearFieldId = new ID("105B4388-B073-4BB6-A599-A09402373D95");
                public const string YearFieldName = "Year";

                public static readonly ID QuarterFieldId = new ID("AA2A7983-24D1-4363-8EFB-F51AF1977E6A");
                public const string QuarterFieldName = "Quarter";

                public static readonly ID QuarterResultTitleFieldId = new ID("23D0FB2A-7C4D-4366-8A25-936239D2FE51");
                public const string QuarterResultTitleFieldName = "QuarterResultTitle";
            }
        }

        public struct FinancialResultsYear
        {
            public const string TemplateIdString = "7C225C64-70DE-4563-A1AC-077BB9E25740";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_FinancialResultsYear";

            public struct Fields
            {
                public static readonly ID YearFieldId = new ID("3149820F-7967-41A3-B69E-3BE8B58D27E1");
                public const string YearFieldName = "Year";
            }
        }

        public struct AccordionTemplate
        {
            public const string TemplateIdString = "{78768ae2-17b3-4873-9e7f-ff0e70133db7}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Accordion";

            public struct Fields
            {
                public static readonly ID CountFieldId = new ID("791f8dba-e1b9-4aca-9751-6610fab7633c");
                public const string CountFieldName = "Count";

                public static readonly ID TitleFieldId = new ID("D6BDF7B3-9657-4E11-937D-940001FFE237");
                public const string TitleFieldName = "Title";
            }
        }
        public struct Accordion_Section
        {
            public const string TemplateIdString = "f51fab8a-6db5-4ebb-aeb4-e40a221b0c55";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Accordion Section";
            public struct Fields
            {
                public static readonly ID Section_HeadingFieldId = new ID("5160ae13-9320-4e81-8df3-ae3b404c247b");
                public const string Section_HeadingFieldName = "Section Heading";

                public static readonly ID ActiveFieldId = new ID("DE609658-9C0A-40C3-B11E-414ADEFB8160");
                public const string ActiveFieldName = "Active";
            }

        }
    }
}