using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<Person> people = new List<Person>();
            List<string> ids = new List<string>();
            int count = 0;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] command = line.Split();
                string name = command[0];
                string id = command[1];
                int age = int.Parse(command[2]);

                Person person = new Person(name, id, age);

                if (ids.Contains(person.ID))
                {
                    people[count].Name = person.Name;
                    people[count].Age = int.Parse(person.ID);
                }

                people.Add(person);
                count++;
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
