using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Entities;
using PortalApi.Models;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class ArticlesCategoryController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ArticlesCategoryController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleCategoryDto>>> GetArticlesCategoriesNames()
        {
            var articleCategories = await _portalRepository.GetArticlesCategoriesAsync();
            return Ok(_mapper.Map<IEnumerable<ArticleCategoryDto>>(articleCategories));
        }

        [HttpGet("articles")]
        public async Task<ActionResult<IEnumerable<ArticleCategoryWithArticlesDto>>> GetArticlesCategoriesNamesWithArticles(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }


            var articleCategoriesFromrepo = await _portalRepository.GetArticlesCategoriesWithArticleAsync(amount);
            return Ok(_mapper.Map<IEnumerable<ArticleCategoryWithArticlesDto>>(articleCategoriesFromrepo));
        }
    }
}
