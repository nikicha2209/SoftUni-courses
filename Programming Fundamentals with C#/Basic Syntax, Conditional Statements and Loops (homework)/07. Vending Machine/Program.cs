using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            decimal totalMoney = 0.0m;

            while ((input = Console.ReadLine()) != "Start")
            {
                decimal coin = decimal.Parse(input);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1.0m || coin == 2.0m)
                {
                    totalMoney += coin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Nuts")
                {
                    if (totalMoney >= 2.0m)
                    {
                        Console.WriteLine("Purchased nuts");
                        totalMoney -= 2;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }

                else if (input == "Water")
                {
                    if (totalMoney >= 0.7m)
                    {
                        Console.WriteLine("Purchased water");
                        totalMoney -= 0.7m;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }

                else if (input == "Crisps")
                {
                    if (totalMoney >= 1.5m)
                    {
                        Console.WriteLine("Purchased crisps");
                        totalMoney -= 1.5m;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }

                else if (input == "Soda")
                {
                    if (totalMoney >= 0.8m)
                    {
                        Console.WriteLine("Purchased soda");
                        totalMoney -= 0.8m;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }

                else if (input == "Coke")
                {
                    if (totalMoney >= 1.0m)
                    {
                        Console.WriteLine("Purchased coke");
                        totalMoney -= 1.0m;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");

        }
    }
}
