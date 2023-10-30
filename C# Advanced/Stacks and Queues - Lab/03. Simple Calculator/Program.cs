namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            Stack<string>stack = new Stack<string>(input);

            int result = int.Parse(stack.Pop());

            while (stack.Any())
            {
                char sign = char.Parse(stack.Pop());
                int number = int.Parse(stack.Pop());

                if (sign == '+')
                {
                    result += number;
                }

                else if (sign == '-')
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);


        }
    }
}