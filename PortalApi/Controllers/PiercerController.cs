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

        [HttpPost]
        public async Task<ActionResult> AddPiercerAccountToUser ([FromBody] PiercerForCreationDto piercerAccount)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

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

    }
}
