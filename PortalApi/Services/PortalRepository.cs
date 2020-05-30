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
                .Include(r => r.ArticleSubCategory)
                .FirstOrDefaultAsync(a => a.Id == articleId);
        }

        /// <summary>
        /// Get Articles by category
        /// </summary>
        /// <param name="subcategoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int amount)
        {
            var collection = _context.Articles.AsQueryable().Where(a => a.ArticleSubCategoryId == subcategoryId).Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Article>;

            if (amount != 0)
            {
                collection = collection.Take(amount);
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

            var collection = await _context.Articles.AsQueryable().Where(a => a.ArticleSubCategoryId == subcategoryId)
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
                .Include(s => s.SubCategories).OrderBy(c => c.Name).ToListAsync();
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

            if (tattoosResourceParameters.City != null)
            {
                var city = tattoosResourceParameters.City.Trim();
                collection = collection.Where(t => t.City == city);
            }

            if (tattoosResourceParameters.Style != null)
            {
                Enum.TryParse(tattoosResourceParameters.Style.Trim(), out Style style);
                collection = collection.Where(t => t.Style == style);
            }

            if (tattoosResourceParameters.Color != null)
            {
                Enum.TryParse(tattoosResourceParameters.Color.Trim(), out Color color);
                collection = collection.Where(t => t.Color == color);
            }

            if (tattoosResourceParameters.Technique != null)
            {
                Enum.TryParse(tattoosResourceParameters.Technique.Trim(), out Technique technique);
                collection = collection.Where(t => t.Technique == technique);
            }

            if (tattoosResourceParameters.Gender != null)
            {
                Enum.TryParse(tattoosResourceParameters.Gender.Trim(), out Gender gender);
                collection = collection.Where(t => t.Gender == gender);
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

        public async Task<IEnumerable<Piercing>> GetPiercings(int amount)
        {
            var collection = _context.Piercings.Include(p => p.Person).OrderByDescending(m => m.Date) as IQueryable<Piercing>;

            if (amount != 0)
            {
                collection = collection.Take(amount);
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

            if (piercingsResourceParameters.City != null)
            {
                var city = piercingsResourceParameters.City.Trim();
                collection = collection.Where(t => t.City == city);
            }

            if (piercingsResourceParameters.Pierce != null)
            {
                Enum.TryParse(piercingsResourceParameters.Pierce.Trim(), out Pierce pierce);
                collection = collection.Where(t => t.Pierce == pierce);
            }

            if (piercingsResourceParameters.Gender != null)
            {
                Enum.TryParse(piercingsResourceParameters.Gender.Trim(), out Gender gender);
                collection = collection.Where(t => t.Gender == gender);
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
                collection = collection.Where(t => t.Piercing == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == false && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Piercing == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == true && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Piercing == piercing && t.Tattoo == tattoo);
            }
            else if (modelsResourceParameters.Piercing == false && modelsResourceParameters.Tattoo == false)
            {
                var piercing = modelsResourceParameters.Piercing;
                var tattoo = modelsResourceParameters.Tattoo;
                collection = collection.Where(t => t.Piercing == piercing && t.Tattoo == tattoo);
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
    }
}
