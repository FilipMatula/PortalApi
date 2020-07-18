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
        Task<IEnumerable<ArticleCategory>> GetArticlesCategoriesAsync();
        Task<IEnumerable<ArticleCategory>> GetArticlesCategoriesWithArticleAsync(int? amount);
        Task<ArticleSubcategory> GetArticleSubcategoryAsync(int subcategoryId);
        Task<IEnumerable<Article>> GetArticlesByCategoryAsync(int subcategoryId, int? amount);
        Task<PagedList<Article>> GetArticlesByCategoryAsync(int subcategoryId, ArticlesResourceParameters articlesResourceParameters);
        Task<Article> GetArticleAsync(int articleId);
        void AddArticle(Article article);
        Task<bool> ArticleExistsAsync(int articleId);
        void DeleteArticle(Article article);

        #endregion

        #region Tattoo's methods
        Task<Tattoo> GetTattooAsync(int tattooId);
        Task<IEnumerable<Tattoo>> GetTattoosAsync(int? amount);
        Task<PagedList<Tattoo>> GetTattoosAsync(TattoosResourceParameters tattoosResourceParameters);
        void AddTattoo(Tattoo tattoo);
        Task<bool> TattooExistsAsync(int tattooId);
        void DeleteTattoo(Tattoo tattoo);

        #endregion

        #region Piercing's methods
        Task<Piercing> GetPiercingAsync(int piercingId);
        Task<IEnumerable<Piercing>> GetPiercingsAsync(int? amount);
        Task<PagedList<Piercing>> GetPiercingsAsync(PiercingsResourceParameters piercingsResourceParameters);
        void AddPiercing(Piercing piercing);
        Task<bool> PiercingExistsAsync(int piercingId);
        void DeletePiercing(Piercing piercing);
        #endregion

        #region Model's Photo methods
        Task<ModelPhoto> GetModelPhotoAsync(int modelId);
        Task<IEnumerable<ModelPhoto>> GetModelsPhotosAsync(int? amount);
        Task<PagedList<ModelPhoto>> GetModelsPhotosAsync(ModelsPhotosResourceParameters modelsPhotosResourceParameters);
        void AddModelPhoto(ModelPhoto modelPhoto);
        Task<bool> ModelPhotoExistsAsync(int modelPhotoId);
        void DeleteModelPhoto(ModelPhoto modelPhoto);
        #endregion

        #region Photographer's Photo methods
        Task<PhotographerPhoto> GetPhotographerPhotoAsync(int photographerId);
        Task<IEnumerable<PhotographerPhoto>> GetPhotographersPhotosAsync(int? amount);
        Task<PagedList<PhotographerPhoto>> GetPhotographersPhotosAsync(PhotographersPhotosResourceParameters photographerPhotosResourceParameters);
        void AddPhotographerPhoto(PhotographerPhoto photographerPhoto);
        Task<bool> PhotographerPhotoExistsAsync(int photographerPhotoId);
        void DeletePhotographerPhoto(PhotographerPhoto photographerPhoto);
        #endregion

        #region AvailableDesign's methods
        Task<AvailableDesign> GetAvailableDesignAsync(int designId);
        Task<IEnumerable<AvailableDesign>> GetAvailableDesignsAsync(int? amount);
        Task<PagedList<AvailableDesign>> GetAvailableDesignsAsync(AvailableDesignsResourceParameters availableDesignsResourceParameters);
        void AddAvailableDesign(AvailableDesign availableDesign);
        Task<bool> AvailableDesignExistsAsync(int availableDesignId);
        void DeleteAvailableDesign(AvailableDesign availableDesign);
        #endregion

        #region Piercer's methods
        Task<Piercer> GetPiercerAsync(int piercerId);
        Task<IEnumerable<Piercer>> GetPircersThumbnailsAsync(int? amount);
        Task<PagedList<Piercer>> GetPiercersProfilesAsync(PiercersProfilesResourceParameters piercersProfilesResourceParameters);
        void AddPircerAccount(Piercer piercerAccount);
        Task<bool> PiercerAccountExistsAsync(int piercerAccountId);
        void DeletePiercerAccount(Piercer piercerAccount);
        #endregion

        #region Model's methods
        Task<Model> GetModelAsync(int modelId);
        Task<IEnumerable<Model>> GetModelsThumbnailsAsync(int? amount);
        Task<PagedList<Model>> GetModelsProfilesAsync(ModelsProfilesResourceParameters modelsProfilesResourceParameters);
        void AddModelAccount(Model modelAccount);
        Task<bool> ModelAccountExistsAsync(int modelAccountId);
        void DeleteModelAccount(Model modelAccount);
        #endregion

        #region Tattooer's methods
        Task<Tattooer> GetTattooerAsync(int tattooerId);
        Task<IEnumerable<Tattooer>> GetTattooersThumbnailsAsync(int? amount);
        Task<PagedList<Tattooer>> GetTattooersProfilesAsync(TattooersProfilesResourceParameters tattooersProfilesResourceParameters);
        void AddTattooerAccount(Tattooer tattooerAccount);
        Task<bool> TattooerAccountExistsAsync(int tattooerAccountId);
        void DeleteTattooerAccount(Tattooer tattooerAccount);
        #endregion

        #region Photographer's methods
        Task<Photographer> GetPhotographerAsync(int photographerId);
        Task<IEnumerable<Photographer>> GetPhotographersThumbnailsAsync(int? amount);
        Task<PagedList<Photographer>> GetPhotographersProfilesAsync(PhotographersProfilesResourceParameters photographersProfilesResourceParameters);
        void AddPhotographerAccount(Photographer photographerAccount);
        Task<bool> PhotographerAccountExistsAsync(int photographerAccountId);
        void DeletePhotographerAccount(Photographer photographerAccount);
        #endregion

        Task<bool> SaveChangesAsync();
        Task<bool> UserExistsAsync(int userId);
        Task<bool> ArticleSubcategoryExistAsync(int subcategoryId);
        Task<bool> IsUserPiercerAsync(int userId);
        Task<bool> IsUserTattooerAsync(int userId);
        Task<bool> IsUserModelAsync(int userId);
        Task<bool> IsUserPhotographerAsync(int userId);
    }
}