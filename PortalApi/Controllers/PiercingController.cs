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

        [AllowAnonymous]
        [HttpGet("{piercingId}", Name = "GetPiercing")]
        public async Task<ActionResult<PiercingDto>> GetPiercing(int piercingId)
        {
            var piercing = await _portalRepository.GetPiercingAsync(piercingId);

            if (piercing == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PiercingDto>(piercing));
        }

        [HttpPost]
        public async Task<ActionResult> CreatePiercing([FromBody] PiercingForCreationDto piercing)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (! await _portalRepository.IsUserPiercerAsync(currentUserID))
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

            piercingEntity.UserId = currentUserID;

            _portalRepository.AddPiercing(piercingEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetPiercingAsync(piercingEntity.Id);

            return CreatedAtRoute("GetPiercing",
                new { piercingId = piercingEntity.Id },
                _mapper.Map<PiercingDto>(piercingEntity));
        }

        [HttpDelete("{piercingId}")]
        public async Task<ActionResult> DeletePiercing(int piercingId)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (!await _portalRepository.IsUserPiercerAsync(currentUserID))
            {
                return Forbid();
            }

            if (! await _portalRepository.PiercingExistsAsync(piercingId))
            {
                return NotFound();
            }

            var piercingEntity = await _portalRepository.GetPiercingAsync(piercingId);

            if (currentUserID != piercingEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeletePiercing(piercingEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }

    }
}
