using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double roberPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalMoney = lightSaberPrice * (Math.Ceiling(students + 0.1 * students)) + roberPrice * students + beltsPrice * (Math.Ceiling(students - students / 6f));

            if (budget >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }

            else
            {
                Console.WriteLine($"John will need {totalMoney - budget:f2}lv more.");
            }
        }
    }
}
