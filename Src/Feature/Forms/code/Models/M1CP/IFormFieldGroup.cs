using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormFieldGroup.TemplateIdString, AutoMap = true)]
    public interface IFormFieldGroup : IFormUIElements
    {
        [SitecoreField(Templates.FormFieldGroup.Fields.Field)]
        IEnumerable<IListFormField> Fields { get; set; }

        bool ApplyValidation { get; set; }
    }
}