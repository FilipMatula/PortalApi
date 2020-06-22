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
    [Route("api/photographers")]
    public class PhotographerCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public PhotographerCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<PhotographerThumbnailDto>>> GetPhotographersThumbnails(int? amount = 30)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var photographers = await _portalRepository.GetPhotographersThumbnailsAsync(amount);
            return Ok(_mapper.Map<IEnumerable<PhotographerThumbnailDto>>(photographers));
        }


        [HttpGet(Name = "GetPhotographersProfiles")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PhotographerThumbnailDto>>> GetPhotographersProfiles(
            [FromQuery] PhotographersProfilesResourceParameters photographersProfilesResourceParameters)
        {
            if (!_resourceValidator.ValidPhotographersProfilesParameters(photographersProfilesResourceParameters))
            {
                return BadRequest();
            }

            var photographersProfiles = await _portalRepository.GetPhotographersProfilesAsync(photographersProfilesResourceParameters);

            var previousPageLink = photographersProfiles.HasPrevious ?
               CreateModelsPhotosResourceUri(photographersProfilesResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = photographersProfiles.HasNext ?
                CreateModelsPhotosResourceUri(photographersProfilesResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = photographersProfiles.TotalCount,
                pageSize = photographersProfiles.PageSize,
                currentPage = photographersProfiles.CurrentPage,
                totalPages = photographersProfiles.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<PhotographerThumbnailDto>>(photographersProfiles));
        }

        private string CreateModelsPhotosResourceUri(
           PhotographersProfilesResourceParameters photographersProfilesResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetPhotographersProfiles",
                      new
                      {
                          pageNumber = photographersProfilesResourceParameters.PageNumber - 1,
                          pageSize = photographersProfilesResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetPhotographersProfiles",
                      new
                      {
                          pageNumber = photographersProfilesResourceParameters.PageNumber + 1,
                          pageSize = photographersProfilesResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetPhotographersProfiles",
                    new
                    {
                        pageNumber = photographersProfilesResourceParameters.PageNumber,
                        pageSize = photographersProfilesResourceParameters.PageSize
                    });
            }
        }
    }
}
