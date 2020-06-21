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
    [Route("api/piercers")]
    public class PiercerCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public PiercerCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<PiercerThumbnailDto>>> GetPiercersThumbnails(int? amount = 30)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var piercers = await _portalRepository.GetPircersThumbnails(amount);
            return Ok(_mapper.Map<IEnumerable<PiercerThumbnailDto>>(piercers));
        }

        [HttpGet(Name = "GetPiercersProfiles")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PiercerThumbnailDto>>> GetPiercersProfiles(
            [FromQuery] PiercersProfilesResourceParameters piercersProfilesResourceParameters)
        {
            if (!_resourceValidator.ValidPiercersProfilesParameters(piercersProfilesResourceParameters))
            {
                return BadRequest();
            }

            var piercerProfiles = await _portalRepository.GetPiercersProfiles(piercersProfilesResourceParameters);

            var previousPageLink = piercerProfiles.HasPrevious ?
               CreateModelsPhotosResourceUri(piercersProfilesResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = piercerProfiles.HasNext ?
                CreateModelsPhotosResourceUri(piercersProfilesResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = piercerProfiles.TotalCount,
                pageSize = piercerProfiles.PageSize,
                currentPage = piercerProfiles.CurrentPage,
                totalPages = piercerProfiles.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<PiercerThumbnailDto>>(piercerProfiles));
        }

        private string CreateModelsPhotosResourceUri(
           PiercersProfilesResourceParameters piercersProfilesResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetPiercerProfiles",
                      new
                      {
                          pageNumber = piercersProfilesResourceParameters.PageNumber - 1,
                          pageSize = piercersProfilesResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetPiercerProfiles",
                      new
                      {
                          pageNumber = piercersProfilesResourceParameters.PageNumber + 1,
                          pageSize = piercersProfilesResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetPiercerProfiles",
                    new
                    {
                        pageNumber = piercersProfilesResourceParameters.PageNumber,
                        pageSize = piercersProfilesResourceParameters.PageSize
                    });
            }
        }

    }
}
