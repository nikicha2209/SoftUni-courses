using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int shorterList = 0;
            int longerList = 0;
            if (firstList.Count == secondList.Count)
            {
                shorterList = firstList.Count;
                longerList = firstList.Count;
            }

            else if (firstList.Count > secondList.Count)
            {
                shorterList = secondList.Count;
                longerList = firstList.Count;
            }

            else
            {
                shorterList = firstList.Count;
                longerList = secondList.Count;
            }

            for (int i = 0; i < shorterList; i++)
            {
                Console.Write(firstList[i] + " ");
                Console.Write(secondList[i] + " ");
            }

            for (int i = shorterList; i < longerList; i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    Console.Write(firstList[i] + " ");
                }

                else
                {
                    Console.Write(secondList[i] + " ");
                }
            }
        }
    }
}
