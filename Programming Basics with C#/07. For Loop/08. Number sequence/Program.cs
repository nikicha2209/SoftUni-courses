using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current < smallest)
                {
                    smallest = current;
                }

                if (current > biggest)
                {
                    biggest = current;
                }
            }

            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
