using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static double RaiseToPower(double baseNumber, double power)
        {
            return Math.Pow(baseNumber, power);
        }
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(baseNumber, power));
        }
    }
}
