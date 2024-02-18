namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //string[] names = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(name => name.Length <= n)
            //    .ToArray();

            //Console.WriteLine(string.Join("\n", names));

            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> isValidName = name => name.Length <= n;
            Console.WriteLine(string.Join("\n", names.Where(name => isValidName(name))));

        }
    }
}