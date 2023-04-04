//3. Write a C# Program to print Fibonacci Series for a given number.
using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = -1;
            int b = 1;
            int c = 0;
            for(int i=0;i<n;i++)
            {
                c = a + b;
                Console.Write(c+"\t");
                a = b;
                b=c;
            }
        }
    }
}