using M1CP.Feature.Form.Models;
using M1CP.Feature.Form.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Text;
using Sitecore.Mvc.Presentation;
using M1CP.Foundation.Base.Controllers;
using M1CP.Feature.Forms.Models.M1CP;
using System.Web;
using Sitecore.Data.Items;
using M1CP.Foundation.Services.Helper;

namespace M1CP.Feature.Forms.Controllers
{
    public class FormController : BaseController
    {
        IFormRepository _repository;
        public FormController()
        {
            _repository = new FormRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var form = _repository.LoadForm(CurrentItem);
            return PartialView(Constants.Views.FormIndexView, form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormModel form)
        {
            Item formitem = M1CP.Foundation.Services.Helper.SitecoreHelper.GetSitecoreItemById(form.FormId);
            var forms = _repository.LoadFormById(formitem, Request);
            if (formitem != null)
            {
                if (forms.FormInvalid == false)
                {
                    _repository.SaveToDatabase();
                    forms = null;
                    return PartialOrEmpty(Constants.Views.FormIndexView, forms);
                }
                else
                {
                    ViewBag.Message = "Please check validation";
                    return PartialView(Constants.Views.FormIndexView, forms);
                }
            }
            else
            {
                return PartialView(Constants.Views.FormIndexView);
            }
        }


    }
}
