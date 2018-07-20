using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FieldData.TemplateIdString, AutoMap = true)]
    public interface IFieldData 
    {
        [SitecoreField(Templates.FieldData.Fields.Title)]
        string Title { get; set; }

        [SitecoreField(Templates.FieldData.Fields.HtmlTagType)]
        string HtmlTagType { get; set; }
    }
}