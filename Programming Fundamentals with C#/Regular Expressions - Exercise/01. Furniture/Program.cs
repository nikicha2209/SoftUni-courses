using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{

    class Furniture
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnituresList = new List<Furniture>();

            string pattern = @">>(?<FurnitureName>[A-Za-z]+)<<(?<Price>\d+|\d+.\d+)!(?<Quantity>\d+)";
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Purchase")
            {
                foreach (Match m in Regex.Matches(line, pattern))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = m.Groups["FurnitureName"].Value;
                    furniture.Price = double.Parse(m.Groups["Price"].Value);
                    furniture.Quantity = int.Parse(m.Groups["Quantity"].Value);
                    furnituresList.Add(furniture);
                }
            }

            Console.WriteLine("Bought furniture:");
            double total = 0;

            foreach (Furniture f in furnituresList)
            {
                Console.WriteLine(f.Name);
                total += f.Price * f.Quantity;
            }

            Console.WriteLine($"Total money spend: {total:f2}");


        }
    }
}
