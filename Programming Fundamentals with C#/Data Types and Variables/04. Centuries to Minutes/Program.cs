using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (long)(years * 365.2422m);
            long hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
