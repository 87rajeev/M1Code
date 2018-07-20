using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateId = "{B2B559C9-2779-4447-ACD7-2EC01E917DAD}", AutoMap = true)]
    public interface IThumbnailPromotionParameter : IComponentTheme, IComponentOrientation, IThumbnailPromotionsMaxMin
    {

    }
}