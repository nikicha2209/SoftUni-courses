namespace _08._Car_Salesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);
                switch (engineData.Length)
                {
                    case 2:
                        {
                            Engine engine = new Engine(model, power, -1, "n/a");
                            engines.Add(engine);
                            break;
                        }

                    case 3:
                        {
                            string item = engineData[2];
                            if (int.TryParse(item, out _))
                            {
                                Engine engine = new Engine(model, power, int.Parse(item), "n/a");
                                engines.Add(engine);

                            }

                            else
                            {
                                Engine engine = new Engine(model, power, -1, item);
                                engines.Add(engine);
                            }

                            break;
                        }

                    case 4:
                        {
                            int displacement = int.Parse(engineData[2]);
                            string efficiency = engineData[3];
                            Engine engine = new Engine(model, power, displacement, efficiency);
                            engines.Add(engine);
                            break;
                        }

                }

            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                Engine engine = engines.Find(engine => engine.Model == carData[1]);
                switch (carData.Length)
                {
                    case 2:
                        {
                            Car car = new Car(model, engine, -1, "n/a");
                            cars.Add(car);
                            break;
                        }

                    case 3:
                        {
                            string item = carData[2];
                            if (int.TryParse(item, out _))
                            {
                                Car car = new Car(model, engine, int.Parse(item), "n/a");
                                cars.Add(car);

                            }

                            else
                            {
                                Car car = new Car(model, engine, -1, item);
                                cars.Add(car);
                            }

                            break;
                        }

                    case 4:
                        {
                            int weight = int.Parse(carData[2]);
                            string color = carData[3];
                            Car car = new Car(model, engine, weight, color);
                            cars.Add(car);
                            break;
                        }

                }

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == -1)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }

                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == -1)
                {
                    Console.WriteLine($"  Weight: n/a");
                }

                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");

            }


        }
    }
}