using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Banner.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ISlider
    {
        [SitecoreField(Templates.Slidercolor.Fields.SliderColor)]
        IStyle SliderColor { get; set; }
    }
}
