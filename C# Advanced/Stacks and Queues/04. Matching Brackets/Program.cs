namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5 


            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                else if (input[i] == ')')
                {
                    int openBracket = stack.Pop();
                    string substring = input.Substring(openBracket, i-openBracket+1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}