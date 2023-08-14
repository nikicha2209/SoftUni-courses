using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string firstWord = input[0];
            string secondWord = input[1];

            int sum = 0;

            int longer = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < longer; i++)
            {

                if (i < firstWord.Length && i < secondWord.Length)
                {
                    sum += firstWord[i] * secondWord[i];
                }

                else if (i < firstWord.Length)
                {
                    sum += firstWord[i];
                }

                else if (i < secondWord.Length)
                {
                    sum += secondWord[i];
                }
            }

            Console.WriteLine(sum);
        }

    }
}
