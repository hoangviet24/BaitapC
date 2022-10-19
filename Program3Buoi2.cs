using System;
namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double c, dv, t;
            Console.WriteLine("Input integer n < 1000");
            n = Convert.ToInt32(Console.ReadLine());
            c = (n % 100) / 10;
            dv = (n % 100) % 10;
            t = n / 100;
            
            Console.WriteLine("t = {0}", t);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("dv = {0}", dv);
            if (c %2 == 0 && dv %2 != 0)
                Console.WriteLine("odd number");
            if (c % 2 == 0 && dv % 2 == 0)
                Console.WriteLine("even number");
            else
                Console.WriteLine("No answer");
            Console.ReadKey();
        }
    }
}
