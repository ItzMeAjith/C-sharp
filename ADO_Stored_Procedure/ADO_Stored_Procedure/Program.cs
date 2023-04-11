using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
namespace ADO_Stored_Procedure
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Manipulation mn= new Manipulation();
            Console.Write("Enter the city : ");
            string cty=Console.ReadLine();
            mn.Fetch(cty);
           // mn.Count();
        }

    }
}