using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.Services;
using System;
using System.Collections.Generic;
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

        [HttpGet("{piercingId}")]
        public async Task<ActionResult<PunctureDto>> GetPiercing(int piercingId)
        {
            var piercing = await _portalRepository.GetPiercing(piercingId);

            if (piercing == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PunctureDto>(piercing));
        }
    }
}
