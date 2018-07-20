using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Banner.Models
{
    [SitecoreType(TemplateId = Templates.BannerWithoutCTA.TemplateIdString, AutoMap = true)]
    //[SitecoreType( AutoMap = true)]
    public interface IBannerWithoutCTA:IItemBase,IGlassBase
    {
        [SitecoreField(Templates.BannerWithoutCTA.Fields.SubTitle)]
        string SubTitle { get; set; }

        [SitecoreField(Templates.BannerWithoutCTA.Fields.EnableDots)]
        bool EnableDots { get; set; }
    }
}
