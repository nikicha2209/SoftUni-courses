using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double graphicsCards = double.Parse(Console.ReadLine());
            double processors = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            int graphicsCardPrice = 250;
            double processorPrice = 0.35 * graphicsCardPrice  * graphicsCards ;
            double ramPrice = 0.1 * graphicsCardPrice  * graphicsCards ;
            double total = graphicsCardPrice  * graphicsCards  + processors  * processorPrice  + ram  * ramPrice ;

            if (graphicsCards  > processors )
            {
                total  = total  * 0.85;
            }

            if (budget >= total )
            {
                double leftOver = budget - total ;
                Console.WriteLine($"You have {leftOver :f2} leva left!");
            }

            else
            {
                double insufficient = total  - budget;
                Console.WriteLine($"Not enough money! You need {insufficient :f2} leva more!");
            }

        }
    }
}
