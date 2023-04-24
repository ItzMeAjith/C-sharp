using System;
using System.Security.Cryptography.X509Certificates;

namespace Flight_status
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> flights = new Dictionary<string, int>()
            {
                {"FL1",10 },
                {"FL2",16 },
                {"FL3", 21}
            };
            Console.WriteLine("Enter the flight number : ");
            string fl=Console.ReadLine();
            if (flights.ContainsKey(fl))
            {
                int t = flights[$"{fl}"];
                Console.WriteLine(t>DateTime.Now.Hour? $"You have {t-DateTime.Now.Hour} hours to get flight":"Flight already left");
            }
            else
                Console.WriteLine("Enter the valid flight number !!!!!!!!!!!!!");
            


        }
    }
}