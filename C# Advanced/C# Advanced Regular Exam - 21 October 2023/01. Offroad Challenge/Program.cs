namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] thirdArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> initialFuel = new Stack<int>(firstArray);
            Queue<int> additionalFuel = new Queue<int>(secondArray);
            Queue<int> neededFuel = new Queue<int>(thirdArray);

            int altitudesCount = 0;

            for (int i = 1; i <= 4; i++)
            {
                //Console.WriteLine($"{initialFuel.Peek()} {additionalFuel.Peek()} {neededFuel.Peek()}");
                if (initialFuel.Peek() - additionalFuel.Peek() >= neededFuel.Peek())
                {
                    initialFuel.Pop();
                    additionalFuel.Dequeue();
                    neededFuel.Dequeue();
                    Console.WriteLine($"John has reached: Altitude {i}");
                    altitudesCount++;
                }

                else
                {
                    Console.WriteLine($"John did not reach: Altitude {i}");
                    Console.WriteLine("John failed to reach the top.");
                    break;
                }
            }

            if (altitudesCount == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }

            else if (altitudesCount > 0)
            {
                Console.Write($"Reached altitudes:");
                for (int i = 1; i <= altitudesCount; i++)
                {
                    if (i == altitudesCount)
                    {
                        Console.Write($" Altitude {i}");
                    }

                    else
                    {
                        Console.Write($" Altitude {i},");
                    }

                }
            }

            else
            {
                Console.WriteLine("John didn't reach any altitude.");
            }
        }
    }
}