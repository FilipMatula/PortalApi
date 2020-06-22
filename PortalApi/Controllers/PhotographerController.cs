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

        [HttpGet("{photographerId}")]
        public async Task<ActionResult<PhotographerDto>> GetPhotogrgapher(int photographerId)
        {
            var photographer = await _portalRepository.GetPhotographerAsync(photographerId);

            if (photographer == null)
                return NotFound();

            return Ok(_mapper.Map<PhotographerDto>(photographer));
        }
    }
}
