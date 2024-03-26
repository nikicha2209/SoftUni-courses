using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04._Wild_Farm.Animal.Bird;
using _04._Wild_Farm.Animal.Mammal;
using _04._Wild_Farm.Animal.Mammal.Feline;
using _04._Wild_Farm.Food;

namespace _04._Wild_Farm
{
    public class Factory
    {
        public static Animal.Animal GetAnimal(string input)
        {
            string[] info = input.Split();
            string type = info[0];
            string name = info[1];
            double weight = double.Parse(info[2]);

            switch (type)
            {
                case "Owl": return new Owl(name, weight, double.Parse(info[3]));
                case "Hen": return new Hen(name, weight, double.Parse(info[3]));
                case "Mouse": return new Mouse(name, weight, info[3]);
                case "Dog": return new Dog(name, weight, info[3]);
                case "Cat": return new Cat(name, weight, info[3], info[4]);
                case "Tiger": return new Tiger(name, weight, info[3], info[4]);
                default: return null;
            }
        }

        public static Food.Food GetFood(string input)
        {
            string[] info = input.Split();
            string type = info[0];
            int quantity = int.Parse(info[1]);

            switch (type)
            {
                case "Fruit": return new Fruit(quantity);
                case "Meat": return new Meat(quantity);
                case "Seeds": return new Seeds(quantity);
                case "Vegetable": return new Vegetable(quantity);
                default: return null;
            }
        }
    }
}
