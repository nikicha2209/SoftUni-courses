using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person john = new Person("John", 22);
            Console.WriteLine(john.Name);
            Console.WriteLine(john.Age);
        }
    }
}