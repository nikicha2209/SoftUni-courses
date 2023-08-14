using System;
using System.Dynamic;
using System.Net;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day-1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
