using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm.Animal.Bird
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        { }

        protected override double WeightGain => 0.35;

        public override void Eat(Food.Food food)
        {
            Weight += WeightGain * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override void Sound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
