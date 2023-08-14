using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                newText += (char)(symbol+3);
            }

            Console.WriteLine(newText);
        }
    }
}
