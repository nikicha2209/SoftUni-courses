using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Start()
            => "Engine start";

        public string Stop()
            => "Breaaak!";

        public override string ToString()
        => $"{Color} Tesla {Model} with {Battery} Batteries" + Environment.NewLine +
           Start() + Environment.NewLine +
           Stop();
    }
}
