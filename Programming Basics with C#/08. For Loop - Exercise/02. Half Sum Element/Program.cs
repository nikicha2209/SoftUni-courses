using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            int current = 0;

            for (int i = 1; i <= n; i++)
            {
                current = int.Parse(Console.ReadLine());
                sum += current;

                if (max < current)
                {
                    max = current;
                }
            }

            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - (sum - max))}");
            }
        }
    }
}
