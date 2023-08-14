using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                TotalPriceCoffee(product, quantity);
            }

            else if (product == "water")
            {
                TotalPriceWater(product, quantity);
            }

            else if (product == "coke")
            {
                TotalPriceCoke(product, quantity);
            }

            else if (product == "snacks")
            {
                TotalPriceSnacks(product, quantity);
            }
        }

        static void TotalPriceCoffee(string product, int quantity)
        {
            Console.WriteLine($"{1.5 * quantity:f2}");
        }

        static void TotalPriceWater(string product, int quantity)
        {
            Console.WriteLine($"{1 * quantity:f2}");
        }

        static void TotalPriceCoke(string product, int quantity)
        {
            Console.WriteLine($"{1.4 * quantity:f2}");
        }

        static void TotalPriceSnacks(string product, int quantity)
        {
            Console.WriteLine($"{2 * quantity:f2}");
        }
    }
}
