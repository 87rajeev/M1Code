// ***********************************************************************
// Assembly         : M1CP.Foundation.Logging
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-26-2018
// ***********************************************************************
// <copyright file="InvalidDatasourceItemExceptionProcessor.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace M1CP.Foundation.Logging.Pipelines.MvcException
{
    using System.Web.Mvc;
    using M1CP.Foundation.Logging.Exception;
    using Sitecore.Mvc.Pipelines.MvcEvents.Exception;
    using Sitecore;

    /// <summary>
    /// Class InvalidDatasourceItemExceptionProcessor.
    /// </summary>
    public class InvalidDatasourceItemExceptionProcessor
    {
        /// <summary>
        /// Process ti handle the Exception
        /// </summary>
        /// <param name="exceptionArgs">Exception argument</param>
        public void Process(ExceptionArgs exceptionArgs)
        {
            if (exceptionArgs.ExceptionContext.ExceptionHandled)
            {
                return;
            }

            this.HandleException(exceptionArgs.ExceptionContext);
        }
        /// <summary>
        /// Handle Exception with the exception context
        /// </summary>
        /// <param name="exceptionContext">Exception context as parameter</param>
        protected virtual void HandleException(ExceptionContext exceptionContext)
        {
            var dataSourceException = exceptionContext.Exception as InvalidDataSourceItemException;
            if (dataSourceException == null)
                return;
            Logger.Portal.Error(dataSourceException.Message, dataSourceException);

            if (Context.PageMode.IsNormal)
            {
                exceptionContext.Result = new EmptyResult();
            }
            else
            {
                Logger.Portal.Error("Data source isn't set or have wrong template");
            }
            exceptionContext.ExceptionHandled = true;
        }
    }
}
