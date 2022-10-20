using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] dungcodeaunua)
        {
            int day_in_week;
            do
            {
                Console.WriteLine("Nhap thu trong tuan: ");
                day_in_week = Convert.ToInt32(Console.ReadLine());
            }
            while ((day_in_week <= 1 || day_in_week > 8));

           
            switch (day_in_week)
            {
                case 2:Console.WriteLine("Monday");break;
                case 3:Console.WriteLine("Tuesday");break;
                case 4:Console.WriteLine("Wednesday");break;
                case 5:Console.WriteLine("Thursday");break;
                case 6:Console.WriteLine("Friday");break;
                case 7:Console.WriteLine("Saturday");break;
                case 8:Console.WriteLine("Sunday");break;
                case 9:Console.WriteLine("No command");break;
                
            }
        }
    }
}
