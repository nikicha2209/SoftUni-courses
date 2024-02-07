namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People { get { return people; } set { people = value; } }

        public Family()
        {
            this.People = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
            => this.People.OrderByDescending(p => p.Age).First();
    }
}