using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double bananaPrice = 0;
            double applePrice = 0;
            double orangePrice = 0;
            double grapefruitPrice = 0;
            double kiwiPrice = 0;
            double pineapplePrice = 0;
            double grapesPrice = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    bananaPrice = 2.5;
                    double obshto = bananaPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "apple")
                {
                    applePrice = 1.2;
                    double obshto = applePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "orange")
                {
                    orangePrice = 0.85;
                    double obshto = orangePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "grapefruit")
                {
                    grapefruitPrice = 1.45;
                    double obshto = grapefruitPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "kiwi")
                {
                    kiwiPrice = 2.7;
                    double obshto = kiwiPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "pineapple")
                {
                    pineapplePrice = 5.5;
                    double obshto = pineapplePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "grapes")
                {
                    grapesPrice = 3.85;
                    double obshto = grapesPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    bananaPrice = 2.7;
                    double obshto = bananaPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "apple")
                {
                    applePrice = 1.25;
                    double obshto = applePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "orange")
                {
                    orangePrice = 0.9;
                    double obshto = orangePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "grapefruit")
                {
                    grapefruitPrice = 1.6;
                    double obshto = grapefruitPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "kiwi")
                {
                    kiwiPrice = 3;
                    double obshto = kiwiPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "pineapple")
                {
                    pineapplePrice = 5.6;
                    double obshto = pineapplePrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else if (fruit == "grapes")
                {
                    grapesPrice = 4.2;
                    double obshto = grapesPrice * quantity;
                    Console.WriteLine($"{obshto:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }


            else
            {
                Console.WriteLine("error");
            }
        }

    }
}

