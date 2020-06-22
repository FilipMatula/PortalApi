using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/modelphoto")]
    public class ModelPhotoController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ModelPhotoController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpGet("{modelPhotoId}", Name = "GetModelPhoto")]
        public async Task<ActionResult<ModelPhotoDto>> GetModelPhoto(int modelPhotoId)
        {
            var modelPhoto = await _portalRepository.GetModelPhoto(modelPhotoId);

            if (modelPhoto == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ModelPhotoDto>(modelPhoto));
        }

        [HttpPost]
        public async Task<ActionResult> CreateModelPhoto([FromBody] ModelPhotoForCreationDto modelPhoto)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (!await _portalRepository.IsUserModel(currentUserID))
            {
                return Forbid();
            }

            if (!Enum.IsDefined(typeof(ModelingStyle), modelPhoto.ModelingStyle))
            {
                ModelState.AddModelError(
                    "ModelingStyle",
                    "This modeling style does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var modelPhotoEntity = _mapper.Map<Entities.ModelPhoto>(modelPhoto);

            modelPhotoEntity.UserId = currentUserID;

            _portalRepository.AddModelPhoto(modelPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetModelPhoto(modelPhotoEntity.Id);

            return CreatedAtRoute("GetModelPhoto",
                new { modelPhotoId = modelPhotoEntity.Id },
                _mapper.Map<ModelPhotoDto>(modelPhotoEntity));
        }

        [HttpDelete("{modelPhotoId}")]
        public async Task<ActionResult> DeletePiercing(int modelPhotoId)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (!await _portalRepository.IsUserModel(currentUserID))
            {
                return Forbid();
            }

            if (!await _portalRepository.ModelPhotoExists(modelPhotoId))
            {
                return NotFound();
            }

            var modelPhotoEntity = await _portalRepository.GetModelPhoto(modelPhotoId);

            if (currentUserID != modelPhotoEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteModelPhoto(modelPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
