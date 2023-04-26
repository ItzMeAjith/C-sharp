using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1= { 1, 2,3 };
            int[] arr2= { 4,5,6 };
            var lin=from a1 in arr1 && from a2 in arr2  
        }
    }
}




/*
// Data source
string[] names = { "Bill", "Steve", "James", "Mohan","Ajith","vijay" };

// LINQ Query 
var myLinqQuery = from name in names
                  where name.Contains('a') || name.Contains('A')
                  select name;

// Query execution
foreach (var name in myLinqQuery)
    Console.Write(name + " ");
*/