using M1CP.Foundation.Base.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using System.Collections.Generic;

namespace M1CP.Feature.ImagePromo.Models
{
    /// <summary>
    /// IImagePromoRepositiry Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Feature/ImagePromo/_ImagePromoInfo</para>	
    /// <para>ID: 1BA89FDE-8CA2-41EF-91F5-B3A20B045371</para>	
    /// </summary>
    public interface IImagePromoInfo : IItemBase, IGlassBase
    {
        /// <summary>
        /// The child ImagePromo Items field.
        /// <para></para>
        /// <para>Field Type: Multilist</para>		
        /// <para>Field ID: CE928FB3-E18C-48DD-B983-956CA7BB6E36</para>
        /// <para>Select: </para>
        /// </summary>
        [SitecoreField(Templates.ImagePromoInfo.Fields.Select_LinksFieldName)]
        IEnumerable<IImagePromoContent> Select { get; set; }
    }

}