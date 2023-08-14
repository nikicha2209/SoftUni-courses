using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(TheSmallestNumber(first, second, third));
        }

        static int TheSmallestNumber(int first, int second, int third)
        {
            int result = Math.Min(first, second);
            result = Math.Min(result, third);
            return result;
        }
    }
}
