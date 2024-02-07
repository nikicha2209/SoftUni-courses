namespace _07._Raw_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();
                Car car = new Car(carData);
                cars.Add(car);
            }

            string line = Console.ReadLine();
            if (line == "fragile")
            {
                foreach (Car car in cars.Where(c =>
                             c.Cargo.Type == "fragile" &&
                             c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }

            else if (line == "flammable")
            {
                foreach (Car car in cars.Where(car=>
                             car.Cargo.Type == "flammable" &&
                             car.Engine.Power >250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}