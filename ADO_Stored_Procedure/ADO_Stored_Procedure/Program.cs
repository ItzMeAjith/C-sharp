using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace ADO_Stored_Procedure
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Manipulation mn = new Manipulation();
            string op;
            do
            {
                Console.WriteLine("Enter the option to be performed :\n1.Fetch all records\n2.Search\n3.Total count ");
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
                            Console.Write("Enter the department to search : ");
                            string dep = Console.ReadLine();
                            mn.Search(dep);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter the department to get count : ");
                            string dep = Console.ReadLine();
                            mn.Count(dep);
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