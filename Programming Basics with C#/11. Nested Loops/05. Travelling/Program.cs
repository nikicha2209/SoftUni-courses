using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination  != "End")
            {
                double requiredSum= double.Parse(Console.ReadLine());
                double total = 0;

                while (total < requiredSum)
                {
                    double savings = double.Parse(Console.ReadLine());
                    total += savings ;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
