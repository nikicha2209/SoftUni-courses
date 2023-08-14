using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(width, height));
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
