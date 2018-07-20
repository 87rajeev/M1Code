using M1CP.Feature.Accordion.Models;
using M1CP.Feature.Accordion.Repositories;
using M1CP.Foundation.Base.Controllers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
//using M1CP.Feature.Accordion.Models;

namespace M1CP.Feature.Accordion.Controllers
{
    public class AccordionController : BaseController
    {
       
        /// <summary>
        /// private property to hold accordion repository
        /// </summary>
        private readonly IAccordionRepository _accordionRepository;

        /// <summary>
        /// Intialize accordion repository
        /// </summary>
        /// <param name="accordion">Accordion repository</param>
        public AccordionController(IAccordionRepository accordion)
        {
            _accordionRepository = accordion;            
        }
        
        /// <summary>
        /// Get accordion and its respective sections 
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Accordion()
        {
            IAccordionRepository model = null;
            model = _accordionRepository;
            return PartialOrEmpty(Constants.Views.AccordionView, model);               
        }

        /// <summary>
        /// Get all Financial year results
        /// </summary>
        /// <param name="year">Year</param>
        /// <returns>View</returns>
        public ActionResult AccordionListWithThumbnail(float year=2017)
        {
            IFinancialResultsYear model =null;            
            if(CurrentItem.TemplateID.ToString().Equals(Templates.FinancialResultsFolder.TemplateIdString))
            {
                model = _accordionRepository.GetAccordionThumbnailItems(CurrentItem, year);
            }           
            return PartialOrEmpty(Constants.Views.AccordionListWithThumbnailView, model);
        }
      
    }
}