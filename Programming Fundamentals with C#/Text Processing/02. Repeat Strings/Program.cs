using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
