using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Models;
using PortalApi.ProfilesProperties;
using PortalApi.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Authorize]
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

        [AllowAnonymous]
        [HttpGet("{modelId}", Name ="GetModel")]
        public async Task<ActionResult<ModelDto>> GetModel(int modelId)
        {
            var model = await _portalRepository.GetModelAsync(modelId);

            if (model == null)
                return NotFound();

            return Ok(_mapper.Map<ModelDto>(model));
        }

        [HttpPost]
        public async Task<ActionResult> AddModelAccountToUser([FromBody] ModelForCreationDto modelAccount)
        {
            var currentUserID = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (await _portalRepository.IsUserPiercerAsync(currentUserID))
            {
                return BadRequest("User is already a model");
            }

            // TODO check correctness of BodyDecorations
            //if (!Enum.IsDefined(typeof(BodyDecorations), modelAccount.BodyDecorations))
            //{
            //    ModelState.AddModelError(
            //        "BodyDecoration",
            //        "This BodyDecoration does not exist");
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var modelAccountEntity = _mapper.Map<Entities.Model>(modelAccount);

            modelAccountEntity.UserId = currentUserID;

            _portalRepository.AddModelAccount(modelAccountEntity);
            await _portalRepository.SaveChangesAsync();

            await _portalRepository.GetModelAsync(modelAccountEntity.Id);

            return CreatedAtRoute("GetModel",
                new { modelId = modelAccountEntity.Id },
                _mapper.Map<ModelDto>(modelAccountEntity));
        }

    }
}
