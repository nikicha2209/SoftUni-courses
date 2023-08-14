using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int current = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int numbersPerRow = 1; numbersPerRow <= row; numbersPerRow++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write($"{current} ");
                    current++;
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine("");

            }
        }
    }
}
