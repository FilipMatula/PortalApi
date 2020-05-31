using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/designs")]
    public class AvailableDesignPhotoCollectionController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public AvailableDesignPhotoCollectionController(IPortalRepository portalRepository,
            IMapper mapper, IResourceValidator resourceValidator)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
            _resourceValidator = resourceValidator ??
                throw new ArgumentNullException(nameof(resourceValidator));
        }

        [HttpGet("thumbs")]
        public async Task<ActionResult<IEnumerable<AvailableDesignPhotoThumbnailDto>>> GetDesignsThumbnails(int amount = 0)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var designs = await _portalRepository.GetDesigns(amount);
            return Ok(_mapper.Map<IEnumerable<AvailableDesignPhotoThumbnailDto>>(designs));
        }
        [HttpGet(Name = "GetDesigns")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<AvailableDesignPhotoThumbnailDto>>> GetArticlesByCategory(
            [FromQuery] AvailableDesignPhotoResourceParameters availableDesignResourceParameters)
        {
            //if (!_resourceValidator.ValidDesignsParameters(availableDesignResourceParameters))
            //{
            //    return BadRequest();
            //}

            var articles = await _portalRepository.GetDesigns(availableDesignResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreateModelsResourceUri(availableDesignResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreateModelsResourceUri(availableDesignResourceParameters,
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

            return Ok(_mapper.Map<IEnumerable<AvailableDesignPhotoThumbnailDto>>(articles));
        }
        public string CreateModelsResourceUri(
           AvailableDesignPhotoResourceParameters availableDesignResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetDesigns",
                      new
                      {
                          pageNumber = availableDesignResourceParameters.PageNumber - 1,
                          pageSize = availableDesignResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetDesigns",
                      new
                      {
                          pageNumber = availableDesignResourceParameters.PageNumber + 1,
                          pageSize = availableDesignResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetDesigns",
                    new
                    {
                        pageNumber = availableDesignResourceParameters.PageNumber,
                        pageSize = availableDesignResourceParameters.PageSize
                    });
            }
        }
    }
}
