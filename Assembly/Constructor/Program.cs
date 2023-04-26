using classpgm;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee pn = new Employee();
            Console.WriteLine("Enter the PersonID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PersonName:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Income:");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the BonusAmount:");
            int bonus = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-----------------------------Parameterized constructor----------------------------------------");
            Employee em=new Employee (id, name, age, income, bonus);
            em.display();

            Console.WriteLine("-------------------------------Object Initializer----------------------------------------");
            Employee em1=new Employee() { PersonID=id,PName=name,Age=age,Monthlyincome=income,bonus=bonus };
            em1.display();
            //Console.WriteLine("Total amount with bonus:" + pn.total(bonus));
        }
    }
}