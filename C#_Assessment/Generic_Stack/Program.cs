using System;

namespace Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<string> stk = new Stack<string>();
                Console.WriteLine("Students list is : ");
                foreach (string item in stk)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("----------------------------------------------------------------------");
                string op;
                do
                {
                    
                    Console.WriteLine("Enter your choice : \n1.Insert\n2.Delete");
                    int ch=Convert.ToInt32(Console.ReadLine());
                    switch(ch)
                    {
                        case 1:
                            {
                                Console.Write("How many students you want to push into stack : ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < n; i++)
                                {
                                    Console.Write($"Enter the name of {i + 1} student : ");
                                    stk.Push(Console.ReadLine());

                                }

                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("Students list is : ");
                                foreach (string item in stk)
                                {
                                    Console.WriteLine(item);
                                }
                                Console.WriteLine("--------------------------------------------------------------------");
                                break;
                            }
                        case 2:
                            {
                                Console.Write("How many students you want to pop from stack (Note : it will remove the last records ) : ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < n; i++)
                                {
                                    stk.Pop();

                                }

                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("Students list after updation is : ");
                                foreach (string item in stk)
                                {
                                    Console.WriteLine(item);
                                }
                                Console.WriteLine("--------------------------------------------------------------------");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Enter valid choice !!!!");
                                break;
                            }
                    }
                    Console.Write("Do you want to continue (y/n) : ");
                    op=Console.ReadLine();
                }
                while (op.ToLower()=="y");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : "+ex.Message);
            }
        }
    }
}