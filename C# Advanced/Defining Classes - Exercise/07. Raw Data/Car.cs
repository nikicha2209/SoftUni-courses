using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string[] carInfo)
        {
            Model = carInfo[0];

            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            Engine engine = new Engine(engineSpeed, enginePower);
            Engine = engine;

            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];
            Cargo cargo = new Cargo(cargoType, cargoWeight);
            Cargo = cargo;

            Tires = new Tire[4];

            for (int i = 0; i < 4; i++)
            {
                double pressure = double.Parse(carInfo[5 + i]);
                double age = double.Parse(carInfo[6 + i]);
                Tires[i] = new Tire(pressure, age);
            }


        }
    }

}
