using System;

namespace UsingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Viết chương trình nhập vào 1 số nguyên n.Cho biết:
            //a) n là số chẵn hay số lẻ?
            //b) n là số âm hay số không âm
            // Cách 1: dùng do while
            //Console.WriteLine("xac dinh so nguyen hay le, am hay duong");
            //int n;
            //do
            //{
            //    Console.Write("Nhap vao 1 so de xem nó la am hay duong chan hay le");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    Console.Write(n + " ");
            //    string am_duong = (n > 0) ? "So duong" : "So am";
            //    string chan_le = (n % 2 == 0) ? "So chan" : "So le";
            //    Console.Write(am_duong + " ");
            //    Console.WriteLine(chan_le);
            //    n++;

            //}// n > 100: chỉ nhập được 1 lần với điều kiện n < 100
            ////while (n > 100);
            ////n < 100: chỉ được nhập 1 lần với điều kiện n > 100
            //while (n < 100 );

            ////cách 2: dùng while
            //while (n < 100)
            //{
            //    Console.Write(n + " ");
            //    string am_duong = (n > 0) ? "So duong" : "So am";
            //    string chan_le = (n % 2 == 0) ? "So chan" : "So le";
            //    Console.Write(am_duong + " ");
            //    Console.WriteLine(chan_le);
            //    n++;
            //};
            /*
             2).Viết chương trình nhập vào số nguyên n không âm. In ra dãy số từ 1 đên n, tính tổng dãy số, tính tích dãy số
             */


            //int i, n;
            //double s = 0.0;

            //Console.Write("\n");
            //Console.Write("Tinh tong day so trong C#:\n");
            //Console.Write("-------------------------");
            //Console.Write("\n\n");

            //Console.Write("Nhap so phan tu: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n\n");
            //for (i = 1; i <= n; i++)
            //{
            //    if (i < n)
            //    {
            //        Console.Write("1/{0} + ", i);
            //    }
            //    else
            //    {
            //        Console.Write("1/{0}", i);
            //    }
            //    s += 1 / (float)i;
            //}
            //Console.Write("\n\nTong cua day {0} phan tu bang: {1} \n", n, s);

            //Console.ReadKey();

            //3). Viết chương trình nhập vào số nguyên n không âm. In ra dãy số chẳng, dãy số lẻ đến n

            //int So_gioi_han, Le_chan;
            //Console.WriteLine("Nhap vao so nguyen gioi han lon ho 0: ");
            //So_gioi_han = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap vao so nguyen khong am: ");
            //Le_chan = Convert.ToInt32(Console.ReadLine());
            //while (So_gioi_han > 0 && Le_chan<So_gioi_han)
            //{
            //    string result = (Le_chan % 2 == 0) ? "So chan" : "So le";
            //    Console.WriteLine(Le_chan+" "+result);
            //    Le_chan++;
            //}

            //4). Viết chương trình in bảng cửu chương từ 2 đến 10

            //Console.WriteLine("Input x: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i + "*" + x + "=" + i * x);
            //}

            //Bài 5: Viết chương trình nhập vào số nguyên n. In ra dãy số nguyên tố

            //Console.Write("Nhap vao mot so: ");
            //int number = int.Parse(Console.ReadLine());
            //bool IsPrime = true;
            //if (number < 2)
            //{
            //    IsPrime = false;
            //}
            //for (int i = 2; i < number / 2; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        IsPrime = false;
            //        break;
            //    }
            //}
            //if (IsPrime)
            //{
            //    Console.Write($"{number} la so nguyen to.");
            //}
            //else
            //{
            //    Console.Write($"{number} khong phai so nguyen to.");
            //}
            //Console.ReadKey();

            //Bài 6: viết chương trình nhập vào số nguyên n. Vẽ tam giác hình (*) tương ứng với n 

            //lấy số dòng từ bàn phím
            Console.Write("Nhap vao so dong cua tam giac:");
            int rows = Convert.ToInt32(Console.ReadLine());
            //sử dụng vòng lặp for thứ nhất để lặp qua các dòng
            for (int i = 1; i <= rows; i++)
            {
                //sử dụng vòng lặp for thứ hai để in ký tự * cho mỗi dòng
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                    
                //sau khi in mỗi dòng sẽ xuống hàng
                Console.Write("\n");
            }
            Console.WriteLine("\n----Chuong trinh nay duoc dang tai Freetuts.net----\n");
            Console.ReadLine();
        }
    }









}

