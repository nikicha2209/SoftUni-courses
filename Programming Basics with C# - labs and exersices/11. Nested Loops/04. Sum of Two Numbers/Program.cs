using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int tries = 0;
            bool flag = false;

            for (int x1 = start; x1 <= stop; x1++)
            {

                for (int x2 = start; x2 <= stop; x2++)
                {
                    tries++;

                    if (x1 + x2 == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{tries} ({x1} + {x2} = {x1 + x2})");
                        flag = true;
                        break;
                    }

                    if (x1 == stop && x2 == stop)
                    {
                        Console.WriteLine($"{tries} combinations - neither equals {magicalNumber}");
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }
        }
    }
}
