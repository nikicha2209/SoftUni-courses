namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                Car car = new Car(line[0], double.Parse(line[1]), double.Parse(line[2]));
                cars.Add(car);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string carModel = tokens[1];
                int km = int.Parse(tokens[2]);
                Car searchedCar = cars.Find(car => car.Model == carModel);
                searchedCar.Drive(km);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}