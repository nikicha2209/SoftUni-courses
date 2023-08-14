using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }

    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split('/');
                Catalog catalog = new Catalog();

                if (tokens[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = tokens[1];
                    car.Model = tokens[2];
                    car.HP = int.Parse(tokens[3]);
                    catalog.Cars.Add(car);
                }

               else if (tokens[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = tokens[1];
                    truck.Model = tokens[2];
                    truck.Weight = int.Parse(tokens[3]);
                    catalog.Trucks.Add(truck);
                }
            }

            Console.WriteLine(1);
        }
    }
}
