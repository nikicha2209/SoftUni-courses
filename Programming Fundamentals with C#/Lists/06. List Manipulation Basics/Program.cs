using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
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
                    string[] command = input.Split();
                    int number = int.Parse(command[1]);
                    switch (command[0])
                    {
                        case "Add":
                            Add(number, numbers);
                            break;

                        case "Remove":
                            Remove(number, numbers);
                            break;

                        case "RemoveAt":
                            RemoveAt(number, numbers);
                            break;

                        case "Insert":
                            Insert(number, numbers, command[2]);
                            break;
                    }

                }

                Console.WriteLine(string.Join(" ", numbers));
            }

            static void Insert(int number, List<int> numbers, string indexAsString)
            {
                int index = int.Parse(indexAsString);
                numbers.Insert(index, number);
            }

            static void RemoveAt(int number, List<int> numbers)
            {
                numbers.RemoveAt(number);
            }

            static void Remove(int numberToRemove, List<int> numbers)
            {
                numbers.Remove(numberToRemove);
            }

            static void Add(int numberToAdd, List<int> numbers)
            {
                numbers.Add(numberToAdd);
            }

        }
    }
}
