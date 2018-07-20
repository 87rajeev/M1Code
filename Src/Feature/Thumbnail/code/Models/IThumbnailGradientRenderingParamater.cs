namespace M1CP.Feature.Thumbnail.Models
{
    using Foundation.GlassMapper.Models;
    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(TemplateId = Templates._ThumbnailGradientRenderingParamater.TemplateIdString, AutoMap = true)]
       public interface IThumbnailGradientRenderingParamater : IComponentItemMaxMin,  IGlassBase
    {
       
    }
}
