using System;
using Assemblylink;
namespace Assemblylink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IT t1 = new IT();
            Console.WriteLine("Name is {0}\nRollno is {1}",t1.name,t1.roll);
        }
    }
}