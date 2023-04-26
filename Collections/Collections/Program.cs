using System;
using System.Collections;
namespace Collectins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op,name;
            int roll;
            ArrayList Std=new ArrayList();
            do
            {
                Console.Write("Enter Roll no : ");
                roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name : ");
                name = Console.ReadLine();
                Std.Add(roll);
                Std.Add(name);
                Console.Write("Do you want to insert another recored (yes/no) : ");
                op = Console.ReadLine();
            } while (op == "yes");
            Console.WriteLine("Students list is : ");
            foreach(object i in Std)
            {
                Console.Write(i+" ");
            }

        }
    }
}