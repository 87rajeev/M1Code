using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormModel.TemplateIdString, AutoMap = true)]
    public class IFormModel
    {
        [SitecoreField(Templates.FormModel.Fields.FieldGroups)]
        string FieldGroups { get; set; }

        [SitecoreField(Templates.FormModel.Fields.ButtonGroups)]
        string ButtonGroups { get; set; }
    }
}