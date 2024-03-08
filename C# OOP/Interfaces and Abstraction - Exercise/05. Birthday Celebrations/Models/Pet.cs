using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using _05._Birthday_Celebrations.Models.Interfaces;

namespace _05._Birthday_Celebrations.Models
{
    public class Pet : IBirthable, INameable
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }


}
