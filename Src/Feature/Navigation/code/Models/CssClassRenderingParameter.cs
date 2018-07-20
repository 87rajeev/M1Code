using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Feature.Navigation.Models;
using M1CP.Feature.Navigation.Repositories;
using M1CP.Foundation.Core.Models;
using Sitecore.Mvc.Presentation;

namespace M1CP.Feature.Navigation.Models
{
    [SitecoreType(AutoMap = true, TemplateId = Templates.CssClassRenderingParameterConstants.TemplateIdString)]
    public interface ICssClassRenderingParameter : IGlassBase
    {
        [SitecoreField(Templates.CssClassRenderingParameterConstants.Fields.CssClassTypesFieldName)]
        string Class { get; set; }
    }

    [SitecoreType(TemplateId = Templates.CssClassTypesConstants.TemplateIdString)] //, Cachable = true
    public interface ICssClassTypes : IGlassBase
    {
        /// <summary>
        /// The CSS field.
        /// <para></para>
        /// <para>Field Type: Single-Line Text</para>		
        /// <para>Field ID: b3553a48-07ec-4df8-9e94-7d261a961161</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.CssClassTypesConstants.Fields.CssFieldName)]
        string Css { get; set; }
    }

}
