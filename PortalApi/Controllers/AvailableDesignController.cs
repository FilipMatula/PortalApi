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

        [HttpGet("{availableDesignId}")]
        public async Task<ActionResult<AvailableDesignDto>> GetAvailableDesign(int availableDesignId)
        {
            var availableDesign = await _portalRepository.GetAvailableDesign(availableDesignId);

            if (availableDesign == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AvailableDesignDto>(availableDesign));
        }
    }
}
