using Sitecore.Configuration;
using Sitecore.Data.Events;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Actions;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
namespace M1CP.Foundation.SitecoreExtensions.Extensions
{

    /// <summary>
    /// ItemRenameAction class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemRenameAction<T> : RuleAction<T> where T : RuleContext
    {
        /// <summary>
        /// Gets or sets the string with which to replace invalid characters in item names.
        /// </summary>
        private string _hyphen = "-";

        /// <summary>
        ///  Gets or sets the regular expression used to validate each character in item names
        /// </summary>
        private string _matchPattern = "^[A-Z|a-z|0-9|_]$";

        /// <summary>
        /// Get and set Hypen 
        /// </summary>
        public string Hyphen
        {
            get
            {
                return this._hyphen;
            }
            set
            {
                _hyphen = value;
            }
        }

        /// <summary>
        /// Get and set MatchPattern 
        /// </summary>
        public string MatchPattern
        {
            get
            {
                return this._matchPattern;
            }
            set
            {
                _matchPattern = value;
            }
        }


        /// <summary>
        /// Item Rename Action 
        /// </summary>
        /// <param name="ruleContext">current item context</param>
        public override void Apply(T ruleContext)
        {
            Assert.IsNotNull(Hyphen, "Hyphen");
            var patternMatcher = new Regex(MatchPattern);
            var newName = string.Empty;

            foreach (var c in ruleContext.Item.Name)
                if (patternMatcher.IsMatch(c.ToString(CultureInfo.InvariantCulture)))
                    newName += c;
                else if (!string.IsNullOrEmpty(Hyphen))
                    newName += Hyphen;

            while (newName.StartsWith(Hyphen, StringComparison.OrdinalIgnoreCase))
                newName = newName.Substring(Hyphen.Length, newName.Length - Hyphen.Length);

            while (newName.EndsWith(Hyphen, StringComparison.OrdinalIgnoreCase))
                newName = newName.Substring(0, newName.Length - Hyphen.Length);

            var sequence = Hyphen + Hyphen;

            while (newName.Contains(sequence))
                newName = newName.Replace(sequence, Hyphen);

            if (string.IsNullOrEmpty(newName))
                newName = Hyphen;

            if (ruleContext.Item.Name != newName)
                if (!(TemplateManager.IsTemplate(ruleContext.Item)))
                    RenameItem(ruleContext.Item, newName.ToLowerInvariant());
        }

        /// <summary>
        /// Update renamed item name
        /// </summary>
        /// <param name="item">current item</param>
        /// <param name="newName">new item</param>
        protected void RenameItem(Item item, string newName)
        {
            if ((item?.Template.StandardValues != null) && (item.ID == item.Template.StandardValues.ID))
                return;
            if (newName == "$name")
                return;

            if (Factory.GetSiteInfoList().Any(site => string.Compare(site.RootPath + site.StartItem, item.Paths.FullPath, StringComparison.OrdinalIgnoreCase) == 0))
                return;

            using (new SecurityDisabler())
            using (new EditContext(item))
            using (new EventDisabler())
            if (!(TemplateManager.IsTemplate(item) || item.Name.Equals("*")))
             {
                    if (item.Fields[Sitecore.FieldIDs.DisplayName] != null)
                    {
                        item.Fields[Sitecore.FieldIDs.DisplayName].Value = item.DisplayName;
                    }
                    item.Name = newName;
             }
        }
    }
}