//2. Write a C# Program to reverse the given number.
using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to be reversed : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (n!=0)
            {
                int r = n % 10;
                Reverse=Reverse* 10 + r;
                n=n/10;
            }
            Console.WriteLine("The reverse of the number is : "+Reverse);
        }
    }
}