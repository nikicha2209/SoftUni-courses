using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int primeSum = 0;
            int compositeSum = 0;
            bool isItPrime = false;

            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i < number; i++)
                {
                    isItPrime = false;

                    if (number % i == 0)
                    {
                        isItPrime = true;
                        break;
                    }
                }

                if (isItPrime && number != 0)
                {
                    compositeSum += number;
                }

                else
                {
                    primeSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compositeSum}");
        }
    }
}
