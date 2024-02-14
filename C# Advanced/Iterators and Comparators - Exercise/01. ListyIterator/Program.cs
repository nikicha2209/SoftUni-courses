using System.Runtime.InteropServices;

namespace _01._ListyIterator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] entries = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToArray();

            ListyIterator<string> listy = new ListyIterator<string>(entries);
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                switch (line)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                }
            }
        }

    }
}