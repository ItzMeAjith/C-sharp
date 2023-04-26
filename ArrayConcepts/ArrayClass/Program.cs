using System;

namespace ArrayClass
{
    public class Clg
    {
        public int roll;
        public string name;
        public string dept;

        public Clg(int roll, string name, string dept)
        {
            this.roll = roll;
            this.name = name;
            this.dept = dept;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no of Students : ");
            int n=Convert.ToInt32(Console.ReadLine());
           // string[][] clg = new string[n][];
            Clg[] c=new Clg[n];
            for(int i=0;i<n;i++)
            {
                Console.Write($"Enter Roll no of {i+1}th student : ");
                int r=Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter name of {i + 1}th student : ");
                string name = Console.ReadLine();
                Console.Write($"Enter dept of {i + 1}th student : ");
                string dept = Console.ReadLine();
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                c[i] = new Clg(r,name,dept);
            }
            foreach(Clg j in c)
            {
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                Console.WriteLine($"{j.roll}  {j.name}  {j.dept}");
            }

        }
    }
}