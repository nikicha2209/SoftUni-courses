    using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string newText = string.Empty;
            int strength = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    strength += int.Parse(line[i + 1].ToString());
                    newText += line[i];
                }

                else if (strength == 0)
                {
                    newText += line[i];
                }

                else
                {
                    strength--;
                }
            }

            Console.WriteLine(newText);;
        }
    }
}
