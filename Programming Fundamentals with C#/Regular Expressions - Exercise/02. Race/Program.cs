using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participantsDictionary = new Dictionary<string, int>();

            List<string> participantsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end of race")
            {
                string patternName = @"[A-Za-z]";
                string patternDistance = @"\d";

                StringBuilder name = new StringBuilder();

                foreach (Match match in Regex.Matches(line, patternName))
                {
                    name.Append(match.Value);
                }

                if (!participantsList.Contains(name.ToString()))
                {
                    continue;
                }

                int totalDistance = 0;

                foreach (Match match in Regex.Matches(line, patternDistance))
                {
                    totalDistance += int.Parse(match.Value);
                }

                if (participantsDictionary.ContainsKey(name.ToString()))
                {
                    participantsDictionary[name.ToString()] += totalDistance;
                }

                else
                {
                    participantsDictionary.Add(name.ToString(), totalDistance);
                }

            }


            for (int i = 1; i <= 3; i++)
            {
                int searched = participantsDictionary.Values.Max();
                string searchedName = string.Empty;

                foreach (var pair in participantsDictionary)
                {
                    if (pair.Value == searched)
                    {
                        searchedName = pair.Key;
                        break;
                    }
                }

                if (i == 1)
                {
                    Console.WriteLine($"1st place: {searchedName}");
                }

                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {searchedName}");
                }

                else if (i == 3)
                {
                    Console.WriteLine($"3rd place: {searchedName}");
                }

                participantsDictionary.Remove(searchedName);
            }

        }
    }
}
