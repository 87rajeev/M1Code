namespace M1CP.Feature.Thumbnail.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;
    using System.Collections.Generic;
    using Thumbnail;

    [SitecoreType(TemplateId = Templates.DeviceThumbnail.TemplateIdString, AutoMap = true)]
    public interface IDeviceThumbnail : IItemBase, IGlassBase
    {

        /// <summary>
        /// The Devices field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID:550B2969-2B2A-4157-9D16-8202239E6BB4</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceThumbnail.Fields.DevicesFieldName)]
        IEnumerable<IThumbnailDeviceDetails> Devices { get; set; }
    }
}
