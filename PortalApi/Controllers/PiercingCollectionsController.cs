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
    [Route("api/piercings")]
    public class PiercingCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public PiercingCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<PiercingThumbnailDto>>> GetPiercingsThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var piercings = await _portalRepository.GetPiercings(amount);
            return Ok(_mapper.Map<IEnumerable<PiercingThumbnailDto>>(piercings));
        }

        [HttpGet(Name = "GetPiercings")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PiercingThumbnailDto>>> GetPiercings(
            [FromQuery] PiercingsResourceParameters piercingsResourceParameters)
        {
            if (!_resourceValidator.ValidPiercingsParameters(piercingsResourceParameters))
            {
                return BadRequest();
            }

            var piercings = await _portalRepository.GetPiercings(piercingsResourceParameters);

            var previousPageLink = piercings.HasPrevious ?
               CreatePiercingsResourceUri(piercingsResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = piercings.HasNext ?
                CreatePiercingsResourceUri(piercingsResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = piercings.TotalCount,
                pageSize = piercings.PageSize,
                currentPage = piercings.CurrentPage,
                totalPages = piercings.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<PiercingThumbnailDto>>(piercings));
        }

        protected string CreatePiercingsResourceUri(
           PiercingsResourceParameters piercingsResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetPiercings",
                      new
                      {
                          pageNumber = piercingsResourceParameters.PageNumber - 1,
                          pageSize = piercingsResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetPiercings",
                      new
                      {
                          pageNumber = piercingsResourceParameters.PageNumber + 1,
                          pageSize = piercingsResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetPiercings",
                    new
                    {
                        pageNumber = piercingsResourceParameters.PageNumber,
                        pageSize = piercingsResourceParameters.PageSize
                    });
            }
        }
    }
}
