using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace _06._Cards_Game
{
    internal class Program
    {
        private static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (first.Count > 0 && second.Count > 0)
            {
                int playerOneCard = first[0];
                int playerTwoCard = second[0];

                if (playerOneCard > playerTwoCard)
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                    first.Add(playerTwoCard);
                    first.Add(playerOneCard);
                }
                else if (playerTwoCard > playerOneCard)
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                    second.Add(playerOneCard);
                    second.Add(playerTwoCard);
                }
                else
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
            }

            if (first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(first)}");
            }
            else if (second.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(second)}");
            }
            else
            {
                Console.WriteLine("No player wins! Sum: 0");
            }
        }
    }
}

