using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    enum Type
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Type Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }

        public Vehicle(string type, string model, string color, string hp)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            Model = model;
            Color = color;
            HP = int.Parse(hp);
        }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HP}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<Vehicle> vehicles = new List<Vehicle>();

            while ((line = Console.ReadLine()) != "End")
            {
                string[] command = line.Split();
                Vehicle vehicle = new Vehicle(command[0], command[1], command[2], command[3]);
                vehicles.Add(vehicle);
            }


            while ((line = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle found = vehicles.FirstOrDefault(v => v.Model == line);
                if (found != null)
                {
                    Console.WriteLine(found);
                }
            }

            double averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Car)
                .Select(vehicle => vehicle.HP)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Truck)
                .Select(vehicle => vehicle.HP)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");

        }
    }
}
