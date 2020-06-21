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
    [Route("api/tattoo")]
    public class TattooController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public TattooController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{tattooId}", Name = "GetTattoo")]
        public async Task<ActionResult<TattooDto>> GetTattoo(int tattooId)
        {
            var tattoo = await _portalRepository.GetTattoo(tattooId);

            if (tattoo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TattooDto>(tattoo));
        }

        [HttpPost]
        public async Task<ActionResult> CreateTattoo([FromBody] TattooForCreationDto tattoo)
        {
            if (!await _portalRepository.UserExists(tattoo.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
            }

            if (!await _portalRepository.IsUserTattooer(tattoo.UserId.GetValueOrDefault()))
            {
                return Forbid();
            }

            if (!Enum.IsDefined(typeof(Color), tattoo.Color))
            {
                ModelState.AddModelError(
                    "Color",
                    "This color does not exist");
            }

            if (!Enum.IsDefined(typeof(TattooStyle), tattoo.TattooStyle))
            {
                ModelState.AddModelError(
                    "TattooStyle",
                    "This tattoo style does not exist");
            }

            if (!Enum.IsDefined(typeof(Technique), tattoo.Technique))
            {
                ModelState.AddModelError(
                    "Technique",
                    "This technique does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tattooEntity = _mapper.Map<Entities.Tattoo>(tattoo);

            _portalRepository.AddTattoo(tattooEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetTattoo(tattooEntity.Id);

            return CreatedAtRoute("GetTattoo",
                new { tattooId = tattooEntity.Id },
                _mapper.Map<TattooDto>(tattooEntity));
        }

        [HttpDelete("{tattooId}")]
        public async Task<ActionResult> DeleteTattoo([Required]int userId, int tattooId)
        {
            if (!await _portalRepository.UserExists(userId))
            {
                return BadRequest("User with such id does not exist");
            }

            if (!await _portalRepository.IsUserTattooer(userId))
            {
                return Forbid();
            }

            if (!await _portalRepository.TattooExists(tattooId))
            {
                return NotFound();
            }

            var tattooEntity = await _portalRepository.GetTattoo(tattooId);

            if (userId != tattooEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteTattoo(tattooEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
