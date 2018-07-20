namespace M1CP.Feature.Thumbnail.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;

    [SitecoreType(TemplateId = Templates.ThumbnailComponent.TemplateIdString, AutoMap = true)]
    public interface IThumbnailComponent : IVideo, IItemBase, IImage, ICTA, IGlassBase
    {

        /// <summary>
        /// The Thumnail Support Text field.
        /// <para></para>
        /// <para>Field Type: Single Text Field</para>		
        /// <para>Field ID: 1D98E6F5-843F-49BE-8E1B-5ED6227212A9</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ThumbnailComponent.Fields.Thumnail_Support_TextFieldName)]
        string Thumnail_Support_Text { get; set; }
    }
}
