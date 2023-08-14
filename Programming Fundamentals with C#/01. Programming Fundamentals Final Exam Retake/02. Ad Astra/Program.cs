using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Product
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }

        public Product(string productName, string date, int calories)
        {
            Name = productName;
            Date = date;
            Calories = calories;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string line = Console.ReadLine();
            string pattern = @"(#|\|)(?<productName>[A-Za-z\s]+)(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d+)(\1)";
            int totalCalories = 0;

            foreach (Match match in Regex.Matches(line, pattern))
            {
                string productName = match.Groups[5].Value;
                string date = match.Groups[6].Value;
                int calories = int.Parse(match.Groups[7].Value);
                totalCalories += calories;

                Product product = new Product(productName, date, calories);
                products.Add(product);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Product product in products)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.Date}, Nutrition: {product.Calories}");
            }
        }
    }
}
