namespace _05._Generic_Count_Method_String
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            string itemToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(itemToCompare));

        }
    }
}