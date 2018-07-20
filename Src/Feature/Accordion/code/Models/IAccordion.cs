using Glass.Mapper.Sc.Configuration.Attributes;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Accordion.Models
{
    [SitecoreType(TemplateId = Templates.AccordionTemplate.TemplateIdString, AutoMap = true)]
    public interface IAccordion : IGlassBase, IItemBase
    {
        [SitecoreField(Templates.AccordionTemplate.Fields.CountFieldName)]
        int Count { get; set; }
    }
}