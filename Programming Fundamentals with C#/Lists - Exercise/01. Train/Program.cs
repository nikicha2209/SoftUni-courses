using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfAWagon = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();

                if (commands[0] == "Add")
                {
                    wagonsList.Add(int.Parse(commands[1]));
                }

                else
                {
                    for (int i = 0; i < wagonsList.Count; i++)
                    {
                        if (maxCapacityOfAWagon - wagonsList[i] >= int.Parse(commands[0]))
                        {
                            wagonsList[i] += int.Parse(commands[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonsList));
        }
    }
}
