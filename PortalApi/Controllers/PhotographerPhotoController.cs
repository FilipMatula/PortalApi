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
    [Route("api/photographerphoto")]
    public class PhotographerPhotoController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public PhotographerPhotoController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{photographerPhotoId}", Name = "GetPhotographerPhoto")]
        public async Task<ActionResult<PhotographerPhotoDto>> GetPhotographerPhoto(int photographerPhotoId)
        {
            var photographerPhoto = await _portalRepository.GetPhotographerPhoto(photographerPhotoId);

            if (photographerPhoto == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PhotographerPhotoDto>(photographerPhoto));
        }

        [HttpPost]
        public async Task<ActionResult> CreatePhotographerPhoto([FromBody] PhotographerPhotoForCreationDto photographerPhoto)
        {
            if (!await _portalRepository.UserExists(photographerPhoto.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
            }

            if (!await _portalRepository.IsUserPhotographer(photographerPhoto.UserId.GetValueOrDefault()))
            {
                return Forbid();
            }

            if (!Enum.IsDefined(typeof(ModelingStyle), photographerPhoto.ModelingStyle))
            {
                ModelState.AddModelError(
                    "ModelingStyle",
                    "This modeling style does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var photographerPhotoEntity = _mapper.Map<Entities.PhotographerPhoto>(photographerPhoto);

            _portalRepository.AddPhotographerPhoto(photographerPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetPhotographerPhoto(photographerPhotoEntity.Id);

            return CreatedAtRoute("GetPhotographerPhoto",
                new { photographerPhotoId = photographerPhotoEntity.Id },
                _mapper.Map<PhotographerPhotoDto>(photographerPhotoEntity));
        }

        [HttpDelete("{photographerPhotoId}")]
        public async Task<ActionResult> DeletePhotographerPhoto([Required]int userId, int photographerPhotoId)
        {
            if (!await _portalRepository.UserExists(userId))
            {
                return BadRequest("User with such id does not exist");
            }

            if (!await _portalRepository.IsUserPhotographer(userId))
            {
                return Forbid();
            }

            if (!await _portalRepository.PhotographerPhotoExists(photographerPhotoId))
            {
                return NotFound();
            }

            var photographerPhotoEntity = await _portalRepository.GetPhotographerPhoto(photographerPhotoId);

            if (userId != photographerPhotoEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeletePhotographerPhoto(photographerPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
