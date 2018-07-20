using System;

namespace M1CP.Foundation.Services
{
    /// <summary>
    /// Template items.
    /// </summary>
    public struct Templates
    {
        /// <summary>
        /// Throttle Item details
        /// </summary>

        public struct Throttle
        {
            public const string TemplateIdString = "EA6362C1-0BE5-4E92-89F9-103FD11228E9";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public const string TemplateName = "ThrottleList";

            public struct Fields
            {
                public static readonly Guid Select_ThrottleList_FieldId = new Guid("{B4C89081-D402-4B58-B3B6-F6DF9F1C584A}");
                public const string Select_ThrottleList_Field = "ThrottleList";
            }
        }
        public struct PageThrottle
        {
            public static readonly Guid TemplateIdString = new Guid("{905D06EE-F48F-4BD2-B4F6-C84514FEBD7B}");
        }
    }
}