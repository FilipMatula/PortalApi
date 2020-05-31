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
    [Route("api/tattoos")]
    public class TattooCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;
        private readonly IResourceValidator _resourceValidator;

        public TattooCollectionsController(IPortalRepository portalRepository,
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
        public async Task<ActionResult<IEnumerable<TattooThumbnailDto>>> GetTattoosThumbnails(int? amount = null)
        {
            if (amount <= 0)
            {
                return BadRequest();
            }

            var articles = await _portalRepository.GetTattoos(amount);
            return Ok(_mapper.Map<IEnumerable<TattooThumbnailDto>>(articles));
        }

        [HttpGet(Name = "GetTattoos")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<TattooThumbnailDto>>> GetTattoos(
            [FromQuery] TattoosResourceParameters tattoosResourceParameters)
        {
            if (!_resourceValidator.ValidTattoosParameters(tattoosResourceParameters))
            {
                return BadRequest();
            }

            var articles = await _portalRepository.GetTattoos(tattoosResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreateTattoosResourceUri(tattoosResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreateTattoosResourceUri(tattoosResourceParameters,
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

            return Ok(_mapper.Map<IEnumerable<TattooThumbnailDto>>(articles));
        }

        public string CreateTattoosResourceUri(
           TattoosResourceParameters tattoosResourceParameters,
           ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetTattoos",
                      new
                      {
                          pageNumber = tattoosResourceParameters.PageNumber - 1,
                          pageSize = tattoosResourceParameters.PageSize
                      });
                case ResourceUriType.NextPage:
                    return Url.Link("GetTattoos",
                      new
                      {
                          pageNumber = tattoosResourceParameters.PageNumber + 1,
                          pageSize = tattoosResourceParameters.PageSize
                      });

                default:
                    return Url.Link("GetTattoos",
                    new
                    {
                        pageNumber = tattoosResourceParameters.PageNumber,
                        pageSize = tattoosResourceParameters.PageSize
                    });
            }
        }
    }
}
