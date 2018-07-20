using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormValidationBase.TemplateIdString, AutoMap = true)]
    public interface IFormValidationBase : RegexFieldValidation, RequiredFieldValidation , IUploadFileValidation, IFormUIElements
    {
        [SitecoreField(Templates.FormValidationBase.Fields.Validation_Message)]
        string Validation_Message { get; set; }

        [SitecoreField(Templates.FormValidationBase.Fields.DataAttribute)]
        string DataAttribute { get; set; }

        string SitecoreValidationMessage { get; set; }
    }
}