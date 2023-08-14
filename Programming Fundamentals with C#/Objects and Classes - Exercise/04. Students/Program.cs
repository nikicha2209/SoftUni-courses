using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = double.Parse(grade);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split();
                Student student = new Student(line[0], line[1], line[2]);

                students.Add(student);
                
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
