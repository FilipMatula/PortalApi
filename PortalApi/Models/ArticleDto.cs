using System;

namespace PortalApi.Models
{
    public class ArticleDto
    {
        public PersonDto Person { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
        public ArticleSubCategoryDto ArticleSubCategory { get; set; }
    }
}
