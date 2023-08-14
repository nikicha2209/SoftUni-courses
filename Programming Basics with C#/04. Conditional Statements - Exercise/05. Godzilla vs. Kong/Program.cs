using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decor = 0.1 * budget ;
            clothingPrice  = clothingPrice  * actors ;

            if (actors  > 150)
            {
                clothingPrice  = clothingPrice  - 0.1 * clothingPrice ;
            }

            if (budget  >= decor + clothingPrice )
            {
                double remaining = budget  - (decor + clothingPrice );
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {remaining :f2} leva left.");
            }

            else
            {
                double insufficient = (decor + clothingPrice ) - budget ;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {insufficient :f2} leva more. ");
            }
        }
    }
}
