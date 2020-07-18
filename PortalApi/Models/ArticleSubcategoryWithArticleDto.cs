using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ArticleSubcategoryWithArticleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ArticleThumbnailDto> Articles { get; set; } = new List<ArticleThumbnailDto>();
    }
}
