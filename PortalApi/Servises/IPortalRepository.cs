using PortalApi.Entities;
using PortalApi.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Servises
{
    public interface IPortalRepository
    {
        Task<IEnumerable<ArticleCategory>> GetArticlesCategories();
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int amount);
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters);
        Task<Article> GetArticle(int articleId);
    }
}