using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.Roaming.Models
{
[SitecoreType(AutoMap = true)]
    public interface IPackList :IGlassBase
    {
       
        [SitecoreField(FieldId = "{561EFE28-BC98-4967-9EAF-E8F5C68CF738}")]
        string countryPackInfo { get; set; }

        [SitecoreField(FieldId = "{B526496F-450F-41E6-BDDB-780DE64964E2}")]
        IEnumerable<IPackItem> packList { get; set; }

        Image packIcon { get; set; }

        string packTitle { get; set; }


    }
}
