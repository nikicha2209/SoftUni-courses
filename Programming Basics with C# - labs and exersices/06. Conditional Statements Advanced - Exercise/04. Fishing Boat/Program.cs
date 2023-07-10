using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            double rental = 0;

            if (season  == "Spring")
            {
                rental  = 3000;
            }

            else if (season  == "Summer" || season  == "Autumn")
            {
                rental  = 4200;
            }

            else if (season  == "Winter")
            {
                rental  = 2600;
            }

            if (fishermenCount  <= 6)
            {
                rental  = rental  - rental  * 0.1;
            }

            else if (fishermenCount  >= 7 && fishermenCount  <= 11)
            {
                rental  = rental  - rental  * 0.15;
            }

            else if (fishermenCount  >= 12)
            {
                rental  = rental  - rental  * 0.25;
            }

            double remainingMoney = 0;
            double insufficientMoney = 0;


            if (fishermenCount  % 2 == 0 && season  != "Autumn")
            {
                rental  = rental  - 0.05 * rental ;
            }

            if (budget  >= rental )
            {
                remainingMoney  = budget  - rental ;
                Console.WriteLine($"Yes! You have {remainingMoney :f2} leva left.");
            }

            else
            {
                insufficientMoney  = rental  - budget ;
                Console.WriteLine($"Not enough money! You need {insufficientMoney :f2} leva.");
            }

        }
    }
}
