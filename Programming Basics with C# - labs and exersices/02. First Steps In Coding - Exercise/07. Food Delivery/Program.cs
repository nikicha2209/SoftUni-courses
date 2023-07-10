using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double main = chicken * 10.35 + fish * 12.4 + vegetarian  * 8.15;
            double dessert = 0.2 * main;
            double total = main + dessert + 2.5;
            Console.WriteLine(total); 
        }
    }
}
