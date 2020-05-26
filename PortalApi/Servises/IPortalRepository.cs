using PortalApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Servises
{
    public interface IPortalRepository
    {
        Task<IEnumerable<ArticleCategory>> GetArticlesCategories();
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId);
    }
}