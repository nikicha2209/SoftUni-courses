using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01._Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + 0.9)
        { }

        
    }
}
