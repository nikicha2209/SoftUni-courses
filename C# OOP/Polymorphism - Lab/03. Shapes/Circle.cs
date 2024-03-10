using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
            => 2 * Math.PI * Radius;

        public override double CalculateArea()
            => Math.PI * Math.Pow(Radius, 2);


        public override string Draw()
            => base.Draw() + GetType().Name;
    }
}
