namespace _02._Generic_Box_of_Integer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(number);
                Console.WriteLine($"{box.Value.GetType()}: {box.Value}");
            }
        }
    }
}