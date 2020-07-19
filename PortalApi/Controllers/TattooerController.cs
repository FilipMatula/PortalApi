using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/tattooer")]
    public class TattooerController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public TattooerController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpGet("{tattooerId}", Name = "GetTattooer")]
        public async Task<ActionResult<TattooerDto>> GetTattooer(int tattooerId)
        {
            var tattooer = await _portalRepository.GetTattooerAsync(tattooerId);

            if (tattooer == null)
                return NotFound();

            return Ok(_mapper.Map<TattooerDto>(tattooer));
        }

        /// <summary>
        /// Add Tattooer Account to User
        /// </summary>
        /// <param name="tattooerAccount"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddTattooerAccountToUser([FromBody] TattooerForCreationDto tattooerAccount)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (await _portalRepository.IsUserTattooerAsync(currentUserID))
            {
                return BadRequest("User is already a tattooer");
            }

            if (!Enum.IsDefined(typeof(TattooStyle), tattooerAccount.TattooStyle))
            {
                ModelState.AddModelError(
                    "TattooStyle",
                    "This TattooStyle does not exist");
            }

            if (!Enum.IsDefined(typeof(Experience), tattooerAccount.Experience))
            {
                ModelState.AddModelError(
                    "Experience",
                    "This experience level does not exist");
            }

            if (!Enum.IsDefined(typeof(Technique), tattooerAccount.Technique))
            {
                ModelState.AddModelError(
                    "Technique",
                    "This technique level does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tattooerAccountEntity = _mapper.Map<Entities.Tattooer>(tattooerAccount);

            tattooerAccountEntity.UserId = currentUserID;

            _portalRepository.AddTattooerAccount(tattooerAccountEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetTattooerAsync(tattooerAccountEntity.Id);

            return CreatedAtRoute("GetTattooer",
                new { tattooerId = tattooerAccountEntity.Id },
                _mapper.Map<TattooerDto>(tattooerAccountEntity));
        }

        /// <summary>
        /// Delete Tattooer Account
        /// </summary>
        /// <param name="tattooerAccountId"></param>
        /// <returns></returns>
        [HttpDelete("{tattooerAccountId}")]
        public async Task<ActionResult> DeleteTattooerAccount(int tattooerAccountId)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (!await _portalRepository.IsUserTattooerAsync(currentUserID))
            {
                return Forbid();
            }

            if (!await _portalRepository.TattooerAccountExistsAsync(tattooerAccountId))
            {
                return NotFound();
            }

            var tattooerAccountEntity = await _portalRepository.GetTattooerAsync(tattooerAccountId);

            if (currentUserID != tattooerAccountEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteTattooerAccount(tattooerAccountEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
