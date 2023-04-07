using System;
using System.Linq.Expressions;

namespace LambdaExpression
{
    class std
    {
        public int id;
        public string name;
        public string dept;
        public std(int id, string name, string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter n : ");
                int n = Convert.ToInt32(Console.ReadLine());
                std[] s = new std[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter id : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter dept: ");
                    string dep = Console.ReadLine();
                    s[i] = new std(id, name, dep);
                    var res = s.Select(x => x.dept);

                    foreach (string iu in res)
                    {
                        Console.WriteLine(iu);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}