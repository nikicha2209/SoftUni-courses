using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string wordToLower = word.ToLower();
                if (!counts.ContainsKey(wordToLower))
                {
                    counts.Add(wordToLower, 0);
                }

                counts[wordToLower]++;
            }

            foreach (var value in counts)
            {
                if (value.Value % 2 == 1)
                {
                    Console.Write($"{value.Key} ");
                }   
            }
        }
    }
}
