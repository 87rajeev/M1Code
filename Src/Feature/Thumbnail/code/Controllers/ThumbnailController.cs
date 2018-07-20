using System.Web.Mvc;
using M1CP.Foundation.Base.Controllers;
using M1CP.Feature.Thumbnail.Repositories;
using M1CP.Feature.Thumbnail.Models;

namespace M1CP.Feature.Thumbnail.Controllers
{
    public class ThumbnailController : BaseController
    {
        // <summary>
        /// The ThumbnailGradient repository
        /// </summary>
        private readonly IThumbnailRepository _thumbnailRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailGradientController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ThumbnailController(IThumbnailRepository repository)
        {
            this._thumbnailRepository = repository;
        }

        public ActionResult ThumbnailTextGradient()
        {
            var model = _thumbnailRepository.GetGradientThumnailItems(CurrentItem);
            return PartialOrEmpty(Constants.Views.ThumbnailTextGradient, model);

        }
        public ActionResult ThumbnailWithGradient()
        {
            var model = _thumbnailRepository.GetGradientThumnailItems(CurrentItem);
            return PartialOrEmpty(Constants.Views.ThumbnailGradient, model);

        }

        /// <summary>
        /// Image Thumbnail.
        /// </summary>
        /// <returns></returns>
        public ActionResult ImageThumbnail()
        {
            IThumbnailSection model=null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.Thumbnail.TemplateIdString))
            {
                model = _thumbnailRepository.GetThumbnailItems(CurrentItem);
            }             
            return PartialOrEmpty(Constants.Views.ImageThumbnail, model);
        }

        /// <summary>
        /// Device Thumbnail.
        /// </summary>
        /// <returns></returns>
        public ActionResult DeviceThumbnail()
        {
            var model = _thumbnailRepository.GetDeviceThumbnailItems(CurrentItem);
            return PartialOrEmpty(Constants.Views.DeviceThumbnail, model);
        }

        public ActionResult PromotionThumbnail()
        {
            IThumbnailSection model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.Thumbnail.TemplateIdString))
            {
                model = _thumbnailRepository.GetThumbnailItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.PromotionThumbnail, model);
        }

        public ActionResult ThumbnailIcon()
        {
            IThumbnailIcon model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.Iconthumbnail.TemplateIdString))
            {
                model = _thumbnailRepository.GetThumbnailicons(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.IconThumbnail, model);
        }

    }
}