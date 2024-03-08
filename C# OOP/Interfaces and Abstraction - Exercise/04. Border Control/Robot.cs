using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Border_Control
{
    public class Robot : IIdentifiable
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Robot(string name, string id)
        {
            Name = name;
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
