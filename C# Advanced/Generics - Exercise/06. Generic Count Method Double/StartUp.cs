namespace _06._Generic_Count_Method_Double
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}