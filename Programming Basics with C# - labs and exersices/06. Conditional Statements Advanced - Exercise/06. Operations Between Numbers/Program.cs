using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double result;

            if (sign == '+')
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }

            }

            else if (sign == '-')
            {
                result = number1 - number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }

            else if (sign == '*')
            {
                result = number1 * number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }

            else
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }

                else if (sign == '/')
                {
                    result = (double)number1 / number2;
                    Console.WriteLine($"{number1} / {number2} = {result:f2}");
                }

                else
                {
                    result = number1 % number2;
                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }
        }
    }
}
