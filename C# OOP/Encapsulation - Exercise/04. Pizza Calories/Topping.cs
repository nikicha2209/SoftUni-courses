using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    public class Topping
    {
        private const double MOD_MEAT = 1.2;
        private const double MOD_VEGGIES = 0.8;
        private const double MOD_CHEESE = 1.1;
        private const double MOD_SAUCE = 0.9;

        private string type;
        private double grams;

        public string Type
        {
            set
            {
                if (!new List<string> { "meat", "veggies", "cheese", "sauce" }.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Grams
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }

                grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double caloriesPerGram = 2;
                if (type.ToLower() == "meat") caloriesPerGram *= MOD_MEAT;
                else if (type.ToLower() == "veggies") caloriesPerGram *= MOD_VEGGIES;
                else if (type.ToLower() == "cheese") caloriesPerGram *= MOD_CHEESE;
                else if (type.ToLower() == "sauce") caloriesPerGram *= MOD_SAUCE;
                return caloriesPerGram;
            }
        }

        public Topping(string type, double grams)
        {
            Type = type;
            Grams = grams;
        }

        public double GetCalories()
            => CaloriesPerGram * grams;

    }
}
