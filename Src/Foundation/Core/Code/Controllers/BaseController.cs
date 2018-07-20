using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using M1CP.Foundation.Base.Attributes;
using M1CP.Foundation.Base.Models;

namespace M1CP.Foundation.Base.Controllers
{
    [LogAction]
    [HandleException]
    public abstract class BaseController : GlassController
    {
        /// <summary>
        ///     Gets the current datasource item. If datasource item is null returns current context item
        /// </summary>
        /// <value>
        ///     The current item.
        /// </value>
        protected Item CurrentItem => RenderingContext.CurrentOrNull?.Rendering.Item ?? Sitecore.Context.Item;

        /// <summary>
        /// Returns PartialView.
        /// If model is empty, then returns EmptyResult. In Experience Editor mode returns a simple view to allow author to
        /// select and edit contents.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="viewName">Name of the view.</param>
        /// <param name="model">The model.</param>
        /// <param name="showComponent">if set to <c>true</c> [show component].</param>
        /// <returns>
        /// PartialViewResult or EmptyResult
        /// </returns>
        protected ActionResult PartialOrEmpty<T>(string viewName, T model)
        {
            if (model == null)
            {
                if (Context.Site != null && (
                        Context.PageMode.IsExperienceEditor || Context.PageMode.IsExperienceEditorEditing))
                    return PartialView("~/Views/M1CP/Shared/DataSourceEmpty.cshtml", viewName);
                return new EmptyResult();
            }

            if (!IsAngularRendering()) return PartialView(viewName, model);
            AngularRenderingModel ngModel = new AngularRenderingModel()
            {
                Data = model,
                DatasourceItemId = CurrentItem.ID.ToString(),
                RenderingItemId = RenderingContext.CurrentOrNull?.Rendering.RenderingItem.ID.ToString(),
                NgDirective = RenderingContext.CurrentOrNull?.Rendering.RenderingItem.InnerItem[Constants.AngularDirective]
            };
            return PartialView("~/Views/M1CP/Shared/AngularView.cshtml", ngModel);
        }

        private bool IsAngularRendering()
        {
            return RenderingContext.CurrentOrNull?.Rendering.RenderingItem.InnerItem[Constants.IsAngularRenderinView] == "1";
        }
    }
}