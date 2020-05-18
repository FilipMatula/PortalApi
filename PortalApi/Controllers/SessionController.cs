using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalApi.Contexts;
using PortalApi.Entities;

namespace PortalApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/session")]
    public class SessionsController : Controller
    {
        private readonly DatabaseContext _context;
        public SessionsController(DatabaseContext context)
        {
            this._context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public async Task<IActionResult> AddSession([FromBody] Session session)
        {
            session.UserId = User.Claims.SingleOrDefault(u => u.Type == "uid")?.Value;
            _context.Add(session);
            await _context.SaveChangesAsync();
            return Created($"api/session/{session.SessionId}", session);
        }

        [HttpGet]
        [Route("api/sessions")]
        public async Task<IActionResult> GetAllSessions()
        {
            var userId = User.Claims.SingleOrDefault(u => u.Type == "uid")?.Value;
            var sessions = _context.Sessions.Where(c => c.UserId == userId).ToListAsync();
            return Ok(sessions);
        }
    }
}