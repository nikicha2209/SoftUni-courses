using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Food : Product
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual double Grams { get; set; }

        public Food(string name, decimal price, double grams)
            :base(name, price)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }
    }
}
