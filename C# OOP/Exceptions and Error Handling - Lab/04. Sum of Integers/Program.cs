using System.Globalization;

namespace _04._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;

            foreach (string element in input)
            {
                int number = 0;
                try
                {
                    number = int.Parse(element);
                }

                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }

                catch (OverflowException e)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }

                sum += number;
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");

        }
    }
}