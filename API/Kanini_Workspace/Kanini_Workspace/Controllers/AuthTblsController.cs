using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanini_Workspace.Models;
using Kanini_Workspace.Repository.AuthenticationTable;

namespace Kanini_Workspace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTblsController : ControllerBase
    {
        private readonly IAuthenticationTable ctx;
        private readonly KaniniWorkspaceContext context;
        public AuthTblsController(KaniniWorkspaceContext _context, IAuthenticationTable _ctx)
        {
            context = _context;
            ctx=_ctx;
        }

        // GET: api/AuthTbls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthTbl>>> GetAuthTbls()
        {
          if (context.AuthTbls == null)
          {
              return NotFound();
          }
            return await ctx.GetAuthTbls();
        }

        // GET: api/AuthTbls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthTbl>> GetAuthTbl(int id)
        {
          if (context.AuthTbls == null)
          {
              return NotFound();
          }
            var authTbl = await ctx.GetAuthTbl(id);

            if (authTbl == null)
            {
                return NotFound();
            }

            return authTbl;
        }

        // PUT: api/AuthTbls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthTbl(int id, AuthTbl authTbl)
        {
            if (id != authTbl.AuthId)
            {
                return BadRequest();
            }

            _context.Entry(authTbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthTblExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AuthTbls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AuthTbl>> PostAuthTbl(AuthTbl authTbl)
        {
          if (_context.AuthTbls == null)
          {
              return Problem("Entity set 'KaniniWorkspaceContext.AuthTbls'  is null.");
          }
            _context.AuthTbls.Add(authTbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthTbl", new { id = authTbl.AuthId }, authTbl);
        }

        // DELETE: api/AuthTbls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthTbl(int id)
        {
            if (_context.AuthTbls == null)
            {
                return NotFound();
            }
            var authTbl = await _context.AuthTbls.FindAsync(id);
            if (authTbl == null)
            {
                return NotFound();
            }

            _context.AuthTbls.Remove(authTbl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthTblExists(int id)
        {
            return (_context.AuthTbls?.Any(e => e.AuthId == id)).GetValueOrDefault();
        }
    }
}
