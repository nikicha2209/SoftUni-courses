using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                Random rnd = new Random();

                for (int i = 0; i < input.Count; i++)
                {
                    int randomIndex = rnd.Next(0, input.Count);
                    string currentIndexValue = input[i];
                    string randomIndexValue = input[randomIndex];
                    input[i] = randomIndexValue;
                    input[randomIndex] = currentIndexValue;
                }

                Console.WriteLine(string.Join(Environment.NewLine, input));
            }
    }
}
