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
    [Route("api/photographers")]
    public class PhotographerPhotoCollections : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public PhotographerPhotoCollections(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("thumbs")]
        public async Task<ActionResult<IEnumerable<PhotographerPhotoThumbnailDto>>> GetPhotographersThumbnails(int amount = 0)
        {
            var articles = await _portalRepository.GetPhotographers(amount);
            return Ok(_mapper.Map<IEnumerable<PhotographerPhotoThumbnailDto>>(articles));
        }

        [HttpGet(Name = "GetPhotographers")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PhotographerPhotoThumbnailDto>>> GetArticlesByCategory(
            [FromQuery] PhotographerResourceParameters photographerResourceParameters)
        {
            var articles = await _portalRepository.GetPhotographers(photographerResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreateModelsResourceUri(photographerResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreateModelsResourceUri(photographerResourceParameters,
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

            return Ok(_mapper.Map<IEnumerable<PhotographerPhotoThumbnailDto>>(articles));
        }
        public string CreateModelsResourceUri(
           PhotographerResourceParameters photographerResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetPhotographers",
                      new
                      {
                          pageNumber = photographerResourceParameters.PageNumber - 1,
                          pageSize = photographerResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetPhotographers",
                      new
                      {
                          pageNumber = photographerResourceParameters.PageNumber + 1,
                          pageSize = photographerResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetPhotographers",
                    new
                    {
                        pageNumber = photographerResourceParameters.PageNumber,
                        pageSize = photographerResourceParameters.PageSize
                    });
            }
        }

    }
}
