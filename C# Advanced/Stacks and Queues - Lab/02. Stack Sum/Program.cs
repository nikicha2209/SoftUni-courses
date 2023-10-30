namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string line = string.Empty;
            while ((line = Console.ReadLine()).ToLower() != "end")
            {
                line = line.ToLower();
                string[] tokens = line.Split();

                if (tokens[0] == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }

                else if (tokens[0] == "remove")
                {
                    if (stack.Count >= int.Parse(tokens[1]))
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}