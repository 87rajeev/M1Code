using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.RequiredFieldValidation.TemplateIdString, AutoMap = true)]

    public interface RequiredFieldValidation
    {
        [SitecoreField(Templates.RequiredFieldValidation.Fields.IsRequired)]
        bool IsRequired { get; set; }
    }
}