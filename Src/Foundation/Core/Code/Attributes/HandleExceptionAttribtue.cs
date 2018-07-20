using System.Web.Mvc;
using Sitecore;
using Sitecore.Diagnostics;

namespace M1CP.Foundation.Base.Attributes
{
    /// <summary>
    ///     Handle Exception gracefully. Show error in experience editor mode but hides for users
    /// </summary>
    /// <seealso cref="System.Web.Mvc.FilterAttribute" />
    /// <seealso cref="System.Web.Mvc.IExceptionFilter" />
    public sealed class HandleExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        /// <summary>
        ///     Called when an exception occurs.
        /// Shows Error in ExperienceEditor mode but hides the component from End User in CD mode
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public void OnException(ExceptionContext filterContext)
        {
            Log.Error(
                $"Error in executing: Controller - {filterContext.RequestContext.RouteData.Values["Controller"]} - Action -{filterContext.RequestContext.RouteData.Values["Action"]}",
                filterContext.Exception, this);
            if (!(Context.PageMode.IsExperienceEditor ||
                  Context.PageMode.IsExperienceEditorEditing))
            {
                filterContext.ExceptionHandled = true;
                filterContext.Result = new EmptyResult();
            }
        }
    }
}