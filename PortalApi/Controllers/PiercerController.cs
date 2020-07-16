using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Entities;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/piercer")]
    public class PiercerController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public PiercerController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpGet("{piercerId}", Name = "GetPiercer")]
        public async Task<ActionResult<PiercerDto>> GetPiercer(int piercerId)
        {
            var piercer = await _portalRepository.GetPiercerAsync(piercerId);

            if (piercer == null)
                return NotFound();

            return Ok(_mapper.Map<PiercerDto>(piercer));
        }

        /// <summary>
        /// Add Piercer Account to User
        /// </summary>
        /// <param name="piercerAccount"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddPiercerAccountToUser ([FromBody] PiercerForCreationDto piercerAccount)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (await _portalRepository.IsUserPiercerAsync(currentUserID))
            {
                return BadRequest("User is already a piercer");
            }

            if (!Enum.IsDefined(typeof(Puncture), piercerAccount.Punctures))
            {
                ModelState.AddModelError(
                    "Puncture",
                    "This puncture does not exist");
            }

            if (!Enum.IsDefined(typeof(Experience), piercerAccount.Experience))
            {
                ModelState.AddModelError(
                    "Experience",
                    "This experience level does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var piercerAccountEntity = _mapper.Map<Entities.Piercer>(piercerAccount);

            piercerAccountEntity.UserId = currentUserID;

            _portalRepository.AddPircerAccount(piercerAccountEntity);
            await _portalRepository.SaveChangesAsync();
            
            await _portalRepository.GetPiercerAsync(piercerAccountEntity.Id);

            return CreatedAtRoute("GetPiercer",
                new { piercerId = piercerAccountEntity.Id},
                _mapper.Map<PiercerDto>(piercerAccountEntity));
        }

        /// <summary>
        /// Delete Piercer Account
        /// </summary>
        /// <param name="piercerAccountId"></param>
        /// <returns></returns>
        [HttpDelete("{piercerAccountId}")]
        public async Task<ActionResult> DeletePiercerAccount(int piercerAccountId)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (!await _portalRepository.IsUserPiercerAsync(currentUserID))
            {
                return Forbid();
            }

            if (!await _portalRepository.PiercerAccountExistsAsync(piercerAccountId))
            {
                return NotFound();
            }

            var piercerAccountEntity = await _portalRepository.GetPiercerAsync(piercerAccountId);

            if (currentUserID != piercerAccountEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeletePiercerAccount(piercerAccountEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
