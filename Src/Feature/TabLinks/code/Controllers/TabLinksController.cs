using System.Web.Mvc;
using M1CP.Foundation.Base.Controllers;
using M1CP.Feature.TabLinks.Repositories;

namespace M1CP.Feature.TabLinks.Controllers
{
    public class TabLinksController : BaseController
    {
        // GET: TabLinks
        /// <summary>
        /// The TabsLink Repository
        /// </summary>
        private readonly ITabLinksRepository _tabLinksRepository;
        public TabLinksController(ITabLinksRepository TabLinksRepository)
        {
            _tabLinksRepository = TabLinksRepository;
        }
        public ActionResult TabLinks()
        {
            var model = _tabLinksRepository.GetTabLinkItems(CurrentItem);
            
            return PartialOrEmpty(Constants.Views.CTAComponent, model); 
        }
    }
}