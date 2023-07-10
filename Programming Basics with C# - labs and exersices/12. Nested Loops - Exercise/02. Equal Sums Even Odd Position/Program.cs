using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string number = i.ToString();
                int odds = 0;
                int evens = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    int digit = int.Parse(number[j].ToString());
                    if (j % 2 == 0)
                    {
                        evens += digit;
                    }

                    else
                    {
                        odds += digit;
                    }

                }
                if (evens == odds)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
