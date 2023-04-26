using SAMPLE_EF.Models;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.Write("Select the option u want to perform :\n1.Fetch\n2.Insert\n3.Search\n4.Delete\n");
                int id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:
                        {
                            Fetch();+
                            break;
                        }
                    case 2:
                        {
                            Insert();
                            break;
                        }
                    case 3:
                        {
                            Search();
                            break;
                        }
                    case 4:
                        {
                            Delete();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter valid option!!!!!");
                            break;
                        }

                }
                Console.Write("Do u want to continue (y/n) : ");
                op = Console.ReadLine();
            } while (op=="y");

        }
        public static void Fetch()
        {
            using (CanteenManagementContext con = new CanteenManagementContext())
            {
                List<Menu> res = con.Menus.ToList();
                foreach (Menu m in res)
                {
                    Console.WriteLine($"{m.ItemId} {m.ItemName} {m.ItemType} {m.Price} {m.Offer}");
                }
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        public static void Insert()
        {
            try
            {
                Console.Write("Enter item name : ");
                string name = Console.ReadLine();
                Console.Write("Enter item type : ");
                string type = Console.ReadLine();
                Console.Write("Enter Item price : ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter item offer : ");
                string offer = Console.ReadLine();
                using (CanteenManagementContext con = new CanteenManagementContext())
                {
                    Menu mu = new Menu()
                    {
                        ItemName = name,
                        ItemType = type,
                        Price = (decimal?)price,
                        Offer = offer
                    };
                    con.Add(mu);
                    con.SaveChanges();
                }
                Console.WriteLine("Inserted successfully");
                Console.WriteLine("------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : "+ex.Message);
            }
        }
        public static void Search()
        {
            Console.Write("Enter Item ID do u want to search : ");
            int id = Convert.ToInt32(Console.ReadLine());
            using (CanteenManagementContext con = new CanteenManagementContext())
            {
                Menu m = con.Menus.First(x => x.ItemId == id);
                Console.WriteLine($"{m.ItemId} {m.ItemName} {m.ItemType} {m.Price} {m.Offer}");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        public static void Update()
        {
            try
            {
                Console.Write("Enter Item ID do u want to update : ");
                int id = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter new item name : ");
                string name = Console.ReadLine();
                Console.Write("Enter new item type : ");
                string type = Console.ReadLine();
                Console.Write("Enter new Item price : ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new item offer : ");
                string offer = Console.ReadLine();
                using (CanteenManagementContext con = new CanteenManagementContext())
                {
                    Menu m=con.Menus.First(x=>x.ItemId==id);
                    m.ItemName = name;
                    m.ItemType = type;
                    m.Price =(decimal) price;
                    m.Offer = offer;
                    con.SaveChanges();
                }
                Console.WriteLine("Updated successfully");
                Console.WriteLine("------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
        }

        public static void Delete()
        {
            try
            {
                Console.Write("Enter Item ID do u want to delete : ");
                int id = Convert.ToInt32(Console.ReadLine());

                using (CanteenManagementContext con = new CanteenManagementContext())
                {
                    Menu m = con.Menus.First(x => x.ItemId == id);
                    con.Remove(m);
                    con.SaveChanges();
                }
                Console.WriteLine("Deleted successfully");
                Console.WriteLine("------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
        }
    }
}