using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    /// <summary>
    /// IColor Interface
    /// <para></para>
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/Styling/_Color</para>	
    /// <para>ID: 61CEB5B7-2A7F-478B-9F39-6F8E727137BA</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates._Color.TemplateIdString, AutoMap = true)] //, Cachable = true
    public interface IColor
    {

        /// <summary>
        /// The Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 1CC8685D-FEF3-48CB-B88F-0FCE1E57B25B</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._Color.Fields.Color_CodeFieldName)]
        string Color_Code { get; set; }
    }
}
