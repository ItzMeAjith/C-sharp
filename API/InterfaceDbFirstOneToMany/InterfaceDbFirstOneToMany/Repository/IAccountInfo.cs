using InterfaceDbFirstOneToMany.Models;

namespace InterfaceDbFirstOneToMany.Repository
{
    public interface IAccountInfo
    {
        //Get
        public IEnumerable<AccountInfo> Get();

        //Get By ID
        public AccountInfo GetBYID(int id);

        //POST
        public string Post(AccountInfo acc);

        //PUT
        public string Put(AccountInfo acc);

        //Delete
        public string Delete(int id);
    }
}
