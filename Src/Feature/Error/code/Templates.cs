using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;


namespace M1CP.Feature.Error
{
    public class Templates
    {
        
        public struct PageNotFound 
        {
            public const string TemplateIdString = "C8A31AE7-AF8E-4B02-84F8-A5C5C094D803";
            public static readonly ID TemplateId = new ID(TemplateIdString);
            public const string TemplateName = "Error Page";

        }
       
    }
}