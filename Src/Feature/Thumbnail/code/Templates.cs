namespace M1CP.Feature.Thumbnail
{
    using Sitecore.Data;
    public struct Templates
    {
        public struct ThumbnailList
        {
            public const string TemplateIdString = "569BF43A-1585-4F30-B5AB-BDE5D85B57A3";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "ThumbnailList";
            public struct Fields
            {
                public static readonly ID Select_Thumbnail_ListFieldId = new ID("847F816F-9FF1-43BF-B817-B31E45F93C77");
                public const string Select_Thumbnail_ListFieldName = "Select Thumbnail List";
            }
        }

        public struct Thumbnail
        {
            public const string TemplateIdString = "{6B5DDC1F-0239-4BA3-BCB2-0665159FE3B9}";
            public const string TemplateName = "Thumbnail";
        }
        public struct ThunmbnailItem
        {
            public const string TemplateIdString = "28508DAD-7C48-4963-9D00-662CEE842507";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Thumbnail";

            public struct Fields
            {
                public static readonly ID TitleFieldId = new ID("DC583DF5-E7D1-484E-BA6F-26B599FF4DED");
                public const string TitleFieldName = "Title";

                public static readonly ID NotationsFieldId = new ID("74DA58A4-480E-4529-A2B8-591F4EAF9E24");
                public const string NotationsFieldName = "Notations";

                public static readonly ID ShortSummaryFieldId = new ID("3D312E90-BED8-4F93-88D1-C9EBF7727B85");
                public const string ShortSummaryFieldName = "ShortSummary";

                public static readonly ID DescriptionFieldId = new ID("54849339-4A7D-4E8D-914B-9AB2725B1E18");
                public const string DescriptionFieldName = "Description";

                public static readonly ID ColorFieldId = new ID("CBB1738E-E1D7-4C08-B31F-E67DE67E5E58");
                public const string ColorFieldName = "Color";
            }
        }

        public struct ThumbnailDeviceDetails
        {
            public const string TemplateIdString = "F1C65CA6-73FA-4EA4-A992-04B5B37446BB";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ThumbnailDeviceDetails";

            public struct Fields
            {

                public static readonly ID NameFieldId = new ID("C48FC17F-F333-4056-9869-F88A0E15DA50");
                public const string NameFieldName = "Name";

                public static readonly ID Cost_of_deviceFieldId = new ID("04A9CF58-63F3-4EB2-914E-2445C1AF1FC5");
                public const string Cost_of_deviceFieldName = "Cost of device";


                public static readonly ID Cost_of_device_per_monthFieldId = new ID("3D58C16F-2DDB-42CE-B784-ADB7736F66E6");
                public const string Cost_of_device_per_monthFieldName = "Cost of device per month";


                public static readonly ID SIM_DetailsFieldId = new ID("04626E78-E26A-47F6-92E1-B9482B80EB08");
                public const string SIM_DetailsFieldName = "SIM Details";


                public static readonly ID Available_ColoursFieldId = new ID("FC069CE6-97E3-498A-9EFE-193DAE32B187");
                public const string Available_ColoursFieldName = "Available Colours";

                public static readonly ID Device_LinkFieldId = new ID("8D0ADF74-5154-43E2-877F-550C57A1D4CC");
                public const string Device_LinkFieldName = "Device Link";

            }
        }
        public struct DeviceThumbnail
        {
            public const string TemplateIdString = "F1C65CA6-73FA-4EA4-A992-04B5B37446BB";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_DeviceThumbnail";

            public struct Fields
            {
                public static readonly ID DevicesFieldId = new ID("550B2969-2B2A-4157-9D16-8202239E6BB4");
                public const string DevicesFieldName = "Devices";
            }
        }

        public struct ThumbnailSection
        {
            public const string TemplateIdString = "649E18E0-3E1A-4602-A7DF-A0FC95A0C487";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ThumbnailSection";


            public struct Fields
            {
                public static readonly ID Thumbnail_Component_ItemsFieldId = new ID("7F951ECA-B94D-4A2D-B481-C42C1C3D51A3");
                public const string Thumbnail_Component_ItemsFieldName = "Thumbnail Component Items";

                public static readonly ID EnableCTAFieldId = new ID("7B2FE7B4-BD75-431B-8BBD-7809ADA81B30");
                public const string EnableCTAFieldName = "Enable CTA";
                public const string ViewLessCTA = "ViewLess CTA";
            }
        }


        public struct ThumbnailComponent
        {
            public const string TemplateIdString = "3E385337-6A6C-4B28-B344-EBC8A6797C68";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_ThumbnailComponent";

            public struct Fields
            {
                public static readonly ID Thumnail_Support_TextFieldId = new ID("1D98E6F5-843F-49BE-8E1B-5ED6227212A9");
                public const string Thumnail_Support_TextFieldName = "Thumnail Support Text";
            }
        }

        public struct _ThumbnailGradientRenderingParamater
        {
            public const string TemplateIdString = "0912FE48-13F8-4DEB-AE99-ADEEBD4900AF";
        }
        public struct _GradientColor
        {
            public const string TemplateName = "_GradientColor";
            public struct Fields
            {
                public const string SelectedGradientColor = "GradientColor";
            }
        }
        public struct _TextGradientColor
        {
            public const string TemplateName = "_TextGradientColor";
            public struct Fields
            {
                public const string SelectedTextGradientColor = "TextGradientColor";
            }
        }

        public struct Iconthumbnail
        {
            public const string TemplateIdString = "{300B8C0D-59DC-40A7-9380-E4F31E5ECF40}";
            public const string TemplateName = "IconThumbnail_list";
            public struct Fields
            {
                public const string Thumbnaillistitems = "ThumbnailListitems";
            }
        }

        public struct ThumbnailPromotion
        {
            public struct Fields
            {
                public const string ThumbnailPromotionsCount = "ThumbnailPromotionsCount";
            }
        }

    }
}
