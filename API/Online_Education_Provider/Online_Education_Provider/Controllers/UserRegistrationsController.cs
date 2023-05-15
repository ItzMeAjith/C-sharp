using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Education_Provider.Models;

namespace Online_Education_Provider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationsController : ControllerBase
    {
        private readonly OnlineEducationProviderContext _context;

        public UserRegistrationsController(OnlineEducationProviderContext context)
        {
            _context = context;
        }

        // GET: api/UserRegistrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRegistration>>> GetUserRegistrations()
        {
          if (_context.UserRegistrations == null)
          {
              return NotFound();
          }
            return await _context.UserRegistrations.ToListAsync();
        }

        // GET: api/UserRegistrations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserRegistration>> GetUserRegistration(int id)
        {
          if (_context.UserRegistrations == null)
          {
              return NotFound();
          }
            var userRegistration = await _context.UserRegistrations.FindAsync(id);

            if (userRegistration == null)
            {
                return NotFound();
            }

            return userRegistration;
        }

        // PUT: api/UserRegistrations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRegistration(int id, UserRegistration userRegistration)
        {
            if (id != userRegistration.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userRegistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRegistrationExists(id))
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

        // POST: api/UserRegistrations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserRegistration>> PostUserRegistration(UserRegistration userRegistration)
        {
          if (_context.UserRegistrations == null)
          {
              return Problem("Entity set 'OnlineEducationProviderContext.UserRegistrations'  is null.");
          }
            _context.UserRegistrations.Add(userRegistration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserRegistration", new { id = userRegistration.UserId }, userRegistration);
        }

        // DELETE: api/UserRegistrations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRegistration(int id)
        {
            if (_context.UserRegistrations == null)
            {
                return NotFound();
            }
            var userRegistration = await _context.UserRegistrations.FindAsync(id);
            if (userRegistration == null)
            {
                return NotFound();
            }

            _context.UserRegistrations.Remove(userRegistration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserRegistrationExists(int id)
        {
            return (_context.UserRegistrations?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
