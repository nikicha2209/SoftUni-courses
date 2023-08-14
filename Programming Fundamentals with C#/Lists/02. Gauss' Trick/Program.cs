using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count- i -1]);
            }

            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count/2]);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
