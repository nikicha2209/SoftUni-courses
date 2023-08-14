using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int represents = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, represents));
        }

        static string RepeatString(string text, int represents)
        {
            string result = string.Empty;
            for (int i = 0; i < represents; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
