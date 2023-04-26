using System;
using System.Security.Cryptography.X509Certificates;

namespace Account
{
    /*
    public class balerror:Exception
    {
        public balerror(string msg) : base(msg) { }
    }*/
    public class Account
    {
        private int id;
        private string accountType;
        private double balance;

        public int ID
        { get { return id; } }
        public string AccountType
        { get { return accountType; } }
        public double Balance
        { get { return balance; } }
        public double newBalance,bal;
        public Account(int id,string accountType,double balance)
        {
            this.id = id;
            this.accountType = accountType;
            this.balance = balance;
        }
        public Account(){}
        public bool withdraw(double balance)
        {
            bal = this.balance;
            if (this.balance > balance)
            {

                this.balance -= balance;
                newBalance = this.balance;
                return true;
            }
            else
            {
                //throw new balerror("Error : The withdrawel balence should be greater than the account balance");
               Console.WriteLine("Insufficient balence !!!!");
                return false;
            }
        }

        public void getDetails()
        {
            Console.Write("Enter account ID : ");
            this.id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter account type : ");
            this.accountType=Console.ReadLine();
            Console.Write("Enter the account balance : ");
            this.balance=Convert.ToDouble(Console.ReadLine());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc=new Account();
            acc.getDetails();
            Console.Write("Enter the amount to withdraw : ");
            double wit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------OUTPUT--------------------");
            Console.WriteLine("Account ID is : "+acc.ID);
            Console.WriteLine("Account type is : "+acc.AccountType);
            if(acc.withdraw(wit))
            {
                Console.WriteLine("Balance after withdraw is : " + acc.newBalance);
            }
            else
            {
                Console.WriteLine("Balance is : " + acc.bal);
            }
        }
    }
}