using System.Threading.Channels;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people.Add(new Person(input[0], int.Parse(input[1])));
            }

            string filterType = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string formatType = Console.ReadLine();

            Func<Person, bool> filter = GetFilter(filterType, ageFilter);
            people = people.Where(p => filter(p)).ToList();

            Action<Person> printer = GetPrinter(formatType);

            foreach (var person in people)
            {
                printer(person);
            }
        }

         static Action<Person> GetPrinter(string formatType)
        {
            switch(formatType)
            {
                case "name age":
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
                case "name":
                    return p => Console.WriteLine(p.Name);
                case "age":
                    return p => Console.WriteLine(p.Age);
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetFilter(string filterType, int age)
        {
            switch (filterType)
            {
                case "younger":
                    return person => person.Age < age;
                case "older":
                    return person=> person.Age >= age;
                default:
                    return null;
            }
        }
       
    }
}