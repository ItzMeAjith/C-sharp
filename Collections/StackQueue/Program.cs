using System;
using System.Collections;
namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non generic Stack--------------");
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push("Ajith");
             foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------");
            // Queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue("Ajith");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------");
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}