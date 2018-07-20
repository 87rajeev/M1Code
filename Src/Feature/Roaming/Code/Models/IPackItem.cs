using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;
using M1CP.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.Roaming.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IPackItem: IGlassBase,ICTA,IItemBase
    {
      
    }
}
