using M1CP.Feature.TableComponent.Repositories;
using M1CP.Foundation.Base.Controllers;
using System.Web.Mvc;

namespace M1CP.Feature.TableComponent.Controllers
{
    public class DynamicTableController : BaseController

    {
        /// <summary>
        /// The Carousal Repository
        /// </summary>
        private readonly ITableRepository _tableRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarousalController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public DynamicTableController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        // GET: DynamicTable
        public ActionResult TableCreation()
        {

            var model = CurrentItem;
            var tblItems= _tableRepository.GetTableRows(CurrentItem);
            
            return PartialOrEmpty(Constants.Views.Table, tblItems);

        }
    }
}