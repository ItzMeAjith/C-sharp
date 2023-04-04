//3. Write a C# program to display multiplication table of any given number using For loop.
using System;
namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i=1;i<=10;i++)
            {
                Console.Write("{0} * {1} = {2}",n,i,n*i);
            }
    }
}