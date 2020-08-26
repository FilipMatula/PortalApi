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
        /// <summary>
        /// Get and Map Model to Entity
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("{modelId}", Name ="GetModel")]
        public async Task<ActionResult<ModelDto>> GetModel(int modelId)
        {
            var model = await _portalRepository.GetModelAsync(modelId);

            if (model == null)
                return NotFound();

            return Ok(_mapper.Map<ModelDto>(model));
        }
        /// <summary>
        /// Add Model Account to User prfile
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddModelAccountToUser([FromBody] ModelForCreationDto modelAccount)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (await _portalRepository.IsUserPiercerAsync(currentUserID))
            {
                return BadRequest("Użytkownik jest już Modelem");
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
        /// <summary>
        /// Delete Model Account
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{modelAccountId}")]
        public async Task<ActionResult> DeletePiercerAccount(int modelAccountId)
        {
            var currentUserID = int.Parse(User.Identity.Name);

            if (!await _portalRepository.IsUserModelAsync(currentUserID))
            {
                return Forbid();
            }

            if (!await _portalRepository.ModelAccountExistsAsync(modelAccountId))
            {
                return NotFound();
            }

            var modelAccountEntity = await _portalRepository.GetModelAsync(modelAccountId);

            if (currentUserID != modelAccountEntity.UserId)
            {
                return Forbid();
            }

            _portalRepository.DeleteModelAccount(modelAccountEntity);
            await _portalRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
