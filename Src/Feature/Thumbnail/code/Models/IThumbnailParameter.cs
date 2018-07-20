using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(TemplateId = "{FDDC1D0B-255A-4528-87DA-D739A8F625F6}", AutoMap = true)]
    public interface IThumbnailParameter: IComponentTheme, IComponentOrientation,IComponentItemMaxMin
    {
     
    }
}