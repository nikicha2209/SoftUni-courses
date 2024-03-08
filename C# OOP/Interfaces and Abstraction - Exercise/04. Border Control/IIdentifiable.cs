using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Border_Control
{
    public interface IIdentifiable
    {
        public string Name { get;}
        public string Id { get; }

        void CheckId(string fakeSubstring);
    }
}
