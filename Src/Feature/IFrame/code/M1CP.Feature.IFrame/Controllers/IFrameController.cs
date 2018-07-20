using Sitecore.Configuration;
using Sitecore.Data;
using System.Web.Mvc;
using M1CP.Foundation.Base.Controllers;
using M1CP.Feature.IFrame.Repositories;
using M1CP.Feature.IFrame.Models;

namespace M1CP.Feature.IFrame.Controllers
{
    /// <summary>
    /// IFrameController
    /// </summary>
    public class IFrameController: BaseController
    {
        /// <summary>
        /// IFrame repository
        /// </summary>
        private readonly IIFrameRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="IFrameController"/> class.
        /// </summary>
        /// <param name="iframeRepository">iframeRepository</param>
        public IFrameController(IIFrameRepository iframeRepository)
        {
            this._repository = iframeRepository;
        }

        /// <summary>
        /// Load IFrame component 
        /// </summary>
        /// <returns>IFrame items</returns>
        public ActionResult IFrame()
        {
            IIFrame model = null;
            if (CurrentItem != null)
            {
                model = _repository.GetIFrameItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.IFrame, model);
        }
    }
}