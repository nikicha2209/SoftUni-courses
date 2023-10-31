namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
// 5 2 32
// 1 13 45 32 4
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numberQueue = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                numberQueue.Dequeue();
            }

            if (numberQueue.Contains(x))
            {
                Console.WriteLine("true");
            }

            else if (numberQueue.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                int smallest = int.MaxValue;
                while (numberQueue.Count > 0)
                {
                    if (numberQueue.Peek() < smallest)
                    {
                        smallest = numberQueue.Dequeue();
                    }

                    else
                    {
                        numberQueue.Dequeue();
                    }
                }

                Console.WriteLine(smallest);
            }
        }
    }
}