namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Predicate<string> isUpperCase = word => char.IsUpper(word[0]);

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => isUpperCase(word))
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}