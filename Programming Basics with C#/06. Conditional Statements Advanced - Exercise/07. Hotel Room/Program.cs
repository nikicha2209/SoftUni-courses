using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio;
            double aparatment;

            if (month == "May" || month == "October")
            {
                studio = 50;
                aparatment = 65;
                if (nights > 7 && nights < 14)
                {
                    studio = studio * 0.95;
                }

                else if (nights > 14)
                {
                    studio = studio * 0.7;
                    aparatment = aparatment * 0.9;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = 75.2;
                aparatment = 68.7;

                if (nights > 14)
                {
                    aparatment = aparatment * 0.9;
                    studio = studio * 0.8;
                }
            }

            else
            {
                studio = 76;
                aparatment = 77;

                if (nights > 14)
                {
                    aparatment = 0.9 * aparatment;
                }
            }

            Console.WriteLine($"Apartment: {(aparatment * nights):f2} lv.");
            Console.WriteLine($"Studio: {(studio * nights):f2} lv.");
        }
    }
}
