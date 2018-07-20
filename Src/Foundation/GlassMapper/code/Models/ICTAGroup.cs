using Glass.Mapper.Sc.Configuration.Attributes;
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
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/CTA/_CTAGroup</para>	
    /// <para>ID: 2BA5B662-561B-4095-A6CB-FAA1ED3DC8BA</para>	
    /// </summary>
[SitecoreType(TemplateId = Templates._CTAGroup.TemplateIdString)] //, Cachable = true
    public interface ICTAGroup
    {
        /// <summary>
        /// The CTA Group field.
        /// <para></para>
        /// <para>Field Type: Tree List</para>		
        /// <para>Field ID: C3D5A8F3-6B91-4AF6-ADB5-7E3D466EB134</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._CTAGroup.Fields.CTA_GroupFieldName)]
        IEnumerable<ICTA> CTATitle { get; set; }
    }
}
