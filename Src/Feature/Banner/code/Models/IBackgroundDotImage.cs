using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Banner.Models
{
    [SitecoreType(TemplateId = Templates.BackgroundDotImage.TemplateIdString, AutoMap = true)]
    public interface IBackgroundDotImage
    {
        IStyle DotImageColor { get; set; }

    }
}
