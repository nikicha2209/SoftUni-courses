using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);

                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
