
namespace M1CP.Foundation.AssetsIncludes.Models
{
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(AutoMap =true)]
 public    interface AssertModel
    {
        [SitecoreField(FieldName=Templates.PageAssets.Fields.CssCode)]
        string cssIncludes { get; set; }

        [SitecoreField(FieldName=Templates.PageAssets.Fields.JavascriptCodeTop)]
        string scriptIncludes { get; set; }

        [SitecoreField(FieldName=Templates.PageAssets.Fields.GACode)]
        string gaIncludes { get; set; }

    }
}
