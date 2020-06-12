using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalApi.ProfilesProperties;
using PortalApi.Models;
using PortalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/filteroptions")]
    public class FilterOptionsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public FilterOptionsController(IMapper mapper)
        {
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("colors")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetColors()
        {
            var options = ((Color[])Enum.GetValues(typeof(Color))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("genders")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetGenders()
        {
            var options = ((Gender[])Enum.GetValues(typeof(Gender))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("punctures")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetPuncture()
        {
            var options = ((Puncture[])Enum.GetValues(typeof(Puncture))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("styles")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetStyles()
        {
            var options = ((TattooStyle[])Enum.GetValues(typeof(TattooStyle))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("techniques")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetTechniques()
        {
            var options = ((Technique[])Enum.GetValues(typeof(Technique))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("experiences")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetExperiences()
        {
            var options = ((Experience[])Enum.GetValues(typeof(Experience))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }

        [HttpGet("modelingstyles")]
        public ActionResult<IEnumerable<FilterOptionDto>> GetModelingStyles()
        {
            var options = ((ModelingStyle[])Enum.GetValues(typeof(ModelingStyle))).ToDictionary(k => k.ToString(), v => (int)v);
            return Ok(_mapper.Map<IEnumerable<FilterOptionDto>>(options));
        }
    }
}
