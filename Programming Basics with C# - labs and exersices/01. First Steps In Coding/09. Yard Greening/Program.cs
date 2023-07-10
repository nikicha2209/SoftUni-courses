using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double price = size * 7.61;
            double discount = 0.18 * price;
            Console.WriteLine($"The final price is : {price-discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
