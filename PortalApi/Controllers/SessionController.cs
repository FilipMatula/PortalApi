using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalApi.Contexts;
using PortalApi.Entities;

namespace PortalApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/sessions")]
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
        public async Task<IActionResult> GetAllSessions()
        {
            var userId = User.Claims.SingleOrDefault(u => u.Type == "uid")?.Value;
            var sessions = await _context.Sessions.Where(c => c.UserId == userId).ToListAsync();
            return Ok(sessions);
        }

        //[HttpPost("{sessionId}")]
        //public async Task<IActionResult> UpdateSession([FromBody] Session session)
        //{
        //    var savedSession = await _context.Sessions.FirstOrDefaultAsync(x => x.SessionId == session.SessionId);
        //    if (savedSession == null)
        //    {
        //        return NotFound();
        //    }
        //    if (savedSession.UserId != User.Claims.SingleOrDefault(u => u.Type == "uid")?.Value)
        //    {
        //        return Unauthorized();
        //    }
        //    savedSession.Title = session.Title;
        //    savedSession.Abstract = session.Abstract;
        //    await _context.SaveChangesAsync();
        //    return Ok(savedSession);
        //}

        //[HttpDelete("{sessionId}")]
        //public async Task<IActionResult> Delete(int sessionId)
        //{
        //    var session = await _context.Sessions.FirstOrDefaultAsync(sess => sess.SessionId == sessionId);
        //    if (session == null)
        //    {
        //        return NotFound();
        //    }
        //    if (session.UserId != User.Claims.SingleOrDefault(u => u.Type == "uid")?.Value)
        //    {
        //        return Unauthorized();
        //    }
        //    _context.Remove(session);
        //    await _context.SaveChangesAsync();
        //    return Ok();
        //}
    }
}