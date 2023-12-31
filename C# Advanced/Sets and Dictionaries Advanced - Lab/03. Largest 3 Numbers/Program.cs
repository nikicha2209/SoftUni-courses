namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            List<int> output = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                if (i >= sorted.Length)
                {
                    break;
                }
                output.Add(sorted[i]);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}