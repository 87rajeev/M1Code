using M1CP.Feature.FAQ.Models;
using M1CP.Feature.FAQ.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.FAQ.Controllers
{
    public class FAQController : BaseController
    {

        private readonly IFAQRepository _faqRepository;

        /// <summary>
        /// Intialize FAQ Repository
        /// </summary>
        /// <param name="FAQRepository">IFAQRepository</param>
        public FAQController(IFAQRepository FAQRepository)
        {
            _faqRepository = FAQRepository;
        }
       
        /// <summary>
        /// Get FAQ details
        /// </summary>
        /// <returns>View</returns>
        public ActionResult FAQ()
        {
            IFAQGroup model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates._FAQ_Group.TemplateIdString))
            {
                model = _faqRepository.GetFAQItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.FAQView, model);
        }
    }
}