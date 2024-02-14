using System.Text;

namespace CarManufacturer;

public class Car
{

    private string _make;
    public string Make
    {
        get => _make;

        set => _make = value;
    }


    private string _model;
    public string Model
    {
        get => _model;

        set => _model = value;
    }


    private int _year;
    public int Year
    {
        get => _year;

        set => _year = value;
    }


    private double _fuelQuantity;
    public double FuelQuantity
    {
        get => _fuelQuantity;

        set => _fuelQuantity = value;
    }


    private double _fuelConsumption;
    public double FuelConsumption
    {
        get => _fuelConsumption;

        set => _fuelConsumption = value;
    }


    public Car()
    {
        this.Make = "VW";
        this.Model = "Golf";
        this.Year = 2025;
        this.FuelQuantity = 200;
        this.FuelConsumption = 10;
    }

    public Car(string make, string model, int year) : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public void Drive(double distance)
    {
        if (distance * _fuelConsumption > _fuelQuantity)
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }

        else
        {
            _fuelQuantity -= distance * _fuelConsumption;
        }
    }

    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.AppendLine($"Fuel: {this.FuelQuantity:f2}");
        return sb.ToString().Trim();
    }
}