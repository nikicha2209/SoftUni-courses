using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] array = input.Split(' ');

                Student student = new Student();
                student.FirstName = array[0];
                student.LastName = array[1];
                student.Age = int.Parse(array[2]);
                student.HomeTown = array[3];

                students.Add(student);
            }

            string givenCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == givenCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
