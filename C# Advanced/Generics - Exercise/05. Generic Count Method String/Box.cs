using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Generic_Count_Method_String
{
    internal class Box<T> where T:IComparable<T>
    {
        public List<T> items { get; set; }

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
            foreach (var item in items)
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
