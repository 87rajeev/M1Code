using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Foundation.SitecoreExtensions.Extensions;

namespace M1CP.Feature.Accordion.Models
{
    public class DynamicAccordionModel
    {
        private Accordion_Section[] _items;
        public Item Item { get; set; }

        public string Id { get; private set; }

        private Accordion_Section[] CreateDynamicAccordionItems()
        {
            var childItems = this.Item.Children.ToArray();
            Accordion_Section[] returnItems = { };

            var count = this.Item.GetInteger(I_AccordionConstants.CountFieldId);
            if (count.HasValue)
            {
                returnItems = new object[count.Value].Select(o => new Accordion_Section()).ToArray();
            }

            return returnItems;
        }

        public DynamicAccordionModel(Item dynamicAccordion)
        {
            if (dynamicAccordion == null)
            {
                throw new ArgumentNullException(nameof(dynamicAccordion));
            }
            this.Item = dynamicAccordion;
            this.Id = $"accordion-{Guid.NewGuid().ToString("N")}";
        }

        public IEnumerable<Accordion_Section> Items
        {
            get
            {
                if (this._items != null)
                {
                    return this._items;
                }
                this._items = this.CreateDynamicAccordionItems();
                //this.SetActiveItem(this._items);
                return this._items;
            }
        }
    }
   
}