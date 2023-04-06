using System;

namespace StringConcate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name : ");
            string fn=Console.ReadLine();
            Console.Write("Enter last name : ");
            string ln=Console.ReadLine();
            //string fullname=(string)fn.Concat(ln);
            //Console.WriteLine(string.Concat(fn, ln));
            Console.WriteLine(fn+" "+ln);
        }
    }
}