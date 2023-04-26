/* 5. Write a C# Program to form a number pyramid.
Hint: Use two ‘for’ loops(Outer and Inner)
Sample Output:
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
8 8 8 8 8 8 8 8
9 9 9 9 9 9 9 9 9
*/
using System;
namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i=0;i<10;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}