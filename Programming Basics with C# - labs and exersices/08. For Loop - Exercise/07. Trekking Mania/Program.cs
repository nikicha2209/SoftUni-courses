using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string mount;
            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                total += people;

                if (people <= 5)
                {
                    mount = "Musala";
                    musala += people;
                }

                else if (people >= 6 && people <= 12)
                {
                    mount = "Monblan";
                    monblan += people;
                }

                else if (people >= 13 && people <= 25)
                {
                    mount = "Kilimandjaro";
                    kilimanjaro += people;
                }

                else if (people >= 26 && people <= 40)
                {
                    mount = "K2";
                    k2 += people;
                }

                else if (people >= 41)
                {
                    mount = "Everest";
                    everest += people;
                }
            }

           
            Console.WriteLine($"{musala / total * 100:f2}%");
            Console.WriteLine($"{monblan / total * 100:f2}%");
            Console.WriteLine($"{kilimanjaro / total * 100:f2}%");
            Console.WriteLine($"{k2 / total * 100:f2}%");
            Console.WriteLine($"{everest / total * 100:f2}%");
        }
    }
}
