using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }

            Console.WriteLine(sum);
        }
    }
}
