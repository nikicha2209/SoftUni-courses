using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                List<string> commands = input.Split(" ").ToList();

                if (commands.Count == 3)
                {
                    if (!people.Contains(commands[0]))
                    {
                        people.Add(commands[0]);
                    }

                    else
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                }

                else if (commands.Count == 4)
                {
                    if (people.Contains(commands[0]))
                    {
                        people.Remove(commands[0]);
                    }

                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
                

            }

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
