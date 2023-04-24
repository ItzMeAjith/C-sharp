using System;

namespace Calculator
{
    class Calculator
    {
        public int Addition(int a,int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public double Division(int a, int b,out double remainder)
        {
            int r = a % b;
            remainder = r;
            Console.WriteLine("Remainder = "+remainder);
            return a/b;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            string ch;
            do
            {
                Console.Write("Enter the operation to be performed : ");
                string op = Console.ReadLine();
                Console.Write("Enter the operand1 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the operand2 : ");
                int b = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case "+":
                        {
                            Console.WriteLine($"The result of {a} {op} {b} is {cal.Addition(a, b)} ");
                            Console.WriteLine("------------------------------------------------------");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine($"The result of {a} {op} {b} is {cal.Subtraction(a, b)} ");
                            Console.WriteLine("------------------------------------------------------");
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine($"The result of {a} {op} {b} is {cal.Multiplication(a, b)} ");
                            Console.WriteLine("------------------------------------------------------");
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine($"The result of {a} {op} {b} is {cal.Division(a, b, out double r)} ");
                            Console.WriteLine("------------------------------------------------------");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter valid operation!!!!!");
                            Console.WriteLine("------------------------------------------------------");
                            break;
                        }
                }
                Console.Write("Do you want to continue (yes/no): ");
                ch=Console.ReadLine();
            } while( ch=="yes" );
        }
    }
}