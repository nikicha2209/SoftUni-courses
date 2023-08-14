using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([0-9]{2})([--/])([A-Z][a-z][a-z])\2(\d{4})\b";
            string input = Console.ReadLine();
            var dates = Regex.Matches(input, regex);
            //13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f, 25.Dec.1937 23/09/1973, 1/Feb/2016

            foreach (Match date in dates)
            { 
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
