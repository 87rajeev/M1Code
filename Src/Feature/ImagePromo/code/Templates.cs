using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace M1CP.Feature.ImagePromo
{
    public struct Templates
    {
        /// <summary>
        /// ImagePromoInfo
        /// </summary>
        public struct ImagePromoInfo
        {            
            public const string TemplateIdString = "{C3666A8C-E579-4EFD-B200-51191BC01DD1}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ImagePromoInfo";
            public struct Fields
            {
                public static readonly ID Select_LinksFieldId = new ID("CE928FB3-E18C-48DD-B983-956CA7BB6E36");
                public const string Select_LinksFieldName = "Select";
            }
        }

        /// <summary>
        /// Image promo content
        /// </summary>
        public struct ImagePromoContent
        {
            public const string TemplateIdString = "BFCA30A6-4A9A-4FCD-8A39-AF402438195D";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ImagePromoContent";

        }

        /// <summary>
        /// ImagePromoParameter
        /// </summary>
        public struct ImagePromoParameter
        {
            public const string TemplateIdString = "{70A2D78F-9B5E-482E-BB22-71A2A8280C7C}";
            public static readonly ID TemplateId = new ID(TemplateIdString);            

            public struct Fields
            {
                public const string SelectedDesktopCountFieldName = "DesktopCount";
                public const string SelectedMobileCountFieldName = "MobileCount";
            }
        }

    }
}