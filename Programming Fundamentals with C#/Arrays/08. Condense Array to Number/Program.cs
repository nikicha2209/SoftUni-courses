using System;
using System.Globalization;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[nums.Length - 1];

            for (int i = nums.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);

        }
    }
}
