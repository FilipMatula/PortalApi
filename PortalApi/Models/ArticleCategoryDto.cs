using System.Collections.Generic;

namespace PortalApi.Models
{
    public class ArticleCategoryDto
    {
        public string Name { get; set; }
        public List<ArticleSubCategoryDto> SubCategories { get; set; } = new List<ArticleSubCategoryDto>();
    }
}
