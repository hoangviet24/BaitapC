using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            double c, dv, t;
            Console.WriteLine("Input n < 1000");
            n = Convert.ToSingle(Console.ReadLine());
            c = (n % 100) / 10;
            dv = (n % 100) % 10;
            t = n / 100;
            
            Console.WriteLine("t = {0}", t);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("dv = {0}", dv);
            if (c == 0 && dv != 0)
                Console.WriteLine("odd number");
            if (c == 0 && dv == 0)
                Console.WriteLine("even number");
            else
                Console.WriteLine("No answer");
            Console.ReadKey();
        }
    }
}