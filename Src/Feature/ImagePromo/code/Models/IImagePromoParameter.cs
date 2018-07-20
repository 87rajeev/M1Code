using M1CP.Foundation.GlassMapper.Models;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace M1CP.Feature.ImagePromo.Models
{
    /// <summary>
    /// IImagePromoParameter Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Project/Common/Content Types/ImagePromo/ImagePromoParameter</para>	
    /// <para>ID: {70A2D78F-9B5E-482E-BB22-71A2A8280C7C}</para>	
    /// </summary>
    /// 
    [SitecoreType(TemplateId = Templates.ImagePromoParameter.TemplateIdString, AutoMap = true)]    
    public interface IImagePromoParamater : IComponentTheme, IComponentItemMaxMin
    {      
    }
}