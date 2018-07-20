using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using M1CP.Feature.Error.Models;
using M1CP.Feature.Error.Repositories;
using M1CP.Foundation.Base.Controllers;
namespace M1CP.Feature.Error.Controllers
{
    public class ItemNotFoundController : BaseController
    {
        // GET: ItemNotFound

        readonly IError _error;
        public ItemNotFoundController(IError error)
        {
            _error = error;
        }
        public ActionResult M1CP404Logger()
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;
            Response.TrySkipIisCustomErrors = true;
            Response.StatusDescription = "Page not found";
            var errorPage = _error.GetErrorInformation(CurrentItem);
            return PartialOrEmpty(Constants.Views.PageNotFound, errorPage);
        }
        public ActionResult M1CP500Logger()
        {

           
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            Response.TrySkipIisCustomErrors = true;
            Response.StatusDescription = "Internal Server Error";
            var errorPage = _error.GetErrorInformation(CurrentItem);
            return PartialOrEmpty(Constants.Views.PageNotFound, errorPage);
        }
    }
}