using AutoMapper;
using System.Collections.Generic;

namespace PortalApi.Profiles
{
    public class ArticleCategoryProfile : Profile
    {
        public ArticleCategoryProfile()
        {
            CreateMap<Entities.ArticleCategory, Models.ArticleCategoryDto>();
            CreateMap<Entities.ArticleSubcategory, Models.ArticleSubcategoryDto>();
        }
    }
}
