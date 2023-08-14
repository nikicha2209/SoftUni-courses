using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = length * width  * height ;
            double volumeLiters = volume  / 1000;
            double water = volumeLiters  * (1 - percent  / 100);
            Console.WriteLine(water);
        }
    }
}
