

namespace M1CP.Feature.TabLinks.Models
{
    using Foundation.GlassMapper.Models;
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    [SitecoreType(TemplateId = Templates.LinkTabs.TemplateIdString, AutoMap = true)]
   public interface ITabLink: IItemBase,ICTAGroup, IGlassBase
    {
    }
}
