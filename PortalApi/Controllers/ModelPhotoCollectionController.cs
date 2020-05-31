using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Helpers;
using PortalApi.Models;
using PortalApi.ResourceParameters;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/models")]
    public class ModelPhotoCollectionController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ModelPhotoCollectionController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("thumbs")]
        public async Task<ActionResult<IEnumerable<ModelPhotoThumbnailDto>>> GetModelsThumbnails(int amount = 0)
        {
            var articles = await _portalRepository.GetModels(amount);
            return Ok(_mapper.Map<IEnumerable<ModelPhotoThumbnailDto>>(articles));
        }

        [HttpGet(Name = "GetModels")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<ModelPhotoThumbnailDto>>> GetArticlesByCategory(
            [FromQuery] ModelResourceParameters modelsResourceParameters)
        {
            var articles = await _portalRepository.GetModels(modelsResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreateModelsResourceUri(modelsResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreateModelsResourceUri(modelsResourceParameters,
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

            return Ok(_mapper.Map<IEnumerable<ModelPhotoThumbnailDto>>(articles));
        }
        public string CreateModelsResourceUri(
           ModelResourceParameters modelsResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetModels",
                      new
                      {
                          pageNumber = modelsResourceParameters.PageNumber - 1,
                          pageSize = modelsResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetModels",
                      new
                      {
                          pageNumber = modelsResourceParameters.PageNumber + 1,
                          pageSize = modelsResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetModels",
                    new
                    {
                        pageNumber = modelsResourceParameters.PageNumber,
                        pageSize = modelsResourceParameters.PageSize
                    });
            }
        }
    }
}
