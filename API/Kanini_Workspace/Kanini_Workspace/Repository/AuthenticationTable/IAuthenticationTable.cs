using Kanini_Workspace.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanini_Workspace.Repository.AuthenticationTable
{
    public interface IAuthenticationTable
    {
        public Task<ActionResult<IEnumerable<AuthTbl>>> GetAuthTbls();
        public Task<ActionResult<AuthTbl>> GetAuthTbl(int id);
        public Task<IActionResult> PutAuthTbl(int id, AuthTbl authTbl);
    }
}
