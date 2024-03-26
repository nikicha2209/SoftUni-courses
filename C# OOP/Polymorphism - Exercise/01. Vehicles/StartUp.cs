using _01._Vehicles;

namespace _01._Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]));

            string[] truckInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string vehicleType = tokens[1];
                double value = double.Parse(tokens[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }

                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                }

                else if (command == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }

                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }

                
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}

