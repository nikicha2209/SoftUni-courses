using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm.Animal.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        { }

        protected override double WeightGain => 0.25;

        public override void Eat(Food.Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                Weight += WeightGain * food.Quantity;
                FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");

            }
        }
        public override void Sound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
