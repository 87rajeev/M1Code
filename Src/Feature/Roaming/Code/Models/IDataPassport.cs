using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1CP.Feature.Roaming.Models
{
    public interface IDataPassport
    {
        [SitecoreField(Templates.DataPassport.Fields.DataPassportTitle)]
        string DataPassportTitle { get; set; }

        [SitecoreField(Templates.DataPassport.Fields.DataPassportHeading)]
        string DataPassportHeading { get; set; }

        [SitecoreField(Templates.DataPassport.Fields.DataPassportDescription)]
        string DataPassportDescription { get; set; }

        [SitecoreField(Templates.DataPassport.Fields.DataPassportCountryList)]
        IEnumerable<IDataPassportCountryList> DataPassportCountryList { get; set; }
    }
}
