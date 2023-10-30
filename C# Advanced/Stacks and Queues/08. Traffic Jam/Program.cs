namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = string.Empty;
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while ((line = Console.ReadLine()) != "end")
            {
                if (line == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(cars.Dequeue() + " passed!");
                        count++;
                    }
                }

                else
                {
                    cars.Enqueue(line);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }

    }
}