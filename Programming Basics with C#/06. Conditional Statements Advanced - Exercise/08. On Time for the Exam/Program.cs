using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arriveTime = arriveHour * 60 + arriveMinutes;
            int difference = arriveTime - examTime;

            if (difference > 0)
            {
                Console.WriteLine("Late");
                int lateHours = difference / 60;
                int lateMinutes = difference % 60;

                if (lateHours > 0)
                {
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }

                else
                {
                    Console.WriteLine($"{lateMinutes} minutes after the start");
                }
            }


            else if (difference >= -30)
            {
                Console.WriteLine("On time");

                if (difference != 0)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }
            }

            else
            {
                Console.WriteLine("Early");
                int earlyHours = Math.Abs(difference) / 60;
                int earlyMinutes = Math.Abs(difference) % 60;

                if (earlyHours > 0)
                {
                    Console.WriteLine($"{earlyHours}:{earlyMinutes:D2} hours before the start");
                }

                else
                {
                    Console.WriteLine($"{earlyMinutes} minutes before the start");
                }
            }

        }
    }
}
