using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingPrice= int.Parse(Console.ReadLine());
            double sneakers = trainingPrice - 0.4 * trainingPrice;
            double outfit = sneakers  - 0.2 * sneakers ;
            double ball = outfit  / 4;
            double accessories = ball / 5;
            double total = trainingPrice + sneakers  + outfit  + ball + accessories ;
            Console.WriteLine(total);
        }
    }
}
