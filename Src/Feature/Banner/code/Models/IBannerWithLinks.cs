using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace M1CP.Feature.Banner.Models
{
    public interface IBannerWithLinks
    {
        /// <summary>
        /// The Banner Heading field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: D412EFBA-1CB9-47D7-AD56-EE90D4F18892</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerWithLinks.Fields.BannerHeading)]
        string BannerHeading { get; set; }

        /// <summary>
        /// The Banner Sub Heading field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: 93ED1D70-BF02-43EA-B0E1-CC759FA6CDF0</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerWithLinks.Fields.BannerSubHeading)]
        string BannerSubHeading { get; set; }


        /// <summary>
        /// The Banner Promo SubText field.
        /// <para></para>
        /// <para>Field Type: Rich Text</para>		
        /// <para>Field ID: D799C4ED-AACD-40F9-A399-527A08382BC1</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerWithLinks.Fields.EnableDotThemeText)]
        bool EnableDotTheme { get; set; }

        /// <summary>
        /// The Dot Image Field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 5EF156E0-1297-4FC0-8B96-088BB3F9C91C</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerWithLinks.Fields.DotImageSubText)]
        Image DotImage { get; set; }
    }
}
