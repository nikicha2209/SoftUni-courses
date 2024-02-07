namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => value = name; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}