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
    [Route("api/models")]
    public class ModelCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public ModelCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<ModelThumbnailDto>>> GetModelsThumbnails(int? amount = 30)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var models = await _portalRepository.GetModelsThumbnailsAsync(amount);
            return Ok(_mapper.Map<IEnumerable<ModelThumbnailDto>>(models));
        }


        [HttpGet(Name = "GetModelsProfiles")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<ModelThumbnailDto>>> GetModelsProfiles(
            [FromQuery] ModelsProfilesResourceParameters modelsProfilesResourceParameters)
        {
            if (!_resourceValidator.ValidModelsProfilesParameters(modelsProfilesResourceParameters))
            {
                return BadRequest();
            }

            var modelsProfiles = await _portalRepository.GetModelsProfilesAsync(modelsProfilesResourceParameters);

            var previousPageLink = modelsProfiles.HasPrevious ?
               CreateModelsPhotosResourceUri(modelsProfilesResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = modelsProfiles.HasNext ?
                CreateModelsPhotosResourceUri(modelsProfilesResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = modelsProfiles.TotalCount,
                pageSize = modelsProfiles.PageSize,
                currentPage = modelsProfiles.CurrentPage,
                totalPages = modelsProfiles.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<ModelThumbnailDto>>(modelsProfiles));
        }

        private string CreateModelsPhotosResourceUri(
           ModelsProfilesResourceParameters modelsProfilesResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetModelsProfiles",
                      new
                      {
                          pageNumber = modelsProfilesResourceParameters.PageNumber - 1,
                          pageSize = modelsProfilesResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetModelsProfiles",
                      new
                      {
                          pageNumber = modelsProfilesResourceParameters.PageNumber + 1,
                          pageSize = modelsProfilesResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetModelsProfiles",
                    new
                    {
                        pageNumber = modelsProfilesResourceParameters.PageNumber,
                        pageSize = modelsProfilesResourceParameters.PageSize
                    });
            }
        }


    }
}
