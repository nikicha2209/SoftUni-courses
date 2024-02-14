using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._ListyIterator
{
    public class ListyIterator<T>
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
    }
}
