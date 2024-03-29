﻿

namespace _02._Vehicles_Extension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]), double.Parse(carInformation[3]));

            string[] truckInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]), double.Parse(truckInformation[3]));

            string[] busInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(busInformation[1]), double.Parse(busInformation[2]), double.Parse(busInformation[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string vehicleType = tokens[1];
                double value = double.Parse(tokens[2]);

                if (command == "Drive")
                {
                    switch (vehicleType)
                    {
                        case "Car": car.Drive(value); break;
                        case "Truck": truck.Drive(value); break;
                        case "Bus": bus.Drive(value); break;
                    }
                }
                else if (command == "Refuel")
                {
                    switch (vehicleType)
                    {
                        case "Car": car.Refuel(value); break;
                        case "Truck": truck.Refuel(value); break;
                        case "Bus": bus.Refuel(value); break;
                    }
                }
                else if (command == "DriveEmpty")
                {
                    bus.DriveEmpty(value);
                }


            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}

