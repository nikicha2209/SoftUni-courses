using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Vehicles_Extension
{
    public class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }
        public double TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            LitersPerKm = litersPerKm;
            TankCapacity = tankCapacity;

            if (fuelQuantity <= tankCapacity)
            {
                FuelQuantity = fuelQuantity;
            }


        }

        public virtual void Drive(double km)
        {
            double newFuel = FuelQuantity - LitersPerKm * km;

            if (newFuel < 0)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }

            else
            {
                FuelQuantity = newFuel;
                Console.WriteLine($"{GetType().Name} travelled {km} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }

            else
            {
                FuelQuantity += liters;
            }
        }

        public override string ToString()
            => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
