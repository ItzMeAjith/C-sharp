using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GenericCollections
{
    class Students
    {
        public string name { get; set; }
        public string fname { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name,fname,op;
            List<Students> std = new List<Students>();
            do
            {
                Console.Write("Enter name : ");
                Name = Console.ReadLine();
                Console.Write("Enter father name : ");
                fname = Console.ReadLine();
                std.Add(new Students() { name = Name, fname = fname });
                Console.Write("Do you want to insert another recored (yes/no) : ");
                op = Console.ReadLine();
            } while (op == "yes");
            Console.WriteLine("------------------------------STUDENTS DETAILS------------------------------");
           // Console.WriteLine("Students list is : ");
            foreach (Students s in std)
            {
                Console.WriteLine(s.name+" "+s.fname);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
