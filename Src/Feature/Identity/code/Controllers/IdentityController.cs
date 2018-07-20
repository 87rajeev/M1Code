using System.Web.Mvc;
using M1CP.Feature.Identity.Models;
using M1CP.Foundation.Base.Controllers;

namespace M1CP.Feature.Identity.Controllers
{
    /// <summary>
    /// Identity class used to display site level information like logo
    /// </summary>
    /// <seealso cref="M1CP.Foundation.Base.Controllers.BaseController" />
    public class IdentityController :BaseController
    {
        // GET: Identity
        public ActionResult SiteIdentity()
        {
            var cportalPage = SitecoreContext.GetItem<LogoItem>(Templates.Site.Fields.Path);

            return PartialOrEmpty(Constants.Views.SiteIdentify, cportalPage);
        }
    }
}