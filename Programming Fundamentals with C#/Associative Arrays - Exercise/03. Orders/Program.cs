using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            Dictionary<string, int> nameAndQuantities = new Dictionary<string, int>();
            string line;

            while ((line = Console.ReadLine()) != "buy")
            {

                string[] arguments = line.Split();
                string name = arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                double totalPrice = price * quantity;

                if (!products.ContainsKey(name))
                {
                    products[name] = totalPrice;
                    nameAndQuantities[name] = quantity;
                }

                else
                {
                    nameAndQuantities[name] += quantity;
                    products[name] = nameAndQuantities[name] * price;
                }

            }

            foreach (KeyValuePair<string, double> item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }
}
