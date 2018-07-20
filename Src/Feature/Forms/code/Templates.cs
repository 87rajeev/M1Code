using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms
{
    public class Templates
    {
        public struct FormModel
        {
            public const string TemplateIdString = "{EE860BA8-C8F2-4F5A-A146-8A0E1A23E2AC}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Form";

            public struct Fields
            {
                public static readonly ID Field_GroupsFieldId = new ID("709B0481-6690-4E72-AF08-1A3B7F2DFEE1");
                public const string FieldGroups = "Field Groups";

                public static readonly ID ButtonGroups_ItemFieldId = new ID("BC286FB0-C648-4E06-A6EF-11A0E6708539");
                public const string ButtonGroups = "Button Groups";

                public static readonly ID BackGroundImage_ItemsFieldId = new ID("C249FB7E-E930-43C5-A81C-377BEA1066BC");
                public const string BackGroundImage = "BackGroundImage";
            }
        }
        public struct ListFormField
        {
            public const string TemplateIdString = "{3EC74F3E-E8BB-46A3-8E2A-6AEE60D63D61}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "ListFormField";

            public struct Fields
            {
                public static readonly ID Items_ItemsFieldId = new ID("A9179DFA-AFA7-48D6-B12A-88D6997F0D59");
                public const string Items = "Items";
            }
        }


        public struct FormValidationBase
        {
            public const string TemplateIdString = "{10875832-3E5A-4D88-9172-BC876FED81D6}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormValidationBase";

            public struct Fields
            {
                public static readonly ID ValidationMessage_ItemFieldId = new ID("387FB02B-C661-469D-B66C-CD17C24A2B56");
                public const string Validation_Message = "Validation Message";

                public static readonly ID DataAttribute_ItemFieldId = new ID("{9D0E4B76-FD5B-4A95-8E66-83090B7F8B85}");
                public const string DataAttribute = "Data Attribute";

            }
        }

        public struct FormUIElements
        {
            public const string TemplateIdString = "{3ABC1866-FB54-4A3C-9347-686991C99B52}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormUIElements";

            public struct Fields
            {
                public static readonly ID Class_ItemFieldId = new ID("1A867597-71C7-4D67-A626-3019D172340D");
                public const string Class = "Class";

                public static readonly ID Id_ItemFieldId = new ID("B4996218-6017-4EBF-AD45-DDAF57482183");
                public const string Id = "Id";

                public static readonly ID PlaceholderText_ItemFieldId = new ID("678A9A3A-20C4-4CAD-9C0C-B2C9C1FAAEB7");
                public const string PlaceholderText = "Placeholder Text";

                public static readonly ID HelpText_ItemFieldId = new ID("289AB28D-8BD4-4343-A622-B3500C403E62");
                public const string HelpText = "Help Text";

                public static readonly ID ParentClass_ItemFieldId = new ID("A5C32942-C800-4041-850E-C35785B172E3");
                public const string ParentClass = "Parent Class";

                public static readonly ID Attributes_ItemFieldId = new ID("039796B9-741A-4415-90D9-8927422CD8DC");
                public const string Attributes = "Attributes";
            }
        }

        public struct Form
        {
            public const string TemplateIdString = "{EE860BA8-C8F2-4F5A-A146-8A0E1A23E2AC}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Form";

            public struct Fields
            {
                public static readonly ID FieldGroups_ItemFieldId = new ID("709B0481-6690-4E72-AF08-1A3B7F2DFEE1");
                public const string FieldGroups = "Field Groups";

                public static readonly ID ButtonGroups_ItemFieldId = new ID("BC286FB0-C648-4E06-A6EF-11A0E6708539");
                public const string Button_Groups = "Button Groups";

                public static readonly ID BackGroundImage_ItemFieldId = new ID("C249FB7E-E930-43C5-A81C-377BEA1066BC");
                public const string BackGroundImage = "BackGroundImage";

                public static readonly ID RedirectOnSuccess_ItemFieldId = new ID("BC52381B-9611-4B40-A785-A9D380BE964B");
                public const string RedirectOnSuccess = "Redirect On Success";

                public static readonly ID RedirectPage_ItemFieldId = new ID("00A3259B-939A-4449-A685-3C454E71C9C4");
                public const string RedirectPage = "Redirect Page";

                public static readonly ID SuccessMessage_ItemFieldId = new ID("9ED1F804-CC8E-4F4F-AE48-3143DB7F3DD4");
                public const string SuccessMessage = "SuccessMessage";

                public static readonly ID FormEvents_ItemFieldId = new ID("A26A6B3B-C793-443C-B8D9-DAAC95CE39A8");
                public const string FormEvents = "Form Events";

            }
        }


        public struct FormEvent
        {
            public const string TemplateIdString = "{3AFC52D4-9298-47ED-83B6-21AD8FD2BD0F}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormEvent";

            public struct Fields
            {
                public static readonly ID Provider_ItemFieldId = new ID("FD3F9389-2CB6-4EEB-BBEA-6C9426BE5688");
                public const string Provider = "Provider";

                public static readonly ID AdditionalParameters_ItemFieldId = new ID("BF367288-9A1F-48D2-8F6C-3BE4420642FD");
                public const string AdditionalParameters = "Additional Parameters";

                public static readonly ID ContinueOnError_ItemFieldId = new ID("51E932B0-0FB3-43B9-8229-9D3EA3AC91D3");
                public const string ContinueOnError = "Continue On Error";

                public static readonly ID SQLTable_ItemFieldId = new ID("93705333-2FCD-41E0-A4DA-0702A60F733B");
                public const string SQLTable = "SQLTable";

                public static readonly ID SQLFields_ItemFieldId = new ID("AE778F35-997A-40EC-95B9-80584CC93C9D");
                public const string SQLFields = "SQLFields";
            }
        }

        public struct FieldData
        {
            public const string TemplateIdString = "{4F526D34-7DFE-4444-8B89-0616DE873203}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FieldData";

            public struct Fields
            {
                public static readonly ID Title_ItemFieldId = new ID("14E9EB32-4478-410B-94D1-AF64DAF16636");
                public const string Title = "Title";

                public static readonly ID HtmlTagType_ItemFieldId = new ID("7E27589E-2CA0-42FE-B456-CC66DF9F3E6D");
                public const string HtmlTagType = "Html Tag Type";

            }
        }

        public struct FormButton
        {
            public const string TemplateIdString = "{AC66CA13-4D41-4745-AE2E-CA6AF3DDFD71}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormButton";

            public struct Fields
            {
                public static readonly ID Type_ItemFieldId = new ID("CDF835FB-F750-4BCB-BC65-8DEC570A91EA");
                public const string Type = "Type";

                public static readonly ID Title_ItemFieldId = new ID("2A3D246B-DB9D-4BF3-BAB2-3E5CA3DAE387");
                public const string Title = "Title";

            }
        }

        public struct FormButtonGroup
        {
            public const string TemplateIdString = "{C30649B4-1E4C-4647-B011-F07AEA0E4CFA}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormButtonGroup";

            public struct Fields
            {
                public static readonly ID Buttons_ItemFieldId = new ID("7E8831C0-B470-4BAF-A022-BF04490C3E5A");
                public const string Buttons = "Buttons";
            }
        }

        public struct FormFieldGroup
        {
            public const string TemplateIdString = "{D104A865-50AA-426A-BAEC-A551F01204C8}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormFieldGroup";

            public struct Fields
            {
                public static readonly ID Fields_ItemFieldId = new ID("306C830A-D8FB-45C9-973D-ED9F6B837B7F");
                public const string Field = "Fields";
            }
        }

        public struct ListOptionsFormField
        {
            public const string TemplateIdString = "{CE16F8BC-FC14-4ADE-B94B-047381E5EAE9}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "ListOptionsFormField";

            public struct Fields
            {
                public static readonly ID Title_ItemFieldId = new ID("E65E1BAD-CFE1-4C3A-85F2-59679C9207B9");
                public const string Title = "Title";
            }
        }

        public struct IFormField
        {
            public const string TemplateIdString = "{03B63407-7FAA-43F4-A7C2-926ED8E9B8CE}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "FormField";

            public struct Fields
            {
                public static readonly ID Title_ItemFieldId = new ID("C571731C-BA08-406C-8648-EBC7237AABBD");
                public const string Title = "Title";

                public static readonly ID Type_ItemFieldId = new ID("0C07886D-701E-450D-927E-5B848200E205");
                public const string Type = "Type";

                public static readonly ID IsRequired_ItemsFieldId = new ID("08B562FA-7EBF-43A4-8569-32514105108E");
                public const string Is_Required = "Is Required";

                public static readonly ID Validation_ItemsFieldId = new ID("5F16EB8F-83DB-40D4-8B72-B372EDE8B13C");
                public const string Validation = "Validation";

                public static readonly ID SQL_ColoumnName_ItemsFieldId = new ID("744F0565-C9AB-4CD0-9171-06DA182D8E14");
                public const string SQL_ColoumnName = "SQL ColoumnName";
            }
        }

        public struct KeyValuePair
        {
            public const string TemplateIdString = "{2ECB4A2C-C573-48C2-A931-6879EEBBCF98}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "KeyValuePair";

            public struct Fields
            {
                public static readonly ID Key_ItemFieldId = new ID("0E0A7E31-8DF6-40B8-8C1D-77048C0E2DC7");
                public const string Key = "Key";

                public static readonly ID Text_ItemFieldId = new ID("72CA4CAE-5157-48A2-92D5-FB38A80B6404");
                public const string Text = "Text";

            }
        }

        public struct RegexFieldValidation
        {
            public const string TemplateIdString = "{93E1A72C-0EF0-44E5-8CB9-FBFB8D14F309}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "RegexFieldValidation";

            public struct Fields
            {
                public static readonly ID Regex_ItemFieldId = new ID("B310EA74-0537-43EE-AE0C-18214403942E");
                public const string Regex = "Regex";
            }
        }

        public struct RequiredFieldValidation
        {
            public const string TemplateIdString = "{A458276D-BF18-41E9-BE67-BA132956595F}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "RequiredFieldValidation";
            public struct Fields
            {
                public static readonly ID IsRequired_ItemFieldId = new ID("8C7FEDBC-3061-4E2A-A799-E55EFAA78DEC");
                public const string IsRequired = "IsRequired";
            }
        }
        public struct UploadFileValidation
        {
            public const string TemplateIdString = "{317990DF-2B81-4703-81D9-4EE876D10D03}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "UploadFileValidation";

            public struct Fields
            {
                public static readonly ID MaximumUploadedFileSize_ItemFieldId = new ID("B310EA74-0537-43EE-AE0C-18214403942E");
                public const string MaximumUploadedFileSize = "MaximumUploadedFileSize";

                public static readonly ID UploadedFileFormat_ItemFieldId = new ID("D3FE685C-D866-4D37-8EF7-E34CC48A0648");
                public const string UploadedFileFormat = "UploadedFileFormat";
            }
        }
    }
}