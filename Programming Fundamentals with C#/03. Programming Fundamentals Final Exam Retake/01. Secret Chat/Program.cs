using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] commands = input.Split(":|:");

                if (commands[0] == "InsertSpace")
                {
                    message = message.Insert(int.Parse(commands[1]), " ");
                    Console.WriteLine(message);
                }

                else if (commands[0] == "Reverse")
                {
                    if (message.Contains(commands[1]))
                    {
                        int index = message.IndexOf(commands[1]);
                        string substring = message.Substring(index, commands[1].Length);
                        char[] reversed = substring.Reverse().ToArray();
                        string newSubstring = new string(reversed);
                        message = message.Remove(index, commands[1].Length);
                        message += newSubstring;
                        Console.WriteLine(message);
                    }

                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (commands[0] == "ChangeAll")
                {
                    message = message.Replace(commands[1], commands[2]);
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
