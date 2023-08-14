using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double balance = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {money:f2}");
                balance += money;
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
