using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Vehicles
{
    public class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }

        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
        }

        public virtual void Drive(double km)
        {
            double newFuel = FuelQuantity - LitersPerKm * km;

            if (newFuel >= 0)
            {
                FuelQuantity = newFuel;
                Console.WriteLine($"{GetType().Name} travelled {km} km");
            }

            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
            => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
