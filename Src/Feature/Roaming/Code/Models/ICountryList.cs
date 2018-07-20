namespace M1CP.Feature.Roaming.Models
{

    using Foundation.Base.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using M1CP.Foundation.GlassMapper.Models;
    using System.Collections.Generic;
    using Roaming;

    [SitecoreType(AutoMap = true)]
    public interface ICountryList: IItemBase
    {

        [SitecoreField(Templates.CountryList.Fields.CalltoActionFieldName)]
        string CallToActionField { get; set; }

        [SitecoreField(Templates.CountryList.Fields.CountryListFieldName)]
        IEnumerable<ICountryDetails> CountryListField { get; set; }

    }
}