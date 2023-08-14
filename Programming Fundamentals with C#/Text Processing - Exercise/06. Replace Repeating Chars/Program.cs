using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string newText = string.Empty;

            for (int i = 0; i < line.Length; i++)
            {
                if (i == line.Length - 1)
                {
                    continue;
                }

                if (line[i] == line[i + 1])
                {
                    continue;
                }

                else
                {
                    newText += line[i];
                }
            }

            newText += line[line.Length - 1];

            Console.WriteLine(newText);;
        }
    }
}
