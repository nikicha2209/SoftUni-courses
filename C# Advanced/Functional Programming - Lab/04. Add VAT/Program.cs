namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(price => $"{price*1.2:f2}")
                .ToArray()));
        }
    }
}