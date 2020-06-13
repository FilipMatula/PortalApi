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
    public class AvailableDesignCollectionController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public AvailableDesignCollectionController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<AvailableDesignThumbnailDto>>> GetDesignsThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var designs = await _portalRepository.GetDesigns(amount);
            return Ok(_mapper.Map<IEnumerable<AvailableDesignThumbnailDto>>(designs));
        }

        [HttpGet(Name = "GetDesigns")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<AvailableDesignThumbnailDto>>> GetDesigns(
            [FromQuery] AvailableDesignsResourceParameters availableDesignsResourceParameters)
        {
            if (!_resourceValidator.ValidDesignsParameters(availableDesignsResourceParameters))
            {
                return BadRequest();
            }

            var designs = await _portalRepository.GetDesigns(availableDesignsResourceParameters);

            var previousPageLink = designs.HasPrevious ?
               CreateDesignsResourceUri(availableDesignsResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = designs.HasNext ?
                CreateDesignsResourceUri(availableDesignsResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = designs.TotalCount,
                pageSize = designs.PageSize,
                currentPage = designs.CurrentPage,
                totalPages = designs.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<AvailableDesignThumbnailDto>>(designs));
        }

        protected string CreateDesignsResourceUri(
           AvailableDesignsResourceParameters availableDesignsResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetDesigns",
                      new
                      {
                          pageNumber = availableDesignsResourceParameters.PageNumber - 1,
                          pageSize = availableDesignsResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetDesigns",
                      new
                      {
                          pageNumber = availableDesignsResourceParameters.PageNumber + 1,
                          pageSize = availableDesignsResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetDesigns",
                    new
                    {
                        pageNumber = availableDesignsResourceParameters.PageNumber,
                        pageSize = availableDesignsResourceParameters.PageSize
                    });
            }
        }
    }
}
