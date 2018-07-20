using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.Form.TemplateIdString, AutoMap = true)]
    public interface IFormButton : IFormUIElements
    {
        [SitecoreField(Templates.FormButton.Fields.Type)]
        string Type { get; set; }

        [SitecoreField(Templates.FormButton.Fields.Title)]
        string Title { get; set; }
    }
}