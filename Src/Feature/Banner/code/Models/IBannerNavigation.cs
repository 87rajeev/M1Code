using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using System.Collections.Generic;

namespace M1CP.Feature.Banner.Models
{
    public interface IBannerNavigation
    {
        /// <summary>
        /// The Navigation Header field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: B3C2C9C2-49CA-4D48-BE23-BF7780422E4A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerNavigation.Fields.NavigationHeader)]
        string NavigationHeader { get; set; }

        /// <summary>
        /// The Navigation Links field.
        /// <para></para>
        /// <para>Field Type: Multi Root Tree List</para>		
        /// <para>Field ID: 4F352FAA-4DB9-403D-932E-AF0B2A2A3FF2</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.BannerNavigation.Fields.NavigationLinksHeading)]
        IEnumerable<ICTA> NavigationLinks { get; set; }
    }
}
