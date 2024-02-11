namespace _01._Generic_Box_of_String
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                Box<string> box = new Box<string>(line);
                Console.WriteLine($"{box.Value.GetType()}: {box.Value}");
            }
        }
    }
}