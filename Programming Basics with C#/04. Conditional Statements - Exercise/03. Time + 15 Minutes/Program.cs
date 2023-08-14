using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (minutes < 45)
            {
                minutes = minutes + 15;
            }

            else
            {
                minutes = 60 - minutes;
                minutes = 15 - minutes;
                hours = hours + 1;
            }



            if (hours == 24)
            {
                hours = 0;
                Console.WriteLine($"{hours:D1}:{minutes:D2}");
            }

            else if (minutes < 10)
            {
                Console.WriteLine(hours + ":" + "0" + minutes);
            }


            else if (hours < 23)
            {
                Console.WriteLine(hours + ":" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
        }
    }
}
