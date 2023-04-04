//1. Write a C# program to display the first and last digit of a number.
using System;
namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            String n = Console.ReadLine();
            Console.WriteLine("The first digit is {0} \nThe last digit is {1}", n[0], n[n.Length - 1]);
        }
    }
}