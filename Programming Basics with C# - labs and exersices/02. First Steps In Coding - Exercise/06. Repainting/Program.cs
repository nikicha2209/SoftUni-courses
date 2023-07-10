using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine()) + 2;
            double paint = double.Parse(Console.ReadLine());
            paint = paint + 0.1 * paint;
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double bags = 0.4;
            double nylonPrice = nylon * 1.5;
            double paintPrice = paint * 14.5;
            double thinnerPrice = thinner  * 5;
            double materials = bags + nylonPrice  + paintPrice  + thinnerPrice;
            double laborFee = 0.3 * materials  * hours;
            double total = laborFee  + materials ;
            Console.WriteLine(total);
        }
    }
}
