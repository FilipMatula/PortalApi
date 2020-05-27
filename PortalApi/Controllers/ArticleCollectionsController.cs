using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Entities;
using PortalApi.Models;
using PortalApi.ResourceParameters;
using PortalApi.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleCollectionsController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ArticleCollectionsController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
     
        [HttpGet("thumbs/{subcategoryId}")]
        public async Task<ActionResult<IEnumerable<ArticleThumbNailDto>>> GetArticlesThumbNailsByCategory(int subcategoryId, int amount=0)
        {
            var articles = await _portalRepository.GetArticlesByCategory(subcategoryId, amount);
            return Ok(_mapper.Map<IEnumerable<ArticleThumbNailDto>>(articles));
        }

        [HttpGet("{subcategoryId}")]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<ArticleOverviewDto>>> GetArticlesByCategory(int subcategoryId, 
            [FromQuery] ArticlesResourceParameters articlesResourceParameters)
        {
            var articles = await _portalRepository.GetArticlesByCategory(subcategoryId, articlesResourceParameters);
            return Ok(_mapper.Map<IEnumerable<ArticleOverviewDto>>(articles));
        }
    }
}

