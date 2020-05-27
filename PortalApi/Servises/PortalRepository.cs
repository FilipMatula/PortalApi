using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using PortalApi.Entities;
using PortalApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace PortalApi.Servises
{
    public class PortalRepository : IPortalRepository
    {
        private readonly PortalContext _context;

        public PortalRepository(PortalContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Article> GetArticle(int articleId)
        {
            return await _context.Articles.AsQueryable()
                .Include(p => p.Person)
                .Include(r => r.ArticleSubCategory)
                .FirstOrDefaultAsync(a => a.Id == articleId);
        }

        public async Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int amount)
        {
            if (amount == 0)
            {
                return await _context.Articles.AsQueryable()
                    .Where(a => a.ArticleSubCategoryId == subcategoryId)
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date)
                    .ToListAsync();
            }
            else
            {
                return await _context.Articles.AsQueryable()
                    .Where(a => a.ArticleSubCategoryId == subcategoryId)
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date)
                    .Take(amount)
                    .ToListAsync();
            }

        }

        public async Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters)
        {

            return await _context.Articles.AsQueryable()
                    .Where(a => a.ArticleSubCategoryId == subcategoryId)
                    .Include(p => p.Person)
                    .OrderByDescending(m => m.Date)
                    .Skip(articlesResourceParameters.PageSize * (articlesResourceParameters.PageNumber - 1))
                    .Take(articlesResourceParameters.PageSize)
                    .ToListAsync();
        }

        public async Task<IEnumerable<ArticleCategory>> GetArticlesCategories()
        {
            return await _context.ArticleCategories.AsQueryable()
                .Include(s => s.SubCategories).OrderBy(c => c.Name).ToListAsync();
        }
    }
}
