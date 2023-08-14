using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            var phoneNumbers = Regex.Matches(phones, pattern);

            var matchedPhones = phoneNumbers
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
