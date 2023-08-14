using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            SumOfFirstAndSecond(first, second);
            Console.WriteLine(SubtractTheThirdFromTheResultOfTheSum(SumOfFirstAndSecond(first, second), third));
        }

        static int SubtractTheThirdFromTheResultOfTheSum(int sum, int third)
        {
            return sum - third;
        }

        static int SumOfFirstAndSecond(int first, int second)
        {
            return first + second;
        }
    }
}
