using System.Linq;
using M1CP.Feature.TextMedia.Models;
using M1CP.Foundation.Base.Repositories;
using M1CP.Foundation.DependencyInjection;
using Sitecore.Data.Items;

namespace M1CP.Feature.TextMedia.Repositories
{
    [Service(typeof(ITextMediaRepostiry))]
    public class TextMediaRepository : RepositoryBase, ITextMediaRepostiry
    {
        /// <summary>
        /// Create an instance of TextMediaRepository
        /// </summary>
        public TextMediaRepository()
        {
        }
        /// <summary>
        /// Get Media Models
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public TextMediaModelList GetMediaModelList(Item item)
        {
            var model = ScContext.Cast<TextMediaModelList>(item);
            model.Items = model.ItemIds.Select(x => ScContext.GetItem<TextMediaModel>(x));

            return model;
        }
    }
}