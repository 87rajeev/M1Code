

namespace M1CP.Feature.Content.Models
{
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;

    [SitecoreType(TemplateId =Foundation.GlassMapper.Templates.ItemBase.TemplateIdString, AutoMap = true)]
    public interface IContent: IItemBase,IImage, IGlassBase
    {
       
    }
}
