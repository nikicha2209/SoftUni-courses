using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double total = (5.80 * pen + 7.20 * markers + 1.2 * detergent);
            double finalSum = total - total * discount / 100;
            Console.WriteLine(finalSum);
        }
    }
}
