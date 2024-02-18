namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();
            Action<string> printer = name => Console.WriteLine(name);

            foreach (var name in names)
            {
                printer(name);
            }
        }
    }
}