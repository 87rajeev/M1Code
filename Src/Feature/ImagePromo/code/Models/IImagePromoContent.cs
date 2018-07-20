using M1CP.Foundation.Base.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.GlassMapper.Models;
namespace M1CP.Feature.ImagePromo.Models
{
    /// <summary>
    /// IImagePromoContent Interface
    /// <para></para>
    /// <para>Path: /sitecore/templates/User Defined/m1/M1CP/Feature/ImagePromo/_ImagePromoContent</para>	
    /// <para>ID: BFCA30A6-4A9A-4FCD-8A39-AF402438195D</para>	
    /// </summary>
    [SitecoreType(TemplateId = Templates.ImagePromoContent.TemplateIdString, AutoMap = true)]
    public interface IImagePromoContent : ICTA, IItemBase, IImage, IGlassBase
    {
       
    }
}
