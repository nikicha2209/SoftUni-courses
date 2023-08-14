using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double recordToBeat = distance  * timePerMeter ;
            double resistance = Math.Floor(distance  / 15) * 12.5;
            double newRecord = recordToBeat  + resistance ;

            if (newRecord  < record )
            {
                double faster = record  - newRecord ;
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(newRecord ):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record  - newRecord ):f2} seconds slower.");
            }
        }
    }
}
