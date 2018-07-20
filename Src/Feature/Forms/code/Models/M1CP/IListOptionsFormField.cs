using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.ListOptionsFormField.TemplateIdString, AutoMap = true)]
    public interface IListOptionsFormField : IFormValidationBase
    {

        [SitecoreField(Templates.ListOptionsFormField.Fields.Title)]
        string Title { get; set; }
    }
}