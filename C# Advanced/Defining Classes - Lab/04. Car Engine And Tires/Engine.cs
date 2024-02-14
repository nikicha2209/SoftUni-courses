using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
		private int _horsePower;

		public int HorsePower
		{
			get => _horsePower; 
			set => _horsePower = value;
        }


		private double _cubicCapacity;

		public double CubicCapacity
        {
			get => _cubicCapacity;
            set => _cubicCapacity = value;
        }

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }




	}
}
