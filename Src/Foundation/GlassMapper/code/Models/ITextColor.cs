using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Foundation.GlassMapper.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ITextColor
    {
        [SitecoreField(Templates._ITextColor.Fields.SelectedTxtColorFieldName)]
        IStyle txtColor { get; set; }
    }
}
