using M1CP.Feature.Content.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.Content.Controllers
{
    public class ContentController : BaseController
    {
        /// <summary>
        /// The Content Repository
        /// </summary>
        private readonly IContentRepository _contentRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="contentController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ContentController(IContentRepository contentRepository)
        {
             _contentRepository = contentRepository;
        }

        // GET: Content
        public ActionResult TextContent()
        {
            var model = _contentRepository.GetContent(CurrentItem);
                       return PartialOrEmpty(Constants.Views.TextContent, model);
           // return null;
        }
        public ActionResult ImageContent()
        {
            var model = _contentRepository.GetImageContent(CurrentItem);
            return PartialOrEmpty(Constants.Views.ImageContent, model);
            // return null;
        }
    }
}