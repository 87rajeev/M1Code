using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Feature.Form.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.Form.TemplateIdString, AutoMap = true)]
    public interface IForms  
    {
        [SitecoreId]
        Guid SitecoreId { get; set; }

        [SitecoreField(Templates.Form.Fields.FieldGroups)]
        IEnumerable<IFormFieldGroup> FieldGroups { get; set; }

        [SitecoreField(Templates.Form.Fields.Button_Groups)]
        IEnumerable<IFormButtonGroup> ButtonGroups { get; set; }

        [SitecoreField(Templates.Form.Fields.BackGroundImage)]
        Image BackGroundImage { get; set; }

        [SitecoreField(Templates.Form.Fields.RedirectOnSuccess)]
        bool RedirectOnSuccess { get; set; }

        [SitecoreField(Templates.Form.Fields.RedirectPage)]
        Item RedirectPage { get; set; }

        [SitecoreField(Templates.Form.Fields.SuccessMessage)]
        string SuccessMessage { get; set; }

        [SitecoreField(Templates.Form.Fields.FormEvents)]
        IEnumerable<Item> FormEvents { get; set; }

        IFormUIElements FormUIElements { get; set; }

        bool FormInvalid { get; set; }

    }
}