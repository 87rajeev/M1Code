
namespace M1CP.Feature.Carousal.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;
    using M1CP.Foundation.GlassMapper.Models;
    using System.Collections.Generic;

    [SitecoreType(TemplateId = Templates.DeviceCarousal.TemplateIdString, AutoMap = true)]
    public interface IDeviceCarousal:IItemBase, IGlassBase
    {

        /// <summary>
        /// The Devices field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID:E0F181F9-5708-4A59-955F-339084ABD546</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceCarousal.Fields.DevicesFieldName)]
        IEnumerable<IDeviceDetails> Devices { get; set; }
        /// <summary>
        /// The Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: 1C2E6556-7956-47FF-B335-4C36393A04FA</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.DeviceCarousal.Fields.NewProductLogosFieldName)]
        Image NewProductLogo { get; set; }

        /// <summary>
        /// The Image field.
        /// <para></para>
        /// <para>Field Type: Image</para>		
        /// <para>Field ID: A0BB96DF-54FE-440A-8EF0-CAF6CF516927</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.DeviceCarousal.Fields.FeaturedProductLogoFieldName)]
        Image FeaturedProductLogo { get; set; }


        [SitecoreField(Templates.DeviceCarousal.Fields.HotdealProductLogoFieldName)]
        Image HotdealProductLogo { get; set; }

        /// <summary>
        /// The Text field.
        /// <para></para>
        /// <para>Field Type: Text</para>		
        /// <para>Field ID: 1603F242-0DB8-4573-894A-3DC871286982</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.DeviceCarousal.Fields.ViewallProductFieldName)]
        string Viewall { get; set; }

        /// <summary>
        /// The Text field.
        /// <para></para>
        /// <para>Field Type: Text</para>		
        /// <para>Field ID: DF4F1D6D-A36F-4276-A415-EB142F88D06D</para>
        /// <para>Custom Data: </para>
        /// </summary>
        [SitecoreField(Templates.DeviceCarousal.Fields.ViewlessProductFieldName)]
        string Viewless { get; set; }
    }

}
