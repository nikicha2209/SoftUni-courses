using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((line = Console.ReadLine()) != "end")
            {
                string[] arguments = line.Split(" : ");
                string course = arguments[0];
                string name = arguments[1];

                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }

                courses[course].Add(name);

            }

            foreach (KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.ForEach(x => Console.WriteLine($"-- {x}"));

            }
        }
    }
}
