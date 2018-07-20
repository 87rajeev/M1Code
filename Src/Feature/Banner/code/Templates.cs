using Sitecore.Data;

namespace M1CP.Feature.Banner
{
    public class Templates
    {

        public struct BannerModel
        {
            public const string TemplateIdString = "{7F769626-4ADB-4E2D-9236-3EE1EA88F0F4}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "HeroBanner";

            public struct Fields
            {
                public static readonly ID BannerMainHeading_ItemsFieldId = new ID("0ED77FDC-77B7-44B9-B76B-30C04474899A");
                public const string BannerMainHeading = "Banner Main Heading";

                public static readonly ID BannerHeading_ItemsFieldId = new ID("DEFE043D-E4AB-4D7D-8DF1-27CD3D4E5785");
                public const string BannerHeading = "Banner Heading";

                public static readonly ID BannerSubHeading_ItemsFieldId = new ID("0217E3D6-12EF-45B9-93D5-480841400D91");
                public const string BannerSubHeading = "Banner Sub Heading";

                public static readonly ID BannerpromoText_ItemsFieldId = new ID("F8E22791-9719-4312-AE4F-FF18FEE45476");
                public const string BannerPromoText = "Banner Promo Text";

                public static readonly ID BannerPromoSubText_ItemsFieldId = new ID("8F00C23B-7EBE-4B9F-B262-841652D0889A");
                public const string BannerPromoSubText = "Banner Promo SubText";

                public static readonly ID EnableDotThemeText_ItemsFieldId = new ID("9B3EC423-1B54-4C55-BC3E-2C6F26B2C374");
                public const string EnableDotThemeText = "Enable Dot Theme";

                public static readonly ID DotImageSubText_ItemsFieldId = new ID("7B44F754-9A75-498A-96BB-198E7B5EA932");
                public const string DotImageSubText = "Dot Image";
            }
        }

        public struct BannerWithLinks
        {
            public const string TemplateIdString = "{AB03428B-2EE9-49F5-89EE-16F06A233E91}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "HeroBannerWithLinks";

            public struct Fields
            {

                public static readonly ID BannerHeading_ItemsFieldId = new ID("D412EFBA-1CB9-47D7-AD56-EE90D4F18892");
                public const string BannerHeading = "Banner Heading";

                public static readonly ID BannerSubHeading_ItemsFieldId = new ID("93ED1D70-BF02-43EA-B0E1-CC759FA6CDF0");
                public const string BannerSubHeading = "Banner Sub Heading";

                public static readonly ID EnableDotThemeText_ItemsFieldId = new ID("D799C4ED-AACD-40F9-A399-527A08382BC1");
                public const string EnableDotThemeText = "Enable Dot Theme";

                public static readonly ID DotImageSubText_ItemsFieldId = new ID("5EF156E0-1297-4FC0-8B96-088BB3F9C91C");
                public const string DotImageSubText = "Dot Image";
            }
        }

        public struct BannerNavigation
        {
            public const string TemplateIdString = "{4AF4C39D-426A-4025-801B-E14E32109B14}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_BannerNavigation";

            public struct Fields
            {
                public static readonly ID NavigationHeader_ItemsFieldId = new ID("B3C2C9C2-49CA-4D48-BE23-BF7780422E4A");
                public const string NavigationHeader = "NavigationHeader";

                public static readonly ID NavigationLinksHeading_ItemsFieldId = new ID("4F352FAA-4DB9-403D-932E-AF0B2A2A3FF2");
                public const string NavigationLinksHeading = "NavigationLinks";
            }
        }



        public struct PageBanner
        {
            public const string TemplateIdString = "{F3F2627C-EFE8-49EE-8545-445AD54AD579}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_PageBanner";

            public const string PageBannerTemplateIdString = "{BC55ED8F-6D13-4313-8A82-0E90FF57CB0B}";
            public static readonly ID PageBannerTemplateId = new ID(TemplateIdString);
            public const string PageBannerTemplateName = "PageBanner";

            public const string ImagePageBannerTemplateIdString = "{F997879B-5D4B-4052-9723-2D5800FBF297}";
            public static readonly ID ImagePageBannerTemplateId = new ID(TemplateIdString);
            public const string ImagePageBannerTemplateName = "ImagePageBanner";


            public struct Fields
            {
                public static readonly ID SupportTextItemsFieldId = new ID("D7D8F4D1-E72D-4873-8BCC-85FD33A1FF3D");
                public const string SupportText = "Support Text";

                public static readonly ID BannerMainHeadingItemsFieldId = new ID("C9D2E949-30B9-4458-AC50-0D590B1C0333");
                public const string BannerMainHeading = "Banner Main Heading";
            }
        }
        public struct BannerParameter
        {
            public const string TemplateIdString = "{6E4216DE-6085-410D-8E2A-417C3FEE33CC}";
        }

        public struct BannerParameterWithoutCTA
        {
            public const string TemplateIdString = "{5E7406B7-9C08-4818-9BB3-709A7E8A8901}";
        }
        public struct DataBannerParameter
        {
            public const string TemplateIdString = "{388393D0-1E2D-40B4-B78D-4ADBE7891BE4}";
        }

        public struct BannerWithoutCTA
        {
            public const string TemplateIdString = "{A9852DC3-8492-48DA-935D-2EBB36602D54}";
            public const string TemplateName = "BannerWithOutCTA";
            public struct Fields
            {
                public const string SubTitle = "SubTitle";
                public const string EnableDots = "EnableDots";

            }
        }

        public struct BackgroundDotImage
        {
            public const string TemplateIdString = "{1DF4CBAF-24DD-4579-9E89-74E30492CE9B}";
            public const string TemplateName = "_BackgroundDotImage";
            public struct Fields
            {
                public const string DotImageColor = "DotImageColor";
            }
        }
        public struct Slidercolor
        {
            public const string TemplateIdString = "{F3986DD7-E0E8-4F04-97B7-4FFC288B2D3F}";
            public const string TemplateName = "_Slider";
            public struct Fields
            {
                public const string SliderColor = "SliderColor";
            }
        }
    }
}