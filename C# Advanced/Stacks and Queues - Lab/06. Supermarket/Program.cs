namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            Queue<string> names = new Queue<string>();

            while ((line = Console.ReadLine()) != "End")
            {
                while (line == "Paid" && names.Count > 0)
                {
                    Console.WriteLine(names.Dequeue());
                }

                if (line != "Paid")
                {
                    names.Enqueue(line);
                }

            }

            Console.WriteLine($"{names.Count} people remaining.");

        }
    }
}