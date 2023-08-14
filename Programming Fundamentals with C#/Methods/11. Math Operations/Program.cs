using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(first, operation, second));
        }

        static int Calculate(int first, char operation, int second)
        {
            int result = 0;

            if (operation == '/')
            {
                result =  first / second;
            }

            else if (operation == '*')
            {
                result = first * second;
            }

            else if (operation == '+')
            {
                result = first + second;
            }

            else if(operation == '-')
            {
                result = first - second;
            }

            return result;
        }
    }
}
