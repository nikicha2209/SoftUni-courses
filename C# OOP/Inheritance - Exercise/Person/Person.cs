using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public virtual int Age
        {
            get => age;
            set
            {
                if (value >= 0) age = value;
            }

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, Age: {Age}");
            return sb.ToString();
        }
    }
}
