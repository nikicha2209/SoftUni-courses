namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isEven = Console.ReadLine() == "even";

            Func<int, int, List<int>> generateRange = (start, end) =>
            {
                List<int> range = new List<int>();
                
                for (int i = start; i <= end; i++)
                {
                    range.Add(i);
                }

                return range;
            };

            List<int> numbers = generateRange(range[0], range[1]);

            Predicate<int> filter;

            if (isEven)
            {
                filter = number => number % 2 == 0;
            }

            else
            {
                filter = number => number % 2 != 0;
            }

            List<int> outputNumbers = new List<int>();
            foreach(int number in numbers)
            {
                if (filter(number))
                {
                    outputNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", outputNumbers));
        }
    }
}