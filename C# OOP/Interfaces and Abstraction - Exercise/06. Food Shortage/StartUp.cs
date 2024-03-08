using _06._Food_Shortage;

namespace _05._Birthday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> entries = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    entries.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }

                else if (tokens.Length == 3)
                {
                    entries.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                var found = entries.FirstOrDefault(entry => entry.Name == line);

                if (found != null)
                {
                    found.BuyFood();
                }
            }

            int total = 0;

            foreach (var entry in entries)
            {
                total += entry.Food;
            }

            Console.WriteLine(total);
        }
    }
}