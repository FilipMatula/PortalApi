using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private readonly DatabaseContext _atx;

        public DummyController(DatabaseContext atx)
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
