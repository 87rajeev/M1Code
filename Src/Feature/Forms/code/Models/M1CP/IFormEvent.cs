using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormEvent.TemplateIdString, AutoMap = true)]
    public interface IFormEvent : IFormValidationBase
    {
        [SitecoreField(Templates.FormEvent.Fields.Provider)]
        string Provider { get; set; }

        [SitecoreField(Templates.FormEvent.Fields.AdditionalParameters)]
        string AdditionalParameters { get; set; }

        [SitecoreField(Templates.FormEvent.Fields.ContinueOnError)]
        string ContinueOnError { get; set; }

        [SitecoreField(Templates.FormEvent.Fields.SQLTable)]
        string SQLTable { get; set; }

        [SitecoreField(Templates.FormEvent.Fields.SQLFields)]
        string SQLFields { get; set; }
    }
}