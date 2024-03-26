using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Vehicles_Extension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + 1.6, tankCapacity)
        { }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if (FuelQuantity + liters * 0.95 > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }

            else
            {
                base.Refuel(liters * 0.95);
            }
            
        }

        
    }
}
