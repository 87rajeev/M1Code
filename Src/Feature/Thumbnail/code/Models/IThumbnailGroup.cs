using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;
using System.Collections.Generic;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateId = Templates.ThumbnailList.TemplateIdString, AutoMap = true)]
 public interface IThumbnailGroup: IItemBase, IGlassBase
    {

        [SitecoreField(Templates.ThumbnailList.Fields.Select_Thumbnail_ListFieldName)]
        IEnumerable<IThumbnail> ThumbnailList { get; set; }
    }
}
