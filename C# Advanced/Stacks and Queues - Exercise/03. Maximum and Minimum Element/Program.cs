namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (query[0] == 1)
                {
                    stack.Push(query[1]);
                }

                else if (query[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }

                else if (query[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }

                }

                else if (query[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());

                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}