using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Vehicles_Extension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        { }

        public override void Drive(double km)
        {
            LitersPerKm += 1.4;
            base.Drive(km);
            LitersPerKm -= 1.4;
        }

        public void DriveEmpty(double km)
        {
            base.Drive(km);
        }

    }
}
