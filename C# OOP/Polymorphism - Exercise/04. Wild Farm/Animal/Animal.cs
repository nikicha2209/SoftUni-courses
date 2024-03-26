using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm.Animal
{
    public abstract class Animal
    {
        protected abstract string Name { get; set; }
        protected abstract double Weight { get; set; }
        protected abstract int FoodEaten { get; set; }
        protected abstract double WeightGain { get; }

        public abstract void Sound();
        public abstract void Eat(Food.Food food);

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }
    }
}
