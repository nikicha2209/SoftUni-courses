using System.Numerics;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numberStack = new Stack<int>(numbers);
            for (int i = 0; i < s; i++)
            {
                numberStack.Pop();
            }

            if (numberStack.Contains(x))
            {
                Console.WriteLine("true");
            }

            else if (numberStack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                int smallest = int.MaxValue;
                while (numberStack.Count != 0)
                {
                    if (numberStack.Peek() < smallest)
                    {
                        smallest = numberStack.Pop();
                    }
                    else
                    {
                        numberStack.Pop();
                    }
                }

                Console.WriteLine(smallest);
            }
        }
    }
}