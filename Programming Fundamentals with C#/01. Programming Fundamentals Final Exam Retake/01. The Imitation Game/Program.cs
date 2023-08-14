using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Decode")
            {
                string[] commands = line.Split('|');
                
                if (commands[0] == "ChangeAll")
                {
                    message = message.Replace(commands[1], commands[2]);
                }

                else if (commands[0] == "Insert")
                {
                    message = message.Insert(int.Parse(commands[1]), commands[2]);
                }

                else if (commands[0] == "Move")
                {
                    string substring = message.Substring(0, int.Parse(commands[1]));
                    message = message.Remove(0, int.Parse(commands[1]));
                    message += substring;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
