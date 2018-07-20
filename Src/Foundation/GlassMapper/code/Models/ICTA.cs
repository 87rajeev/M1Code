using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1CP.Foundation.GlassMapper;

namespace M1CP.Foundation.GlassMapper.Models
{
    /// <summary>
    /// ICTA Interface
    /// <para></para>
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/CTA/_CTA</para>	
    /// <para>ID: 347443B8-A1DC-48B9-AE7D-34B3709DFC52</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates._CTA.TemplateIdString)] //, Cachable = true
    public interface ICTA
    {

        [SitecoreId]
        Guid Id { get; set; }

        /// <summary>
        /// The CTA Title field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 54157107-9B6D-436F-9FD5-D6A247C0DF1E</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._CTA.Fields.CTATitleFieldName)]
        string CTATitle { get; set; }

        /// <summary>
        /// The CTA Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: B3EAA68C-885E-442B-9BBE-8859D555422F</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates._CTA.Fields.CTALinkFieldName)]
        Link CTALink { get; set; }

        /// <summary>
        /// To hold trackingID of an Item
        /// </summary>
        StringBuilder TrackingID { get; set; }
    }
}
