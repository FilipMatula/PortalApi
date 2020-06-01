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
        Task<ArticleSubcategory> GetArticleSubcategory(int subcategoryId);
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int? amount);
        Task<PagedList<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters);
        Task<Article> GetArticle(int articleId);
        
        #endregion

        #region Tattoo's methods
        Task<Tattoo> GetTattoo(int tattooId);
        Task<IEnumerable<Tattoo>> GetTattoos(int? amount);
        Task<PagedList<Tattoo>> GetTattoos(TattoosResourceParameters tattoosResourceParameters);

        #endregion

        #region Piercing's methods
        Task<Piercing> GetPiercing(int piercingId);
        Task<IEnumerable<Piercing>> GetPiercings(int? amount);
        Task<PagedList<Piercing>> GetPiercings(PiercingsResourceParameters piercingsResourceParameters);
        #endregion

        #region Model's methods
        Task<ModelPhoto> GetModelPhoto(int modelId);
        Task<IEnumerable<ModelPhoto>> GetModelsPhotos(int? amount);
        Task<PagedList<ModelPhoto>> GetModelsPhotos(ModelsPhotosResourceParameters modelsPhotosResourceParameters);
        #endregion

        #region Photographer's methods
        Task<PhotographerPhoto> GetPhotographerPhoto(int photographerId);
        Task<IEnumerable<PhotographerPhoto>> GetPhotographersPhotos(int? amount);
        Task<PagedList<PhotographerPhoto>> GetPhotographersPhotos(PhotographersPhotosResourceParameters photographerPhotosResourceParameters);
        #endregion

        #region AvailableDesign's methods
        Task<AvailableDesign> GetDesign(int designId);
        Task<IEnumerable<AvailableDesign>> GetDesigns(int? amount);
        Task<PagedList<AvailableDesign>> GetDesigns(AvailableDesignsResourceParameters availableDesignsResourceParameters);
        #endregion
    }
}