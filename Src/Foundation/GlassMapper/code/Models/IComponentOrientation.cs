using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace M1CP.Foundation.GlassMapper.Models
{
    [SitecoreType(TemplateId = Templates._ComponentOrientation.TemplateIdString, AutoMap = true)]
    public interface IComponentOrientation
    {
        [SitecoreField(Templates._ComponentOrientation.Fields.SelectedThemeFieldName)]
        IStyle SelectedOrientation { get; set; }
    }
}
