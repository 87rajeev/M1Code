using M1CP.Feature.Accordion.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using M1CP.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Mvc.Presentation;

namespace M1CP.Feature.Accordion.Repositories
{
    [Service(typeof(IAccordionRepository))]
    public class AccordionRepository : RepositoryBase, IAccordionRepository
    {
        #region DECLARATION
        private AccordionSection[] _items;
        public Item Item { get; set; }

        public string Id { get; private set; }

        public string AccordionHeading { get; set; }

        public string SectionHeading { get; set; }

        public IEnumerable<AccordionSection> Items
        {
            get
            {
                if (this._items != null)
                {
                    return this._items;
                }
                this._items = this.CreateDynamicAccordionItems();

                return this._items;
            }
        }

        #endregion

        /// <summary>
        /// Create accordion sections 
        /// </summary>
        /// <returns>Array of Accordion sections</returns>
        private AccordionSection[] CreateDynamicAccordionItems()
        {
            var childItems = this.Item.Children.ToArray();
            AccordionSection[] returnItems = { };
            if (childItems.Any())
            {
                returnItems = childItems.Select(i => new AccordionSection(i)).ToArray();
            }
            else
            {
                var count = this.Item.GetInteger(Templates.AccordionTemplate.Fields.CountFieldId);
                if (count.HasValue)
                {
                    returnItems = new object[count.Value].Select(o => new AccordionSection()).ToArray();
                }
            }
            
            return returnItems;
        }

        /// <summary>
        /// Intialize Accordion item
        /// </summary>
        public AccordionRepository()
        {
            Item dynamicAccordion = RenderingContext.Current.Rendering.Item;
            if (dynamicAccordion == null)
            {
                throw new ArgumentNullException(nameof(dynamicAccordion));
            }
            
            this.Item = dynamicAccordion;
            this.Id = $"accordion-{Guid.NewGuid().ToString("N")}";
            
            IAccordion accordiontems = ScContext.Cast<IAccordion>(dynamicAccordion);
            this.AccordionHeading = accordiontems.Title;
        }

       
        /// <summary>
        /// Get thumbnail items based on year
        /// </summary>
        /// <param name="current">Current Item</param>
        /// <param name="year">Year</param>
        /// <returns></returns>
        public IFinancialResultsYear GetAccordionThumbnailItems(Item current,float year)
        {
            //String ResultsFolderId = "{00F7639F-ED67-46B1-B338-F2EE71E25EF2}";
            //Sitecore.Data.Database DB = Sitecore.Context.Database;
            //Item ResultsItem= DB.GetItem(CurrentItem);
            IFinancialResultsYear FinancialResults = ScContext.Cast<IFinancialResultsYear>(current.GetChildren().Where(x => x.Name.Equals(year.ToString())).First());
            FinancialResults.QuaterFinancialRelease=FinancialResults.QuaterFinancialRelease.OrderBy(x=>x.Quater).Reverse();
            FinancialResults.ListOfYears = current.GetChildren().Select(x => x.Name);                
            return FinancialResults;
        }

    }
}