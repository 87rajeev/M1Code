using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System.Linq;

namespace M1CP.Foundation.SitecoreExtensions.Rules
{
    [UsedImplicitly]
    public class NavigationDataSourceRule<T> : StringOperatorCondition<T> where T : RuleContext
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Executes the specified rule context.
        /// </summary>
        /// <param name="ruleContext">The rule context.</param>
        /// <returns>returns a boolean value of true or false</returns>
        protected override bool Execute(T ruleContext)
        {

            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            Assert.ArgumentNotNull(Context.Item, "Context item");
            Assert.ArgumentNotNull(Value, "Value");

            bool? id = Context.Item.Paths?.LongID?.Contains(Value);
            return id.HasValue && id.Value;

        }
    }
}