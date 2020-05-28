using PortalApi.Entities;
using PortalApi.Helpers;
using PortalApi.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public interface IPortalRepository
    {
        #region Article's methods
        Task<IEnumerable<ArticleCategory>> GetArticlesCategories();
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int amount);
        Task<PagedList<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters);
        Task<Article> GetArticle(int articleId);
        
        #endregion

        #region Tattoo's methods
        Task<Tattoo> GetTattoo(int tattooId);

        #endregion
    }
}