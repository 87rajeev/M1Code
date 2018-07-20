using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Models.M1CP
{
    [SitecoreType(TemplateId = Templates.KeyValuePair.TemplateIdString, AutoMap = true)]
    public interface KeyValuePair
    {

        [SitecoreField(Templates.KeyValuePair.Fields.Key)]
        string Key { get; set; }

        [SitecoreField(Templates.KeyValuePair.Fields.Text)]
        string Text { get; set; }
    }
}