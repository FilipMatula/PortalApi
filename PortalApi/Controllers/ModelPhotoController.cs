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
    [Route("api/modelphoto")]
    public class ModelPhotoController : ControllerBase
    {
        private readonly IPortalRepository _portalRepository;
        private readonly IMapper _mapper;

        public ModelPhotoController(IPortalRepository portalRepository, IMapper mapper)
        {
            _portalRepository = portalRepository ??
                throw new ArgumentNullException(nameof(portalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{modelPhotoId}")]
        public async Task<ActionResult<ModelPhotoDto>> GetModelPhoto(int modelPhotoId)
        {
            var modelPhoto = await _portalRepository.GetModelPhoto(modelPhotoId);

            if (modelPhoto == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ModelPhotoDto>(modelPhoto));
        }
    }
}
