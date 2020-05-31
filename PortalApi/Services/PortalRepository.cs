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
                .Include(s => s.Subcategories).OrderBy(c => c.Name).ToListAsync();
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
                IEnumerable<Color> colors = tattoosResourceParameters.Styles.Select(a => (Color)Enum.Parse(typeof(Color), a));
                collection = collection.Where(t => colors.Contains(t.Color));
            }

            if (tattoosResourceParameters.Techniques != null)
            {
                IEnumerable<Technique> techniques = tattoosResourceParameters.Styles.Select(a => (Technique)Enum.Parse(typeof(Technique), a));
                collection = collection.Where(t => techniques.Contains(t.Technique));
            }

            if (tattoosResourceParameters.Genders != null)
            {
                IEnumerable<Gender> genders = tattoosResourceParameters.Styles.Select(a => (Gender)Enum.Parse(typeof(Gender), a));
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
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == piercingId);
        }

        public async Task<IEnumerable<Piercing>> GetPiercings(int? amount)
        {
            var collection = _context.Piercings.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Piercing>;

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
                    .Include(p => p.Person)
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
        public async Task<Model> GetModel(int modelId)
        {
            return await _context.Models.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == modelId);
        }

        public async Task<IEnumerable<Model>> GetModels(int? amount)
        {
            var collection = _context.Models.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Model>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }
        public async Task<PagedList<Model>> GetModels(ModelResourceParameters modelsResourceParameters)
        {
            if (modelsResourceParameters == null)
                throw new ArgumentNullException(nameof(modelsResourceParameters));

            var collection = _context.Models.AsQueryable()
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date) as IQueryable<Model>;

            if (modelsResourceParameters.City != null)
            {
                var city = modelsResourceParameters.City.Trim();
                collection = collection.Where(t => t.City == city);
            }

            if (modelsResourceParameters.Piercing == true && modelsResourceParameters.Tattoo == true)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Puncture == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == false && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Puncture == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == true && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Puncture == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == false && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Puncture == piercing && t.Tattoo == tattoo);
            }

            if (modelsResourceParameters.Gender != null)
            {
                Enum.TryParse(modelsResourceParameters.Gender.Trim(), out Gender gender);
                collection = collection.Where(t => t.Gender == gender);
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Model>.Create(listCollection,
                modelsResourceParameters.PageNumber,
                modelsResourceParameters.PageSize);
        }

        #endregion

        #region Photographer's method
        public async Task<Photographer> GetPhotographer(int photographerId)
        {
            return await _context.Photographers.AsQueryable()
                .Include(p => p.Person)
                .FirstOrDefaultAsync(a => a.Id == photographerId);
        }

        public async Task<IEnumerable<Photographer>> GetPhotographers(int? amount)
        {
            var collection = _context.Photographers.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Photographer>;

            if (amount != null)
            {
                collection = collection.Take(amount.GetValueOrDefault());
            }

            return await collection.ToListAsync();
        }

        public async Task<PagedList<Photographer>> GetPhotographers(PhotographerResourceParameters photographerResourceParameters)
        {
            if (photographerResourceParameters == null)
                throw new ArgumentNullException(nameof(photographerResourceParameters));

            var collection = _context.Photographers.AsQueryable()
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date) as IQueryable<Photographer>;

            if (photographerResourceParameters.City != null)
            {
                var city = photographerResourceParameters.City.Trim();
                collection = collection.Where(t => t.City == city);
            }

            if (photographerResourceParameters.Experience != null)
            {
                Enum.TryParse(photographerResourceParameters.Experience.Trim(), out Experience experience);
                collection = collection.Where(t => t.Experience == experience);
            }

            if (photographerResourceParameters.Gender != null)
            {
                Enum.TryParse(photographerResourceParameters.Gender.Trim(), out Gender gender);
                collection = collection.Where(t => t.Gender == gender);
            }

            var listCollection = await collection.ToListAsync();

            return PagedList<Photographer>.Create(listCollection,
                photographerResourceParameters.PageNumber,
                photographerResourceParameters.PageSize);
        }
        #endregion
    }
}
