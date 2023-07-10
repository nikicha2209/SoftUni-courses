using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedPrice = double.Parse(Console.ReadLine());
            int periodOfTime = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double finalPrice = depositedPrice + periodOfTime * ((depositedPrice * interestRate / 100) / 12); ;
            Console.WriteLine(finalPrice);
        }
    }
}
