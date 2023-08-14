using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})(\1)";
            int points = 0;
            List<string>locations = new List<string>();

            foreach (Match m in Regex.Matches(line, pattern))
            {
                string location = m.Groups[2].Value;
                points += location.Length;
                locations.Add(location);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
