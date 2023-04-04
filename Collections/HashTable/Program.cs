using System;
using System.Collections;
using System.Collections.Generic;
namespace HashTable
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non generic - hash table---------");
            Hashtable ht = new Hashtable();
            ht.Add(1, "Ajith");
            ht.Add(3, "Hari");
            ht.Add("SU", "Suresh");
            ht.Add(3.6, "Ranjith");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
            Console.WriteLine("generic - Dictionary ---------");

            Dictionary<int,string> dic= new Dictionary<int,string>();
            dic.Add(1, "Ajith");
            dic.Add(2, "HAri");
            foreach (KeyValuePair<int,string> d1 in dic)
            {
                Console.WriteLine(d1.Key+" "+d1.Value);
            }
        }
    }
}