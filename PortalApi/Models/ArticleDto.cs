using System;

namespace PortalApi.Models
{
    public class ArticleDto
    {
        public UserShortDto User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
        public ArticleSubcategoryDto ArticleSubcategory { get; set; }
    }
}
