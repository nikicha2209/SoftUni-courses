using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = people / capacity;
            if (courses % capacity != 0)
            {
                courses++;
            }

            if (people <= capacity)
            {
                courses = 1;
            }

            Console.WriteLine(courses);
        }
    }
}
