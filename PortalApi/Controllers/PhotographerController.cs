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
    [Route("api/photographer")]
    public class PhotographerController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public PhotographerController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{photographerId}", Name = "GetPhotogrgapher")]
        public async Task<ActionResult<PhotographerDto>> GetPhotogrgapher(int photographerId)
        {
            var photographer = await _portalRepository.GetPhotographerAsync(photographerId);

            if (photographer == null)
                return NotFound();

            return Ok(_mapper.Map<PhotographerDto>(photographer));
        }

        [HttpPost]
        public async Task<ActionResult> AddPhotograperAccountToUser([FromBody] PhotographerForCreationDto photographerAccount)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (await _portalRepository.IsUserPhotographerAsync(currentUserID))
            {
                return BadRequest("User is already a photographer");
            }

            if (!Enum.IsDefined(typeof(Experience), photographerAccount.Experience))
            {
                ModelState.AddModelError(
                    "Experience",
                    "This experience level does not exist");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var photographerAccountEntity = _mapper.Map<Entities.Photographer>(photographerAccount);

            photographerAccountEntity.UserId = currentUserID;

            _portalRepository.AddPhotographerAccount(photographerAccountEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetPhotographerAsync(photographerAccountEntity.Id);

            return CreatedAtRoute("GetPhotogrgapher",
                new { photographerId = photographerAccountEntity.Id },
                _mapper.Map<PhotographerDto>(photographerAccountEntity));
        }
    }
}
