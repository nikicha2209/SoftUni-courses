using _05._Birthday_Celebrations.Models.Interfaces;

namespace _05._Birthday_Celebrations.Models
{
    public class Citizen : IIdentifiable, INameable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthday { get; set; }
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        
    }
}
