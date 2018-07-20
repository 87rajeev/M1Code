namespace M1CP.Feature.TabLinks.Models
{
    using Foundation.GlassMapper.Models;
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(TemplateId = Templates.TabLinksParameter.TemplateIdString, AutoMap = true)]
     public interface ITabLinksParamater: IComponentTheme, ITextColor, IComponentItemMaxMin,  IGlassBase
    {
       
    }
}
