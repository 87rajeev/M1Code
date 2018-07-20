using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormValidationBase.TemplateIdString, AutoMap = true)]
    public interface IFormUIElements
    {
        [SitecoreField(Templates.FormUIElements.Fields.Id)]
        string Id { get; set; }

        [SitecoreField(Templates.FormUIElements.Fields.Class)]
        string Class { get; set; }

        [SitecoreField(Templates.FormUIElements.Fields.Attributes)]
        NameValueCollection Attributes { get; set; }

        [SitecoreField(Templates.FormUIElements.Fields.PlaceholderText)]
        string PlaceholderText { get; set; }

        [SitecoreField(Templates.FormUIElements.Fields.HelpText)]
        string HelpText { get; set; }

        [SitecoreField(Templates.FormUIElements.Fields.ParentClass)]
        string ParentClass { get; set; }
    }
}