using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using System;

namespace M1CP.Feature.Accordion.Models
{
    public class AccordionSection
    {
        [SitecoreField(Templates.Accordion_Section.Fields.Section_HeadingFieldName)]
         string Section_Heading { get; set; }

        [SitecoreField(Templates.Accordion_Section.Fields.ActiveFieldName)]
        bool Active { get; set; }

        public AccordionSection(Item headline) : this()
        {
            this.Item = headline;
            this.Section_Heading = Section_Heading;

        }
        public AccordionSection()
        {
            this.HeaderId = $"header{Guid.NewGuid().ToString("N")}";
            this.PanelId = $"panel{Guid.NewGuid().ToString("N")}";

        }

        public Item Item { get; set; }
        public string HeaderId { get; private set; }
        public string PanelId { get; private set; }
             

        public bool SectionActive
        {
            get
            {
                return this.Active;
            }
            set
            {
                this.Active = value;
            }
        }

    }
    
}