namespace M1CP.Feature.Thumbnail.Models
{
    using Foundation.GlassMapper.Models;
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;
    using System.Collections.Generic;
    using Thumbnail;

    [SitecoreType(TemplateId = Templates.ThumbnailDeviceDetails.TemplateIdString, AutoMap = true)]
    public interface IThumbnailDeviceDetails : IGlassBase
    {
        /// <summary>
        /// The Device Name field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: C48FC17F-F333-4056-9869-F88A0E15DA50</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.NameFieldName)]
        string DeviceName { get; set; }

        /// <summary>
        /// The Cost Of Device field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID:04A9CF58-63F3-4EB2-914E-2445C1AF1FC5</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.Cost_of_deviceFieldName)]
        string Cost_of_device { get; set; }

        /// <summary>
        /// The Cost Of Device Per Month field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 3D58C16F-2DDB-42CE-B784-ADB7736F66E6</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.Cost_of_device_per_monthFieldName)]
        string Cost_of_device_per_month { get; set; }

        /// <summary>
        /// The SIM Details field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 04626E78-E26A-47F6-92E1-B9482B80EB08</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.SIM_DetailsFieldName)]
        string SIM_Details { get; set; }

        /// <summary>
        /// The Available Colour field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID: FC069CE6-97E3-498A-9EFE-193DAE32B187</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.Available_ColoursFieldName)]
        IEnumerable<IImage> Available_Colours { get; set; }


        /// <summary>
        /// The Device Link field.
        /// <para></para>
        /// <para>Field Type: General Link</para>		
        /// <para>Field ID: 8D0ADF74-5154-43E2-877F-550C57A1D4CC</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.ThumbnailDeviceDetails.Fields.Device_LinkFieldName)]
        Link Device_Link { get; set; }

    }
}
