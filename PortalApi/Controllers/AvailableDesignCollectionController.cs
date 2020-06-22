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
    [Route("api/availabledesigns")]
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
        public async Task<ActionResult<IEnumerable<AvailableDesignThumbnailDto>>> GetAvailableDesignsThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var availableDesigns = await _portalRepository.GetAvailableDesignsAsync(amount);
            return Ok(_mapper.Map<IEnumerable<AvailableDesignThumbnailDto>>(availableDesigns));
        }

        [HttpGet(Name = "GetAvailableDesigns")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<AvailableDesignThumbnailDto>>> GetAvailableDesigns(
            [FromQuery] AvailableDesignsResourceParameters availableDesignsResourceParameters)
        {
            if (!_resourceValidator.ValidAvailableDesignsParameters(availableDesignsResourceParameters))
            {
                return BadRequest();
            }

            var availableDesigns = await _portalRepository.GetAvailableDesignsAsync(availableDesignsResourceParameters);

            var previousPageLink = availableDesigns.HasPrevious ?
               CreateAvailableDesignsResourceUri(availableDesignsResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = availableDesigns.HasNext ?
                CreateAvailableDesignsResourceUri(availableDesignsResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = availableDesigns.TotalCount,
                pageSize = availableDesigns.PageSize,
                currentPage = availableDesigns.CurrentPage,
                totalPages = availableDesigns.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<AvailableDesignThumbnailDto>>(availableDesigns));
        }

        private string CreateAvailableDesignsResourceUri(
           AvailableDesignsResourceParameters availableDesignsResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetAvailableDesigns",
                      new
                      {
                          pageNumber = availableDesignsResourceParameters.PageNumber - 1,
                          pageSize = availableDesignsResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetAvailableDesigns",
                      new
                      {
                          pageNumber = availableDesignsResourceParameters.PageNumber + 1,
                          pageSize = availableDesignsResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetAvailableDesigns",
                    new
                    {
                        pageNumber = availableDesignsResourceParameters.PageNumber,
                        pageSize = availableDesignsResourceParameters.PageSize
                    });
            }
        }
    }
}
