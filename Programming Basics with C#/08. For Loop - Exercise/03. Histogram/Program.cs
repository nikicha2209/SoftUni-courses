using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int current = 0;

            for (int i = 0; i < n; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current < 200)
                {
                    p1 += 1;
                }

                else if (current >= 200 && current < 400)
                {
                    p2 += 1;
                }

                else if (current >= 400 && current < 600)
                {
                    p3 += 1;
                }

                else if (current >= 600 && current < 800)
                {
                    p4 += 1;
                }

                else if (current >= 800)
                {
                    p5 += 1;
                }
            }

            double p1Percentage = p1 / n * 100;
            double p2Percentage = p2 / n * 100;
            double p3Percentage = p3 / n * 100;
            double p4Percentage = p4 / n * 100;
            double p5Percentage = p5 / n * 100;

            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
            Console.WriteLine($"{p4Percentage:f2}%");
            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}
