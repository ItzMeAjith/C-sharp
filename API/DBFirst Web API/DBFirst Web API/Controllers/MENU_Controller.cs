using DBFirst_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MENU_Controller : ControllerBase
    {
        private readonly DbapiContext con;
        public MENU_Controller(DbapiContext _con)
        {
            con = _con;
        }

        //Crud
        //GET
        [HttpGet]
        public async Task<ActionResult< IEnumerable<Menu>>> GetMenus()
        {
            return await con.Menus.ToListAsync();
        }

        //GET by ID
        [HttpGet("{id}")]//Route
        public async Task<ActionResult< Menu>> GetMenuByID(int id)
        {
            Menu mn= await con.Menus.FirstOrDefaultAsync (x => x.ItemId==id);
            return mn;
        }

        //POST
        [HttpPost]
        public async Task<ActionResult<string>> PostMenu(Menu mn)
        {
             con.Menus.Add(mn);
            await con.SaveChangesAsync();
            return Ok(mn);
        }
        //DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteMenuByID(int id)
        {
            Menu mn = await con.Menus.FirstOrDefaultAsync(x => x.ItemId == id);
            con.Menus.Remove(mn);
            await con.SaveChangesAsync();
            return "Item Deleted successfully";
        }
        //PUT
        /*
        [HttpPut("{id}")]
        
        public async Task<ActionResult<string>> PUTMenuByID(Menu mn,int id)
        {
            Menu mnu = await con.Menus.FirstOrDefaultAsync(x => x.ItemId == id);
            mnu.ItemId = mn.ItemId;
            mnu.ItemName= mn.ItemName;
            mnu.ItemPrice= mn.ItemPrice;
            mnu.ItemCount= mn.ItemCount;
            await con.SaveChangesAsync();
            return Ok(mn);
        }*/
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PUTMenuByID(Menu mn, int id)
        {
            con.Entry(mn).State= EntityState.Modified;
            await con.SaveChangesAsync();
            return Ok(mn);
        }
    }
}
