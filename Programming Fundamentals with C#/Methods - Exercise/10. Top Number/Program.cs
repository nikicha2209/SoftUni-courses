using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsSumOfItsDigitsDivisbleBy8(number);
            HasOddDigit(number);

            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (IsSumOfItsDigitsDivisbleBy8(number) && HasOddDigit(number))
            {
                return true;
            }

            return false;
        }

        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 1)
                {
                    return true;
                    break;
                }
                number /= 10;
            }

            return false;
        }

        static bool IsSumOfItsDigitsDivisbleBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
