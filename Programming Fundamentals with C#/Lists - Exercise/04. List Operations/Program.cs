using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commands = input.Split().ToList();

                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }

                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) > numbers.Count || int.Parse(commands[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                }

                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) > numbers.Count || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.RemoveAt(int.Parse(commands[1]));
                    }
                }

                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        // 1,4,5,6,9,3     => 2
                        // 5,6,9,3,1,4

                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            int tempNumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(tempNumber);
                        }
                    }

                    if (commands[1] == "right")
                    {
                        // 1,4,5,6,9,3     => 2
                        // 3,1,4,5,6,9
                        // 9 3 1 4 5 6 

                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            int tempNumber = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count-1);
                            numbers.Insert(0, tempNumber);
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
