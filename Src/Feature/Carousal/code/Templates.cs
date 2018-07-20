namespace M1CP.Feature.Carousal
{
    using Sitecore.Data;
    public struct Templates
    {
        public struct Carousal
        {
            public const string TemplateIdString = "D60AA9B1-C17E-47C6-9AFC-4673BD3EF872";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Carousal";
            public struct Fields
            {
                public static readonly ID CarousalComponentFieldId = new ID("365BC1C6-9D55-4DCC-B9A7-5907BEDCDE0A");
                public const string CarousalComponentFieldName = "Carousal Component Items";

                public static readonly ID ExpandCTAFieldId = new ID("E9BC8247-0F84-466C-BE13-FA136D06FBAB");
                public const string ExpandCTAFieldName = "Expand CTA";
            }
        }
        public struct CarousalContent
        {
            public const string TemplateIdString = "{8C122B0C-046E-4E47-8196-A6E4992FDFD8}";
            public const string TemplateName = "Carousal";

            public const string DeviceCarousalTemplateIdString = "{28336C18-2098-4530-AF87-1EA37046416F}";
            public const string DeviceCarousalTemplateName = "DeviceCarousal";
        }



        public struct CarousalComponent
        {
            public const string TemplateIdString = "F3D37C3C-0203-42A1-BA21-7A9062B79B0D";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_CarousalComponent";
            public struct Fields
            {
                public static readonly ID Carousal_ComponentLinkFieldId = new ID("0D2CDAB2-0A1E-4810-B5CB-D9A242B87F75");
                public static readonly string Carousal_ComponentLinkFieldIdString = "{0D2CDAB2-0A1E-4810-B5CB-D9A242B87F75}";
                public const string CarousalComponentLinkFieldName = "Carousal Component Link";
            }

        }

        public struct DeviceDetails
        {
            public const string TemplateIdString = "4CCA54F8-821F-4F27-8353-05F787F603CE";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_DeviceDetails";

            public struct Fields
            {

                public static readonly ID NameFieldId = new ID("1DBF18A4-A103-4CB6-AE06-8DF7956D54BC");
                public const string NameFieldName = "Name";

                public static readonly ID DeviceModelFieldId = new ID("55D798CB-60FB-4CC0-8E77-6253A125343E");
                public const string DeviceModelFieldName = "Device Model";

                public static readonly ID CostofdeviceFieldId = new ID("2A983145-E504-429E-9FCD-103814952DEB");
                public const string CostofdeviceFieldName = "Cost of device";


                public static readonly ID CostofdevicepermonthFieldId = new ID("81C6ADB6-A1A5-43FC-974C-5E2504F5E167");
                public const string CostofdevicepermonthFieldName = "Cost of device per month";


                public static readonly ID SIMDetailsFieldId = new ID("3030F33D-9337-49E9-BDCA-B57ED7B0AC4A");
                public const string SIMDetailsFieldName = "SIM Details";


                public static readonly ID AvailableColoursFieldId = new ID("03C4168C-5D10-4B34-9DE4-F8264EDC0BD2");
                public const string AvailableColoursFieldName = "Available Colours";

                public static readonly ID DeviceLinkFieldId = new ID("2EA23078-91A8-4732-BAC1-B325C30F10B7");
                public const string DeviceLinkFieldName = "Device Link";

                public static readonly ID DeviceoffersFieldId = new ID("603FD975-1593-426B-8AC1-CF81F8F2F25C");
                public const string DeviceoffersFieldName = "Offers";

                public static readonly ID DeviceFeaturedId = new ID("7DC572AB-B53C-4D72-923D-3DF7E3F796B6");
                public const string DeviceFeaturedFieldName = "Featured";

                public static readonly ID DeviceHotdealId = new ID("2D688E17-99B2-4801-A2CB-A28B841F457E");
                public const string DeviceHotdealFieldName = "Hot Deal";

                public static readonly ID DeviceNewId = new ID("F9C97C6B-6C11-43B6-8B17-3212BF39ECE5");
                public const string DeviceNewIdFieldName = "New";

            }
        }
        public struct DeviceCarousal
        {
            public const string TemplateIdString = "B868A438-88CA-4776-990F-F608EB963309";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_DeviceCarousal";

            public const string DeviceCarousalTemplateIdString = "{28336C18-2098-4530-AF87-1EA37046416F}";
            public static readonly ID DeviceCarousalTemplateId = new ID(TemplateIdString);
            public const string DeviceCarousalTemplateName = "DeviceCarousal";

            public struct Fields
            {
                public static readonly ID DevicesFieldId = new ID("E0F181F9-5708-4A59-955F-339084ABD546");
                public const string DevicesFieldName = "Devices";

                public static readonly ID NewProduct_LogoFieldId = new ID("1C2E6556-7956-47FF-B335-4C36393A04FA");
                public const string NewProductLogosFieldName = "New Product Logo";

                public static readonly ID FeaturedProduct_LogoFieldId = new ID("A0BB96DF-54FE-440A-8EF0-CAF6CF516927");
                public const string FeaturedProductLogoFieldName = "Featured Product Logo";

                public static readonly ID EnableSearchFieldId = new ID("65A898EE-3080-4A80-A02F-9FD11F6B4C18");
                public const string EnableSearchFieldName = "Enable Search";

                public static readonly ID SearchPlaceholderTextFieldId = new ID("E15A7221-1748-4289-B3B0-3624650D9175");
                public const string SearchPlaceholderTextFieldName = "Search Placeholder Text";

                public static readonly ID HotdealProduct_LogoFieldId = new ID("84B53605-8A49-4912-A8C2-FD6CD89A8316");
                public const string HotdealProductLogoFieldName = "Hot Deal Product Logo";

                public static readonly ID ViewallProduct_FieldId = new ID("1603F242-0DB8-4573-894A-3DC871286982");
                public const string ViewallProductFieldName = "View All";

                public static readonly ID ViewlessProduct_FieldId = new ID("DF4F1D6D-A36F-4276-A415-EB142F88D06D");
                public const string ViewlessProductFieldName = "View Less";
            }
        }
        public struct CarousalParameter
        {
            public const string TemplateIdString = "9E118F9F-070E-48A0-81AF-F68705A3F785";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_CarousalRenderingParameter";

            public struct Fields
            {
                public static readonly ID MinValueFieldId = new ID("9235B2C0-9B9F-4621-80A3-D6B4F9BCD735");
                public const string MinValueFieldName = "Min Value";

                public static readonly ID MaxValueFieldId = new ID("A4441F0F-C14F-47EE-8FF7-5C5292B51EF8");
                public const string MaxValueFieldName = "Max Value";

                public static readonly ID EnableAuto_ScrollFieldId = new ID("251E946A-62F2-4A1F-BBFD-BB97F5CD26C1");
                public const string EnableAutoScrollFieldName = "Enable Auto Scroll";

                public static readonly ID CarousalSpeedFieldId = new ID("AC84D9CB-B1F7-4E08-823E-25CF2E0FE36D");
                public const string CarousalSpeedFieldName = "Carousal Speed";

                public static readonly ID EnableInfinite_ScrollFieldId = new ID("248F9C08-A227-4D5E-81CA-E6D96783D4CE");
                public const string EnableInfiniteScrollFieldName = "Enable Infinite Scroll";

                public static readonly ID AutoPlaySpeedFieldId = new ID("D9CA8F64-B96E-42A8-855F-4B74C8C6DEE6");
                public const string AutoPlaySpeedFieldName = "AutoPlay Speed";
            }
        }

        public struct DeviceList
        {
            public const string TemplateIdString = "76D94C6A-64E5-41B1-BFAC-5491C4EEECC4";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_DeviceListRenderingParameter";

            public struct Fields
            {
                public static readonly ID DeviceCountFieldID = new ID("8E121FFC-0B3A-45F3-B448-1FFDB5A4A145");
                public const string DeviceCountFieldName = "Device Count";
            }

        }


    }
}