using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.ListFormField.TemplateIdString, AutoMap = true)]
    public interface IListFormField : IFormField 
    {
        [SitecoreId]
        Guid SitecoreItemId { get; set; }

        [SitecoreField(Templates.ListFormField.Fields.Items)]
        IEnumerable<IFieldData> Items { get; set; }

        string ValidationMessage { get; set; }

    }

 
}