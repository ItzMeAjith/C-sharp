using System;

namespace Partial_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partial class---------");

            Class1 c=new Class1() { id= 1,name="Ajith",dept="CSE" };
            c.display(c.id,c.name,c.dept);
        }
    }
}