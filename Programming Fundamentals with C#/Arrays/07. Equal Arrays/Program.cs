using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

                if (numbers[i] == numbers2[i])
                {
                    counter++;
                    sum += numbers[i];
                }
            }



            if (counter == numbers.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
