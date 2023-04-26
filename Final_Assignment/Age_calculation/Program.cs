using System;

namespace Age_calculations
{
   
    class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public DateTime dob { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Person p = new Person();
             Console.Write("Enter first name : ");
             p.firstName = Console.ReadLine();
             Console.Write("Enter last name : ");
             p.lastName = Console.ReadLine();
             Console.Write("Enter DOB in the format of yyyy/mm/dd : ");
             p.dob=Convert.ToDateTime(Console.ReadLine());
             int age=DateTime.Today.Year-p.dob.Year;
            Console.WriteLine($"First name : {p.firstName}\nLast name : {p.lastName}");
            Console.WriteLine("Age = "+age);
            Console.WriteLine(age > 18 ? "Adult" : "Child");
             
               
        }
    }
}