using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int biggestNumber = 0;
            int bestCountSymbol = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int count = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;

                        if (count > biggestNumber)
                        {
                            biggestNumber = count;
                            bestCountSymbol = numbers[i];
                        }
                    }

                    else
                    {
                        break;
                    }

                }
            }

            for (int i = 0; i < biggestNumber; i++)
            {
                Console.Write($"{bestCountSymbol} ");
            }


        }
    }
}
