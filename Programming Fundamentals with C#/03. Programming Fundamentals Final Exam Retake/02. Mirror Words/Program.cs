using System;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\@|\#)(?<firstWord>[A-Za-z]{3,})\1";

            foreach (Match match in Regex.Matches(input, pattern))
            {

            }
        }
    }
}
