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
    [Route("api/Tattooer")]
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

        [HttpGet("{tattooerId}")]
        public async Task<ActionResult<TattooerDto>> GetTattooer(int tattooerId)
        {
            var tattooer = await _portalRepository.GetTattooer(tattooerId);

            if (tattooer == null)
                return NotFound();

            return Ok(_mapper.Map<TattooerDto>(tattooer));
        }
    }
}
