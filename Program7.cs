using System;
using System.Security.Cryptography;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] hmm)
        {
            
            Console.WriteLine("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tim so lon nhat va nho nhat cua a,b,c,d");
            
           
            if (a > b && a > c && a > d)
                Console.WriteLine("Max la " + a);
            if (b > a && b > c && b > d)
                Console.WriteLine("Max la " + b);
            if (c > a && c > b && c > d)
                Console.WriteLine("Max la " + c);
            if (d > a && d > b && d > c)
                Console.WriteLine("Max la " + d);
            if (a < b && a < c && a < d)
                Console.WriteLine("Min la " + a);
            if (b < a && b < c && b < d)
                Console.WriteLine("Min la " + b);
            if (c < a && c < b && c < d)
                Console.WriteLine("Min la " + c);
            if (d < a && d < b && d < c)
                Console.WriteLine("Min la " + d);
            Console.WriteLine("---------------------------------------");
            int a, b, c,d, max, min;
            Console.Write("\n Nhap vao so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu tu: ");
            d = Convert.ToInt32(Console.ReadLine());
            max = ((a > b && a > c && a > d) ? a : (b > c && b > d) ? b : (c > d) ? c : d);
            min = ((a < b && a < c && a < d) ? a : (b < c && b < d) ? b : (c < d) ? c : d);
            Console.WriteLine("\nSo lon nhat trong 4 so: " +
                                a + ", " + b + ", " +
                                    c + " va " + d +
                                         " la " + max);
            Console.WriteLine("\nSo nho nhat trong 4 so: " +
                                a + ", " + b + ", " +
                                    c + " va " + d +
                                         " la " + min);

            Console.WriteLine("Tim so nho nhat va lon nhat cua a,b va c,d");

            Console.WriteLine("So lon nhat cua a va b la: " + Math.Max(a, b));
            Console.WriteLine("So nho nhat cua a va b la: " + Math.Min(a, b));
            Console.WriteLine("So lon nhat cua c va d la: " + Math.Max(c, d));
            Console.WriteLine("So nho nhat cua c va d la: " + Math.Max(c, d));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("So sanh cac cap voi nhau");
            if ((Math.Max(a, b)) > Math.Max(c, d))
                Console.WriteLine("Cap lon hon la a va b: "+a , b);
            if ((Math.Max(a, b)) < Math.Max(c, d))
                Console.WriteLine("Cap lon hon la c va d: "+c , d);
            if ((Math.Min(a, b)) > Math.Min(c, d))
                Console.WriteLine("Cap nho hon la a va b: "+a , b);
            if ((Math.Min(a, b)) < Math.Min(c, d))
                Console.WriteLine("Cap nho hon la c va d:"+c , d);

            Console.ReadKey();




        }
    }
}
