
namespace M1CP.Foundation.GlassMapper
{
    using Sitecore.Data;
    public struct Templates
    {
        public struct _Image
        {
            public const string TemplateIdString = "677C8ED7-1695-4F12-B907-B6CEC86EE411";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Image";
            public struct Fields
            {
                public static readonly ID Image_DesktopFieldId = new ID("1CC8685D-FEF3-48CB-B88F-0FCE1E57B25B");
                public const string Image_DesktopFieldName = "Image";
            }
        }

        public struct _Color
        {
            public const string TemplateIdString = "61CEB5B7-2A7F-478B-9F39-6F8E727137BA";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Colors";
            public struct Fields
            {
                public static readonly ID Color_CodeFieldId = new ID("6C40041E-B9CD-4FA2-9C3A-037ABEEA49B8");
                public const string Color_CodeFieldName = "Color Code";
            }
        }

        public struct _CTA
        {
            public const string TemplateIdString = "347443B8-A1DC-48B9-AE7D-34B3709DFC52";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_CTA";

            public struct Fields
            {
                public static readonly ID CTATitleFieldId = new ID("54157107-9B6D-436F-9FD5-D6A247C0DF1E");
                public const string CTATitleFieldName = "CTATitle";

                public static readonly ID CTALinkFieldId = new ID("B3EAA68C-885E-442B-9BBE-8859D555422F");
                public const string CTALinkFieldName = "CTALink";
               
            }
        }

        public struct ItemBase
        {
            public const string TemplateIdString = "752BE5E0-6B6D-4AB4-9F0B-8C3CA5811763";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ItemBase";

            public struct Fields
            {

                public static readonly ID TitleFieldId = new ID("D6BDF7B3-9657-4E11-937D-940001FFE237");
                public const string TitleFieldName = "Title";

                public static readonly ID DescriptionFieldId = new ID("64500D65-2403-4D70-8211-ED85D86CA0E4");
                public const string DescriptionFieldName = "Description";

            }
        }
        public struct _Video
        {
            public const string TemplateIdString = "06F30964-9090-43C2-A464-AEE216DBEDF6";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Video";

            public struct Fields
            {
                public static readonly ID Video_URLFieldId = new ID("15197F74-BE43-4301-8192-2FD22280F837");
                public const string Video_URLFieldName = "Video URL";

                public static readonly ID IsVideoFieldId = new ID("6EF85F21-B413-4F6B-80D0-1F88CCAD6E78");
                public const string IsVideoFieldName = "IsVideo";

                public static readonly ID Video_PosterFieldId = new ID("E859331B-519C-4431-8846-F22BFBE4EB86");
                public const string Video_PosterFieldName = "Video Poster";
            }
        }
        public struct _CTAGroup
        {
            public const string TemplateIdString = "2BA5B662-561B-4095-A6CB-FAA1ED3DC8BA";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_CTAGroup";

            public struct Fields
            {
                public static readonly ID CTA_GroupFieldId = new ID("FDD6E5FD-42C3-4D5C-BCDE-E05D0DC115FF");
                public const string CTA_GroupFieldName = "CTA Group";
            }
        }
        public struct _Style
        {
            public const string TemplateIdString = "9046A3F1-24E6-41A1-A902-0BE12D5AF702";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Style";

            public struct Fields
            {

                public static readonly ID SelectedStyleFieldId = new ID("3FEF19B5-6FE2-433C-BDAC-D5EB95CFF9A5");
                public const string SelectedStyleFieldName = "Class";
            }
        }
        public struct _MaxMin
        {
            //public const string TemplateIdString = "9046A3F1-24E6-41A1-A902-0BE12D5AF702";
            //public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_MaxMinValue";

            public struct Fields
            {

               // public static readonly ID SelectedStyleFieldId = new ID("3FEF19B5-6FE2-433C-BDAC-D5EB95CFF9A5");
                public const string SelectedCountFieldName = "Value";
            }
        }

        public struct _ComponentTheme
        {
            public const string TemplateIdString = "41236812-7EC6-4DB5-8238-EEBEF2586340";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "ComponentTheme";

            public struct Fields
            {

                public static readonly ID SelectedThemeFieldId = new ID("169B68C6-23C6-43FA-9860-FF19CB93C162");
                public const string SelectedThemeFieldName = "Theme";
            }
        }

        public struct _ComponentOrientation
        {
            public const string TemplateIdString = "865B14FA-7BE1-41E3-AE08-0FFA07AEF85A";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "ComponentOrientation";

            public struct Fields
            {

                public static readonly ID SelectedThemeFieldId = new ID("BBE3C460-C4BD-46E2-9389-617237EB8B30");
                public const string SelectedThemeFieldName = "ComponentOrientation";
            }
        }

        public struct _IComponentItemMaxMin
        {
            public const string TemplateName = "_ComponentCount";

            public struct Fields
            {

                public const string SelectedDesktopCountFieldName = "DesktopCount";
                public const string SelectedMobileCountFieldName = "MobileCount";
            }
        }

        
        public struct _ITextColor
        {
            public const string TemplateName = "_TextColor";

            public struct Fields
            {

                public const string SelectedTxtColorFieldName = "TextColor";
            }
        }
        public struct _GradientColor
        {
            public const string TemplateIdString = "25559261-6B36-4E4A-AB00-1A4DE7E82E1A";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_GradientColor";
            public struct Fields
            {
                public static readonly ID SelectedThemeFieldId = new ID("69D5A12B-8123-4708-84D4-66248267874C");
                public const string SelectedGradientColor = "GradientColor";
            }
        }

    }
}