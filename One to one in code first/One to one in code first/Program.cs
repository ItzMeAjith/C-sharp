using One_to_one_in_code_first;
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
                Console.Write("Select the option u want to perform :\n1.Fetch\n2.Insert\n3.Search\n4.Delete\n5.Update\n");
                int id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:
                        {
                            Fetch(); 
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
                    case 5:
                        {
                            Update();
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
            } while (op == "y");
        }
        public static void Search()
        {
            Console.Write("Enter item id u want to search  : ");
            int id = Convert.ToInt32(Console.ReadLine());
            using(HotelDbContext ht= new HotelDbContext())
            {
                Menu m=ht.Menu.First(x=>x.ItemID==id);

                Console.WriteLine($" {m.ItemID} {m.ItemName} {m.Price} {m.Stock} ");

            }

        }
        public static void Fetch()
        {
            try
            {
                using (HotelDbContext ht = new HotelDbContext())
                {
                    var men = ht.Menu.ToList();
                    var ty = ht.ItemTypes.ToList();
                    Console.WriteLine("Menu Details");
                    foreach (var m in men)
                    {
                        Console.WriteLine($"{m.ItemID} {m.ItemName} {m.Price} {m.Stock} ");
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Variety Details");
                    foreach (var t in ty)
                    {
                        Console.WriteLine($"{t.TypeID} {t.TypeName}");
                    }
                    Console.WriteLine("-----------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.Message);
            }
        }

        public static void Insert()
        {
            try
            {
                Console.Write("Select the table u want to insert (Menu/Type) : ");
                string op = Console.ReadLine();
                if (op.ToLower() == "menu")
                {
                    Console.Write("Enter item name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter item price : ");
                    double pri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter item stock  : ");
                    int cnt = Convert.ToInt32(Console.ReadLine());
                    using (HotelDbContext ht = new HotelDbContext())
                    {
                        Menu mu = new Menu()
                        {
                            ItemName = name,
                            Price = pri,
                            Stock = cnt
                        };
                        ht.Add(mu);
                        ht.SaveChanges();
                        Console.WriteLine(  "Inserted successfully...");
                    }
                    Console.WriteLine("-----------------------------------------------");
                }
                else if (op.ToLower() == "type")
                {
                    Console.Write("Enter item type to insert : ");
                    string name= Console.ReadLine();

                    using (HotelDbContext ht = new HotelDbContext())
                    {
                        
                        ItemType it = new ItemType()
                        {
                           TypeName=name
                        };
                        Console.Write("Enter item id for type  : ");
                        int i = Convert.ToInt32(Console.ReadLine());

                        Menu mu = ht.Menu.Find(i);
                        it.Menus = mu;
                        ht.Add(it);
                        ht.SaveChanges();
                        Console.WriteLine("Inserted successfully...");
                    }
                    Console.WriteLine("-----------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Invalid table");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(  "Error : "+ex.Message);
            }

        }

        public static void Update()
        {
            try
            {
                Console.Write("Select the table u want to update (Menu/Type) : ");
                string op = Console.ReadLine();
                if (op.ToLower() == "menu")
                {
                    Console.Write("Enter item id u want to update  : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter new item name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter new item price : ");
                    double pri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new item stock  : ");
                    int cnt = Convert.ToInt32(Console.ReadLine());
                    using (HotelDbContext ht = new HotelDbContext())
                    {
                        Menu mu = ht.Menu.First(x => x.ItemID == id);
                        mu.ItemName = name;
                        mu.Price = pri;
                        mu.Stock = cnt;
                        ht.SaveChanges();
                        Console.WriteLine("Updated successfully...");
                    }
                    Console.WriteLine("-----------------------------------------------");
                }
                else if (op.ToLower() == "type")
                {
                    
                    Console.Write("Enter type id u want to update  : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter new type name : ");
                    string name = Console.ReadLine();

                    using (HotelDbContext ht = new HotelDbContext())
                    {
                        ItemType it = ht.ItemTypes.First(x => x.TypeID == id);
                        it.TypeName = name;
                        ht.SaveChanges();
                        Console.WriteLine("Updated successfully...");
                    }
                    Console.WriteLine("-----------------------------------------------");
                }
             }

            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public static void Delete()
        {
            try
            {
                Console.Write("Select the table u want to delete (Menu/Type) : ");
                string op = Console.ReadLine();
                if (op.ToLower() == "menu")
                {
                    try
                    {
                        Console.Write("Enter item id u want to delete  : ");
                        int id = Convert.ToInt32(Console.ReadLine());


                        using (HotelDbContext ht = new HotelDbContext())
                        {
                            Menu it = ht.Menu.First(x => x.ItemID == id);
                            ht.Remove(it);
                            ht.SaveChanges();
                            Console.WriteLine("Deleted successfully...");
                        }
                        Console.WriteLine("-----------------------------------------------");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                }
                else if (op.ToLower() == "type")
                {
                    try
                    {
                        Console.Write("Enter type id u want to delete  : ");
                        int id = Convert.ToInt32(Console.ReadLine());


                        using (HotelDbContext ht = new HotelDbContext())
                        {
                            ItemType it = ht.ItemTypes.First(x => x.TypeID == id);
                            ht.Remove(it);
                            ht.SaveChanges();
                            Console.WriteLine("Deleted successfully...");
                        }
                        Console.WriteLine("-----------------------------------------------");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid table");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

    }
}