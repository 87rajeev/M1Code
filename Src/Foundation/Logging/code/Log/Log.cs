using System;
using log4net;
using Sitecore.Diagnostics;

namespace M1CP.Foundation.Logging
{

    public class Log
    {
        private static ILog _logger = null;
        public Log(string logName)
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            switch (logName)
            {
                case "404Logger":
                    LoggerFactory.GetLogger("Sitecore.Diagnostics._404Logger");
                    break;
                case "M1CPLogger":
                    LoggerFactory.GetLogger("Sitecore.Diagnostics.M1CPLogger");
                    break;
                case "M1CPCommerceLogger":
                    LoggerFactory.GetLogger("Sitecore.Diagnostics.M1CPCommerceLogger");
                    break;
            }


        }

        /// <summary>
        /// Debug with message
        /// </summary>
        /// <param name="message">message text</param>
        public void Debug(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            _logger.Debug(message);
        }
        /// <summary>
        /// Debug with the message and exception
        /// </summary>
        /// <param name="message">Message text</param>
        /// <param name="exception">Exception</param>
        public void Debug(string message, System.Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            _logger.Debug(message, exception);
        }
        /// <summary>
        /// Info with the message
        /// </summary>
        /// <param name="message">message text</param>
        public void Info(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            _logger.Info(message);
        }
        /// <summary>
        /// info with message and exception
        /// </summary>
        /// <param name="message">Message text </param>
        /// <param name="exception">Exception</param>
        public void Info(string message, System.Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            _logger.Info(message, exception);
        }
        /// <summary>
        /// Warning with message
        /// </summary>
        /// <param name="message">message text</param>
        public void Warn(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            _logger.Warn(message);
        }
        /// <summary>
        /// Warning with message and exception
        /// </summary>
        /// <param name="message">Message text</param>
        /// <param name="exception">Exception</param>
        public void Warn(string message, System.Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            _logger.Warn(message, exception);
        }
        /// <summary>
        /// Error with the Message text
        /// </summary>
        /// <param name="message">Message text</param>
        public void Error(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            _logger.Error(message);
        }
        /// <summary>
        /// Error with the Message text and exception
        /// </summary>
        /// <param name="message">Message text</param>
        /// <param name="exception">Exception</param>
        public void Error(string message, System.Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            _logger.Error(message, exception);
        }
        /// <summary>
        /// Fatal Error with the Message text 
        /// </summary>
        /// <param name="message">Message text </param>
        public void Fatal(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            _logger.Fatal(message);
        }
        /// <summary>
        /// Fatal Error with the Message text and exception
        /// </summary>
        /// <param name="message">Message text</param>
        /// <param name="exception">Exception</param>
        public void Fatal(string message, System.Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            _logger.Fatal(message, exception);
        }
    }
}
