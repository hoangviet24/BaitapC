using System;


namespace bai_thuc_hanh_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            double x, K;

            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());

            K = (x * x + x + 1) * n + (x * x - x + 1) * n;

            Console.Write("ket qua z {0}", K);
            Console.ReadKey();
        }
    }
}
