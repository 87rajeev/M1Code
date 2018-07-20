namespace M1CP.Feature.Navigation
{
    using Sitecore.Data;

    public struct Templates
    {
        public struct Navigation
        {
            public const string TemplateIdString = "de278b23-7249-414b-b596-4d14bc3b4e28";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Navigation";

            public struct Fields
            {
                public static readonly ID Select_Navigation_LinksFieldId = new ID("3486dbe7-2aaa-4ab9-b714-3bfb2d2b08cd");
                public const string Select_Navigation_LinksFieldName = "Select Navigation Links";
            }
        }

        public struct NavigationLinks
        {
            public const string TemplateIdString = "25dcf332-316c-4157-bf69-01ea7a9789cf";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Navigation Link";

            public struct Fields
            {
                public static readonly ID Child_Navigation_ItemsFieldId = new ID("38c0dac4-eb82-49bf-b801-ec903fefc454");
                public const string Child_Navigation_ItemsFieldName = "Child Navigation Items";

                public static readonly ID Navigation_LinkFieldId = new ID("07c62e92-e84f-40ef-b5af-cd7d89ef25fc");
                public const string Navigation_LinkFieldName = "Navigation Link";

                public static readonly ID Navigation_TitleFieldId = new ID("13f88561-e76e-463e-a19d-e97c0b1e9502");
                public const string Navigation_TitleFieldName = "Navigation Title";
            }
        }

        public struct _Navigation_Link
        {
            public const string TemplateIdString = "aec8911c-c076-4651-a628-f3f560d94ec5";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_Navigation Link";

            public struct Fields
            {
                public static readonly ID Child_Navigation_ItemsFieldId = new ID("38c0dac4-eb82-49bf-b801-ec903fefc454");
                public const string Child_Navigation_ItemsFieldName = "Child Navigation Items";

                public static readonly ID Navigation_LinkFieldId = new ID("07c62e92-e84f-40ef-b5af-cd7d89ef25fc");
                public const string Navigation_LinkFieldName = "Navigation Link";

                public static readonly ID Navigation_TitleFieldId = new ID("13f88561-e76e-463e-a19d-e97c0b1e9502");
                public const string Navigation_TitleFieldName = "Navigation Title";
            }
        }

        public struct _BreadCrumbInfo
        {
            public const string TemplateIdString = "883673E3-1324-4354-8F84-AE65ECF5593D";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_BreadCrumbInfo";

            public struct Fields
            {
                public static readonly ID BreadCrumbTitleFieldId = new ID("60B5A6EB-9001-4DF7-81F5-30C28231A128");
                public const string BreadCrumbTitleFieldName = "BreadCrumb Title";                
            }
        }


        public struct CssClassRenderingParameterConstants
        {
            public const string TemplateIdString = "d397fae1-861c-4c78-b200-d737ba6001ec";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_CssClassRenderingParameter";
            public struct Fields
            {
                public static readonly ID CssClassTypesFieldId = new ID("4c2e9426-1871-44d3-b561-f26b0254278c");
                public const string CssClassTypesFieldName = "CssClass Name";
            }
            
        }
        public struct CssClassTypesConstants
        {
            public const string TemplateIdString = "e1c54b30-7c89-415d-8d0a-26bfb8411e0b";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "CssClass Types";
            public struct Fields
            {
                public static readonly ID CssFieldId = new ID("b3553a48-07ec-4df8-9e94-7d261a961161");
                public const string CssFieldName = "CSS";
            }


        }
        public struct Site
        {
            public struct Fields
            {
                public const string FavIconFieldName = "Fav icon";
                public const string Path = "/sitecore/content/M1/CorporatePortal";
                public static readonly ID FavIconFieldId = new ID("2d187a5f-e0c5-4052-bab9-32d2db1cc2e4");
            }
        }
    }
}