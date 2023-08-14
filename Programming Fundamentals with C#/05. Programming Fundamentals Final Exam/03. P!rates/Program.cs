using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._P_rates
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int AmountOfGold { get; set; }

        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            AmountOfGold = gold;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            string firstLine = string.Empty;

            while ((firstLine = Console.ReadLine()) != "Sail")
            {
                string[] tokens = firstLine.Split("||");
                string name = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (cities.Any(x => x.Name == name))
                {
                    var dublicateCity = cities.First(x => x.Name == name);
                    dublicateCity.Population += population;
                    dublicateCity.AmountOfGold += gold;
                }

                else
                {
                    City city = new City(name, population, gold);
                    cities.Add(city);
                }
            }

            string secondLine = string.Empty;
            while ((secondLine = Console.ReadLine()) != "End")
            {
                string[] tokens = secondLine.Split("=>");
                string command = tokens[0];

                if (command == "Plunder")
                {
                    string town = tokens[1];
                    int population = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);
                    var currentCity = cities.FirstOrDefault(x => x.Name == town);

                    if (currentCity.Population >= population && currentCity.AmountOfGold >= gold && currentCity != null)
                    {
                        currentCity.Population -= population;
                        currentCity.AmountOfGold -= gold;
                        Console.WriteLine($"{currentCity.Name} plundered! {gold} gold stolen, {population} citizens killed.");
                    }

                    if (currentCity.Population <= 0 || currentCity.AmountOfGold <= 0)
                    {
                        cities.Remove(currentCity);
                        Console.WriteLine($"{currentCity.Name} has been wiped off the map!");
                    }
                }

                else if (command == "Prosper")
                {
                    string town = tokens[1];
                    int gold = int.Parse(tokens[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }

                    else
                    {
                        var currentCity = cities.FirstOrDefault(x => x.Name == town);

                        if (currentCity != null)
                        {
                            currentCity.AmountOfGold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {currentCity.Name} now has {currentCity.AmountOfGold} gold.");
                        }
                    }
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.AmountOfGold} kg");
                }
            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }



        }
    }
}
