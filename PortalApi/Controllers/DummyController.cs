using Microsoft.AspNetCore.Mvc;
using PortalApi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private readonly ArtistInfoContext _atx;

        public DummyController(ArtistInfoContext atx)
        {
            _atx = atx ?? throw new ArgumentOutOfRangeException(nameof(atx));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }

    }
}
