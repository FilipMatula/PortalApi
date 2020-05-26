using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        async Task<IEnumerable<Article>> IPortalRepository.GetArticlesByCategory(int subcategoryId)
        {
            return await _context.Articles.AsQueryable()
                .Where(a => a.ArticleSubCategoryId == subcategoryId)
                .Include(p=>p.Person)
                .ToListAsync();
        }
         
        async Task<IEnumerable<ArticleCategory>> IPortalRepository.GetArticlesCategories()
        {
            return await _context.ArticleCategories.AsQueryable()
                .Include(s => s.SubCategories).OrderBy(c => c.Name).ToListAsync();
        }
    }
}
