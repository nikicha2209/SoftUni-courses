using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();

                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(commands[1]))
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }

                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
