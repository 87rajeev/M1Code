using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Feature.ImagePromo.Models;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;
using System.Collections.Generic;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateName = Templates.Iconthumbnail.TemplateName, AutoMap = true)]
    public interface IThumbnailIcon : IGlassBase, IItemBase, ICTA, IImage
    {
        [SitecoreField(Templates.Iconthumbnail.Fields.Thumbnaillistitems)]
        IEnumerable<IImagePromoContent> Iconthumbnaillist { get; set; }
    }
}