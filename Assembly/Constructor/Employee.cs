using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace classpgm
{
    public class Employee
    {
        public int PersonID;
        public string? PName;
        public int Age;
        public int Monthlyincome;
        public int bonus;
        public Employee(int id, string name, int age, int income, int bnus)
        {
            PersonID = id;
            PName = name;
            Age = age;
            Monthlyincome = income;
            bonus = bnus;
        }
        public Employee()
        {
            Console.WriteLine("------------------------Default or non parameterized constructor-----------------");
        }
        //calculating total salary
        public int total(int bonus)
        {
            return Monthlyincome + bonus;
        }
        //display Person details
        public void display()
        {
            Console.WriteLine("Person Details");
            Console.WriteLine($"PersonID:{PersonID},\nPersonName: {PName},\nAge:{Age},\nMonthly Income:" +
                              $" {Monthlyincome},\nTotal income with bonus :{total(bonus)}");
            // int totalincome =total(5000) ;
            // Console.WriteLine("TotalIncome:" + totalincome);
        }
    }
}
