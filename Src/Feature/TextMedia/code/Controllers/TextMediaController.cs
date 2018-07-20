using M1CP.Feature.TextMedia.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.TextMedia.Controllers
{
    public class TextMediaController : BaseController
    {
        readonly ITextMediaRepostiry _repository;
        public TextMediaController(ITextMediaRepostiry textMediaRepository)
        {
            this._repository = textMediaRepository;
        }
        /// <summary>
        /// Get List of Text and Media Components
        /// </summary>
        /// <returns>
        /// Partial View : If datasource is defined and is not anugular component
        /// Angular View : If datasource is defined and is angular comopnent
        /// Empty: If datasource is not defined
        /// </returns>
        public ActionResult List()
        {
            var model = _repository.GetMediaModelList(CurrentItem);
            return PartialOrEmpty(Constants.Views.List, model);
        }
        /// <summary>
        /// Get List of Text and Media Components without any Image
        /// </summary>
        /// <returns>
        /// Partial View : If datasource is defined and is not anugular component
        /// Angular View : If datasource is defined and is angular comopnent
        /// Empty: If datasource is not defined
        /// </returns>
        public ActionResult NoImageList()
        {
            var model = _repository.GetMediaModelList(CurrentItem);
            return PartialOrEmpty(Constants.Views.NoImageList, model);
        }
    }
}