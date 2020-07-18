using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ArticleCategoryWithArticlesDto
    {
        public string Name { get; set; }
        public string ArticleType { get; set; }
        public List<ArticleSubcategoryWithArticleDto> Subcategories { get; set; } = new List<ArticleSubcategoryWithArticleDto>();
    }
}
