using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                total += quantitiesOfWater;

                if (total > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    total -= quantitiesOfWater;
                }
            }

            Console.WriteLine(total);
        }
    }
}
