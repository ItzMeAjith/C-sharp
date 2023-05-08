using InterfaceDbFirstOneToMany.Models;
using InterfaceDbFirstOneToMany.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceDbFirstOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountInfoController : ControllerBase
    {
        private readonly IAccountInfo AccInfo;
        public AccountInfoController(IAccountInfo acc)
        {
            AccInfo= acc;
        }

        //GET
        [HttpGet]
        public IEnumerable<AccountInfo>Get()
        {
            return AccInfo.Get();
        }

        //Get by ID
        [HttpGet("{id}")]
        public AccountInfo GetbyID(int id)
        {
            return AccInfo.GetBYID(id);
        }

        //Post
        [HttpPost]
        public string Post(AccountInfo acc)
        {
            AccInfo.Post(acc);
            return "Account Added Successfully";
        }

        //PUT
        [HttpPut]
        public string Put(AccountInfo acc)
        {
            AccInfo.Put(acc);
            return "Updated Successfully!!!";
        }

        //Delete
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            AccInfo.Delete(id);
            return "Deleted Successfully!!!";
        }

        //Count

    }
}
