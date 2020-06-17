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
        void AddTattoo(Tattoo tattoo);
        Task<bool> TattooExists(int tattooId);
        void DeleteTattoo(Tattoo tattoo);

        #endregion

        #region Piercing's methods
        Task<Piercing> GetPiercing(int piercingId);
        Task<IEnumerable<Piercing>> GetPiercings(int? amount);
        Task<PagedList<Piercing>> GetPiercings(PiercingsResourceParameters piercingsResourceParameters);
        void AddPiercing(Piercing piercing);
        Task<bool> PiercingExists(int piercingId);
        void DeletePiercing(Piercing piercing);
        #endregion

        #region Model's methods
        Task<ModelPhoto> GetModelPhoto(int modelId);
        Task<IEnumerable<ModelPhoto>> GetModelsPhotos(int? amount);
        Task<PagedList<ModelPhoto>> GetModelsPhotos(ModelsPhotosResourceParameters modelsPhotosResourceParameters);
        void AddModelPhoto(ModelPhoto modelPhoto);
        Task<bool> ModelPhotoExists(int modelPhotoId);
        void DeleteModelPhoto(ModelPhoto modelPhoto);
        #endregion

        #region Photographer's methods
        Task<PhotographerPhoto> GetPhotographerPhoto(int photographerId);
        Task<IEnumerable<PhotographerPhoto>> GetPhotographersPhotos(int? amount);
        Task<PagedList<PhotographerPhoto>> GetPhotographersPhotos(PhotographersPhotosResourceParameters photographerPhotosResourceParameters);
        void AddPhotographerPhoto(PhotographerPhoto photographerPhoto);
        Task<bool> PhotographerPhotoExists(int photographerPhotoId);
        void DeletePhotographerPhoto(PhotographerPhoto photographerPhoto);
        #endregion

        #region AvailableDesign's methods
        Task<AvailableDesign> GetAvailableDesign(int designId);
        Task<IEnumerable<AvailableDesign>> GetAvailableDesigns(int? amount);
        Task<PagedList<AvailableDesign>> GetAvailableDesigns(AvailableDesignsResourceParameters availableDesignsResourceParameters);
        void AddAvailableDesign(AvailableDesign availableDesign);
        Task<bool> AvailableDesignExists(int availableDesignId);
        void DeleteAvailableDesign(AvailableDesign availableDesign);
        #endregion

        #region Piercer's methods
        Task<Piercer> GetPiercer(int piercerId);


        #endregion


        Task<bool> SaveChangesAsync();
        Task<bool> UserExists(int userId);
        Task<bool> IsUserPiercer(int userId);
        Task<bool> IsUserTattooer(int userId);
        Task<bool> IsUserModel(int userId);
        Task<bool> IsUserPhotographer(int userId);
    }
}