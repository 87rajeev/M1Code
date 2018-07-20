using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateId = Templates.ThunmbnailItem.TemplateIdString, AutoMap = true)]
    public interface IThumbnail :IGradientColor,IGlassBase, IStyle
    {
        /// <summary>
        /// The CTA Title field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 54157107-9B6D-436F-9FD5-D6A247C0DF1E</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ThunmbnailItem.Fields.TitleFieldName)]
        string ThumbnailTitle { get; set; }

        /// <summary>
        /// The CTA Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: B3EAA68C-885E-442B-9BBE-8859D555422F</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.ThunmbnailItem.Fields.DescriptionFieldName)]
        string ThumbnailDescription { get; set; }

        [SitecoreField(Templates.ThunmbnailItem.Fields.NotationsFieldName)]
        string ThumbnailNotation { get; set; }

        [SitecoreField(Templates.ThunmbnailItem.Fields.ShortSummaryFieldName)]
        string ThumbnailShortSummary { get; set; }

        //[SitecoreField(Templates.ThunmbnailItem.Fields.ColorFieldName)]
        //IStyle ThumbnailColor { get; set; }
    }
}

