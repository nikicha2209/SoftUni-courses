using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }

        public Box()
        {
            Item = new Item();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((line = Console.ReadLine()) != "end")
            {
                string[] array = line.Split(' ');
                Box box = new Box();
                box.SerialNumber = array[0];
                box.Item.Name = array[1];
                box.ItemQuantity = int.Parse(array[2]);
                box.Item.Price = double.Parse(array[3]);
                box.PriceForABox = box.ItemQuantity * box.Item.Price;
                boxes.Add(box);

            }

            boxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
