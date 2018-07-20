using M1CP.Foundation.Dictionary.Models;
using Sitecore.Sites;

namespace M1CP.Foundation.Dictionary.Repositories
{
    public interface IDictionaryRepository
    {
        Models.Dictionary Get(SiteContext site);
    }
}