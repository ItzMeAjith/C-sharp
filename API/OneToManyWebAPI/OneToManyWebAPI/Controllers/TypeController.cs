using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyWebAPI.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneToManyWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly MenuForAPIContext ctx;
        public TypeController(MenuForAPIContext _ctx)
        {
             ctx= _ctx;
        }



        // GET: api/<TypeController>
        [HttpGet]
        public  async Task<ActionResult< IEnumerable<MenuTypeAPI>>> Get()
        {
            return await ctx.MenuTypes.Include(x=>x.Menus).ToListAsync();
        }

        // GET api/<TypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult< MenuTypeAPI>> GetByID(int id)
        {
           MenuTypeAPI ty= await ctx.MenuTypes.FirstOrDefaultAsync(x => x.TypeID == id);
            return ty;
        }

        // POST api/<TypeController>
        [HttpPost]
        public async Task<ActionResult<string>> PostMenu(MenuTypeAPI mn)
        {
            ctx.MenuTypes.Add(mn);
            await ctx.SaveChangesAsync();
            return Ok(mn);
        }

        // PUT api/<TypeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PUTMenuByID(MenuTypeAPI mn, int id)
        {
            ctx.Entry(mn).State = EntityState.Modified;
            await ctx.SaveChangesAsync();
            return Ok(mn);
        }

        // DELETE api/<TypeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteMenuByID(int id)
        {
            MenuTypeAPI mn = await ctx.MenuTypes.FirstOrDefaultAsync(x => x.TypeID == id);
            ctx.MenuTypes.Remove(mn);
            await ctx.SaveChangesAsync();
            return "Item Deleted successfully";
        }
    }
}
