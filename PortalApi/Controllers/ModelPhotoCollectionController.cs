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
    [Route("api/modelsphotos")]
    public class ModelPhotoCollectionController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public ModelPhotoCollectionController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<ModelPhotoThumbnailDto>>> GetModelsPhotosThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var modelsPhotos = await _portalRepository.GetModelsPhotos(amount);
            return Ok(_mapper.Map<IEnumerable<ModelPhotoThumbnailDto>>(modelsPhotos));
        }

        [HttpGet(Name = "GetModels")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<ModelPhotoThumbnailDto>>> GetModelsPhotos(
            [FromQuery] ModelsPhotosResourceParameters modelsPhotosResourceParameters)
        {
            if (!_resourceValidator.ValidModelsPhotosParameters(modelsPhotosResourceParameters))
            {
                return BadRequest();
            }

            var modelsPhotos = await _portalRepository.GetModelsPhotos(modelsPhotosResourceParameters);

            var previousPageLink = modelsPhotos.HasPrevious ?
               CreateModelsPhotosResourceUri(modelsPhotosResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = modelsPhotos.HasNext ?
                CreateModelsPhotosResourceUri(modelsPhotosResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = modelsPhotos.TotalCount,
                pageSize = modelsPhotos.PageSize,
                currentPage = modelsPhotos.CurrentPage,
                totalPages = modelsPhotos.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<ModelPhotoThumbnailDto>>(modelsPhotos));
        }

        protected string CreateModelsPhotosResourceUri(
           ModelsPhotosResourceParameters modelsPhotosResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetModels",
                      new
                      {
                          pageNumber = modelsPhotosResourceParameters.PageNumber - 1,
                          pageSize = modelsPhotosResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetModels",
                      new
                      {
                          pageNumber = modelsPhotosResourceParameters.PageNumber + 1,
                          pageSize = modelsPhotosResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetModels",
                    new
                    {
                        pageNumber = modelsPhotosResourceParameters.PageNumber,
                        pageSize = modelsPhotosResourceParameters.PageSize
                    });
            }
        }
    }
}
