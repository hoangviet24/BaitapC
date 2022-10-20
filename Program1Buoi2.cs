using System;
namespace BT1
{
    class program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            Console.WriteLine("Nhap vao phuong trinh bac 2 : a*x^2 + b*x + c = 0 ");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Phuong trinh vua nhap la: {0}*x^2 + {1}*x + {2} = 0", a, b, c);

            if (a == 0)
            {

                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");

                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem duy nhat: x = {0}", -c / b);
                }

            }
            else
            {
                double delta;
                delta = b * b - 4 * a * c;
                Console.WriteLine("Delta = " + delta);
                if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep : x1 = x2 = {0}", -b / 2 * a);

                }
                else if (delta > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}, x2 = {1} ", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
    }
}
