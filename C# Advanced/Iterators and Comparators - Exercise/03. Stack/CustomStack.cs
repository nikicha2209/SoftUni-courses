using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Stack
{
    public class CustomStack<T>:IEnumerable<T>
    {
        public List<T> Items;

        public CustomStack()
        {
            Items = new List<T>();
        }

        public void Push(params T[] elements)
        {
            Items.AddRange(elements);
        }

        public T Pop()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }

            else
            {
                T element = Items[Items.Count - 1];
                Items.RemoveAt(Items.Count-1);
                return element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
