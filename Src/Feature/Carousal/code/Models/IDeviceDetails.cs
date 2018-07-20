
namespace M1CP.Feature.Carousal.Models
{
    using Foundation.GlassMapper.Models;
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;
    using System.Collections.Generic;

    [SitecoreType(TemplateId = Templates.DeviceDetails.TemplateIdString, AutoMap = true)]
    public interface IDeviceDetails: IGlassBase,IImage
    {
        /// <summary>
        /// The Device Name field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 1DBF18A4-A103-4CB6-AE06-8DF7956D54BC</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.NameFieldName)]
        string DeviceName { get; set; }

        /// <summary>
        /// The Device Model field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 55D798CB-60FB-4CC0-8E77-6253A125343E</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.DeviceModelFieldName)]
        string DeviceModel { get; set; }

        /// <summary>
        /// The Cost Of Device field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID:2A983145-E504-429E-9FCD-103814952DEB</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.CostofdeviceFieldName)]
        string Costofdevice { get; set; }

        /// <summary>
        /// The Cost Of Device Per Month field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 81C6ADB6-A1A5-43FC-974C-5E2504F5E167</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.CostofdevicepermonthFieldName)]
        string Costofdevicepermonth { get; set; }

        /// <summary>
        /// The SIM Details field.
        /// <para></para>
        /// <para>Field Type: Single Text</para>		
        /// <para>Field ID: 3030F33D-9337-49E9-BDCA-B57ED7B0AC4A</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.SIMDetailsFieldName)]
        string SIMDetails { get; set; }

        /// <summary>
        /// The Available Colour field.
        /// <para></para>
        /// <para>Field Type: Treelist</para>		
        /// <para>Field ID: 03C4168C-5D10-4B34-9DE4-F8264EDC0BD2</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.AvailableColoursFieldName)]
        IEnumerable<IColor> AvailableColours { get; set; }

        /// <summary>
        /// The Device Link field.
        /// <para></para>
        /// <para>Field Type: Link</para>		
        /// <para>Field ID: 2EA23078-91A8-4732-BAC1-B325C30F10B7</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.DeviceLinkFieldName)]
        Link DeviceLink { get; set; }

        /// <summary>
        /// The Device Offers field.
        /// <para></para>
        /// <para>Field Type: String</para>            
        /// <para>Field ID: 603FD975-1593-426B-8AC1-CF81F8F2F25C</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.DeviceoffersFieldName)]
        string Offers { get; set; }


        /// <summary>
        /// Checkbox field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 7DC572AB-B53C-4D72-923D-3DF7E3F796B6</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 

        [SitecoreField(Templates.DeviceDetails.Fields.DeviceFeaturedFieldName)]
        bool Featured { get; set; }

        /// <summary>
        /// Checkbox field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: 2D688E17-99B2-4801-A2CB-A28B841F457E</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.DeviceHotdealFieldName)]
        bool Hotdeal { get; set; }

        /// <summary>
        /// Checkbox field.
        /// <para></para>
        /// <para>Field Type: Checkbox</para>		
        /// <para>Field ID: F9C97C6B-6C11-43B6-8B17-3212BF39ECE5</para>
        /// <para>Custom Data: </para>
        /// </summary>
        /// 
        [SitecoreField(Templates.DeviceDetails.Fields.DeviceNewIdFieldName)]
        bool New { get; set; }



    }
}