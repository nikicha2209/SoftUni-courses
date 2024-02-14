namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                set.Add(line);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}