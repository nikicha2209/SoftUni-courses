using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfValues = Console.ReadLine();
            if (typeOfValues == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(HigherThanTwo(first, second));
            }

            else if (typeOfValues == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(HigherThanTwo(first, second));
            }

            else if (typeOfValues == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(HigherThanTwo(first, second));
            }
        }

        static int HigherThanTwo(int first, int second)
        {
            int result = 0;
            if (first > second)
            {
                result = first;
            }

            else
            {
                result = second;
            }

            return result;
        }

        static string HigherThanTwo(string first, string second)
        {
            string result = string.Empty;
            int comparison = first.CompareTo(second);

            if (comparison > 0)
            {
                result = first;
            }

            else
            {
                result = second;
            }

            return result;
        }

        static char HigherThanTwo(char first, char second)
        {
            int result = 0;

            if (result > 0)
            {
                result = first;
            }

            else
            {
                result = second;
            }

            return (char)result;
        }
    }
}
