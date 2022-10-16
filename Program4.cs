using System;

/*Sales= Int * fee * 12%
	- Ship = Int * fee * 5%
	- Total_money = Int * fee – Sales + Ship
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

            Console.WriteLine("Input Int: ");
            int Int = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Ship: ");
            int Ship = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Sales = Int * fee * 12 / 100;
            Ship = Int * fee * 5 / 100;
            float Total_money = Int * fee - Sales + Ship;
            Console.WriteLine(Sales);
            Console.WriteLine(Ship);
            Console.WriteLine(Total_money);
        }
    }
}
