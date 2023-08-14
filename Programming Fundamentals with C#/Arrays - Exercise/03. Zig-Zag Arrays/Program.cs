using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int first = int.Parse(numbers[0]);
                int second = int.Parse(numbers[1]);

                if (i % 2 == 1)
                {
                    firstArray[counter] = first;
                    secondArray[counter] = second;
                }

                else
                {
                    firstArray[counter] = second;
                    secondArray[counter] = first;
                }

                counter++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{secondArray[i]} ");
            }
        }
    }
}
