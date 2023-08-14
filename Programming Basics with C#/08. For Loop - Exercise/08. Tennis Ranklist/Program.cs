using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int totalPoints = initialPoints ;
            int wins = 0;
            int finals = 0;
            int semifinals = 0;
            double victories = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    totalPoints += 2000;
                    wins += 2000;
                    victories += 1;
                }

                else if (result == "F")
                {
                    totalPoints += 1200;
                    finals += 1200;
                }

                else if (result == "SF")
                {
                    totalPoints += 720;
                    semifinals += 720;
                }
            }

            double total = finals + wins + semifinals;
            double average = total / tournaments;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{victories / tournaments * 100:f2}%");
        }
    }
}
