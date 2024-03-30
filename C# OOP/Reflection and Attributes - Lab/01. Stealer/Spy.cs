using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public void StealFieldInfo(string className, string[] fieldsNames)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] fieldsInfo = classType.GetFields((BindingFlags)60);
            Console.WriteLine($"Class under investigation: {className}");

            Object instance = Activator.CreateInstance(classType, new object []{});

            foreach (FieldInfo field in fieldsInfo.Where(f=>fieldsNames.Contains(f.Name)))
            {
                Console.WriteLine($"{field.Name} = {field.GetValue(instance)}");
            }
        }
    }
}
