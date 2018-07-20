using Sitecore.Data;

namespace M1CP.Foundation.Dictionary
{
    public struct Templates
    {
        public struct DictionaryFolder
        {
            public static ID ID => new ID("{CFC725FE-D244-44B8-8BFF-75BA9EEF7367}"); //Pass GUID
        }

        public struct DictionaryEntry
        {
            public static ID ID => new ID(""); //Pass GUID
            public struct Fields
            {
                public static ID Phrase => new ID(""); //Pass GUID
            }
        }

        public struct DictionarySettings
        {
            public static ID ID => new ID(""); //Pass GUID
            public struct Fields
            {
                public static ID DefaultLanguage => new ID(""); //Pass GUID
            }
        }
    }
}