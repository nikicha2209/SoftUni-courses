using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int hallCapacity = rows  * columns ;
            double ticketPrice = 0;
            double totalRevenue = 0;

            if (projectionType  == "Premiere")
            {
                ticketPrice  = 12;
                totalRevenue  = hallCapacity  * ticketPrice ;
            }

            else if (projectionType  == "Normal")
            {
                ticketPrice  = 7.5;
                totalRevenue  = hallCapacity  * ticketPrice ;
            }

            else if (projectionType  == "Discount")
            {
                ticketPrice  = 5;
                totalRevenue  = hallCapacity  * ticketPrice ;
            }

            Console.WriteLine($"{totalRevenue :f2}");
        }
    }
}
