namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", DivisibleNumbers(n, numbers)));
        }

        static List<int> DivisibleNumbers(int n, List<int> numbers)
        {
            List<int> output = new List<int>();
            foreach (int number in numbers)
            {
                output.Add(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % n == 0)
                {
                    output.Remove(numbers[i]);
                }
            }
            return output;
        }



    }
}