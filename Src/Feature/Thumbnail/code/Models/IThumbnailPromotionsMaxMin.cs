using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateId = "4BEDABF1-8218-491B-8A4B-0651046E97A1", AutoMap = true)]
    public interface IThumbnailPromotionsMaxMin : IGlassBase
    {
        [SitecoreField(Templates.ThumbnailPromotion.Fields.ThumbnailPromotionsCount)]
        IMaxMin ThumbnailPromotionsCount { get; set; }        
    }
}