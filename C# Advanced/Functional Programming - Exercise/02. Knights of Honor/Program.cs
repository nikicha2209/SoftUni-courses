namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();
            Action<string> printer = name => Console.WriteLine("Sir " + name);

            foreach (var name in names)
            {
                printer(name);
            }
        }
    }
}