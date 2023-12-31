namespace _06._Record_Unique_Names
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

            Console.WriteLine(string.Join("\n", set));
        }
    }
}