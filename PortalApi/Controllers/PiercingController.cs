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
    [Route("api/piercing")]
    public class PiercingController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public PiercingController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{piercingId}", Name = "GetPiercing")]
        public async Task<ActionResult<PiercingDto>> GetPiercing(int piercingId)
        {
            var piercing = await _portalRepository.GetPiercing(piercingId);

            if (piercing == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PiercingDto>(piercing));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePiercing([FromBody] PiercingForCreationDto piercing)
        {
            if (! await _portalRepository.UserExists(piercing.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
            }

            if (! await _portalRepository.IsUserPiercer(piercing.UserId.GetValueOrDefault()))
            {
                return Forbid();
            }

            if (!Enum.IsDefined(typeof(Puncture), piercing.Puncture))
            {
                ModelState.AddModelError(
                    "Puncture",
                    "This puncture does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piercingEntity = _mapper.Map<Entities.Piercing>(piercing);

            _portalRepository.AddPiercing(piercingEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetPiercing(piercingEntity.Id);

            return CreatedAtRoute("GetPiercing",
                new { piercingId = piercingEntity.Id },
                _mapper.Map<PiercingDto>(piercingEntity));
        }

        [HttpDelete("{piercingId}")]
        public async Task<IActionResult> DeletePiercing([Required]int userId, int piercingId)
        {
            if (!await _portalRepository.UserExists(userId))
            {
                return BadRequest("User with such id does not exist");
            }

            if (!await _portalRepository.IsUserPiercer(userId))
            {
                return Forbid();
            }

            if (! await _portalRepository.PiercingExists(piercingId))
            {
                return NotFound();
            }

            var piercingEntity = await _portalRepository.GetPiercing(piercingId);
            if (piercingEntity == null)
            {
                return NotFound();
            }

            _portalRepository.DeletePiercing(piercingEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }

    }
}
