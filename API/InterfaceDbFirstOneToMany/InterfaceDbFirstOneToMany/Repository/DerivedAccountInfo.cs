using InterfaceDbFirstOneToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace InterfaceDbFirstOneToMany.Repository
{
    public class DerivedAccountInfo:IAccountInfo
    {
        private readonly BankContext ctx;

        public DerivedAccountInfo(BankContext _ctx)
        {
            ctx = _ctx;
        }

        

        //Get
        public IEnumerable<AccountInfo> Get()
        {
            return ctx.AccountInfos.Include(x => x.Transactions).ToList();
        }

        //Get by ID
        public AccountInfo GetBYID(int id)
        {
            return ctx.AccountInfos.Include(x => x.Transactions).FirstOrDefault(x => x.AccountNo == id);
        }

        //Post
        public string Post(AccountInfo acc)
        {
            ctx.AccountInfos.Add(acc);
            ctx.SaveChanges();
            return "Accoutant added Successfully !!!";
        }
        //PUT
        public string Put(AccountInfo acc)
        {
            ctx.Entry(acc).State = EntityState.Modified;
            ctx.SaveChanges();
            return "Details updated successfully!!!";
        }

        //Delete
        public string Delete(int id)
        {
            AccountInfo? acc= ctx.AccountInfos.Find(id);
            ctx.AccountInfos.Remove(acc);
            ctx.SaveChanges();
            return "Account deleted successfully!!!";
        }
    }
}
