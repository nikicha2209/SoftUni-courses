using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            double price;
            int nights = days - 1;

            if (typeOfRoom == "room for one person")
            {
                price = nights * 18;
            }

            else if (typeOfRoom == "apartment")
            {
                price = nights * 25;

                if (days < 10)
                {
                    price = price * 0.7;
                }

                else if (days >= 10 && days < 15)
                {
                    price = price * 0.65;
                }

                else
                {
                    price = price * 0.5;
                }
            }

            else
            {
                price = nights * 35;

                if (days < 10)
                {
                    price = price * 0.9;
                }

                else if (days >= 10 && days < 15)
                {
                    price = price * 0.85;
                }

                else
                {
                    price = price * 0.8;
                }
            }


            if (grade == "positive")
            {
                price = price + 0.25 * price;
            }

            else
            {
                price = price * 0.9;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
}
