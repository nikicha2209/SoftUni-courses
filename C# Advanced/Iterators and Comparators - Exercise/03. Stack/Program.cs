namespace _03._Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                string[] command = line.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    string[] elements = command.Skip(1).ToArray();
                    stack.Push(elements);
                }

                else if (command[0] == "Pop")
                {
                    stack.Pop();
                }
            }

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}