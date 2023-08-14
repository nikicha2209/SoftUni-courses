using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split()
                .ToArray();

            string[] second = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string s in second)
            {
                foreach (string s2 in first)
                {
                    if (s2.Equals(s))
                    {
                        Console.Write(s2 + " ");
                    }
                }
            }


        }
    }
}
