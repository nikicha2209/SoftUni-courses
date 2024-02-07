using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            double fuelToUse = distance * FuelConsumptionPerKilometer;
            if (this.FuelAmount - fuelToUse < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            else
            {
                this.FuelAmount -= fuelToUse;
                this.TravelledDistance += distance;
            }
        }
    }
}
