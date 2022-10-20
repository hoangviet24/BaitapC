using System;
namespace BT3
{
    class program
    {
        static void Main(string[] args)
        {
            int n;
            do {
                Console.WriteLine("Nhap vao so nguyen co 3 chu so");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 100 || n > 999);

            int t = n / 100;
            int c = (n % 100) / 10;
            int dv = (n % 100) % 10;
            if (c == 0 && dv == 0)
            {
                Console.WriteLine("Mot tram chan");
            }
            else { 
            switch (t)
            {
                case 1: Console.Write("Mot tram "); break;
                case 2: Console.Write("Hai tram "); break;
                case 3: Console.Write("Ba tram "); break;
                case 4: Console.Write("Bon tram "); break;
                case 5: Console.Write("Nam tram "); break;
                case 6: Console.Write("Sau tram "); break;
                case 7: Console.Write("Bay tram "); break;
                case 8: Console.Write("Tam tram "); break;
                case 9: Console.Write("Chin tram "); break;
            }
            }

            if ( c==0 && dv!=0){
                Console.Write("le ");
            }
            else { 
            switch (c)
            {
                case 1: Console.Write("muoi "); break;
                case 2: Console.Write("hai muoi "); break;
                case 3: Console.Write("ba muoi "); break;
                case 4: Console.Write("bon muoi  "); break;
                case 5: Console.Write("nam muoi "); break;
                case 6: Console.Write("sau muoi "); break;
                case 7: Console.Write("bay muoi "); break;
                case 8: Console.Write("tam muoi "); break;
                case 9: Console.Write("chin muoi "); break;
            }
            }
            switch (dv)
            {
                case 1: Console.Write("mot "); break;
                case 2: Console.Write("hai "); break;
                case 3: Console.Write("ba "); break;
                case 4: Console.Write("bon "); break;
                case 5: Console.Write("nam "); break;
                case 6: Console.Write("sau "); break;
                case 7: Console.Write("bay "); break;
                case 8: Console.Write("tam "); break;
                case 9: Console.Write("chin "); break;
            }
        }
    }
}

