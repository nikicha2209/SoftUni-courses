using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;

            double totalCost = 0;
            double remainingMoney = 0;


            if (flowerType  == "Roses")
            {
                if (flowerCount  > 80)
                {
                    totalCost  = rosePrice  * flowerCount ;
                    totalCost  = totalCost  * 0.9;
                }

                else
                {
                    totalCost  = rosePrice  * flowerCount ;
                }
            }

            else if (flowerType  == "Dahlias")
            {
                if (flowerCount  > 90)
                {
                    totalCost  = dahliaPrice  * flowerCount ;
                    totalCost  = totalCost  * 0.85;
                }

                else
                {
                    totalCost  = dahliaPrice  * flowerCount ;
                }
            }

            else if (flowerType  == "Tulips")
            {
                if (flowerCount  > 80)
                {
                    totalCost  = tulipPrice  * flowerCount ;
                    totalCost  = totalCost  * 0.85;
                }

                else
                {
                    totalCost  = tulipPrice  * flowerCount ;
                }
            }

            else if (flowerType  == "Narcissus")
            {
                if (flowerCount  < 120)
                {
                    totalCost  = narcissusPrice  * flowerCount ;
                    totalCost  = totalCost  * 1.15;
                }

                else
                {
                    totalCost  = narcissusPrice  * flowerCount ;
                }
            }

            else if (flowerType  == "Gladiolus")
            {
                if (flowerCount  < 80)
                {
                    totalCost  = gladiolusPrice  * flowerCount ;
                    totalCost  = totalCost  * 1.2;
                }
                else
                {
                    totalCost  = gladiolusPrice  * flowerCount ;
                }
            }

            if (totalCost  > budget )
            {
                remainingMoney  = totalCost  - budget ;
                Console.WriteLine($"Not enough money, you need {remainingMoney :f2} leva more.");
            }

            else
            {
                remainingMoney  = budget  - totalCost ;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount } {flowerType } and {remainingMoney :f2} leva left.");
            }
        }
    }
}
