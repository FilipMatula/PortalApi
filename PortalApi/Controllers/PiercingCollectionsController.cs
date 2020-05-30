using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Helpers;
using PortalApi.Models;
using PortalApi.ResourceParameters;
using PortalApi.Services;
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

        public PiercingCollectionsController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("thumbs")]
        public async Task<ActionResult<IEnumerable<PiercingThumbNailDto>>> GetPiercingsThumbnails(int amount = 0)
        {
            var articles = await _portalRepository.GetPiercings(amount);
            return Ok(_mapper.Map<IEnumerable<PiercingThumbNailDto>>(articles));
        }

        [HttpGet(Name = "GetPiercings")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<PiercingThumbNailDto>>> GetArticlesByCategory(
            [FromQuery] PiercingsResourceParameters piercingsResourceParameters)
        {
            var articles = await _portalRepository.GetPiercings(piercingsResourceParameters);

            var previousPageLink = articles.HasPrevious ?
               CreatePiercingsResourceUri(piercingsResourceParameters,
               ResourceUriType.PreviousPage) : null;

            var nextPageLink = articles.HasNext ?
                CreatePiercingsResourceUri(piercingsResourceParameters,
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

            return Ok(_mapper.Map<IEnumerable<PiercingThumbNailDto>>(articles));
        }

        public string CreatePiercingsResourceUri(
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
