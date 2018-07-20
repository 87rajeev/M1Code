using M1CP.Feature.StockInformation.Models;
using M1CP.Feature.StockInformation.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.StockInformation.Controllers
{
    /// <summary>
    /// StockInformationController
    /// </summary>
    public class StockInformationController : BaseController
    {
        /// <summary>
        /// Stock Information repository
        /// </summary>
        private readonly IStockInformationRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockInformationController"/> class.
        /// </summary>
        /// <param name="stockinformationRepository">stockinformationRepository</param>
        public StockInformationController(IStockInformationRepository stockinformationRepository)
        {
            this._repository = stockinformationRepository;
        }

        

        /// <summary>
        /// Load stock information component 
        /// </summary>
        /// <returns>Stock Information items</returns>
        public ActionResult StockInformation()
        {
            IStockInformation model = null;
            if (CurrentItem != null)
            {
                model = _repository.GetStockInformationItems(CurrentItem);
            }
            return PartialOrEmpty(Constants.Views.StockInformation, model);
        }
    }
}