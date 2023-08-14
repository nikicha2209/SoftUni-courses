using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int sum = 1;
            int sum2 = 0;
            
            for (int i = number; i > 0; i /= 10)
            {
                digit = i % 10;
                

                for (int a = digit; a > 0; a--)
                {
                    sum = sum * a;
                }
                sum2 += sum;
                sum = 1;
            }

            if (sum2 == number)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
