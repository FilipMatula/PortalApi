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
    [Route("api/design")]
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

        [HttpGet("{designId}")]
        public async Task<ActionResult<AvailableDesignDto>> GetDesign(int designId)
        {
            var design = await _portalRepository.GetDesign(designId);

            if (design == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AvailableDesignDto>(design));
        }
    }
}
