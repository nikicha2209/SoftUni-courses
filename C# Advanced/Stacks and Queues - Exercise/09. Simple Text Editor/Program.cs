namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(string.Empty);

            int n = int.Parse(Console.ReadLine());
            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToArray();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        stack.Push(stack.Peek() + input[1]);
                        break;

                    case 2:
                        int count = int.Parse(input[1]);
                        string substring = stack.Peek().Substring(0,  stack.Peek().Length - count);
                        stack.Push(substring);
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(stack.Peek()[index - 1]);
                        break;

                    case 4:
                        stack.Pop();
                        break;
                }
            }
        }
    }
}