using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API_MenuController : ControllerBase
    {
        private readonly API_MenuDbContext _context;

        public API_MenuController(API_MenuDbContext context)
        {
            _context = context;
        }

        // GET: api/API_Menu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<API_Menu>>> GetMenus()
        {
          if (_context.Menus == null)
          {
              return NotFound();
          }
            return await _context.Menus.ToListAsync();
        }

        // GET: api/API_Menu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<API_Menu>> GetAPI_Menu(int id)
        {
          if (_context.Menus == null)
          {
              return NotFound();
          }
            var aPI_Menu = await _context.Menus.FindAsync(id);

            if (aPI_Menu == null)
            {
                return NotFound();
            }

            return aPI_Menu;
        }

        // PUT: api/API_Menu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAPI_Menu(int id, API_Menu aPI_Menu)
        {
            if (id != aPI_Menu.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(aPI_Menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!API_MenuExists(id))
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

        // POST: api/API_Menu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<API_Menu>> PostAPI_Menu(API_Menu aPI_Menu)
        {
          if (_context.Menus == null)
          {
              return Problem("Entity set 'API_MenuDbContext.Menus'  is null.");
          }
            _context.Menus.Add(aPI_Menu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAPI_Menu", new { id = aPI_Menu.ItemId }, aPI_Menu);
        }

        // DELETE: api/API_Menu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAPI_Menu(int id)
        {
            if (_context.Menus == null)
            {
                return NotFound();
            }
            var aPI_Menu = await _context.Menus.FindAsync(id);
            if (aPI_Menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(aPI_Menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool API_MenuExists(int id)
        {
            return (_context.Menus?.Any(e => e.ItemId == id)).GetValueOrDefault();
        }
    }
}
