using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            double episodeDuration = double.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            double mealTime = 0.125 * breakDuration ;
            double restTime = 0.25 * breakDuration ;

            if (breakDuration  >= mealTime  + restTime  + episodeDuration )
            {
                double remainingTime = breakDuration  - (mealTime  + restTime  + episodeDuration );
                Console.WriteLine($"You have enough time to watch {seriesName } and left with {Math.Ceiling(remainingTime )} minutes free time.");
            }

            else
            {
                double insufficientTime = mealTime  + restTime  + episodeDuration  - breakDuration ;
                Console.WriteLine($"You don't have enough time to watch {seriesName }, you need {Math.Ceiling(insufficientTime )} more minutes.");
            }
        }
    }
}
