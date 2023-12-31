namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!occurrences.ContainsKey(number))
                {
                    occurrences[number] = 0;
                }

                occurrences[number]++;
            }

            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");                
            }
        }
    }
}