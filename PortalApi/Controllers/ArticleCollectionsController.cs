using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Entities;
using PortalApi.Helpers;
using PortalApi.Models;
using PortalApi.ResourceParameters;
using PortalApi.Services;
using PortalApi.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public ArticleCollectionsController(IPortalRepository portalRepository,
            IMapper mapper, IResourceValidator resourceValidator)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
            _resourceValidator = resourceValidator ??
                throw new ArgumentNullException(nameof(resourceValidator));
        }

        [HttpGet("thumbs/{subcategoryId}")]
        public async Task<ActionResult<IEnumerable<ArticleThumbnailDto>>> GetArticlesThumbnailsByCategory(int subcategoryId, int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var subcategory = await _portalRepository.GetArticleSubcategory(subcategoryId);

            if (subcategory == null)
            {
                return NotFound();
            }

            var articles = await _portalRepository.GetArticlesByCategory(subcategoryId, amount);
            return Ok(_mapper.Map<IEnumerable<ArticleThumbnailDto>>(articles));
        }

        [HttpGet("{subcategoryId}", Name = "GetArticles")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<ArticleOverviewDto>>> GetArticlesByCategory(int subcategoryId,
            [FromQuery] ArticlesResourceParameters articlesResourceParameters)
        {
            if(!_resourceValidator.ValidArticlesParameters(articlesResourceParameters))
            {
                return BadRequest();
            }

            var subcategory = await _portalRepository.GetArticleSubcategory(subcategoryId);

            if (subcategory == null)
            {
                return NotFound();
            }

            var articles = await _portalRepository.GetArticlesByCategory(subcategoryId, articlesResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreateArticlesResourceUri(articlesResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreateArticlesResourceUri(articlesResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = articles.TotalCount,
                pageSize = articles.PageSize,
                currentPage = articles.CurrentPage,
                totalPages = articles.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<ArticleOverviewDto>>(articles));
        }

        private string CreateArticlesResourceUri(
           ArticlesResourceParameters articlesResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetArticles",
                      new
                      {
                          pageNumber = articlesResourceParameters.PageNumber - 1,
                          pageSize = articlesResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetArticles",
                      new
                      {
                          pageNumber = articlesResourceParameters.PageNumber + 1,
                          pageSize = articlesResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetArticles",
                    new
                    {
                        pageNumber = articlesResourceParameters.PageNumber,
                        pageSize = articlesResourceParameters.PageSize
                    });
            }
        }
    }
}

