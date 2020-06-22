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
    [Route("api/availabledesign")]
    public class AvailableDesignController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public AvailableDesignController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpGet("{availableDesignId}", Name = "GetAvailableDesign")]
        public async Task<ActionResult<AvailableDesignDto>> GetAvailableDesign(int availableDesignId)
        {
            var availableDesign = await _portalRepository.GetAvailableDesignAsync(availableDesignId);

            if (availableDesign == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AvailableDesignDto>(availableDesign));
        }

        [HttpPost]
        public async Task<ActionResult> CreateAvailableDesign([FromBody] AvailableDesignForCreationDto availableDesign)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (!await _portalRepository.IsUserTattooerAsync(currentUserID))
            {
                return Forbid();
            }

            if (!Enum.IsDefined(typeof(Color), availableDesign.Color))
            {
                ModelState.AddModelError(
                    "Color",
                    "This color does not exist");
            }

            if (!Enum.IsDefined(typeof(TattooStyle), availableDesign.TattooStyle))
            {
                ModelState.AddModelError(
                    "TattooStyle",
                    "This tattoo style does not exist");
            }

            if (!Enum.IsDefined(typeof(Technique), availableDesign.Technique))
            {
                ModelState.AddModelError(
                    "Technique",
                    "This technique does not exist");
            }

            if (availableDesign.Price <= 0)
            {
                ModelState.AddModelError(
                    "Price",
                    "Price must be value above 0");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var availableDesignEntity = _mapper.Map<Entities.AvailableDesign>(availableDesign);

            availableDesignEntity.UserId = currentUserID;

            _portalRepository.AddAvailableDesign(availableDesignEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetAvailableDesignAsync(availableDesignEntity.Id);

            return CreatedAtRoute("GetAvailableDesign",
                new { availableDesignId = availableDesignEntity.Id },
                _mapper.Map<AvailableDesignDto>(availableDesignEntity));
        }

        [HttpDelete("{availableDesignId}")]
        public async Task<ActionResult> DeleteAvailableDesign(int availableDesignId)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (!await _portalRepository.IsUserTattooerAsync(currentUserID))
            {
                return Forbid();
            }

            if (!await _portalRepository.AvailableDesignExistsAsync(availableDesignId))
            {
                return NotFound();
            }

            var availableDesignEntity = await _portalRepository.GetAvailableDesignAsync(availableDesignId);

            if (currentUserID != availableDesignEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteAvailableDesign(availableDesignEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
