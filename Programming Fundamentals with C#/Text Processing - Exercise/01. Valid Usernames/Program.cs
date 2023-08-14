using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                bool flag = username.All(character =>
                    char.IsLetterOrDigit(character) || character == '-' || character == '_');

                if (flag)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
