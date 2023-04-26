using ADO1;
using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ADO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipulations m = new Manipulations();
            string OP;
            do
            {
                Console.WriteLine("Please Enter the choice to be made :\n1.Create\n2.Insert\n3.Update\n4.Delete\n5.Fetch");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        {
                            m.Create();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the roll number to be inserted : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the name to be inserted : ");
                            string name = Console.ReadLine();
                            m.Insert(roll,name);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("What do u want to update (Roll or Name) : ");
                            string op = Console.ReadLine();
                            if (op == "Roll")
                            {
                                Console.Write("Enter the roll number to be updated : ");
                                int pos = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the new roll number : ");
                                int roll = Convert.ToInt32(Console.ReadLine());
                                m.Update(pos, roll);
                                break;
                            }
                            else
                            {
                                Console.Write("Enter the roll number where the name to be updated : ");
                                int pos = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the new name : ");
                                string name = Console.ReadLine();
                                m.Update(pos, name);
                                break;
                            }

                        }
                    case 4:
                        {
                            Console.Write("Enter the roll number where to detete : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            m.Delete(roll);
                            break;
                        }
                    case 5:
                        {
                            m.Fetch();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid choice!!!!!");
                            break;
                        }
                }
                Console.Write("Do you want to continue (yes/no): ");
                OP = Console.ReadLine();
            } while (OP == "yes");
        }

    }
}