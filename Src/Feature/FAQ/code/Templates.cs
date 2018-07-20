using Sitecore.Data;

namespace M1CP.Feature.FAQ
{
    public struct Templates
    {
        public struct _FAQ
        {
            public const string TemplateIdString = "{7E49A1C2-026D-45BA-BE98-494B17D798B5}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_FAQ";
            public struct Fields
            {
                public const string AnswerFieldName = "Answer";
                public const string QuestionFieldName = "Question";
            }
        }

        public struct _FAQ_Group
        {
            public const string TemplateIdString = "{CFF71D88-60BE-44BA-87BA-97A66C4C0950}";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "_FAQ Group";
            public struct Fields
            {
                public const string Group_MembersFieldName = "Group Member";
            }
        }

    }
}