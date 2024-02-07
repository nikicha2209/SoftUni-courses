using DefiningClasses;

namespace _04._Opinion_Poll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person[] filtered = family.People
                .FindAll(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToArray();

            foreach (Person person in filtered)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}