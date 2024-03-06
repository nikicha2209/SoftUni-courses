using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_Spree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                else
                {
                    name = value;
                }
            }
        }


        public decimal Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                cost = value;

            }
        }

        public override string ToString() => Name;
    }
}
