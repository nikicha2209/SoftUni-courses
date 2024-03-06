using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();

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
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get => bagOfProducts;
        }


        public void BuyProduct(Product product)
        {
            if (money >= product.Cost)
            {
                Console.WriteLine($"{Name} bought {product}");
                money -=product.Cost;
                bagOfProducts.Add(product);
            }

            else
            {
                Console.WriteLine($"{Name} can't afford {product}");
            }
        }
    }
}
