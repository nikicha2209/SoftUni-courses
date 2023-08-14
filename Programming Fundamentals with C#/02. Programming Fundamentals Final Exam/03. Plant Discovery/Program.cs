using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Rate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            List<string> plantOrder = new List<string>(); // To store the order of the plants

            int n = int.Parse(Console.ReadLine());
            string input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] tokens = input.Split("<->");
                string plantName = tokens[0];
                int rarity = int.Parse(tokens[1]);

                plants[plantName] = new Plant { Name = plantName, Rarity = rarity, Rate = new List<int>() };
                plantOrder.Add(plantName); // Store the order of the plant entry
            }

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] tokens = input.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (!plants.ContainsKey(tokens[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                string plantName = tokens[1];

                if (tokens[0] == "Rate")
                {
                    int rating = int.Parse(tokens[2]);
                    plants[plantName].Rate.Add(rating);
                }

                else if (tokens[0] == "Update")
                {
                    int newRarity = int.Parse(tokens[2]);
                    plants[plantName].Rarity = newRarity;
                }

                else if (tokens[0] == "Reset")
                {
                    plants[plantName].Rate.Clear();
                }

            }

            Console.WriteLine("Plants for the exhibition: ");
            foreach (var plantName in plantOrder)
            {
                Plant plant = plants[plantName];
                double averageRating = plant.Rate.Count > 0 ? plant.Rate.Average() : 0;
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {averageRating:f2}");
            }
        }
    }
}