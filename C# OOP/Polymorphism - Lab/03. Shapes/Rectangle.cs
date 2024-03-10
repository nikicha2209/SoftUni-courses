using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height 
        { 
            get => height;
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        public double Width 
        { 
            get => width;
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
            => 2 * Width + 2 * Height;

        public override double CalculateArea()
            => Width * Height;

        public override string Draw() 
            => base.Draw() + GetType().Name;
        
    }
}
