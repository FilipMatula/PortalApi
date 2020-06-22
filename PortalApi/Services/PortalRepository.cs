using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using PortalApi.Entities;
using PortalApi.ProfilesProperties;
using PortalApi.Helpers;
using PortalApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace PortalApi.Services
{
    public class PortalRepository : IPortalRepository
    {
        private readonly PortalContext _context;

        public PortalRepository(PortalContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Article's methods

        /// <summary>
        /// Get article by Id
        /// </summary>
        /// <param name="articleId">artilce Id</param>
        /// <returns>Article by Id</returns>
        public async Task<Article> GetArticleAsync(int articleId)
        {
            return await _context.Articles.AsQueryable()
                .Include(p => p.User)
                .Include(r => r.ArticleSubcategory)
                .FirstOrDefaultAsync(a => a.Id == articleId);
        }

        /// <summary>
        /// Get Articles by category
        /// </summary>
        /// <param name="subcategoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Article>> GetArticlesByCategoryAsync(int subcategoryId, int? amount)
        {
            var collection = _context.Articles.AsQueryable().Where(a => a.ArticleSubcategoryId == subcategoryId).Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<Article>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        /// <summary>
        /// Get article by category with pagination
        /// </summary>
        /// <param name="subcategoryId">Article Id</param>
        /// <param name="articlesResourceParameters"></param>
        /// <returns>Article page collectoion </returns>
        public async Task<PagedList<Article>> GetArticlesByCategoryAsync(int subcategoryId, ArticlesResourceParameters articlesResourceParameters)
        {
            if (articlesResourceParameters == null)
                throw new ArgumentNullException(nameof(articlesResourceParameters));

            var collection = await _context.Articles.AsQueryable().Where(a => a.ArticleSubcategoryId == subcategoryId)
                    .Include(p => p.User)
                    .OrderByDescending(m => m.Date).ToListAsync();

            return PagedList<Article>.Create(collection,
                articlesResourceParameters.PageNumber,
                articlesResourceParameters.PageSize);
        }

        /// <summary>
        /// Get all articles category
        /// </summary>
        /// <returns>Article's category</returns>
        public async Task<IEnumerable<ArticleCategory>> GetArticlesCategoriesAsync()
        {
            return await _context.ArticleCategories.AsQueryable()
                .Include(s => s.Subcategories).OrderBy(c => c.Id).ThenBy(s => s).ToListAsync();
        }

        public async Task<ArticleSubcategory> GetArticleSubcategoryAsync(int subcategoryId)
        {
            return await _context.ArticleSubCategories.AsQueryable().Include(c => c.ArticleCategory)
                .Where(s => s.Id == subcategoryId).FirstOrDefaultAsync();
        }

        public void AddArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }

            article.Date = DateTime.Now;

            _context.Add(article);
        }

        public async Task<bool> ArticleExistsAsync(int articleId)
        {
            return await _context.Articles.AnyAsync(p => p.Id == articleId);
        }

        public void DeleteArticle(Article article)
        {
            _context.Articles.Remove(article);
        }

        #endregion

        #region Tattoo's methods

        public async Task<Tattoo> GetTattooAsync(int tattooId)
        {
            return await _context.Tattoos.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == tattooId);
        }

        public async Task<IEnumerable<Tattoo>> GetTattoosAsync(int? amount)
        {
            var collection = _context.Tattoos.Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<Tattoo>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Tattoo>> GetTattoosAsync(TattoosResourceParameters tattoosResourceParameters)
        {
            if (tattoosResourceParameters == null)
                throw new ArgumentNullException(nameof(tattoosResourceParameters));

            var collection = _context.Tattoos.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.Date) as IQueryable<Tattoo>;

            if (tattoosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => tattoosResourceParameters.Cities.Contains(t.User.City));
            }

            if (tattoosResourceParameters.TattooStyles != null)
            {
                IEnumerable<TattooStyle> tattooStyles = tattoosResourceParameters.TattooStyles.Select(a => (TattooStyle)Enum.Parse(typeof(TattooStyle), a));
                collection = collection.Where(t => tattooStyles.Contains(t.TattooStyle));
            }

            if (tattoosResourceParameters.Colors != null)
            {
                IEnumerable<Color> colors = tattoosResourceParameters.Colors.Select(a => (Color)Enum.Parse(typeof(Color), a));
                collection = collection.Where(t => colors.Contains(t.Color));
            }

            if (tattoosResourceParameters.Techniques != null)
            {
                IEnumerable<Technique> techniques = tattoosResourceParameters.Techniques.Select(a => (Technique)Enum.Parse(typeof(Technique), a));
                collection = collection.Where(t => techniques.Contains(t.Technique));
            }

            if (tattoosResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = tattoosResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Tattoo>.Create(listCollection,
                tattoosResourceParameters.PageNumber,
                tattoosResourceParameters.PageSize);
        }

        public void AddTattoo(Tattoo tattoo)
        {
            if (tattoo == null)
            {
                throw new ArgumentNullException(nameof(tattoo));
            }

            tattoo.Date = DateTime.Now;

            _context.Add(tattoo);
        }

        public async Task<bool> TattooExistsAsync(int tattooId)
        {
            return await _context.Tattoos.AnyAsync(p => p.Id == tattooId);
        }

        public void DeleteTattoo(Tattoo tattoo)
        {
            _context.Tattoos.Remove(tattoo);
        }

        #endregion

        #region Piercing's methods
        public async Task<Piercing> GetPiercingAsync(int piercingId)
        {
            return await _context.Piercings.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == piercingId);
        }

        public async Task<IEnumerable<Piercing>> GetPiercingsAsync(int? amount)
        {
            var collection = _context.Piercings.Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<Piercing>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Piercing>> GetPiercingsAsync(PiercingsResourceParameters piercingsResourceParameters)
        {
            if (piercingsResourceParameters == null)
                throw new ArgumentNullException(nameof(piercingsResourceParameters));

            var collection = _context.Piercings.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.Date) as IQueryable<Piercing>;

            if (piercingsResourceParameters.Cities != null)
            {
                collection = collection.Where(t => piercingsResourceParameters.Cities.Contains(t.User.City));
            }

            if (piercingsResourceParameters.Punctures != null)
            {
                IEnumerable<Puncture> punctures = piercingsResourceParameters.Punctures.Select(a => (Puncture)Enum.Parse(typeof(Puncture), a));
                collection = collection.Where(t => punctures.Contains(t.Puncture));
            }

            if (piercingsResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = piercingsResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Piercing>.Create(listCollection,
                piercingsResourceParameters.PageNumber,
                piercingsResourceParameters.PageSize);
        }

        public void AddPiercing(Piercing piercing)
        {
            if (piercing == null)
            {
                throw new ArgumentNullException(nameof(piercing));
            }

            piercing.Date = DateTime.Now;

            _context.Add(piercing);
        }

        public async Task<bool> PiercingExistsAsync(int piercingId)
        {
            return await _context.Piercings.AnyAsync(p => p.Id == piercingId);
        }

        public void DeletePiercing(Piercing piercing)
        {
            _context.Piercings.Remove(piercing);
        }

        #endregion

        #region Model's photos methods
        public async Task<ModelPhoto> GetModelPhotoAsync(int modelId)
        {
            return await _context.ModelsPhotos.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == modelId);
        }

        public async Task<IEnumerable<ModelPhoto>> GetModelsPhotosAsync(int? amount)
        {
            var collection = _context.ModelsPhotos.Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<ModelPhoto>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        public async Task<PagedList<ModelPhoto>> GetModelsPhotosAsync(ModelsPhotosResourceParameters modelsPhotosResourceParameters)
        {

            if (modelsPhotosResourceParameters == null)
                throw new ArgumentNullException(nameof(modelsPhotosResourceParameters));

            var collection = _context.ModelsPhotos.AsQueryable()
                    .Include(p => p.User)
                    .ThenInclude(t => t.Model)
                    .OrderByDescending(m => m.Date) as IQueryable<ModelPhoto>;

            if (modelsPhotosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => modelsPhotosResourceParameters.Cities.Contains(t.User.City));
            }

            if (modelsPhotosResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = modelsPhotosResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (modelsPhotosResourceParameters.ModelingStyles != null)
            {
                IEnumerable<ModelingStyle> modelingStyles = modelsPhotosResourceParameters.ModelingStyles.Select(a => (ModelingStyle)Enum.Parse(typeof(ModelingStyle), a));
                collection = collection.Where(t => modelingStyles.Contains(t.ModelingStyle));
            }

            if (modelsPhotosResourceParameters.Experiences != null)
            {
                IEnumerable<Experience> experiences = modelsPhotosResourceParameters.Experiences.Select(a => (Experience)Enum.Parse(typeof(Experience), a));
                collection = collection.Where(t => experiences.Contains(t.User.Model.Experience));
            }

            if (modelsPhotosResourceParameters.Puncture != null)
            {
                collection = collection.Where(t => t.BodyDecorations.Puncture == modelsPhotosResourceParameters.Puncture);
            }

            if (modelsPhotosResourceParameters.Tattoo != null)
            {
                collection = collection.Where(t => t.BodyDecorations.Tattoo == modelsPhotosResourceParameters.Tattoo);
            }

            if (modelsPhotosResourceParameters.AgeFrom != null)
            {
                collection = collection.Where(t => t.User.Age >= modelsPhotosResourceParameters.AgeFrom);
            }

            if (modelsPhotosResourceParameters.AgeTo != null)
            {
                collection = collection.Where(t => t.User.Age <= modelsPhotosResourceParameters.AgeTo);
            }

            if (modelsPhotosResourceParameters.HeightFrom != null)
            {
                collection = collection.Where(t => t.User.Model.Height >= modelsPhotosResourceParameters.HeightFrom);
            }

            if (modelsPhotosResourceParameters.HeightTo != null)
            {
                collection = collection.Where(t => t.User.Model.Height <= modelsPhotosResourceParameters.HeightTo);
            }

            if (modelsPhotosResourceParameters.WeightFrom != null)
            {
                collection = collection.Where(t => t.User.Model.Weight >= modelsPhotosResourceParameters.WeightFrom);
            }

            if (modelsPhotosResourceParameters.WeightTo != null)
            {
                collection = collection.Where(t => t.User.Model.Weight <= modelsPhotosResourceParameters.WeightTo);
            }

            if (modelsPhotosResourceParameters.BreastFrom != null)
            {
                collection = collection.Where(t => t.User.Model.Breast >= modelsPhotosResourceParameters.BreastFrom);
            }

            if (modelsPhotosResourceParameters.BreastTo != null)
            {
                collection = collection.Where(t => t.User.Model.Breast <= modelsPhotosResourceParameters.BreastTo);
            }

            if (modelsPhotosResourceParameters.WaistFrom != null)
            {
                collection = collection.Where(t => t.User.Model.Waist >= modelsPhotosResourceParameters.WaistFrom);
            }

            if (modelsPhotosResourceParameters.WaistTo != null)
            {
                collection = collection.Where(t => t.User.Model.Waist <= modelsPhotosResourceParameters.WaistTo);
            }

            if (modelsPhotosResourceParameters.HipFrom != null)
            {
                collection = collection.Where(t => t.User.Model.Hip >= modelsPhotosResourceParameters.HipFrom);
            }

            if (modelsPhotosResourceParameters.HipTo != null)
            {
                collection = collection.Where(t => t.User.Model.Hip <= modelsPhotosResourceParameters.HipTo);
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<ModelPhoto>.Create(listCollection,
                modelsPhotosResourceParameters.PageNumber,
                modelsPhotosResourceParameters.PageSize);
        }

        public void AddModelPhoto(ModelPhoto modelPhoto)
        {
            if (modelPhoto == null)
            {
                throw new ArgumentNullException(nameof(modelPhoto));
            }

            modelPhoto.Date = DateTime.Now;

            _context.Add(modelPhoto);
        }

        public async Task<bool> ModelPhotoExistsAsync(int modelPhotoId)
        {
            return await _context.ModelsPhotos.AnyAsync(p => p.Id == modelPhotoId);
        }

        public void DeleteModelPhoto(ModelPhoto modelPhoto)
        {
            _context.ModelsPhotos.Remove(modelPhoto);
        }

        #endregion

        #region Photographer's Photo method
        public async Task<PhotographerPhoto> GetPhotographerPhotoAsync(int photographerId)
        {
            return await _context.PhotographersPhotos.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == photographerId);
        }

        public async Task<IEnumerable<PhotographerPhoto>> GetPhotographersPhotosAsync(int? amount)
        {
            var collection = _context.PhotographersPhotos.Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<PhotographerPhoto>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<PhotographerPhoto>> GetPhotographersPhotosAsync(PhotographersPhotosResourceParameters photographersPhotosResourceParameters)
        {
            if (photographersPhotosResourceParameters == null)
                throw new ArgumentNullException(nameof(photographersPhotosResourceParameters));

            var collection = _context.PhotographersPhotos.AsQueryable()
                    .Include(p => p.User)
                    .ThenInclude(t => t.Photographer)
                    .OrderByDescending(m => m.Date) as IQueryable<PhotographerPhoto>;

            if (photographersPhotosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => photographersPhotosResourceParameters.Cities.Contains(t.User.City));
            }

            if (photographersPhotosResourceParameters.Experiences != null)
            {
                IEnumerable<Experience> experiences = photographersPhotosResourceParameters.Experiences.Select(a => (Experience)Enum.Parse(typeof(Experience), a));
                collection = collection.Where(t => experiences.Contains(t.User.Photographer.Experience));
            }

            if (photographersPhotosResourceParameters.ModelingStyles != null)
            {
                IEnumerable<ModelingStyle> modelingStyles = photographersPhotosResourceParameters.ModelingStyles.Select(a => (ModelingStyle)Enum.Parse(typeof(ModelingStyle), a));
                collection = collection.Where(t => modelingStyles.Contains(t.ModelingStyle));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<PhotographerPhoto>.Create(listCollection,
                photographersPhotosResourceParameters.PageNumber,
                photographersPhotosResourceParameters.PageSize);
        }

        public void AddPhotographerPhoto(PhotographerPhoto photographerPhoto)
        {
            if (photographerPhoto == null)
            {
                throw new ArgumentNullException(nameof(photographerPhoto));
            }

            photographerPhoto.Date = DateTime.Now;

            _context.Add(photographerPhoto);
        }

        public async Task<bool> PhotographerPhotoExistsAsync(int photographerPhotoId)
        {
            return await _context.PhotographersPhotos.AnyAsync(p => p.Id == photographerPhotoId);
        }

        public void DeletePhotographerPhoto(PhotographerPhoto photographerPhoto)
        {
            _context.PhotographersPhotos.Remove(photographerPhoto);
        }
        #endregion

        #region AvailableDesign's methods
        public async Task<AvailableDesign> GetAvailableDesignAsync(int availableDesignId)
        {
            return await _context.AvailableDesigns.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == availableDesignId);
        }

        public async Task<IEnumerable<AvailableDesign>> GetAvailableDesignsAsync(int? amount)
        {
            var collection = _context.AvailableDesigns.Include(p => p.User).OrderByDescending(m => m.Date) as IQueryable<AvailableDesign>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<AvailableDesign>> GetAvailableDesignsAsync(AvailableDesignsResourceParameters availableDesignsResourceParameters)
        {
            if (availableDesignsResourceParameters == null)
                throw new ArgumentNullException(nameof(availableDesignsResourceParameters));

            var collection = _context.AvailableDesigns.AsQueryable()
                    .Include(p => p.User) as IQueryable<AvailableDesign>;

            if (availableDesignsResourceParameters.Cities != null)
            {
                collection = collection.Where(t => availableDesignsResourceParameters.Cities.Contains(t.User.City));
            }

            if (availableDesignsResourceParameters.TattooStyles != null)
            {
                IEnumerable<TattooStyle> tattooStyles = availableDesignsResourceParameters.TattooStyles.Select(a => (TattooStyle)Enum.Parse(typeof(TattooStyle), a));
                collection = collection.Where(t => tattooStyles.Contains(t.TattooStyle));
            }

            if (availableDesignsResourceParameters.Colors != null)
            {
                IEnumerable<Color> colors = availableDesignsResourceParameters.Colors.Select(a => (Color)Enum.Parse(typeof(Color), a));
                collection = collection.Where(t => colors.Contains(t.Color));
            }

            if (availableDesignsResourceParameters.Techniques != null)
            {
                IEnumerable<Technique> techniques = availableDesignsResourceParameters.Techniques.Select(a => (Technique)Enum.Parse(typeof(Technique), a));
                collection = collection.Where(t => techniques.Contains(t.Technique));
            }

            if (availableDesignsResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = availableDesignsResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (availableDesignsResourceParameters.Reserved != null)
            {
                collection = collection.Where(t => t.Reserved == availableDesignsResourceParameters.Reserved);
            }

            if (availableDesignsResourceParameters.WithPrice != null)
            {
                if (availableDesignsResourceParameters.WithPrice == true)
                {
                    collection = collection.Where(t => t.Price != null);
                }
                else
                {
                    collection = collection.Where(t => t.Price == null);
                }
            }

            if (availableDesignsResourceParameters.PriceFrom != null)
            {
                collection = collection.Where(t => t.Price >= availableDesignsResourceParameters.PriceFrom);
            }

            if (availableDesignsResourceParameters.PriceTo != null)
            {
                collection = collection.Where(t => t.Price <= availableDesignsResourceParameters.PriceTo);
            }

            if (!string.IsNullOrWhiteSpace(availableDesignsResourceParameters.OrderBy))
            {
                var trimmedField = availableDesignsResourceParameters.OrderBy.Trim();

                if (trimmedField.ToLowerInvariant() == "datedesc")
                {
                    collection = collection.OrderByDescending(t => t.Date);
                }
                else if (trimmedField.ToLowerInvariant() == "date")
                {
                    collection = collection.OrderBy(t => t.Date);
                }
                else if (trimmedField.ToLowerInvariant() == "pricedesc")
                {
                    collection = collection.OrderByDescending(t => t.Price);
                }
                else if (trimmedField.ToLowerInvariant() == "price")
                {
                    collection = collection.OrderBy(t => t.Price);
                }
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<AvailableDesign>.Create(listCollection,
                availableDesignsResourceParameters.PageNumber,
                availableDesignsResourceParameters.PageSize);
        }

        #endregion

        #region Piercer's method
        /// <summary>
        /// Get piercer by Id
        /// </summary>
        /// <param name="articleId">piercer Id</param>
        /// <returns>Piercer by Id</returns>
        public async Task<Piercer> GetPiercerAsync(int piercerId)
        {       
            return await _context.Piercers.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == piercerId);
        }
        /// <summary>
        /// Get Pirecers Thumbnails 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Piercer>> GetPircersThumbnailsAsync(int? amount)
        {
            var collection = _context.Piercers.Include(p => p.User).OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Piercer>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        /// <summary>
        /// Get partiular Pircer profile
        /// </summary>
        /// <param name="piercersProfilesResourceParameters"></param>
        /// <returns></returns>
        public async Task<PagedList<Piercer>> GetPiercersProfilesAsync(PiercersProfilesResourceParameters piercersProfilesResourceParameters)
        {

            if (piercersProfilesResourceParameters == null)
                throw new ArgumentNullException(nameof(piercersProfilesResourceParameters));

            var collection = _context.Piercers.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Piercer>;

            if (piercersProfilesResourceParameters.Cities != null)
            {
                collection = collection.Where(t => piercersProfilesResourceParameters.Cities.Contains(t.User.City));
            }

            if (piercersProfilesResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = piercersProfilesResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (piercersProfilesResourceParameters.AgeFrom != null)
            {
                collection = collection.Where(t => t.User.Age >= piercersProfilesResourceParameters.AgeFrom);
            }

            if (piercersProfilesResourceParameters.AgeTo != null)
            {
                collection = collection.Where(t => t.User.Age <= piercersProfilesResourceParameters.AgeTo);
            }


            var listCollection = await collection.ToListAsync();

            return PagedList<Piercer>.Create(listCollection,
                piercersProfilesResourceParameters.PageNumber,
                piercersProfilesResourceParameters.PageSize);
        }

        #endregion

        #region Model's method
        /// <summary>
        /// Get model by Id
        /// </summary>
        /// <param name="modelId">model Id</param>
        /// <returns>Model by Id</returns>
        public async Task<Model> GetModelAsync(int modelId)
        {
            return await _context.Models.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == modelId);
        }
        /// <summary>
        /// Get Models Thumbnails
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Model>> GetModelsThumbnailsAsync(int? amount)
        {
            var collection = _context.Models.Include(p => p.User).OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Model>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Model>> GetModelsProfilesAsync(ModelsProfilesResourceParameters modelsProfilesResourceParameters)
        {

            if (modelsProfilesResourceParameters == null)
                throw new ArgumentNullException(nameof(modelsProfilesResourceParameters));

            var collection = _context.Models.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Model>;

            if (modelsProfilesResourceParameters.Cities != null)
            {
                collection = collection.Where(t => modelsProfilesResourceParameters.Cities.Contains(t.User.City));
            }

            if (modelsProfilesResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = modelsProfilesResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (modelsProfilesResourceParameters.AgeFrom != null)
            {
                collection = collection.Where(t => t.User.Age >= modelsProfilesResourceParameters.AgeFrom);
            }

            if (modelsProfilesResourceParameters.AgeTo != null)
            {
                collection = collection.Where(t => t.User.Age <= modelsProfilesResourceParameters.AgeTo);
            }


            var listCollection = await collection.ToListAsync();

            return PagedList<Model>.Create(listCollection,
                modelsProfilesResourceParameters.PageNumber,
                modelsProfilesResourceParameters.PageSize);
        }

        #endregion

        #region Tattooer's method
        /// <summary>
        /// Get tattooer by Id
        /// </summary>
        /// <returns>Tattooer by Id</returns>
        public async Task<Tattooer> GetTattooerAsync(int tattooerId)
        {
            return await _context.Tattooers.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == tattooerId);
        }
        /// <summary>
        /// Get Models Thumbnails
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tattooer>> GetTattooersThumbnailsAsync(int? amount)
        {
            var collection = _context.Tattooers.Include(p => p.User).OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Tattooer>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        /// <summary>
        /// Get tattooers profiles
        /// </summary>
        /// <returns></returns>
        public async Task<PagedList<Tattooer>> GetTattooersProfilesAsync(TattooersProfilesResourceParameters tattooersProfilesResourceParameters)
        {

            if (tattooersProfilesResourceParameters == null)
                throw new ArgumentNullException(nameof(tattooersProfilesResourceParameters));

            var collection = _context.Tattooers.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Tattooer>;

            if (tattooersProfilesResourceParameters.Cities != null)
            {
                collection = collection.Where(t => tattooersProfilesResourceParameters.Cities.Contains(t.User.City));
            }

            if (tattooersProfilesResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = tattooersProfilesResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (tattooersProfilesResourceParameters.AgeFrom != null)
            {
                collection = collection.Where(t => t.User.Age >= tattooersProfilesResourceParameters.AgeFrom);
            }

            if (tattooersProfilesResourceParameters.AgeTo != null)
            {
                collection = collection.Where(t => t.User.Age <= tattooersProfilesResourceParameters.AgeTo);
            }

            if (tattooersProfilesResourceParameters.Techniques != null)
            {
                IEnumerable<Technique> techniques = tattooersProfilesResourceParameters.Techniques.Select(a => (Technique)Enum.Parse(typeof(Technique), a));
                collection = collection.Where(t => techniques.Contains(t.Technique));
            }

            if (tattooersProfilesResourceParameters.TattooStyles != null)
            {
                IEnumerable<TattooStyle> tattooStyle = tattooersProfilesResourceParameters.TattooStyles.Select(a => (TattooStyle)Enum.Parse(typeof(TattooStyle), a));
                collection = collection.Where(t => tattooStyle.Contains(t.TattooStyle));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Tattooer>.Create(listCollection,
                tattooersProfilesResourceParameters.PageNumber,
                tattooersProfilesResourceParameters.PageSize);
        }

        #endregion

        #region Photographer's method
        /// <summary>
        /// Get tattooer by Id
        /// </summary>
        /// <returns>Tattooer by Id</returns>
        public async Task<Photographer> GetPhotographerAsync(int photographerId)
        {
            return await _context.Photographers.AsQueryable()
                .Include(p => p.User)
                .FirstOrDefaultAsync(a => a.Id == photographerId);
        }
        /// <summary>
        /// Get Models Thumbnails
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Photographer>> GetPhotographersThumbnailsAsync(int? amount)
        {
            var collection = _context.Photographers.Include(p => p.User).OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Photographer>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        /// <summary>
        /// Get tattooers profiles
        /// </summary>
        /// <returns></returns>
        public async Task<PagedList<Photographer>> GetPhotographersProfilesAsync(PhotographersProfilesResourceParameters photographersProfilesResourceParameters)
        {

            if (photographersProfilesResourceParameters == null)
                throw new ArgumentNullException(nameof(photographersProfilesResourceParameters));

            var collection = _context.Photographers.AsQueryable()
                    .Include(p => p.User)
                    .OrderByDescending(m => m.User.RegistrationDate) as IQueryable<Photographer>;

            if (photographersProfilesResourceParameters.Cities != null)
            {
                collection = collection.Where(t => photographersProfilesResourceParameters.Cities.Contains(t.User.City));
            }

            if (photographersProfilesResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = photographersProfilesResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.User.Gender));
            }

            if (photographersProfilesResourceParameters.AgeFrom != null)
            {
                collection = collection.Where(t => t.User.Age >= photographersProfilesResourceParameters.AgeFrom);
            }

            if (photographersProfilesResourceParameters.AgeTo != null)
            {
                collection = collection.Where(t => t.User.Age <= photographersProfilesResourceParameters.AgeTo);
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Photographer>.Create(listCollection,
                photographersProfilesResourceParameters.PageNumber,
                photographersProfilesResourceParameters.PageSize);
        }

        #endregion

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<bool> UserExistsAsync(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }

        public void AddAvailableDesign(AvailableDesign availableDesign)
        {
            if (availableDesign == null)
            {
                throw new ArgumentNullException(nameof(availableDesign));
            }

            availableDesign.Date = DateTime.Now;

            _context.Add(availableDesign);
        }

        public async Task<bool> AvailableDesignExistsAsync(int availableDesignId)
        {
            return await _context.AvailableDesigns.AnyAsync(p => p.Id == availableDesignId);
        }

        public void DeleteAvailableDesign(AvailableDesign availableDesign)
        {
            _context.AvailableDesigns.Remove(availableDesign);
        }

        public async Task<bool> IsUserPiercerAsync(int userId)
        {
            return await _context.Users.Include(u => u.Piercer).Select(u => u.Piercer).FirstOrDefaultAsync(u => u.Id == userId) != null;
        }

        public async Task<bool> IsUserTattooerAsync(int userId)
        {
            return await _context.Users.Include(u => u.Tattooer).Select(u => u.Tattooer).FirstOrDefaultAsync(u => u.Id == userId) != null;
        }

        public async Task<bool> IsUserModelAsync(int userId)
        {
            return await _context.Users.Include(u => u.Model).Select(u => u.Model).FirstOrDefaultAsync(u => u.Id == userId) != null;
        }

        public async Task<bool> IsUserPhotographerAsync(int userId)
        {
            return await _context.Users.Include(u => u.Photographer).Select(u => u.Photographer).FirstOrDefaultAsync(u => u.Id == userId) != null;
        }

        public async Task<bool> ArticleSubcategoryExistAsync(int subcategoryId)
        {
            return await _context.ArticleSubCategories.AnyAsync(p => p.Id == subcategoryId);
        }
    }
}
