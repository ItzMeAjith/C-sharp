using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Class1
    {
        //public string a;
        //public string b;
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is : " + (a + b));
        }
        public  int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public  void Sum(string a, string b)
        {
            Console.WriteLine("Concat is : " + (a + b));
        }
        public  void Sum(double a, double b)
        {
            Console.WriteLine("double addition is : " + (a + b));
        }
    }
}
