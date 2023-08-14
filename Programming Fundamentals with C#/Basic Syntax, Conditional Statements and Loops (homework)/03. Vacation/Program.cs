using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if(dayOfWeek == "Friday")
                {
                    price = 8.45;
                }

                else if(dayOfWeek == "Saturday")
                {
                    price = 9.8;
                }

                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }

                totalPrice = price * peopleCount;

                if(peopleCount>=30)
                {
                    totalPrice = 0.85 * totalPrice;
                }
            }

            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.9;
                }

                else if (dayOfWeek == "Saturday")
                {
                    price = 15.6;
                }

                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }

                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                totalPrice = price * peopleCount;
            }

            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }

                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }

                else if (dayOfWeek == "Sunday")
                {
                    price = 22.5;
                }

                totalPrice = price * peopleCount;

                if (peopleCount >= 10 && peopleCount<=20)
                {
                    totalPrice = 0.95 * totalPrice;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
