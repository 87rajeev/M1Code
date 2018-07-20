using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Banner.Models
{
    [SitecoreType(TemplateId = Templates.BannerModel.TemplateIdString, AutoMap = true)]
   
    public interface IBannerModel : IVideo, IImage, IItemBase,ICTAGroup,IGlassBase
    {
        /// <summary>
        /// The Banner Main Heading field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 0ED77FDC-77B7-44B9-B76B-30C04474899A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.BannerMainHeading)]
        string BannerMainHeading { get; set; }

        /// <summary>
        /// The Banner Heading field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: DEFE043D-E4AB-4D7D-8DF1-27CD3D4E5785</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.BannerHeading)]
        string BannerHeading { get; set; }

        /// <summary>
        /// The Banner Sub Heading field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 0217E3D6-12EF-45B9-93D5-480841400D91</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.BannerSubHeading)]
        string BannerSubHeading { get; set; }

        /// <summary>
        /// The Banner Promo Text field.
        /// <para></para>
        /// <para>Field Type: Single Line Text</para>		
        /// <para>Field ID: F8E22791-9719-4312-AE4F-FF18FEE45476</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.BannerPromoText)]
        string BannerPromoText { get; set; }

        /// <summary>
        /// The Banner Promo SubText field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 8F00C23B-7EBE-4B9F-B262-841652D0889A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.BannerPromoSubText)]
        string BannerPromoSubText { get; set; }

        /// <summary>
        /// The Banner Promo SubText field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 8F00C23B-7EBE-4B9F-B262-841652D0889A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.EnableDotThemeText)]
        bool EnableDotTheme { get; set; }

        /// <summary>
        /// The Dot Image Field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 7B44F754-9A75-498A-96BB-198E7B5EA932</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerModel.Fields.DotImageSubText)]
        Image DotImage { get; set; }

    }
  
}