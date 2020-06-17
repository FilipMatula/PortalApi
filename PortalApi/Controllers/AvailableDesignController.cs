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

        [HttpGet("{availableDesignId}", Name = "GetAvailableDesign")]
        public async Task<ActionResult<AvailableDesignDto>> GetAvailableDesign(int availableDesignId)
        {
            var availableDesign = await _portalRepository.GetAvailableDesign(availableDesignId);

            if (availableDesign == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AvailableDesignDto>(availableDesign));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAvailableDesign([FromBody] AvailableDesignForCreationDto availableDesign)
        {
            if (!await _portalRepository.UserExists(availableDesign.UserId.GetValueOrDefault()))
            {
                ModelState.AddModelError(
                    "UserId",
                    "User with such id does not exist");
            }

            if (!await _portalRepository.IsUserTattooer(availableDesign.UserId.GetValueOrDefault()))
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

            _portalRepository.AddAvailableDesign(availableDesignEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetAvailableDesign(availableDesignEntity.Id);

            return CreatedAtRoute("GetAvailableDesign",
                new { availableDesignId = availableDesignEntity.Id },
                _mapper.Map<AvailableDesignDto>(availableDesignEntity));
        }

        [HttpDelete("{availableDesignId}")]
        public async Task<IActionResult> DeleteAvailableDesign([Required]int userId, int availableDesignId)
        {
            if (!await _portalRepository.UserExists(userId))
            {
                return BadRequest("User with such id does not exist");
            }

            if (!await _portalRepository.IsUserTattooer(userId))
            {
                return Forbid();
            }

            if (!await _portalRepository.AvailableDesignExists(availableDesignId))
            {
                return NotFound();
            }

            var availableDesignEntity = await _portalRepository.GetAvailableDesign(availableDesignId);

            if (userId != availableDesignEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteAvailableDesign(availableDesignEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
