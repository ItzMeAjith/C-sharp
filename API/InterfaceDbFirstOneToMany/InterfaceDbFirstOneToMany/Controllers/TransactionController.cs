using InterfaceDbFirstOneToMany.Models;
using InterfaceDbFirstOneToMany.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceDbFirstOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactions AccInfo;
        public TransactionController (ITransactions acc)
        {
            AccInfo = acc;
        }

        //GET
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return AccInfo.Get();
        }

        //Get by ID
       /* [HttpGet("{id}")]
        public Transaction GetbyID(int id)
        {
            return AccInfo.GetBYID(id);
        } */

        //Post
        [HttpPost]
        public string Post(Transaction acc)
        {
            AccInfo.Post(acc);
            return "Transaction Added Successfully";
        }

        //PUT
        [HttpPut]
        public string Put(Transaction acc)
        {
            AccInfo.Put(acc);
            return "Transaction Updated Successfully!!!";
        }

        //Delete
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            AccInfo.Delete(id);
            return "Transaction Deleted Successfully!!!";
        }

        //count
        [HttpGet("{id}")]
        public string Count(int id)
        {
            return "The total transactions made by account no "+id+" is "+AccInfo.Count(id);
        }
    }
}
