using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm + 1.6)
        { }

        public override void Refuel(double liters)
        {
            base.Refuel(liters*0.95);
        }
    }
}
