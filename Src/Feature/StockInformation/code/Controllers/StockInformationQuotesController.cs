using M1CP.Feature.StockInformation.Models;
using M1CP.Feature.StockInformation.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.StockInformation.Controllers
{
    public class StockInformationQuotesController : BaseController
    {
        /// <summary>
        /// Stock Information Quotes repository
        /// </summary>
        private IStockInformationQuotesRepository _repository;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StockInformationQuotesController()
        {
            this._repository = new StockInformationQuotesRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockInformationQuotesController"/> class.
        /// </summary>
        /// <param name="stockInformationQuotesRepository">stockInformationQuotesRepository</param>
        public StockInformationQuotesController(IStockInformationQuotesRepository stockInformationQuotesRepository)
        {
            this._repository = stockInformationQuotesRepository;
        }
       
        /// <summary>
        /// Load stock information component 
        /// </summary>
        /// <returns>Stock Information items</returns>
        public ActionResult StockInformationQuotes()
        {
            Pricefeed model = null;
            if (_repository != null)
            {
                model = _repository.GetStockInformationQuotes();
            }
            return PartialOrEmpty(Constants.Views.StockInformationQuotes, model);
        }
    }
}