using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Car
{

    private string _make;

    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }


    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }


    private int _year;

    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }



}

