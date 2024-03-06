using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            set => dough = value;
        }

        public int Count { get => toppings.Count; }

        public double TotalCalories
        {
            get
            {
                double totalCalories = dough.GetCalories();
                foreach (Topping topping in toppings)
                {
                    totalCalories += topping.GetCalories();
                }

                return totalCalories;
            }
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            if (Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }

        public override string ToString()
            => $"{name} - {TotalCalories:f2} Calories.";

    }
}
