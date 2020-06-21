using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/article")]
    public class ArticleController : ControllerBase
    {

        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ArticleController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet("{articleId}", Name= "GetArticle")]
        public async Task<ActionResult<ArticleDto>> GetArticle(int articleId)
        {
            var article = await _portalRepository.GetArticle(articleId);

            if(article == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ArticleDto>(article));
        }

        [HttpPost]
        public async Task<ActionResult> CreateArticle([FromBody] ArticleForCreationDto article)
        {
            if (!await _portalRepository.UserExists(article.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
            }

            if (!await _portalRepository.ArticleSubcategoryExist(article.ArticleSubcategoryId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "ArticleSubcategoryId",
                    "Subcategory with such id does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var articleSubcategoryEntity = await _portalRepository.GetArticleSubcategory(article.ArticleSubcategoryId.GetValueOrDefault());
            var articleCategoryEntity = articleSubcategoryEntity.ArticleCategory;

            switch (articleCategoryEntity.ArticleType)
            {
                case ArticleType.Tattoo:
                    if (! await _portalRepository.IsUserTattooer(article.UserId.GetValueOrDefault()))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Piercing:
                    if (!await _portalRepository.IsUserPiercer(article.UserId.GetValueOrDefault()))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Photography:
                    if (!await _portalRepository.IsUserPhotographer(article.UserId.GetValueOrDefault()))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Modeling:
                    if (!await _portalRepository.IsUserModel(article.UserId.GetValueOrDefault()))
                    {
                        return Forbid();
                    }
                    break;
            }

            var articleEntity = _mapper.Map<Entities.Article>(article);

            _portalRepository.AddArticle(articleEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetArticle(articleEntity.Id);

            return CreatedAtRoute("GetArticle",
                new { articleId = articleEntity.Id },
                _mapper.Map<ArticleDto>(articleEntity));
        }

        [HttpDelete("{articleId}")]
        public async Task<ActionResult> DeleteArticle([Required]int userId, int articleId)
        {
            if (!await _portalRepository.UserExists(userId))
            {
                return BadRequest("User with such id does not exist");
            }

            if (!await _portalRepository.ArticleExists(articleId))
            {
                return NotFound();
            }

            var articleEntity = await _portalRepository.GetArticle(articleId);

            var articleSubcategoryEntity = await _portalRepository.GetArticleSubcategory(articleEntity.ArticleSubcategoryId);
            var articleCategoryEntity = articleSubcategoryEntity.ArticleCategory;

            switch (articleCategoryEntity.ArticleType)
            {
                case ArticleType.Tattoo:
                    if (!await _portalRepository.IsUserTattooer(userId))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Piercing:
                    if (!await _portalRepository.IsUserPiercer(userId))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Photography:
                    if (!await _portalRepository.IsUserPhotographer(userId))
                    {
                        return Forbid();
                    }
                    break;
                case ArticleType.Modeling:
                    if (!await _portalRepository.IsUserModel(userId))
                    {
                        return Forbid();
                    }
                    break;
            }

            if (userId != articleEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteArticle(articleEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }

}
