using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Food_Shortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Id { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
            Id = id;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
