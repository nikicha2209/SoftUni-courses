using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = int.Parse(Console.ReadLine());
            double kilometers = input / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
