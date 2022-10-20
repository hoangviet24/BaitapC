using System;

/*Sales= row * fee * 12%
	- Ship = row * fee * 5%
	- Total_money = row * fee – Sales + Ship
*/
namespace Baitap4
{
    class Program
    {
        static void Main(string[] hmms)
        {
            Console.WriteLine("Input Sales: ");
            int Sales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input fee: ");
            int fee = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Ship: ");
            int Ship = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Sales = row * fee * 12 / 100;
            Ship = row * fee * 5 / 100;
            float Total_money = row * fee - Sales + Ship;
            Console.WriteLine("So tien giam gia la: "+Sales);
            Console.WriteLine("So tien van chuyen la: "+Ship);
            Console.WriteLine("Tong tien la: "+Total_money);
        }
    }
}
