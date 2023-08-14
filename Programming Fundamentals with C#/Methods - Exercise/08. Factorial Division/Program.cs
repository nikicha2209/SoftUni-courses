using System;
using System.Collections.Generic;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double firstFactorial = FactorialFirstNumber(first);
            double secondFactorial = FactorialSecondNumber(second);
            Console.WriteLine($"{firstFactorial/secondFactorial:f2}");

        }
        static double FactorialFirstNumber(double first)
        {
            double result = 1;
            for (double i = 1; i <= first; i++)
            {
                result *= i;
            }

            return result;
        }

        static double FactorialSecondNumber(double second)
        {
            double result = 1;
            for (double i = 1; i <= second; i++)
            {
                result *= i;
            }

            return result;
        }

        static double DivideTheFirstResultAndTheSecond(double first, double second)
        {
            return first / second;
        }
    }
}
