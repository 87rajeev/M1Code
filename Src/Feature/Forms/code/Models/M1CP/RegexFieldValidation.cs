using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.RegexFieldValidation.TemplateIdString, AutoMap = true)]
    public interface RegexFieldValidation 
    {
        [SitecoreField(Templates.RegexFieldValidation.Fields.Regex)]
        string Regex { get; set; }
    }
}