using M1CP.Feature.Carousal.Models;
using M1CP.Feature.Carousal.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.Carousal.Controllers
{
    public class CarousalController : BaseController
    {
        /// <summary>
        /// The Carousal Repository
        /// </summary>
        private readonly ICarousalRepository _carousalRepository;


        /// <summary>
        /// Initializes a new instance of the <see cref="CarousalController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public CarousalController(ICarousalRepository CarousalRepository)
        {
            _carousalRepository = CarousalRepository;
        }

        /// <summary>
        /// Image Carousal.
        /// </summary>
        /// <returns></returns>
        public ActionResult ImageCarousal()
        {
            ICarousal model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.CarousalContent.TemplateIdString))
            {
                model = _carousalRepository.GetCarousalItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.ImageCarousal, model);
        }


        /// <summary>
        /// Text Carousal.
        /// </summary>
        /// <returns></returns>
        public ActionResult TextCarousal()
        {
            ICarousal model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.CarousalContent.TemplateIdString))
            {
                model = _carousalRepository.GetCarousalItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.TextCarousal, model);
        }


        /// <summary>
        /// Device Carousal.
        /// </summary>
        /// <returns></returns>
        public ActionResult DeviceCarousal()
        {
            IDeviceCarousal model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.CarousalContent.DeviceCarousalTemplateIdString))
            {
                model = _carousalRepository.GetDeviceCarousalItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.DeviceCarousal, model);
        }


        /// <summary>
        /// Image Thumbnail Carousal.
        /// </summary>
        /// <returns></returns>
        public ActionResult ImageThumbnailCarousal()
        {
            ICarousal model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.CarousalContent.TemplateIdString))
            {
                model = _carousalRepository.GetCarousalItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.ImageThumbnailCarousal, model);
        }
        public ActionResult DeviceListing()
        {
            IDeviceCarousal model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.DeviceCarousal.DeviceCarousalTemplateIdString))
            {
                model = _carousalRepository.GetDeviceCarousalItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.DeviceListing, model);
        }
    }
}