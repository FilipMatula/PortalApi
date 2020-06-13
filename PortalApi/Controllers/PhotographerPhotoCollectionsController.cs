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
    [Route("api/photographersphotos")]
    public class PhotographerPhotoCollections : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public PhotographerPhotoCollections(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<PhotographerPhotoThumbnailDto>>> GetPhotographersPhotosThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var photographerPhotos = await _portalRepository.GetPhotographersPhotos(amount);
            return Ok(_mapper.Map<IEnumerable<PhotographerPhotoThumbnailDto>>(photographerPhotos));
        }

        [HttpGet(Name = "GetPhotographers")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PhotographerPhotoThumbnailDto>>> GetPhotographerPhotos(
            [FromQuery] PhotographersPhotosResourceParameters photographersPhotosResourceParameters)
        {
            if (!_resourceValidator.ValidPhotographersPhotosParameters(photographersPhotosResourceParameters))
            {
                return BadRequest();
            }

            var photographerPhotos = await _portalRepository.GetPhotographersPhotos(photographersPhotosResourceParameters);

            var previousPageLink = photographerPhotos.HasPrevious ?
               CreatePhotographersPhotosResourceUri(photographersPhotosResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = photographerPhotos.HasNext ?
                CreatePhotographersPhotosResourceUri(photographersPhotosResourceParameters,
                ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = photographerPhotos.TotalCount,
                pageSize = photographerPhotos.PageSize,
                currentPage = photographerPhotos.CurrentPage,
                totalPages = photographerPhotos.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<PhotographerPhotoThumbnailDto>>(photographerPhotos));
        }
        private string CreatePhotographersPhotosResourceUri(
           PhotographersPhotosResourceParameters photographersPhotosResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetPhotographers",
                      new
                      {
                          pageNumber = photographersPhotosResourceParameters.PageNumber - 1,
                          pageSize = photographersPhotosResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetPhotographers",
                      new
                      {
                          pageNumber = photographersPhotosResourceParameters.PageNumber + 1,
                          pageSize = photographersPhotosResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetPhotographers",
                    new
                    {
                        pageNumber = photographersPhotosResourceParameters.PageNumber,
                        pageSize = photographersPhotosResourceParameters.PageSize
                    });
            }
        }

    }
}
