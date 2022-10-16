using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Input x: ");
            int x = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("T = " + 1 / 2 * x * n + 2 * 32 * Math.Pow(x,3));
        }
    }
}

