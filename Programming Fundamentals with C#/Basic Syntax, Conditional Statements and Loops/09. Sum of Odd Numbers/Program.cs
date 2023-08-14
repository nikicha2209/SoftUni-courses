using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int k = 1;
            int sum = 0;
            while (i < n)
            {
                Console.WriteLine(k);
                sum += k;
                k+=2;
                i++;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
