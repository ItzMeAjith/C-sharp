using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanini_Workspace.Models;

namespace Kanini_Workspace.Repository.AuthenticationTable
{
    public class AuthenticationTableDerived:IAuthenticationTable
    {
        private readonly KaniniWorkspaceContext _context;

        public AuthenticationTableDerived(KaniniWorkspaceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthTbl>>> GetAuthTbls()
        {
            return await _context.AuthTbls.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthTbl>> GetAuthTbl(int id)
        {
            var authTbl = await _context.AuthTbls.FindAsync(id);
            return authTbl;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthTbl(int id, AuthTbl authTbl)
        {
            _context.Entry(authTbl).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return await authTbl;

    }
}
