using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Dessert : Food
    {
        public virtual double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            Calories = calories;
        }
    }
}
