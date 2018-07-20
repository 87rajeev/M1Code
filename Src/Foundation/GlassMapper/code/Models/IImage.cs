using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    /// <summary>
    /// ICTAGroup Interface
    /// <para></para>
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/Media/_Image</para>	
    /// <para>ID: 677C8ED7-1695-4F12-B907-B6CEC86EE411</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates._Image.TemplateIdString, AutoMap = true)] //, Cachable = true
    public interface IImage
    {

        /// <summary>
        /// The Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 1CC8685D-FEF3-48CB-B88F-0FCE1E57B25B</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Image.Fields.Image_DesktopFieldName)]
        CustomImage Image_Desktop { get; set; }
    }

}
