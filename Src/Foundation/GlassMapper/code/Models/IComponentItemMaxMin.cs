using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IComponentItemMaxMin
    {
        [SitecoreField(Templates._IComponentItemMaxMin.Fields.SelectedDesktopCountFieldName)]
        IMaxMin desktopCount { get; set; }
        [SitecoreField(Templates._IComponentItemMaxMin.Fields.SelectedMobileCountFieldName)]
        IMaxMin mobileCount { get; set; }
    }
}
