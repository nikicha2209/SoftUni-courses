using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double coffeePrice = 0;
            double waterPrice = 0;
            double beerPrice = 0;
            double sweetsPrice = 0;
            double nutsPrice = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    coffeePrice = 0.5;
                    Console.WriteLine(coffeePrice * quality);
                }

                else if (product == "water")
                {
                    waterPrice = 0.8;
                    Console.WriteLine(waterPrice * quality);
                }

                else if (product == "beer")
                {
                    beerPrice = 1.2;
                    Console.WriteLine(beerPrice * quality);
                }

                else if (product == "sweets")
                {
                    sweetsPrice = 1.45;
                    Console.WriteLine(sweetsPrice * quality);
                }

                else if (product == "peanuts")
                {
                    nutsPrice = 1.6;
                    Console.WriteLine(nutsPrice * quality);
                }

            }

            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    coffeePrice = 0.4;
                    Console.WriteLine(coffeePrice * quality);
                }

                else if (product == "water")
                {
                    waterPrice = 0.7;
                    Console.WriteLine(waterPrice * quality);
                }

                else if (product == "beer")
                {
                    beerPrice = 1.15;
                    Console.WriteLine(beerPrice * quality);
                }

                else if (product == "sweets")
                {
                    sweetsPrice = 1.3;
                    Console.WriteLine(sweetsPrice * quality);
                }

                else if (product == "peanuts")
                {
                    nutsPrice = 1.5;
                    Console.WriteLine(nutsPrice * quality);
                }

            }

            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    coffeePrice = 0.45;
                    Console.WriteLine(coffeePrice * quality);
                }

                else if (product == "water")
                {
                    waterPrice = 0.7;
                    Console.WriteLine(waterPrice * quality);
                }

                else if (product == "beer")
                {
                    beerPrice = 1.1;
                    Console.WriteLine(beerPrice * quality);
                }

                else if (product == "sweets")
                {
                    sweetsPrice = 1.35;
                    Console.WriteLine(sweetsPrice * quality);
                }

                else if (product == "peanuts")
                {
                    nutsPrice = 1.55;
                    Console.WriteLine(nutsPrice * quality);
                }

            }
        }
    }
}
