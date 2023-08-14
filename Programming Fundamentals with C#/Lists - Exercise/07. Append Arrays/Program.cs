using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|")
                .ToList();

            List<string> reversedNumbers = new List<string>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                string[] currentArray = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                reversedNumbers.AddRange(currentArray);
            }

            Console.WriteLine(string.Join(" ", reversedNumbers));
        }
    }
}
