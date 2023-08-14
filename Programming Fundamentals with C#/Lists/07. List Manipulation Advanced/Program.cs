using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void FilterList(List<int> list, string condition, int number)
        {
            switch (condition)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", list.Where(x => x < number)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", list.Where(x => x > number)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", list.Where(x => x <= number)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", list.Where(x => x >= number)));
                    break;
            }
        }

        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            bool changesMade = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        changesMade = true;
                        break;

                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        changesMade = true;
                        break;

                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1]));
                        changesMade = true;
                        break;

                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        changesMade = true;
                        break;

                    case "Contains":

                        if (list.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }

                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "PrintEven":
                        Console.WriteLine(String.Join(" ", list.Where(x => x % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(String.Join(" ", list.Where(x => x % 2 == 1)));
                        break;

                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "Filter":
                        FilterList(list, command[1], int.Parse(command[2]));
                        break;
                }
            }

            if (changesMade)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
