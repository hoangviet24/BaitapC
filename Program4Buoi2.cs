using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] dungcodeaunua)
        {
            Console.WriteLine("Input day in week: ");
            int day_in_week;
            day_in_week = Convert.ToInt32(Console.ReadLine());
            switch (day_in_week)
            {
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                case 8:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }
        }
    }
}
