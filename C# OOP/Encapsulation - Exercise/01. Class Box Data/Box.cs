using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => length;
            set
            {
                if (value > 0)
                {
                    length = value;
                }

                else
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
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

                else
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value > 0)
                {
                    height = value;
                }

                else
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
            }
        }

        public Box(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public double SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }

        public double LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return 2 * Length * Height + 2 * Width * Height;
        }

        public double Volume()
        {
            return Length * Width * Height;
        }

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():f2}" + Environment.NewLine +
            $"Lateral Surface Area - {LateralSurfaceArea():f2}"+ Environment.NewLine + 
            $"Volume - {Volume():f2}";
        }
    }
}
