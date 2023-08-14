using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (typeOfDay == "Weekday")
            {
                if(0<=age && age <= 18)
                {
                    price = 12;
                }

                else if(age>18 && age <= 64)
                {
                    price = 18;
                }

                else if(age>64 && age<=122)
                {
                    price = 12;
                }
            }

            else if(typeOfDay == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    price = 15;
                }

                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }

                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }

            else if(typeOfDay == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    price = 5;
                }

                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }

                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }

            if(price != 0)
            {
                Console.WriteLine($"{price}$");
            }

            else
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
