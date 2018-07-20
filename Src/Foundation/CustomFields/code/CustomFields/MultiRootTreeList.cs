using System;
using System.Linq;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Shell.Applications.ContentEditor;
using Sitecore.Text;
using Sitecore.Web;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.WebControls;
using Sitecore.Data.Items;
using Sitecore.Web.UI.HtmlControls.Data;

namespace M1CP.Foundation.CustomFields.CustomFields
{   
    public class MultiRootTreeList : TreeList
    {
        private const string QueryPrefix = "query:";
        /// <summary>
        /// Parameter key for the DataSource parameter of the Source field
        /// </summary>
        private const string DataSourceParameterKey = "datasource";

        private string[] _sources;
    
        public string[] Sources => _sources ?? (_sources = GetSources());

        private string[] _dataSources;
        /// <summary>
        /// The datasources retrieved from the <cref="Sources"/>
        /// </summary>
        public string[] DataSources
        {
            get
            {
               
                if (_dataSources != null)
                {
                    return _dataSources;
                }

                if (string.IsNullOrEmpty(Source) || global::Sitecore.Context.ContentDatabase == null || ItemID == null)
                {
                    return (_dataSources = new string[] { });
                }

                var contextDb = global::Sitecore.Context.ContentDatabase;

             
                var currentItem = contextDb.GetItem(ItemID);

                return (_dataSources = Sources
                    .Select(source => GetDatasource(source, currentItem))                   
                    .Where(datasource => datasource != null)
                    .ToArray());
            }
        }

        protected override void OnLoad(EventArgs args)
        {
            Assert.ArgumentNotNull(args, "args");

            // if this is an event, just run the base logic and return
            if (global::Sitecore.Context.ClientPage.IsEvent)
            {
                return;
            }

            base.OnLoad(args);

            // find the existing TreeviewEx that the base OnLoad added, get a ref to its parent, and remove it from controls
            var existingTreeView = (TreeviewEx)WebUtil.FindControlOfType(this, typeof(TreeviewEx));
            var treeviewParent = existingTreeView.Parent;

            existingTreeView.Parent.Controls.Clear(); // remove stock treeviewex, we replace with multiroot

            // find the existing DataContext that the base OnLoad added, get a ref to its parent, and remove it from controls
            var dataContext = (DataContext)WebUtil.FindControlOfType(this, typeof(DataContext));
            var dataContextParent = dataContext.Parent;

            dataContextParent.Controls.Remove(dataContext); // remove stock datacontext, we parse our own

            // create our MultiRootTreeview to replace the TreeviewEx
            var impostor = new MultiRootTreeview
            {
                ID = existingTreeView.ID,
                DblClick = existingTreeView.DblClick,
                Enabled = existingTreeView.Enabled,
                DisplayFieldName = existingTreeView.DisplayFieldName
            };

            // parse the data source and create appropriate data contexts out of it
            var dataContexts = ParseDataContexts(dataContext);

            // join the IDs of all of the DataContext objects together, to be added as controls
            impostor.DataContext =
                string.Join(
                    "|",
                    dataContexts
                        .Select(dc => dc.ID));

            // add the new DataContext controls into the selection pane
            foreach (var context in dataContexts)
            {
                dataContextParent.Controls.Add(context);
            }

            // inject our replaced control where the TreeviewEx originally was
            treeviewParent.Controls.Add(impostor);
        }

        /// <summary>
        /// Gets all of the datasources from the Source field
        /// </summary>
        protected virtual string[] GetSources()
        {
            if (string.IsNullOrEmpty(Source))
            {
                return new string[] { };
            }

            var datasource = global::Sitecore.StringUtil.ExtractParameter(DataSourceParameterKey, Source).Trim();
            datasource = string.IsNullOrEmpty(datasource)
                ? Source
                : datasource;

            return datasource.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Gets the item path to the datasource item
        /// </summary>
        /// <param name="source">The source used to find the datasource item</param>
        /// <param name="currentItem">The current item</param>
        protected virtual string GetDatasource(string source, Item currentItem)
        {
            Item datasourceItem = null;
          
            if (source.StartsWith(QueryPrefix))
            {
                try
                {
                    var results = LookupSources.GetItems(currentItem, source);
                    datasourceItem = results
                        .FirstOrDefault(item => item != null);
                }
                catch (Exception ex)
                {
                    Log.Error($"Treelist field failed to execute query: '{source}'", ex, this);
                }
            }           
            else
            {
                datasourceItem = currentItem.Database.GetItem(source);
            }

            return datasourceItem?.Paths.FullPath;
        }

        protected virtual DataContext[] ParseDataContexts(DataContext originalDataContext)
        {
            // if there are multiple roots; otherwise, just use the original datasource
            return (DataSources.Any() ? DataSources : new ListString(DataSource).AsEnumerable())
                .Select(datasource => CreateDataContext(originalDataContext, datasource))
                .ToArray();
        }

        /// <summary>
        /// Creates a DataContext control for a given Sitecore path data source
        /// </summary>
        protected virtual DataContext CreateDataContext(DataContext baseDataContext, string dataSource)
        {
            var dataContext = new DataContext
            {
                ID = GetUniqueID("D"),
                Filter = baseDataContext.Filter,
                DataViewName = "Master"
            };

            if (!string.IsNullOrEmpty(DatabaseName))
            {
                dataContext.Parameters = "databasename=" + DatabaseName;
            }

            dataContext.Root = dataSource;
            dataContext.Language = Language.Parse(ItemLanguage);

            return dataContext;
        }
    }
}
