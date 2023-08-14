using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;

            while ((word = Console.ReadLine()) != "end")
            {
                string reversed = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }

                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}
