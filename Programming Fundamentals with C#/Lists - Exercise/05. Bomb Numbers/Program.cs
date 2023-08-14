using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialNumberAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNumber = specialNumberAndPower[0];
            int power = specialNumberAndPower[1];

            // Input example:
            // 1 2 2 4 2 2 2 9
            // 4 2


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = i - power;

                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + power + 1;

                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers.RemoveAt(start);
                    }

                    i--;

                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
