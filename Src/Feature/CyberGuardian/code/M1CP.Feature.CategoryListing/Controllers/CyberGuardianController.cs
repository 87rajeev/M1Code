
using M1CP.Feature.CategoryListing.Models;
using M1CP.Feature.CategoryListing.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;
namespace M1CP.Feature.CategoryListing.Controllers
{
    public class CyberGuardianController : BaseController
    {
        /// <summary>
        /// CyberGuardian repository
        /// </summary>
        private readonly ICyberGuardianRepository _repository;
        ICyberGuardianComponentSection model = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="cyberGuardianRepository"/> class.
        /// </summary>
        /// <param name="categoryListingRepository">CyberGuardianRepository</param>
        public CyberGuardianController(ICyberGuardianRepository cyberGuardianRepository)
        {
            this._repository = cyberGuardianRepository;
        }

        /// <summary>
        /// Load CyberGuardian CategoryListing
        /// </summary>
        /// <returns>CategoryListing items</returns>
        public ActionResult CyberGuardian()
        {
            if (CurrentItem.TemplateID.ToString().Equals(Templates.CyberGuardianCategoryListing.TemplateIdString))
            {
                model = _repository.GetSubCategoryItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.CyberGuardianView, model);
        }
    }
}