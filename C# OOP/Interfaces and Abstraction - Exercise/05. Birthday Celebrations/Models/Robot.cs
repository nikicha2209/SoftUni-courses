using _05._Birthday_Celebrations.Models.Interfaces;

namespace _05._Birthday_Celebrations.Models
{
    public class Robot : IIdentifiable, INameable
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

    }
}
