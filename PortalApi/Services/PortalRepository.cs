using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using PortalApi.Entities;
using PortalApi.Enums;
using PortalApi.Helpers;
using PortalApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

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
        public async Task<Article> GetArticle(int articleId)
        {
            return await _context.Articles.AsQueryable()
                .Include(p => p.Person)
                .Include(r => r.ArticleSubcategory)
                .FirstOrDefaultAsync(a => a.Id == articleId);
        }

        /// <summary>
        /// Get Articles by category
        /// </summary>
        /// <param name="subcategoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int? amount)
        {
            var collection = _context.Articles.AsQueryable().Where(a => a.ArticleSubcategoryId == subcategoryId).Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Article>;

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
        public async Task<PagedList<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters)
        {
            if (articlesResourceParameters == null)
                throw new ArgumentNullException(nameof(articlesResourceParameters));

            var collection = await _context.Articles.AsQueryable().Where(a => a.ArticleSubcategoryId == subcategoryId)
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date).ToListAsync();

            return PagedList<Article>.Create(collection,
                articlesResourceParameters.PageNumber,
                articlesResourceParameters.PageSize);
        }

        /// <summary>
        /// Get all articles category
        /// </summary>
        /// <returns>Article's category</returns>
        public async Task<IEnumerable<ArticleCategory>> GetArticlesCategories()
        {
            return await _context.ArticleCategories.AsQueryable()
                .Include(s => s.Subcategories).OrderBy(c => c.Id).ThenBy(s => s).ToListAsync();
        }

        public async Task<ArticleSubcategory> GetArticleSubcategory(int subcategoryId)
        {
            return await _context.ArticleSubCategories.AsQueryable()
                .Where(s => s.Id == subcategoryId).FirstOrDefaultAsync();
        }

        #endregion

        #region Tattoo's methods

        public async Task<Tattoo> GetTattoo(int tattooId)
        {
            return await _context.Tattoos.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == tattooId);
        }

        public async Task<IEnumerable<Tattoo>> GetTattoos(int? amount)
        {
            var collection = _context.Tattoos.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Tattoo>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Tattoo>> GetTattoos(TattoosResourceParameters tattoosResourceParameters)
        {
            if (tattoosResourceParameters == null)
                throw new ArgumentNullException(nameof(tattoosResourceParameters));

            var collection = _context.Tattoos.AsQueryable()
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date) as IQueryable<Tattoo>;

            if (tattoosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => tattoosResourceParameters.Cities.Contains(t.City));
            }

            if (tattoosResourceParameters.Styles != null)
            {
                IEnumerable<Style> styles = tattoosResourceParameters.Styles.Select(a => (Style)Enum.Parse(typeof(Style), a));
                collection = collection.Where(t => styles.Contains(t.Style));
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
                collection = collection.Where(t => genders.Contains(t.Gender));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Tattoo>.Create(listCollection,
                tattoosResourceParameters.PageNumber,
                tattoosResourceParameters.PageSize);
        }

        #endregion

        #region Piercing's methods
        public async Task<Piercing> GetPiercing(int piercingId)
        {
            return await _context.Piercings.AsQueryable()
                .Include(p => p.Piercer)
                .FirstOrDefaultAsync(a => a.Id == piercingId);
        }

        public async Task<IEnumerable<Piercing>> GetPiercings(int? amount)
        {
            var collection = _context.Piercings.Include(p => p.Piercer).OrderByDescending(m => m.Date) as IQueryable<Piercing>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Piercing>> GetPiercings(PiercingsResourceParameters piercingsResourceParameters)
        {
            if (piercingsResourceParameters == null)
                throw new ArgumentNullException(nameof(piercingsResourceParameters));

            var collection = _context.Piercings.AsQueryable()
                    .Include(p => p.Piercer)
                    .OrderByDescending(m => m.Date) as IQueryable<Piercing>;

            if (piercingsResourceParameters.Cities != null)
            {
                collection = collection.Where(t => piercingsResourceParameters.Cities.Contains(t.City));
            }

            if (piercingsResourceParameters.Punctures != null)
            {
                IEnumerable<Puncture> punctures = piercingsResourceParameters.Punctures.Select(a => (Puncture)Enum.Parse(typeof(Puncture), a));
                collection = collection.Where(t => punctures.Contains(t.Puncture));
            }

            if (piercingsResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = piercingsResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.Gender));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Piercing>.Create(listCollection,
                piercingsResourceParameters.PageNumber,
                piercingsResourceParameters.PageSize);
        }

        #endregion

        #region Model's methods
        public async Task<ModelPhoto> GetModelPhoto(int modelId)
        {
            return await _context.ModelsPhotos.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == modelId);
        }

        public async Task<IEnumerable<ModelPhoto>> GetModelsPhotos(int? amount)
        {
            var collection = _context.ModelsPhotos.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<ModelPhoto>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        public async Task<PagedList<ModelPhoto>> GetModelsPhotos(ModelsPhotosResourceParameters modelsPhotosResourceParameters)
        {

            if (modelsPhotosResourceParameters == null)
                throw new ArgumentNullException(nameof(modelsPhotosResourceParameters));

            var collection = _context.ModelsPhotos.AsQueryable()
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date) as IQueryable<ModelPhoto>;

            if (modelsPhotosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => modelsPhotosResourceParameters.Cities.Contains(t.City));
            }

            if (modelsPhotosResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = modelsPhotosResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.Gender));
            }

            // Dodac wiek i reszte kryteriow

            var listCollection = await collection.ToListAsync();

            return PagedList<ModelPhoto>.Create(listCollection,
                modelsPhotosResourceParameters.PageNumber,
                modelsPhotosResourceParameters.PageSize);
        }

        #endregion

        #region Photographer's method
        public async Task<PhotographerPhoto> GetPhotographerPhoto(int photographerId)
        {
            return await _context.PhotographersPhotos.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == photographerId);
        }

        public async Task<IEnumerable<PhotographerPhoto>> GetPhotographersPhotos(int? amount)
        {
            var collection = _context.PhotographersPhotos.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<PhotographerPhoto>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<PhotographerPhoto>> GetPhotographersPhotos(PhotographersPhotosResourceParameters photographersPhotosResourceParameters)
        {
            if (photographersPhotosResourceParameters == null)
                throw new ArgumentNullException(nameof(photographersPhotosResourceParameters));

            var collection = _context.PhotographersPhotos.AsQueryable()
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date) as IQueryable<PhotographerPhoto>;

            if (photographersPhotosResourceParameters.Cities != null)
            {
                collection = collection.Where(t => photographersPhotosResourceParameters.Cities.Contains(t.City));
            }

            if (photographersPhotosResourceParameters.Experiences != null)
            {
                IEnumerable<Experience> experiences = photographersPhotosResourceParameters.Experiences.Select(a => (Experience)Enum.Parse(typeof(Experience), a));
                collection = collection.Where(t => experiences.Contains(t.Experience));
            }

            if (photographersPhotosResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = photographersPhotosResourceParameters.Genders.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
                collection = collection.Where(t => genders.Contains(t.Gender));
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<PhotographerPhoto>.Create(listCollection,
                photographersPhotosResourceParameters.PageNumber,
                photographersPhotosResourceParameters.PageSize);
        }
        #endregion

        #region AvailableDesign's methods
        public async Task<AvailableDesign> GetDesign(int designId)
        {
            return await _context.AvailableDesigns.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == designId);
        }

        public async Task<IEnumerable<AvailableDesign>> GetDesigns(int? amount)
        {
            var collection = _context.AvailableDesigns.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<AvailableDesign>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<AvailableDesign>> GetDesigns(AvailableDesignsResourceParameters availableDesignsResourceParameters)
        {
            if (availableDesignsResourceParameters == null)
                throw new ArgumentNullException(nameof(availableDesignsResourceParameters));

            var collection = _context.AvailableDesigns.AsQueryable()
                    .Include(p => p.Person) as IQueryable<AvailableDesign>;

            if (availableDesignsResourceParameters.Cities != null)
            {
                collection = collection.Where(t => availableDesignsResourceParameters.Cities.Contains(t.City));
            }

            if (availableDesignsResourceParameters.Styles != null)
            {
                IEnumerable<Style> styles = availableDesignsResourceParameters.Styles.Select(a => (Style)Enum.Parse(typeof(Style), a));
                collection = collection.Where(t => styles.Contains(t.Style));
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
                collection = collection.Where(t => genders.Contains(t.Gender));
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

            if(!string.IsNullOrWhiteSpace(availableDesignsResourceParameters.OrderBy))
            {
                var trimmedField = availableDesignsResourceParameters.OrderBy.Trim();

                if(trimmedField.ToLowerInvariant() == "datedesc")
                {
                    collection = collection.OrderByDescending(t => t.Date);
                }
                else if(trimmedField.ToLowerInvariant() == "date")
                {
                    collection = collection.OrderBy(t => t.Date);
                }
                else if(trimmedField.ToLowerInvariant() == "pricedesc")
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

    }
}
