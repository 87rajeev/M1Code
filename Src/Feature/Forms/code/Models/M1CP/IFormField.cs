using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.IFormField.TemplateIdString, AutoMap = true)]
    public interface IFormField : IFormUIElements
    {

        [SitecoreField(Templates.IFormField.Fields.Title)]
        string Title { get; set; }

        [SitecoreField(Templates.IFormField.Fields.Type)]
        KeyValuePair Type { get; set; }

        [SitecoreField(Templates.IFormField.Fields.Is_Required)]
        bool Is_Required { get; set; }

        [SitecoreField(Templates.IFormField.Fields.Validation)]
        IEnumerable<IFormValidationBase> Validations { get; set; }

        [SitecoreField(Templates.IFormField.Fields.SQL_ColoumnName)]
        string SQL_ColoumnName { get; set; }

    }
}