using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzles  * 2.60 + dolls  * 3 + teddyBears  * 4.1 + minions  * 8.2 + trucks  * 2;
            double totalQuantity = puzzles  + dolls  + teddyBears  + minions  + trucks ;

            if (totalQuantity >= 50)
            {
                total = 0.75 * total;
            }

            double rent = 0.1 * total;
            double withoutRent = total - rent;

            if (withoutRent >= tripPrice)
            {
                double remaining = withoutRent - tripPrice;
                Console.WriteLine($"Yes! {remaining :f2} lv left.");
            }

            else
            {
                double insufficient = tripPrice - withoutRent;
                Console.WriteLine($"Not enough money! {insufficient:f2} lv needed.");
            }
        }
    }
}
