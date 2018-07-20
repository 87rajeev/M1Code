using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.FormButtonGroup.TemplateIdString, AutoMap = true)]
    public interface IFormButtonGroup : IFormUIElements
    {
        [SitecoreField(Templates.FormButtonGroup.Fields.Buttons)]
        IEnumerable<IFormButton> Buttons { get; set; }
    }
}