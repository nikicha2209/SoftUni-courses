using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    public class Tire
    {
        public double Age { get; set; }
        public double Pressure { get; set; }

        public Tire(double age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }
    }
}
