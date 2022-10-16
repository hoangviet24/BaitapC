using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] hmms)
        {
            Console.Write("Nhap vao nam bat ky de xem co phai nam nhuan khong: ");
            int nam_nhuan = Convert.ToInt32(Console.ReadLine());

            if ((nam_nhuan % 400) == 0)
                Console.WriteLine(nam_nhuan + "La nam nhuan");
            else if ((nam_nhuan % 100) == 0)
                Console.WriteLine(nam_nhuan + "Khong la nam nhuan");
            else if ((nam_nhuan % 4) == 0)
                Console.WriteLine(nam_nhuan + "La nam nhuan");
            else 
                Console.WriteLine(nam_nhuan + "Khong la nam nhuan");
            Console.ReadKey();
        }
    }
}