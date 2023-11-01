using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine().Trim().Replace(" ", "");
            if (IsBalanced(expression))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsBalanced(string expression)
        {
            if (expression.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            foreach (char bracket in expression)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    stack.Push(bracket);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    char top = stack.Pop();
                    if ((top == '(' && bracket != ')') || (top == '{' && bracket != '}') || (top == '[' && bracket != ']'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}