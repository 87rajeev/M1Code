
namespace M1CP.Feature.Thumbnail.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;
    using System.Collections.Generic;

    [SitecoreType(TemplateId = Templates.ThumbnailSection.TemplateIdString, AutoMap = true)]
    public interface IThumbnailSection : ICTA, IItemBase, IImage, IGlassBase
    {

        /// <summary>
        /// The Thumbnail Component Items field.
        /// <para></para>
        /// <para>Field Type: Tree List</para>		
        /// <para>Field ID: 7F951ECA-B94D-4A2D-B481-C42C1C3D51A3</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ThumbnailSection.Fields.Thumbnail_Component_ItemsFieldName)]
        IEnumerable<IThumbnailComponent> Thumbnail_Component { get; set; }

        /// <summary>
        /// The Enable CTA field.
        /// <para></para>
        /// <para>Field Type: Check Box</para>		
        /// <para>Field ID: 7B2FE7B4-BD75-431B-8BBD-7809ADA81B30</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ThumbnailSection.Fields.EnableCTAFieldName)]
        bool EnableCTA { get; set; }

        [SitecoreField(Templates.ThumbnailSection.Fields.ViewLessCTA)]
        string ViewLessCTA { get; set; }
    }
}
