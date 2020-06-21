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
    [Route("api/tattooers")]
    public class TattoerCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public TattoerCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<TattooerThumbnailDto>>> GetTattooersThumbnails(int? amount = 30)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var tattoers = await _portalRepository.GetTattooersThumbnails(amount);
            return Ok(_mapper.Map<IEnumerable<TattooerThumbnailDto>>(tattoers));
        }

        [HttpGet(Name = "GetTattooersProfiles")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<TattooerThumbnailDto>>> GetTattooersProfiles(
            [FromQuery] TattooersProfilesResourceParameters tattooersProfilesResourceParameters)
        {
            if (!_resourceValidator.ValidTattooersProfilesParameters(tattooersProfilesResourceParameters))
            {
                return BadRequest();
            }

            var tattooersProfiles = await _portalRepository.GetTattooersProfiles(tattooersProfilesResourceParameters);

            var previousPageLink = tattooersProfiles.HasPrevious ?
               CreateModelsPhotosResourceUri(tattooersProfilesResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = tattooersProfiles.HasNext ?
                CreateModelsPhotosResourceUri(tattooersProfilesResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = tattooersProfiles.TotalCount,
                pageSize = tattooersProfiles.PageSize,
                currentPage = tattooersProfiles.CurrentPage,
                totalPages = tattooersProfiles.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<TattooerThumbnailDto>>(tattooersProfiles));
        }

        private string CreateModelsPhotosResourceUri(
           TattooersProfilesResourceParameters tattooersProfilesResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetTattooersProfiles",
                      new
                      {
                          pageNumber = tattooersProfilesResourceParameters.PageNumber - 1,
                          pageSize = tattooersProfilesResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetTattooersProfiles",
                      new
                      {
                          pageNumber = tattooersProfilesResourceParameters.PageNumber + 1,
                          pageSize = tattooersProfilesResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetTattooersProfiles",
                    new
                    {
                        pageNumber = tattooersProfilesResourceParameters.PageNumber,
                        pageSize = tattooersProfilesResourceParameters.PageSize
                    });
            }
        }

    }
}
