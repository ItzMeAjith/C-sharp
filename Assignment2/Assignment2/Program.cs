//Registration Form
using System;

namespace Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Country : ");
            string country = Console.ReadLine();
            Console.WriteLine($"Welcome {name}. Your age is {age} and you are from {country}");
        }
    }
}