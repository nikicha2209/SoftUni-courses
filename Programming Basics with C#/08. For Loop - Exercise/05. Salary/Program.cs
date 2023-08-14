using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fb = 150;
            int ig = 100;
            int reddit = 50;
            int globa = 0;

            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    globa += fb;
                }

                else if (site == "Instagram")
                {
                    globa += ig;
                }

                else if (site == "Reddit")
                {
                    globa += reddit;
                }
                else
                {
                    globa += 0;
                }
            }

            if (globa >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }

            else
            {
                Console.WriteLine($"{salary - globa}");
            }

        }
    }
}
