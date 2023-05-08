using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyWebAPI.Models;

namespace OneToManyWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuForAPIsController : ControllerBase
    {
        private readonly MenuForAPIContext _context;

        public MenuForAPIsController(MenuForAPIContext context)
        {
            _context = context;
        }

        // GET: api/MenuForAPIs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuForAPI>>> GetMenuFors()
        {
          if (_context.MenuFors == null)
          {
              return NotFound();
          }
            return await _context.MenuFors.Include(x=>x.Mtype).ToListAsync();
        }

        // GET: api/MenuForAPIs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuForAPI>> GetMenuForAPI(int id)
        {
          if (_context.MenuFors == null)
          {
              return NotFound();
          }
            var menuForAPI = await _context.MenuFors.FindAsync(id);

            if (menuForAPI == null)
            {
                return NotFound();
            }

            return menuForAPI;
        }

        // PUT: api/MenuForAPIs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuForAPI(int id, MenuForAPI menuForAPI)
        {
            if (id != menuForAPI.ItemID)
            {
                return BadRequest();
            }

            _context.Entry(menuForAPI).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuForAPIExists(id))
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

        // POST: api/MenuForAPIs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MenuForAPI>> PostMenuForAPI(MenuForAPI menuForAPI)
        {
          if (_context.MenuFors == null)
          {
              return Problem("Entity set 'MenuForAPIContext.MenuFors'  is null.");
          }
            MenuTypeAPI mt = await _context.MenuTypes.FindAsync(menuForAPI.Mtype.TypeID);
            menuForAPI.Mtype= mt;
            _context.MenuFors.Add(menuForAPI);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuForAPI", new { id = menuForAPI.ItemID }, menuForAPI);
        }

        // DELETE: api/MenuForAPIs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuForAPI(int id)
        {
            if (_context.MenuFors == null)
            {
                return NotFound();
            }
            var menuForAPI = await _context.MenuFors.FindAsync(id);
            if (menuForAPI == null)
            {
                return NotFound();
            }

            _context.MenuFors.Remove(menuForAPI);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuForAPIExists(int id)
        {
            return (_context.MenuFors?.Any(e => e.ItemID == id)).GetValueOrDefault();
        }
    }
}
