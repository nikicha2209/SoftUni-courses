using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => this.Any();

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
            {
                this.Push(element);
            }
        }
    }
}
