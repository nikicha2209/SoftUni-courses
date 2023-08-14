using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int number)
        {
            int evenDigitsSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    evenDigitsSum += digit;
                }

            }

            return evenDigitsSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddDigitsSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 1)
                {
                    oddDigitsSum += digit;
                }

            }

            return oddDigitsSum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
    }
}
