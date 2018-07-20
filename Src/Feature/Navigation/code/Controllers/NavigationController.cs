using System;
using M1CP.Foundation.Base.Extensions;

namespace M1CP.Feature.Navigation.Controllers
{
    using Foundation.Caching.Contract;
    using Foundation.Base.Controllers;
    using Models;
    using Repositories;
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Navigation controller to display the header and footer
    /// </summary>
    /// <seealso cref="M1CP.Foundation.Base.Controllers.BaseController" />
    public class NavigationController : BaseController
    {
        #region CachKey Constants

        private const string MainNavigationcachKey = Constants.Property.MainNavigationCacheKey;
        private const string PersonalcachKey = Constants.Property.PersonalNavigationCacheKey;
        private const string PageFootercachKey = Constants.Property.FooterNavigationCacheKey;
        private const string RightNavigationcachKey = Constants.Property.RightNavigationCachekey;

        #endregion CachKey Constants

        /// <summary>
        /// The navigation repository
        /// </summary>
        private readonly INavigationRepository _navigationRepository;

        private readonly ICache _cache;

        /// <summary>
        /// Initializes a new instance of the Css<see cref="NavigationController"/> class.
        /// </summary>
        public NavigationController()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="cache"></param>
        public NavigationController(INavigationRepository repository, ICache cache)
        {
            this._navigationRepository = repository;
            _cache = cache;
        }

        /// <summary>
        /// Top Mains Personal the navigation.
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonalNavigation()
        {
            var model = NavigationGroup(PersonalcachKey);

            return PartialOrEmpty(Constants.Views.MainNavigation, model);
        }

        public ActionResult MainNavigation()
        {
            var model = NavigationGroup(MainNavigationcachKey);
            return PartialOrEmpty(Constants.Views.Navbar, model);
        }

        /// <summary>
        /// Businesses the navigation.
        /// </summary>
        /// <returns></returns>

        /// <summary>
        ///   footer navigation
        /// </summary>
        /// <returns></returns>
        public ActionResult PageFooter()
        {
            var model = NavigationGroup(PageFootercachKey);
            ViewBag.FooterId="footer-" + ExtensionHelper.ParseId(Guid.NewGuid());
            return PartialOrEmpty(Constants.Views.FooterNavigation, model);
        }

        /// <summary>
        /// Rights the navigation.
        /// </summary>
        /// <returns></returns>
        public ActionResult RightNavigation()
        {
            var model = NavigationGroup(RightNavigationcachKey);

            return PartialOrEmpty(Constants.Views.RightNavigation, model);
        }

        /// <summary>
        /// Navigations the group.
        /// </summary>
        /// <param name="cachKey">The cach key.</param>
        /// <returns></returns>
        private NavigationGroup NavigationGroup(string cachKey)
        {
            var model = _cache.GetOrSet(CurrentItem?.ID + cachKey, () =>
                _navigationRepository.GetNavigationLinks(CurrentItem), Constants.Property.Duration);

            return model;
        }

        /// <summary>
        /// Sites the identity.
        /// </summary>
        /// <returns></returns>
        public ActionResult SiteIdentity()
        {
            var cportalPage = this.SitecoreContext.GetItem<LogoItem>(Templates.Site.Fields.Path);

            return PartialOrEmpty(Constants.Views.SiteIdentify, cportalPage);
        }

        public ActionResult BreadCrumb()
        {
            List<URLDetails> Model = null;
            Model = _cache.GetOrSet(CurrentItem?.ID + Constants.Property.BreadCrumbCacheKey, () =>
                _navigationRepository.GetBreadCrumb(CurrentItem), Constants.Property.Duration);
            return PartialOrEmpty(Constants.Views.BreadCrumb, Model);
        }
    }
}