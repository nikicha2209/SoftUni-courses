using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Vehicle
    {

        public int HorsePower { get; set; }
        public double DefaultFuelConsumption  { get; set; }
        public virtual double FuelConsumption { get { return this.DefaultFuelConsumption; } }
        public double Fuel { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}
