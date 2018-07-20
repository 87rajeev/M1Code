using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.Roaming.Models
{
    [SitecoreType(AutoMap = true)]
    public   interface IPackInfo : IGlassBase
    {
        [SitecoreField(FieldId = "{B749989E-BFA7-4D6C-8A12-4848323622D6}")]
        Image packIcon { get; set; }

        [SitecoreField(FieldId = "{AC4EC2DF-1E1A-4B9B-B5FC-9DFA74BF4C52}")]
        string packTitle { get; set; }
    }
}
