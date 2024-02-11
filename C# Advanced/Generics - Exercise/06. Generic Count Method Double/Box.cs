using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Generic_Count_Method_Double
{
    internal class Box<T> where T:IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T itemToCompare)
        {
            int count = 0;
            foreach (T item in items)
            {
                if (item.CompareTo(itemToCompare) == 1)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
