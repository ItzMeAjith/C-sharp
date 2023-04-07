using System;
namespace EnumDeligates
{
    class program
    {
        enum Days { Sun, Mon, tue, Wed=890, thu=3, Fri, Sat=4 };
        public static void Main(string[] args)
        {
             string[] arr = Enum.GetNames(typeof(Days));
            Console.WriteLine("Days============================================");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
            int[] arr1 = (int[])Enum.GetValues(typeof(Days));
            Console.WriteLine("Values============================================");
            foreach (int s in arr1)
            {
                Console.WriteLine(s);
            }
            Days ui = (Days)890;
            Console.WriteLine(ui);
        }
    }
}
