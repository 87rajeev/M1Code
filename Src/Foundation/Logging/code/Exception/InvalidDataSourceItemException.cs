// ***********************************************************************
// Assembly         : M1CP.Foundation.Logging
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-26-2018
// ***********************************************************************
// <copyright file="InvalidDataSourceItemException.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace M1CP.Foundation.Logging.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class InvalidDataSourceItemException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class InvalidDataSourceItemException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public InvalidDataSourceItemException() : base("Data source isn't set or have wrong template")
        {
        }

        /// <summary>
        /// Invalid Datasource exception with message
        /// </summary>
        /// <param name="message">Exception Message</param>
        public InvalidDataSourceItemException(string message) : base(message)
        {
        }

        /// <summary>
        /// InvalidDataSourceItemException with exception message and inner exception
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner Exception</param>
        public InvalidDataSourceItemException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// InvalidDataSourceItemException with Exception seralizedInformation and context
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidDataSourceItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}