using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.IFrame
{
    public class Templates
    {
        public struct IFrame
        {
            public const string TemplateIdString = "{3C037388-C957-40D9-AEBF-BBBED60BB2D0}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_IFrame";
            public struct Fields
            {
                public static readonly ID IFrameId = new ID("B3ABB715-D25D-4B54-B577-E459D999DE55");
                public const string IFrameData = "URL";
            }
        }

        public struct IFrameRenderingParameter
        {
            public const string TemplateIdString = "{5891AFA7-939E-44D6-BB5A-C6A71C2245AA}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_IFrameRenderingParameter";
            public struct Fields
            {
                public static readonly ID IFrameRenderingIdId = new ID("708EFF27-F3A2-401E-8984-0B88BDB351EB");
                public const string IFrameRenderingIdName = "Id";

                public static readonly ID IFrameRenderingClassId = new ID("57B1E6DD-4B5E-4AA7-8EB4-88BE45D760AF");
                public const string IFrameRenderingClassName = "Class";

                public static readonly ID IFrameRenderingScrollingId = new ID("6ADE665C-8AC5-4D75-BD67-0701CEDC9D17");
                public const string IFrameRenderingScrollingName = "Scrolling";

                public static readonly ID IFrameRenderingFrameborderId = new ID("B5AE25DB-5808-4524-BE23-249890CEE98B");
                public const string IFrameRenderingFrameborderName = "Frameborder";

                public static readonly ID IFrameRenderingHeightId = new ID("525CE49E-2FD5-4DB3-B7CF-D459085B3E58");
                public const string IFrameRenderingHeightName = "Height";

            }
        }
    }
}