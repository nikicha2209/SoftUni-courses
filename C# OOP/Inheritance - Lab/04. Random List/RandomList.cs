using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(Count);
            string removed = this[index];
            this.RemoveAt(index);
            return removed;
        }
    }
}
