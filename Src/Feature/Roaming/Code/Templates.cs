using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace M1CP.Feature.Roaming
{
    public class Templates
    {
        public struct DataPassport
        {
            public const string TemplateIdString = "711E5CB8-BF57-44A5-BDA1-C99E26FBF6FF";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_DataPassport";
            public struct Fields
            {
                public static readonly ID DataPassportTitleId = new ID("0CED4749-824E-46A7-98B1-B6D7003A56F6");
                public const string DataPassportTitle = "Title";

                public static readonly ID DataPassportHeadingId = new ID("8D3D0D05-AC1B-47BA-AB05-94113AD40B2B");
                public const string DataPassportHeading = "Heading";

                public static readonly ID DataPassportCountryListId = new ID("702CCB40-8B06-4BBB-A93D-D01434737957");
                public const string DataPassportCountryList = "CountryList";

                public static readonly ID DataPassportDescriptionId = new ID("C6CBB4E9-B782-4E72-A308-4DDB6E32CE63");
                public const string DataPassportDescription = "Description";

            }
        }
        public struct Destination
        {
            public const string TemplateIdString = "A1A544E4-9A44-46CF-97AF-B2D84167E117";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Destination";

            public struct Fields
            {
                public static readonly ID DestinationSelectedListId = new ID("F5094597-CEC3-41E5-B583-58EF663B29A1");
                public const string DestinationSelectedList = "SelectedList";

            }
        }
		
		public struct CountryList
        {
            public const string TemplateIdString = "{4EEB8436-3781-40AA-AF13-7C38A8AF0D46}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "CountryList";
            public struct Fields
            {
                                                         
                public const string CalltoActionFieldName = "Call To Action Text";

                public const string CountryListFieldName = "Country List";
            }

        }

        public struct CountryDetails
        {
            public const string TemplateIdString = "4CEB2D59-BB61-4E45-8A55-89684FA0ED65";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "CountryNameRoaming";
            public struct Fields
            {
                
                public const string CountryNameFieldName = "Country Name";

               
                public const string PromotionContentFieldName = "Promotion Content";

               
                public const string CountrySpecificNotesFieldName = "Country Specific Notes";

                
                public const string CountryPageLinkFieldName = "Country Page Link";
            }

        }
    }
}