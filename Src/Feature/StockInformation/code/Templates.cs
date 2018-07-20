using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.StockInformation
{
    public class Templates
    {
        /// <summary>
        /// StockInformation
        /// </summary>
        public struct StockInformation
        {
            public const string TemplateIdString = "{6CA6FD00-0BE9-4280-A626-15E02B1C8742}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_StockInformation";
            public struct Fields
            {
                public static readonly ID ExchangeId = new ID("A01C9DCA-CB75-45EF-8570-7DE1AECA6F76");
                public const string ExchangeName = "Exchange";

                public static readonly ID IndustryId = new ID("3698E1A3-7EDE-4168-A45E-2FC4A1C65155");
                public const string IndustryName = "Industry";

                public static readonly ID IssuedSharesId = new ID("0149E25D-7118-4F9A-B394-31DD3929CC8E");
                public const string IssuedSharesName = "Issued Shares";

                public static readonly ID IssuedCapitalId = new ID("DDA3780C-CC29-4766-A7A3-DBFCA94BED4A");
                public const string IssuedCapitalName = "Issued Capital";

                public static readonly ID AxiataInvestmentsId = new ID("AC5261A8-1151-456C-A567-DB21F17A48DB");
                public const string AxiataInvestmentsName = "Axiata Investments";

                public static readonly ID KeppelTelecomsId = new ID("63B7BD22-B088-4F3D-855B-52A5B2072647");
                public const string KeppelTelecomsName = "Keppel Telecoms";

                public static readonly ID SPHMultimediaId = new ID("289F51D3-4902-4C62-BC55-D03AF996C6DD");
                public const string SPHMultimediaName = "SPH Multimedia";

                public static readonly ID ProfileLastUpdateId = new ID("0A5BB6C2-2CAB-44D9-8AFC-375BBA96A508");
                public const string ProfileLastUpdateName = "Profile Last Updated";

                public static readonly ID MajorShareholderLastUpdateId = new ID("31DB4EA8-248F-4D72-A84C-B01ED443D0DF");
                public const string MajorShareholderLastUpdateName = "Major Shareholder Last Updated";
            }
        }
    }
}