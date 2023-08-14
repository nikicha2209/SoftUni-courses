using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            int toysCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 5;
                    savedMoney--;
                }

                else
                {
                    toysCount++;
                }
            }

            double totalMoneyFromToys = toysCount * toyPrice;
            double totalMoney = totalMoneyFromToys + savedMoney;

            if (totalMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - priceWashingMachine:f2}");
            }

            else
            {
                Console.WriteLine($"No! {priceWashingMachine - totalMoney:f2}");
            }
        }
    }
}
