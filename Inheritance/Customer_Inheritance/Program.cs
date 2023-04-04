using System;

namespace Customer_Inheritance
{
    public class Customer
    {
        private int CustID;
        private string Custname;
        private string phone;
        private string Address;

        public Customer(int custID, string custname, string phone, string address)
        {
            CustID = custID;
            Custname = custname;
            this.phone = phone;
            Address = address;
        }

        public virtual void display()
        {
            Console.WriteLine("--------------------Customer details------------------");
            Console.WriteLine("Customer ID is : " + CustID);
            Console.WriteLine("Customer Name is : " + Custname);
            Console.WriteLine("Customer phone number  is : " + phone);
            Console.WriteLine("Customer Address is : " + Address);
        }
    }
    public class LoanAccount : Customer
    {
        private int loanAccNo;
        private int loanamount;
        private int loanTenure;



        public LoanAccount(int custID, string custname, string phone, string address, int loanAccNo, int loanamount, int loanTenure):base(custID, custname, phone, address)
        {
            this.loanAccNo = loanAccNo;
            this.loanamount = loanamount;
            this.loanTenure = loanTenure;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("--------------------Loan Account details------------------");
            Console.WriteLine("Loan Account number  is : " + loanAccNo);
            Console.WriteLine("Loan amount is : " + loanamount);
            Console.WriteLine("loan tenure  is : " + loanTenure);
        }
    }
    public class SavingAccount : Customer
    {
        private int AccNo;
        private int amount;
        private string branch;
        private string IFSC;
        public SavingAccount(int custID, string custname, string phone, string address, int accNo, int amount, string branch, string iFSC):base(custID,custname,phone,address)
        {
            AccNo = accNo;
            this.amount = amount;
            this.branch = branch;
            IFSC = iFSC;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("--------------------Savings Account  details------------------");
            Console.WriteLine("Saving Account number is : " + AccNo);
            Console.WriteLine("Account balance amount is : " + amount);
            Console.WriteLine("Bank branch  is : " + branch);
            Console.WriteLine("Bank IFSC code  is : " +IFSC);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Enter customer  details------------------\n");
            Console.Write("Enter customer ID : ");
            int custID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter customer name : ");
            string name = Console.ReadLine();
            Console.Write("Enter customer phone number : ");
            string phone = Console.ReadLine();
            Console.Write("Enter customer address : ");
            string address = Console.ReadLine();
            Console.WriteLine("--------------------CHOICE------------------\n");
            //Console.Write("Enter your account type as (savings or loan) : ");
            // string opt = Console.ReadLine();
            string ch;

            do
            {
                Console.Write("Enter your account type as (savings or loan) : ");
                string opt = Console.ReadLine();
                if (opt == "savings")
                {
                    Console.WriteLine("--------------------Enter saving account  details------------------\n");
                    Console.Write("Enter savings account number : ");
                    int Accno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter savings account balance : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter bank branch name : ");
                    string branch = Console.ReadLine();
                    Console.Write("Enter bank's IFSC code : ");
                    string ifsc = Console.ReadLine();
                    SavingAccount s = new SavingAccount(custID, name, phone, address, Accno, amount, branch, ifsc);
                    s.display();
                }
                else if (opt == "loan")
                {
                    Console.WriteLine("--------------------Enter loan account  details------------------\n");
                    Console.Write("Enter loan account number : ");
                    int loanacc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter loan amount : ");
                    int loanamount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter tenure in years : ");
                    int tenure = Convert.ToInt32(Console.ReadLine());
                    LoanAccount l = new LoanAccount(custID, name, phone, address, loanacc, loanamount, tenure);
                    l.display();
                }
                else
                {
                    Console.WriteLine("Enter valid choice : ");
                }
                Console.Write("Do you want to continue (yes or no) : ");
                ch= Console.ReadLine();

            }while(ch=="yes");
            Console.WriteLine("THANK YOU FOR VISITING OUR BANK ......!");
        }
    }
}
















/*
           if(opt=="savings")
           {
               Console.WriteLine("--------------------Enter saving account  details------------------\n");
               Console.Write("Enter savings account number : ");
               int Accno = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter savings account balance : ");
               int amount = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter bank branch name : ");
               string branch = Console.ReadLine();
               Console.Write("Enter bank's IFSC code : ");
               string ifsc = Console.ReadLine();
               SavingAccount s = new SavingAccount(custID,name,phone,address,Accno,amount,branch,ifsc);
               s.display();
           }
           else if(opt=="loan")
           {
               Console.WriteLine("--------------------Enter loan account  details------------------\n");
               Console.Write("Enter loan account number : ");
               int loanacc = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter loan amount : ");
               int loanamount = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter tenure in years : ");
               int tenure = Convert.ToInt32(Console.ReadLine());
               LoanAccount l=new LoanAccount(custID, name, phone, address, loanacc,loanamount,tenure);
               l.display();
           }
           else
           {
               Console.WriteLine("Enter valid choice : ");
           }*/