using System;
namespace Baitap2
{
    class Program
    {
        static void Main(string[] hmms)
        {
            float a, b, c;
            Console.WriteLine("nhap canh a:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap canh b:");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap canh c:");
            c = Convert.ToSingle(Console.ReadLine());

            if ((a == b) && (b == c))
                Console.WriteLine("Tam giac deu");
            else if ((a == b) || (a == c) || (c == b))
                Console.WriteLine("Tam giac can");
            else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                Console.WriteLine("Tam giac vuon");
            else if (((a * a + b * b == c * c) && (a == b)) || ((a * a + c * c == b * b) && (a == c)) || ((b * b + c * c == a * a) && (b == c)))
                Console.WriteLine("Tam giac vuong can");
            else
                Console.WriteLine("Khong co tam giac nao");
            Console.ReadKey();
        }
    }
}