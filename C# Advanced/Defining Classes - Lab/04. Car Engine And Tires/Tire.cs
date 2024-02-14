using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Tire
{
	private int _year;
	public int Year
	{
		get =>  _year; 
		set => _year = value; 
	}


	private double _pressure;
	public double Pressure
	{
		get =>  _pressure; 
		set => _pressure = value; 
	}

    public Tire(int year, double pressure )
    {
        Year = year;
		Pressure = pressure;
    }
}

