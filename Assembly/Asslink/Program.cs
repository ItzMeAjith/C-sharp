using System;
using Assembly;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 t1 = new Class1();
            Console.WriteLine("Roll ni is {0}\nName is {1}",t1.rollno,t1.name);
        }
    }
}