using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Purchase
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<customerName>[A-Z][a-z]+)\%[^|$%.]*\<(?<productName>[\w]+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(?:\.\d+)?)\$$";
            string line = string.Empty;

            List<Purchase> purchases = new List<Purchase>();

            while ((line = Console.ReadLine()) != "end of shift")
            {

                foreach (Match match in Regex.Matches(line, pattern))
                {
                    Purchase purchase = new Purchase();

                    purchase.CustomerName = match.Groups["customerName"].Value;
                    purchase.ProductName = match.Groups["productName"].Value;
                    purchase.Count = int.Parse(match.Groups["count"].Value);
                    purchase.Price = double.Parse(match.Groups["price"].Value);

                    purchases.Add(purchase);
                }
            }

            double totalPrice = 0;

            foreach (Purchase purchase in purchases)
            {
                totalPrice += purchase.Price * purchase.Count;
                Console.WriteLine($"{purchase.CustomerName}: {purchase.ProductName} - {purchase.Count*purchase.Price:f2}");
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");

        }

    }
}
