namespace M1CP.Feature.Carousal.Models
{
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(TemplateId = Templates.DeviceList.TemplateIdString, AutoMap = true)]
    public interface IDeviceCount
    {
        [SitecoreField(Templates.DeviceList.Fields.DeviceCountFieldName)]
        int Count { get; set; }
    }
}