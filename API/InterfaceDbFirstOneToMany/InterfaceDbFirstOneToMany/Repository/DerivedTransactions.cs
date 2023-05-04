using InterfaceDbFirstOneToMany.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InterfaceDbFirstOneToMany.Repository
{
    public class DerivedTransactions :ITransactions
    {
        private readonly BankContext ctx;

        public DerivedTransactions(BankContext _ctx)
        {
            ctx = _ctx;
        }

        //Delete
        public string Delete(int id)
        {
            Transaction? acc = ctx.Transactions.Find(id);
            ctx.Transactions.Remove(acc);
            ctx.SaveChanges();
            return "Transaction deleted successfully!!!";
        }

        //Get
        public IEnumerable<Transaction> Get()
        {
            return ctx.Transactions.Include(x => x.AccountNoNavigation).ToList();
        }

        //Getby ID
        public Transaction GetBYID(int id)
        {
            return ctx.Transactions.Include(x=>x.AccountNoNavigation).FirstOrDefault(x => x.TransId == id);
        }

        //Post
        public string Post(Transaction tr)
        {
            ctx.Transactions.Add(tr);
            AccountInfo acc = ctx.AccountInfos.Find(tr.AccountNoNavigation.AccountNo);
            tr.AccountNoNavigation = acc;
            ctx.SaveChanges();
            return "Transaction added Successfully !!!";
        }

        //Put
        public string Put(Transaction tr)
        {
            ctx.Entry(tr).State = EntityState.Modified;
            ctx.SaveChanges();
            return "Transaction updated successfully!!!";
        }
    }
}
