using Sitecore.Data;

namespace M1CP.Feature.Accordion
{
    public static class Constants
    {
        public static class Views
        {
            public const string AccordionView = "~/Views/M1CP/Accordion/Accordion.cshtml";
            public const string AccordionListWithThumbnailView = "~/Views/M1CP/Accordion/AccordionListWithThumbnail.cshtml";
        }

        public struct AccordionSection
        {
            public static ID ID = new ID("{F51FAB8A-6DB5-4EBB-AEB4-E40A221B0C55}");
            public struct Fields
            {
                public static readonly ID Section_Heading = new ID("{5160AE13-9320-4E81-8DF3-AE3B404C247B}");
                public static readonly ID Active = new ID("{9E942565-677F-491C-A0AC-6B930E37342A}");

            }  
        }
    }
}