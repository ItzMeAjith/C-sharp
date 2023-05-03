using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MTControllerDbFirstOneToMany.Models;

namespace MTControllerDbFirstOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountInfoController : ControllerBase
    {
        public readonly BankContext ctx;
        public AccountInfoController(BankContext _ctx)
        {
            ctx= _ctx;
        }
        //GET
        [HttpGet]

        public async Task<ActionResult<IEnumerable<AccountInfo>>> Get()
        {
            return await ctx.AccountInfos.Include(x=>x.Transactions).ToListAsync();
        }

        //GET By ID
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountInfo>> GetByID(int id)
        {
            AccountInfo ac=await ctx.AccountInfos.Include(x=>x.Transactions).FirstOrDefaultAsync(x=>x.AccountNo == id);
            return ac;
        }

        //POST
        [HttpPost]
        public async Task<ActionResult<string>> Put(AccountInfo acc)
        {
            await ctx.AccountInfos.AddAsync(acc);
            await ctx.SaveChangesAsync();
            return "New Accountant added successfully";
        }

        //PUT
        [HttpPut]
        public async Task<ActionResult<string>> Update(AccountInfo acc)
        {
            ctx.Entry(acc).State=EntityState.Modified;
            await ctx.SaveChangesAsync();
            return "Details Updated Successfully!!!";
        }
        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            AccountInfo acc=await ctx.AccountInfos.FindAsync(id);
            ctx.Remove(acc);
            await ctx.SaveChangesAsync();
            return "Deleted Successfully!!!";
        }
    }
}
