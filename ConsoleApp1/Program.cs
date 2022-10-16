// Bài tập căn bậc 2
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Input y: ");
            float y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("z = "+(2*x + Math.Sqrt(y))/13);
            Console.WriteLine(" ");
            Console.WriteLine(Math.Sqrt(x));
        }
    }
}
