using System.Web.Mvc;
using M1CP.Foundation.Base.Controllers;
using M1CP.Feature.ImagePromo.Repositories;
using M1CP.Feature.ImagePromo.Models;

namespace M1CP.Feature.ImagePromo.Controllers
{
    /// <summary>
    /// ImagePromoController
    /// </summary>
    public class ImagePromoController : BaseController
    {
        /// <summary>
        /// Image promo repository
        /// </summary>
        private readonly IImagePromoRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePromoController"/> class.
        /// </summary>
        /// <param name="imagePromoRepository">imagePromoRepository</param>
        public ImagePromoController(IImagePromoRepository imagePromoRepository)
        {
            this._repository = imagePromoRepository;
        }

       /// <summary>
       /// Load image promo component 
       /// </summary>
       /// <returns>Image promo items</returns>
        public ActionResult ImagePromo()
        {
            IImagePromoInfo model = null;
            if (CurrentItem != null && CurrentItem.TemplateID.ToString().Equals(Templates.ImagePromoInfo.TemplateIdString))
            {
                model = _repository.GetImagePromoItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.ImagePromo, model);
        }
    }
}