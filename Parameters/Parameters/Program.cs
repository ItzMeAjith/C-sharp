using System;
namespace Parameters
{
    public class program
    {
        /*
        public static void sum(int a, int b)
        {
            Console.WriteLine("Sum is : " + (a + b));
        }
        public static int sum(int a, int b,int c)
        {
            return a+b+c;
        }
        public static void sum(string a, string b)
        {
            Console.WriteLine("Concat is : " + (a + b));
        }
        public static void sum(double a, double b)
        {
            Console.WriteLine("double addition is : " + (a + b));
        }
        */

        public static void Main(String[] args)
        {
            //String
            //Console.Write("Enter value of a : ");
            //string? a1 = Console.ReadLine();
           // Console.Write("Enter value of b : ");
           // string? b1 = Console.ReadLine();
            //int
            /*
            Console.Write("Enter value of a : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b : ");
            int b1 = Convert.ToInt32( Console.ReadLine()); */
            Class1 cl = new Class1();
           // cl.a = a1;
          //  cl.b = b1;
            // sum(Convert.ToInt32( a1), Convert.ToInt32(b1));
            //Console.WriteLine("Triple addition" + sum(Convert.ToInt32(a1), Convert.ToInt32(b1), Convert.ToInt32(b1)));
            // sum(a1, b1);
            // sum(Convert.ToDouble(a1),Convert.ToDouble(b1));
            Console.WriteLine("Enter ur option to Manipulate \n1.Int\n2.String\n3.Double");
            int op=Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        Console.Write("Enter value of a : ");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter value of b : ");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        cl.Sum(a1,b1);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter value of a : ");
                        string? a1 = Console.ReadLine();
                        Console.Write("Enter value of b : ");
                        string? b1 = Console.ReadLine();
                        cl.Sum(a1, b1);
                        break;
                    }
                    case 3:
                    {
                        Console.Write("Enter value of a : ");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter value of b : ");
                        double b1 = Convert.ToDouble(Console.ReadLine());
                        cl.Sum(Convert.ToDouble(a1), Convert.ToDouble(b1));
                        break;
                    }
                default: Console.WriteLine("Enter valid option");
                         break;
            }









/*
            if(a1.GetType()==typeof(string))
            {
                cl.Sum(a1, b1 );
            }
            else if (a1.GetType() == typeof(int))
            {
                cl.Sum(a1, b1);
            }
            else if (a1.GetType() == typeof(double))
            {
                cl.Sum(a1, b1);
            }*/
        }
    }
}