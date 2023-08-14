using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isTrue = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTrue = false;
                    }

                    if (isTrue)
                    {
                        Console.Write(numbers[i] + " ");
                        break;
                    }
                }
            }

            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
