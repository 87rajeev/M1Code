// ***********************************************************************
// Assembly         : M1CP.Foundation.Logging
// Author           : rshabara
// Created          : 03-24-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-26-2018
// ***********************************************************************
// <copyright file="Logger.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using log4net;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Diagnostics;

namespace M1CP.Foundation.Logging
{

    /// <summary>
    /// Class Logger.
    /// </summary>
    public class Logger
    {


        /// <summary>
        /// Gets the log404.
        /// </summary>
        /// <value>The log404.</value>
        public static Log Log404 => new Log("404Logger") ?? new Log("404Logger");
        /// <summary>
        /// Gets the commerce.
        /// </summary>
        /// <value>The commerce.</value>
        public static Log Commercelog => new Log("M1CPCommerceLogger") ?? new Log("M1CPCommerceLogger");
        /// <summary>
        /// Gets the portal.
        /// </summary>
        /// <value>The portal.</value>
        public static ILog Portal => LogManager.GetLogger("Sitecore.Diagnostics.M1CPLogger") ?? LoggerFactory.GetLogger(typeof(Log));
        public static Log M1CPLogger => new Log("M1CPLogger") ?? new Log("M1CPLogger");


    }
}