using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    //[SitecoreType(AutoMap = true)]
    //[SitecoreType(TemplateId = Templates._Image.TemplateIdString, AutoMap = true)] //, Cachable = true
    [SitecoreType(TemplateId = Templates._GradientColor.TemplateIdString)]
    public interface IGradientColor
    {
        [SitecoreField(Templates._GradientColor.Fields.SelectedGradientColor)]
        IStyle GradientTheme { get; set; }
    }
}
