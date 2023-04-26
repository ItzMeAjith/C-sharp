using System;

namespace Disconnected_Architecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipulation mn = new Manipulation();
            string op;
            do
            {
                Console.WriteLine("Enter the option to be performed :\n1.Fetch\n2.Insert ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            mn.Fetch();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter roll no : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter name : ");
                            string name = Console.ReadLine();
                            Console.Write("Enter dept : ");
                            string dep = Console.ReadLine();
                            Console.Write("Enter CGPA : ");
                            double cgpa = Convert.ToDouble(Console.ReadLine());
                            mn.Insert(roll, name, dep, cgpa);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice !!!");
                            break;
                        }
                }
                Console.Write("Do you want to continue (yes/no) : ");
                op = Console.ReadLine();
            } while (op == "yes");
        }
    }
}