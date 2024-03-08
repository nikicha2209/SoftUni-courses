using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Food_Shortage
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public int Food { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
    }
}
