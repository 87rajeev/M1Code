using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;
namespace M1CP.Feature.Banner.Models
{
    public interface IPageBanner : IVideo, IImage, IItemBase, ICTAGroup, IGlassBase
    {
        /// <summary>
        /// The Support Text field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: D7D8F4D1-E72D-4873-8BCC-85FD33A1FF3D</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.PageBanner.Fields.SupportText)]
        string SupportText { get; set; }

        /// <summary>
        /// The Banner Main Heading Text field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: C9D2E949-30B9-4458-AC50-0D590B1C0333</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.PageBanner.Fields.BannerMainHeading)]
        string BannerMainHeading { get; set; }

    }
}
