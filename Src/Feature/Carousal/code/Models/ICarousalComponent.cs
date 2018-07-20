
namespace M1CP.Feature.Carousal.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;


    [SitecoreType(TemplateId = Templates.CarousalComponent.TemplateIdString)]
    public interface ICarousalComponent : IVideo, IItemBase, IImage,ICTA, IGlassBase
    {
      
    }

}
