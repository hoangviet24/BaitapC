using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + "*" + x + "=" + i * x);
            }
        }
    }
}
