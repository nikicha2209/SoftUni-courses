using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double percentage = 0;
            double finalAmount = 0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percentage = 0.05;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    percentage = 0.07;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    percentage = 0.08;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 10000)
                {
                    percentage = 0.12;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percentage = 0.045;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    percentage = 0.075;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    percentage = 0.1;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 10000)
                {
                    percentage = 0.13;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }


            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percentage = 0.055;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    percentage = 0.08;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    percentage = 0.12;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else if (sales > 10000)
                {
                    percentage = 0.145;
                    finalAmount = percentage * sales;
                    Console.WriteLine($"{finalAmount:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }


            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

