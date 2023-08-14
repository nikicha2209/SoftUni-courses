using System;
using System.Linq;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Travel")
            {
                string[] commands = line.Split(':');

                if (commands[0] == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string destination = commands[2];

                    if (index < 0 || index > stops.Length)
                    {
                        Console.WriteLine(stops);
                        continue;
                    }

                    else
                    {
                        stops = stops.Insert(index, commands[2]);
                        Console.WriteLine(stops);
                    }
                }

                else if (commands[0] == "Remove Stop")
                {
                    if (commands.Length != 3)
                    {
                        continue;
                    }

                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < 0 || startIndex > stops.Length -1 || endIndex < 0 || endIndex > stops.Length-1)
                    {
                        Console.WriteLine(stops);
                        continue;
                    }

                    else
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(stops);
                    }
                }

                else if (commands[0] == "Switch")
                {
                    if (stops.Contains(commands[1]))
                    {
                        stops = stops.Replace(commands[1], commands[2]);
                        Console.WriteLine(stops);
                    }

                    else
                    {
                        Console.WriteLine(stops);
                        continue;
                    }
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
