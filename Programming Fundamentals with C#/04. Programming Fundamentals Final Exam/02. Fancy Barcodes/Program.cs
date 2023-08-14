using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = string.Empty;
            string pattern = @"@#+(?<name>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();

                Match match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    string matchString = match.ToString();
                    string total = string.Empty;

                    foreach (char c in matchString)
                    {
                        if (char.IsDigit(c))
                        {
                            total += c;
                        }
                    }

                    if (total == string.Empty)
                    {
                        total = "00";
                    }

                    Console.WriteLine($"Product group: {total}");
                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
