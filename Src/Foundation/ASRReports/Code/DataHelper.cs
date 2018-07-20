// ***********************************************************************
// Assembly         : M1CP.Foundation.ASRReports
// Author           : rshabara
// Created          : 03-15-2018
//
// Last Modified By : rshabara
// Last Modified On : 03-20-2018
// ***********************************************************************
// <copyright file="DataHelper.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using ASR.Interface;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace M1CP.Foundation.ASRReports
{
    /// <summary>
    /// Class DataHelper.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    class DataHelper : IDisposable
    {
        // Internal members
        /// <summary>
        /// The connection string
        /// </summary>
        protected string _connString = null;
        /// <summary>
        /// The connection
        /// </summary>
        protected SqlConnection _conn = null;
        /// <summary>
        /// The trans
        /// </summary>
        protected SqlTransaction _trans = null;
        /// <summary>
        /// The disposed
        /// </summary>
        protected bool _disposed = false;
        /// <summary>
        /// Constructor using global connection string.
        /// </summary>
        public DataHelper()
        {
            string ConnectionString = Sitecore.Configuration.Settings.GetConnectionString("M1CPAsrContext");
            _connString = ConnectionString;
        }

        /// <summary>
        /// Constructure using connection string override
        /// </summary>
        /// <param name="connString">Connection string for this instance</param>
        public DataHelper(string connString)
        {
            _connString = connString;
            Connect();
        }

        // Creates a SqlConnection using the current connection string
        /// <summary>
        /// Connects this instance.
        /// </summary>
        protected void Connect()
        {
            _conn = new SqlConnection(_connString);
            _conn.Open();
        }

        /// <summary>
        /// Constructs a SqlCommand with the given parameters. This method is normally called
        /// from the other methods and not called directly. But here it is if you need access
        /// to it.
        /// </summary>
        /// <param name="qry">SQL query or stored procedure name</param>
        /// <param name="type">Type of SQL command</param>
        /// <param name="args">Query arguments. Arguments should be in pairs where one is the
        /// name of the parameter and the second is the value. The very last argument can
        /// optionally be a SqlParameter object for specifying a custom argument type</param>
        /// <returns>SqlCommand.</returns>
        /// <exception cref="System.ArgumentException">Invalid number or type of arguments supplied</exception>
        public SqlCommand CreateCommand(string qry, CommandType type, params object[] args)
        {
            SqlCommand cmd = new SqlCommand(qry, _conn);

            // Associate with current transaction, if any
            if (_trans != null)
                cmd.Transaction = _trans;

            // Set command type
            cmd.CommandType = type;

            // Construct SQL parameters
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] is string && i < (args.Length - 1))
                {
                    SqlParameter parm = new SqlParameter();
                    parm.ParameterName = (string)args[i];
                    parm.Value = args[++i];
                    cmd.Parameters.Add(parm);
                }
                else if (args[i] is SqlParameter)
                {
                    cmd.Parameters.Add((SqlParameter)args[i]);
                }
                else throw new ArgumentException("Invalid number or type of arguments supplied");
            }
            return cmd;
        }

        #region Exec Members

        /// <summary>
        /// Executes a query and returns the results as a DataSet
        /// </summary>
        /// <param name="qry">Query text</param>
        /// <param name="args">Any number of parameter name/value pairs and/or SQLParameter arguments</param>
        /// <returns>Results as a DataSet</returns>
        public DataSet ExecDataSet(string qry, params object[] args)
        {
            using (SqlCommand cmd = CreateCommand(qry, CommandType.Text, args))
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                return ds;
            }
        }

        /// <summary>
        /// Executes a stored procedure and returns the results as a Data Set
        /// </summary>
        /// <param name="qry">The qry.</param>
        /// <param name="args">Any number of parameter name/value pairs and/or SQLParameter arguments</param>
        /// <returns>Results as a DataSet</returns>
        public DataSet ExecDataSetProc(string qry, params object[] args)
        {
            using (SqlCommand cmd = CreateCommand(qry, CommandType.StoredProcedure, args))
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                return ds;
            }
        }

        #endregion

        #region Transaction Members


        /// <summary>
        /// Rolls back any transaction in effect.
        /// </summary>
        public void Rollback()
        {
            if (_trans != null)
            {
                _trans.Rollback();
                _trans = null;
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                // Need to dispose managed resources if being called manually
                if (disposing)
                {
                    if (_conn != null)
                    {
                        Rollback();
                        _conn.Dispose();
                        _conn = null;
                    }
                }
                _disposed = true;
            }
        }

        #endregion

        /// <summary>
        /// Generic method to populate the datset values to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt">The dt.</param>
        /// <returns>List&lt;T&gt;.</returns>
        public List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        /// <summary>
        /// Generic method to Populate the values to Property from column value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr">The dr.</param>
        /// <returns>T.</returns>
        private T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName && dr[column.ColumnName].ToString() == string.Empty)
                    {
                        pro.SetValue(obj, null, null);
                    }
                    else if (pro.Name == column.ColumnName && dr[column.ColumnName].ToString() != string.Empty)
                    {
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    }
                    else
                        continue;
                }
            }
            return obj;
        }

        /// <summary>
        /// Generic Method to populate the Display Values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dElement">The d element.</param>
        /// <param name="list">The list.</param>
        public void BindDisplay<T>(DisplayElement dElement, List<ASR.DomainObjects.Column> list)
        {
            Assert.ArgumentNotNull(dElement, "element");
            dElement.Value = "Element Value";
            dElement.Header = "Element Name";
            var _logElement = (T)dElement.Element;
            if (_logElement != null)
            {
                foreach (var column in list)
                {
                    var selectedColumn = _logElement.GetType().GetProperties().Where(x => x.Name.ToLower() == column.Name.ToLower());
                    if (selectedColumn.Count() > 0)
                        dElement.AddColumn(column.Header, selectedColumn.First().GetValue(_logElement, null) == null ? string.Empty : selectedColumn.First().GetValue(_logElement, null).ToString());
                }
            }
        }
        /// <summary>
        /// To fill the dataset to respective  properties from the Stored procedure.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storProcName">Name of the stor proc.</param>
        /// <returns>List&lt;T&gt;.</returns>
        public List<T> FillDataSet<T>(string storProcName)
        {
            List<T> items = new List<T>();
            Connect();
            var dataSet = ExecDataSetProc(storProcName);
            var dataTable = new DataTable();
            dataTable = dataSet.Tables[0];
            items = ConvertDataTable<T>(dataTable);
            return items;
        }
    }
}