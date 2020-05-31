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
    public class AvailableDesignPhotoController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public AvailableDesignPhotoController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{designId}")]
        public async Task<ActionResult<AvailableDesignPhotoDto>> GetDesign(int designId)
        {
            var designPhoto = await _portalRepository.GetDesign(designId);
            return Ok(_mapper.Map<AvailableDesignPhotoDto>(designPhoto));
        }
    }
}
