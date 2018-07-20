using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    //  [SitecoreType(TemplateId = "7C56C2AA-4ED0-4267-A59B-B75028957600", AutoMap = true)]
    [SitecoreType(AutoMap = true)]
    public interface IMaxMin
    {
        [SitecoreField(Templates._MaxMin.Fields.SelectedCountFieldName)]
        float value { get; set; }
    }
}
