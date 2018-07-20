using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    /// <summary>
    /// IItemBase Interface
    /// <para></para>
    /// <para>Path:/sitecore/templates/User Defined/m1/M1CP/Foundation/Header/_SectionHeader</para>	
    /// <para>ID: 752BE5E0-6B6D-4AB4-9F0B-8C3CA5811763</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates.ItemBase.TemplateIdString)] //, Cachable = true
    public interface IItemBase
    {
        /// <summary>
        /// The Title field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: D6BDF7B3-9657-4E11-937D-940001FFE237</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ItemBase.Fields.TitleFieldName)]
        string Title { get; set; }


        /// <summary>
        /// The Description field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 64500D65-2403-4D70-8211-ED85D86CA0E4</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ItemBase.Fields.DescriptionFieldName)]
        string Description { get; set; }
    }
}
