using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(input));
           
        }

        static string MiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                int index = input.Length / 2;
                return input[index-1].ToString() + input[index].ToString();
            }

            if (input.Length % 2 == 1)
            {
                int index = input.Length / 2;
                return input[index].ToString();
            }

            return null;
        }
    }
}
