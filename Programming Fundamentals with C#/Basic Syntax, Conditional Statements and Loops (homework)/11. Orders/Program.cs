using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
