using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int a = 97; a < 97 + number; a++)
            {
                for (int b = 97; b < 97 + number; b++)
                {
                    for (int c = 97; c < 97 + number; c++)
                    {
                        Console.WriteLine($"{(char)a}{(char)b}{(char)c}");
                    }
                }
            }
        }
    }
}
