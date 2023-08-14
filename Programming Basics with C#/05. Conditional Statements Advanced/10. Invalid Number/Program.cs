using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 100 || number > 200)
            {
                if (number != 0)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
