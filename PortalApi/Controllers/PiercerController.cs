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

        [HttpGet("{piercerId}")]
        public async Task<ActionResult<PiercerDto>> GetPiercer(int piercerId)
        {
            var piercer = await _portalRepository.GetPiercer(piercerId);

            if (piercer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PiercerDto>(piercer));
        }

    }
}
