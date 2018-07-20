using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using M1CP.Foundation.Base.Models;

namespace M1CP.Feature.Navigation.Models
{
    /// <summary>
    /// LogoItem
    /// </summary>
   [SitecoreType(AutoMap =true)]
    public class LogoItem:GlassBase
    {
        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        public Image Logo { get; set; }
    }
}