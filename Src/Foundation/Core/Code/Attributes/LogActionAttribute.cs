using System;
using System.Diagnostics;
using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace M1CP.Foundation.Base.Attributes
{
    /// <inheritdoc />
    /// <summary>
    /// Log action execution time. This action will be enabled when required only
    /// </summary>
    /// <seealso cref="T:System.Web.Mvc.ActionFilterAttribute" />
    public sealed class LogActionAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// The stopWatch to record Controller Action Execution Time
        /// </summary>
        readonly Stopwatch _watchControllerAction = new Stopwatch();
        /// <summary>
        /// The stopWatch to record Controller View Execution Time
        /// </summary>
        readonly Stopwatch _watchResult = new Stopwatch();
        readonly Stopwatch _fullResult = new Stopwatch();
        /// <summary>
        /// The action log enabled or not
        /// </summary>
        private readonly bool _actionLogEnabled;
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:M1CP.Foundation.Base.Attributes.LogActionAttribute" /> class.
        /// </summary>
        public LogActionAttribute()
        {
            var loggingEnabled = Sitecore.Configuration.Settings.GetBoolSetting(Constants.LogEnabled, false);
            if (!loggingEnabled)
                loggingEnabled = HttpContext.Current.Request.QueryString["logAction"] == "1";
            _actionLogEnabled = loggingEnabled;
        }

        /// <inheritdoc />
        /// <summary>
        /// Called by the ASP.NET MVC framework before the action method executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!_actionLogEnabled) return;
            Sitecore.Diagnostics.Log.Info($"Action Executing: {filterContext?.ActionDescriptor?.ActionName}", this);
            _watchControllerAction.Restart();
            _fullResult.Restart();
            base.OnActionExecuting(filterContext);
        }

        /// <inheritdoc />
        /// <summary>
        /// Called by the ASP.NET MVC framework after the action method executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (!_actionLogEnabled) return;
            _watchControllerAction.Stop();
            Sitecore.Diagnostics.Log.Info($"Action Executed: {filterContext?.ActionDescriptor?.ActionName} - Time:{ToString(_watchControllerAction.Elapsed)}", this);

            if (filterContext?.Exception != null)
            {
                Sitecore.Diagnostics.Log.Error($"Exception Thrown:{filterContext.ActionDescriptor?.ActionName}",
                    filterContext.Exception, this);
            }
            base.OnActionExecuted(filterContext);
        }

        /// <inheritdoc />
        /// <summary>
        /// Called by the ASP.NET MVC framework before the action result executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (!_actionLogEnabled) return;
            string actionResultName = GetViewName(filterContext.Result, filterContext.IsChildAction);

            Sitecore.Diagnostics.Log.Info($"Result Executing: {actionResultName}", this);
            _watchResult.Restart();
            base.OnResultExecuting(filterContext);
        }

        /// <inheritdoc />
        /// <summary>
        /// Called by the ASP.NET MVC framework after the action result executes.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (!_actionLogEnabled) return;
            _watchResult.Stop();
            _fullResult.Stop();
            string actionResultName = GetViewName(filterContext.Result, filterContext.IsChildAction);
            Sitecore.Diagnostics.Log.Info($"Result Executed: {actionResultName} - Time : {ToString(_watchResult.Elapsed)}", this);
            Sitecore.Diagnostics.Log.Info($"Execution Time: {actionResultName} - {ToString(_fullResult.Elapsed)} ", this);

            base.OnResultExecuted(filterContext);
        }

        /// <summary>
        /// Gets the name of the view.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="childAction">if set to <c>true</c> [child action].</param>
        /// <returns>View Name</returns>
        private static string GetViewName(ActionResult result, bool childAction)
        {
            string actionResultName = result.GetType().Name;
            var resultType = result.GetType();
            if (resultType == typeof(ViewResult))
            {
                actionResultName = ((ViewResult)result).ViewName;

            }
            else if (resultType == typeof(PartialViewResult))
            {
                actionResultName = ((PartialViewResult)result).ViewName;
            }


            return actionResultName;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="span">The span.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        string ToString(TimeSpan span)
        {
            return span.TotalMilliseconds.ToString(CultureInfo.InvariantCulture);
        }
    }
}