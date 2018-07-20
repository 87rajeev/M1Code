using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Content.Models
{
    [SitecoreType(TemplateId = Templates.ImageDetails.TemplateIdString, AutoMap = true)]
   public  interface IImageContent: IItemBase, IImage,IGlassBase
    {
    }
}
