using InterfaceDbFirstOneToMany.Models;

namespace InterfaceDbFirstOneToMany.Repository
{
    public interface ITransactions
    {
        //Get
        public IEnumerable<Transaction> Get();

        //Get By ID
        public Transaction GetBYID(int id);

        //POST
        public string Post(Transaction tr);

        //PUT
        public string Put(Transaction tr);

        //Delete
        public string Delete(int id);

        //count
        public int Count(int acno);
    }
}
