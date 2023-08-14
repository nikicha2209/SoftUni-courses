using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= inputNumber; i++)
            {
                sum = 0;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
            }
        }
    }
}
