using CODE_FIRST_APPROACH;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(OrderBbContext con=new OrderBbContext())
            {
                var re=con.Orders.ToList();
                foreach(var item in re)
                {
                    Console.WriteLine(item.OrderID+" "+item.ItemName);
                }
            }
        }
    }
}