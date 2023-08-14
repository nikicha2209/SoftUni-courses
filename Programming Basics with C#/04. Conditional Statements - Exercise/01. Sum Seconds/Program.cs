using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int total = first + second + third;

            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }

            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
