using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.Services;
using System;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/model")]
    public class ModelController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ModelController(IPortalRepository portalRepository,
            IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{modelId}")]
        public async Task<ActionResult<ModelDto>> GetModel(int modelId)
        {
            var model = await _portalRepository.GetModel(modelId);

            if (model == null)
                return NotFound();

            return Ok(_mapper.Map<ModelDto>(model));
        }
    }
}
