using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04._Border_Control
{
    public class Citizen : IIdentifiable
    {
        public string Name { get; set;}
        public int Age { get; set; }
        public string Id { get; set; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public void CheckId(string fakeSubstring)
        {

            if (Id.EndsWith(fakeSubstring))
            {
                Console.WriteLine(Id);
            }

        }
    }
}
