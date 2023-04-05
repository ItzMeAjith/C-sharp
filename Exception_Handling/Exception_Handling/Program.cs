using System;
using System.Reflection.Metadata.Ecma335;

namespace Exception_Handling
{
    
    internal class Program
    {
        class Markerror:Exception
        {
           // public Markerror(string msg) : base(msg) { }

            public  override string Message
            {
                get
                {
                    return "mark should be less than 100";
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter mark : ");
            int m=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (m > 100)
                {
                    //throw new Markerror("Mark should not be greater than 100");
                    throw new Markerror();
                }
                else
                    // throw new Markerror("Your mark is accepted ");
                    Console.WriteLine("Your mark is accepted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}