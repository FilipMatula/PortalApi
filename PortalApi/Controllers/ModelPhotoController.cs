using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
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
        public async Task<IActionResult> CreateModelPhoto([FromBody] ModelPhotoForCreationDto modelPhoto)
        {
            if (!await _portalRepository.UserExists(modelPhoto.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
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

            _portalRepository.AddModelPhoto(modelPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetModelPhoto(modelPhotoEntity.Id);

            return CreatedAtRoute("GetModelPhoto",
                new { modelPhotoId = modelPhotoEntity.Id },
                _mapper.Map<ModelPhotoDto>(modelPhotoEntity));
        }

        [HttpDelete("{modelPhotoId}")]
        public async Task<IActionResult> DeletePiercing(int modelPhotoId)
        {
            if (!await _portalRepository.ModelPhotoExists(modelPhotoId))
            {
                return NotFound();
            }

            var pmodelPhotoEntity = await _portalRepository.GetModelPhoto(modelPhotoId);
            if (pmodelPhotoEntity == null)
            {
                return NotFound();
            }

            _portalRepository.DeleteModelPhoto(pmodelPhotoEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
