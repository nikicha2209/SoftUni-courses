using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int counter = first;
            char number;
            while (counter <= last)
            {
                number = Convert.ToChar(counter);
                Console.Write(number + " ");
                counter++;
            }
        }
    }
}
