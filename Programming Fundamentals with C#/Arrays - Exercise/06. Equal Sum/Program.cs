using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int index = 0;
            bool isEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum = 0;
                leftSum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }

                if (rightSum == leftSum && !isEqual)
                {
                    index = i;
                    Console.WriteLine(i);
                    isEqual = true;
                }

            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
