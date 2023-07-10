using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 0;
            double total = 0;
            int repeats = 0;

            while (grade < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                repeats += repeats;

                if (mark < 4)
                {
                    if (repeats == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;

                    }
                    repeats++;
                }

                total += mark;
                grade++;
            }

            if (grade == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(total / 12):f2} ");
            }

        }
    }
}
