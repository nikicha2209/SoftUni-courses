namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orderQueue = new Queue<int>(orders);
            Console.WriteLine(orderQueue.Max());
            while (orderQueue.Any())
            {
                if (orderQueue.Peek() > quantity)
                {
                    break;
                }

                quantity -= orderQueue.Dequeue();

            }

            if (orderQueue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orderQueue)}");

            }

            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}