namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> box = new Stack<int>(input);

            int usedRacks = 0;
            int currentRackCapacity = 0;

            while (box.Any())
            {
                if (currentRackCapacity - box.Peek() < 0)
                {
                    usedRacks++;
                    currentRackCapacity = capacity;
                }

                else
                {
                    currentRackCapacity -= box.Pop();
                }
            }

            Console.WriteLine(usedRacks);
            
        }
    }
}