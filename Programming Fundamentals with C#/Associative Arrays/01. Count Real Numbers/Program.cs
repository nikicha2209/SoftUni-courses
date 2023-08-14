using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbersDictionary = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {
                if(!numbersDictionary.ContainsKey(number))
                {
                    numbersDictionary.Add(number, 0);
                }

                numbersDictionary[number]++;
            }

            foreach (var number in numbersDictionary)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
