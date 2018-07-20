using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;
using M1CP.Feature.Banner.Repositories;
using M1CP.Feature.Banner.Models;
using M1CP.Foundation.SitecoreExtensions.Extensions;
using M1CP.Foundation.GlassMapper.Models;

namespace M1CP.Feature.Banner.Controllers
{
    public class BannerController : BaseController
    {
        readonly IBannerRepository _bannerRepository;
        public BannerController(IBannerRepository heroBannerRepository)
        {
            this._bannerRepository = heroBannerRepository;
        }

        /// <summary>
        /// Top Banner.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTopBannerItem()
        {
            IBannerModel model = null;          
            if (CurrentItem.TemplateID.ToString().Equals(Templates.BannerModel.TemplateIdString))
            {
                model = _bannerRepository.GetBannerItems(CurrentItem);
                
                foreach (ICTA CTA in model.CTATitle)
                {
                    //Get Associated goal's from CTA
                    CTA.TrackingID = ItemExtensions.GetEventDefinition(Sitecore.Context.Database.GetItem(CTA.Id.ToString()));
                }
            }
            return PartialOrEmpty(Constants.Views.TopBannerView, model);
        }


        /// <summary>
        /// Top Banner with Links.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTopBannerWithLinks()
        {
            HeroBannerWithLinks model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.BannerWithLinks.TemplateIdString))
            {
                model = _bannerRepository.GetTopBannerWithLinks(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.TopBannerWithLinksView, model);
        }

        /// <summary>
        /// Page Banner.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPageBannerItem()
        { 
            IPageBanner model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.PageBanner.PageBannerTemplateIdString))
            {
                model = _bannerRepository.GetPageBannerItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.PageBannerView, model);
                
        }

        /// <summary>
        /// Data Passport Page Banner.
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDataPassportPageBannerItem()
        {
            IPageBanner model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.PageBanner.PageBannerTemplateIdString))
            {
                model = _bannerRepository.GetPageBannerItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.DataPassportPageBannerView, model);

        }
        public ActionResult GetBannerWithoutCTA()
        {
            IBannerWithoutCTA model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.BannerWithoutCTA.TemplateIdString))
            {
                model = _bannerRepository.GetTopBannerWithoutCTA(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.BannerWithoutCTAView, model);

        }
        public ActionResult GetImagePageBannerItem()
        {
            IPageBanner model = null;
            if (CurrentItem.TemplateID.ToString().Equals(Templates.PageBanner.ImagePageBannerTemplateIdString))
            {
                model = _bannerRepository.GetPageBannerItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.PageBannerView, model);

        }

    }
}