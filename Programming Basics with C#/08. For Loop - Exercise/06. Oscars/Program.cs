using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double points = academyPoints;

            for (int i = 1; i <= n; i++)
            {
                string judge = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                points += (judge.Length * grade) / 2;

                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
