using System.Collections.Generic;

namespace PortalApi.Models
{
    public class ArticleCategoryDto
    {
        public string Name { get; set; }
        public List<ArticleSubcategoryDto> Subcategories { get; set; } = new List<ArticleSubcategoryDto>();
    }
}
