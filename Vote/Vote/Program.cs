//5. Create a class named Person with the fields Personid,name and age. Check whether the
//given person is eligible to vote or not.
using System;
namespace Day1
{
    class Person
    {
        public static void isEligible(string id,string name,int age)
        {
            if (age >= 18)
                Console.WriteLine("{0} with ID {1} is eligible to vote", name, id);
            else
                Console.WriteLine("{0} with ID {1} is not eligible to vote", name, id);
        }
        static void Main(string[] args)
        {
             string personid;
             string name;
             int age;
            Console.Write("Enter Your Id : ");
            personid = Console.ReadLine();
            Console.Write("Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Your age : ");
            age=int.Parse(Console.ReadLine());
            isEligible(personid,name,age);
        }
    }   
}
