using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (char value in input)
            {
                if (value == ' ')
                {
                    continue;
                }

                if (!occurrences.ContainsKey(value))
                {
                    occurrences.Add(value, 0);
                }

                occurrences[value]++;
            }

            foreach (var occurrence in occurrences)
            {
                Console.WriteLine($"{occurrence.Key} -> {occurrence.Value}");
            }
        }
    }
}
