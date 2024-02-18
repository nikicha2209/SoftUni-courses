namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int max = int.Parse(Console.ReadLine());
            //int[] dividers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //List<int> result = Enumerable.Range(1, max)
            //    .Where(currentNumber => dividers.All(divider => currentNumber % divider == 0))
            //    .ToList();

            //Console.WriteLine(string.Join(" ", result));



            int max = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> result = new List<int>();

            for (int currentNumber = 1; currentNumber <= max; currentNumber++)
            {
                Predicate<int> isDivisible = x => currentNumber % x == 0;
                bool allDivisible = true;

                for (int dividerIndex = 0; dividerIndex < dividers.Length; dividerIndex++)
                {
                    if (!isDivisible(dividers[dividerIndex]))
                    {
                        allDivisible = false;
                        break;
                    }
                }

                if (allDivisible)
                {
                    result.Add(currentNumber);
                }
            }

            Console.WriteLine(string.Join(" ", result));


        }
    }
}