using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Thumbnail.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ITextGradientColor : IGlassBase, IStyle
    {
        [SitecoreField(Templates._TextGradientColor.Fields.SelectedTextGradientColor)]
        IStyle TextGradient { get; set; }
    }

}
