using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Generate")
            {
                string[] commands = line.Split(">>>");

                if (commands[0] == "Contains")
                {
                    if (key.Contains(commands[1]))
                    {
                        Console.WriteLine($"{key} contains {commands[1]}");
                    }

                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (commands[0] == "Flip")
                {
                    string substring = key.Substring(int.Parse(commands[2]), int.Parse(commands[3]) - int.Parse(commands[2]));
                    if (commands[1] == "Upper")
                    {
                        key = key.Replace(substring, substring.ToUpper());
                        Console.WriteLine(key);
                    }

                    else if (commands[1] == "Lower")
                    {
                        key = key.Replace(substring, substring.ToLower());
                        Console.WriteLine(key);
                    }
                }

                else if (commands[0] == "Slice")
                {
                    key = key.Remove(int.Parse(commands[1]), int.Parse(commands[2]) - int.Parse(commands[1]));
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
