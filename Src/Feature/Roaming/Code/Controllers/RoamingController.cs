namespace M1CP.Feature.Roaming.Controllers
{
    using Foundation.Base.Controllers;
    using System.Web.Mvc;
    using M1CP.Feature.Roaming.Repositories;
    using M1CP.Feature.Roaming.Models;

    public class RoamingController : BaseController
    {
        // GET: TravelDestination
        
        private readonly IRoamingRepository _roamingRepository;

        public RoamingController(IRoamingRepository roamingRepository)
        {
            _roamingRepository = roamingRepository;
        }

        public ActionResult Prepaid()
        {
            ICountryList model = null;
            
            
            if(CurrentItem.TemplateID.ToString().Equals(Templates.CountryList.TemplateIdString))
            {
                model = _roamingRepository.GetCountryList(CurrentItem);
            }
            return PartialOrEmpty(Constants.views.PrepaidRoaming, model);
            
        }

        public ActionResult Postpaid()
        {
            ICountryList model = null;


            if (CurrentItem.TemplateID.ToString().Equals(Templates.CountryList.TemplateIdString))
            {
                model = _roamingRepository.GetCountryList(CurrentItem);
            }
            return PartialOrEmpty(Constants.views.PostpaidRoaming, model);

        }

        public ActionResult PackData()
        {

           var  model = _roamingRepository.GetPackItems(CurrentItem);
           
            return PartialOrEmpty(Constants.views.PackDetail, model);

        }
    }
}