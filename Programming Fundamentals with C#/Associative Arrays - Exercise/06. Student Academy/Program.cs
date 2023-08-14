using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.VisualBasic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> grades = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string grade = Console.ReadLine();

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<string>();
                }

                grades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<string>> grade in grades)
            {
                double average = grade.Value.Select(double.Parse).Average();
                if (average >= 4.50)
                {
                    Console.WriteLine($"{grade.Key} -> {average:f2}");
                }
            }
        }
    }
}
