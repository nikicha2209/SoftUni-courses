using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Collection
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private int currentIndex;
        public List<T> Elements { get; set; }

        public ListyIterator(params T[] elements)
        {
            Elements = new List<T>(elements);
            currentIndex = 0;
        }

        public bool Move()
        {
            if (currentIndex < Elements.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return currentIndex < Elements.Count - 1;
        }

        public void PrintAll()
        {
            if (Elements.Count != 0)
            {
                Console.WriteLine(string.Join(" ", Elements));
            }

            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        public void Print()
        {
            if (Elements.Count != 0)
            {
                Console.WriteLine(Elements[currentIndex]);
            }

            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
