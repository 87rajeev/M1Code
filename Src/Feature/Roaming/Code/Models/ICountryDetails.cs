namespace M1CP.Feature.Roaming.Models
{

    using Glass.Mapper.Sc.Configuration.Attributes;
   
    using Roaming;

    [SitecoreType(AutoMap = true)]
    public interface ICountryDetails
    {

        [SitecoreField(Templates.CountryDetails.Fields.CountryNameFieldName)]
        string CountryName { get; set; }

        [SitecoreField(Templates.CountryDetails.Fields.CountryPageLinkFieldName)]
        string CountryLink { get; set; }

        [SitecoreField(Templates.CountryDetails.Fields.CountrySpecificNotesFieldName)]
        string CountryNotes { get; set; }

        [SitecoreField(Templates.CountryDetails.Fields.PromotionContentFieldName)]
        string CountryPromotion { get; set; }
    }
}