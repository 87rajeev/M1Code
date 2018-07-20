using Glass.Mapper.Sc.Configuration.Attributes;


namespace M1CP.Foundation.GlassMapper.Models
{
    
    [SitecoreType(TemplateId = Templates._ComponentTheme.TemplateIdString, AutoMap = true)]
    public  interface IComponentTheme
    {
        [SitecoreField(Templates._ComponentTheme.Fields.SelectedThemeFieldName)]
        IStyle SelectedTheme { get; set; }
    }
}
