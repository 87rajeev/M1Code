using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.IFrame.Models
{
    /// <summary>
    /// IIFrame Repositiry Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Feature/IFrame/_IFrame</para>	
    /// <para>ID: A42286EA-B7A7-48B6-ACB1-BEB0627331F3</para>	
    /// </summary>

    [SitecoreType(TemplateId = Templates.IFrame.TemplateIdString, AutoMap = true)]
    public interface IIFrame : IGlassBase
    {
        [SitecoreField(Templates.IFrame.Fields.IFrameData)]
        string URL { get; set; }
    }
}
