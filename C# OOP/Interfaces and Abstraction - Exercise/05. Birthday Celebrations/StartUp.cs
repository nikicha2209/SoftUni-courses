using _05._Birthday_Celebrations.Models;
using _05._Birthday_Celebrations.Models.Interfaces;

namespace _05._Birthday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<IBirthable> entries = new List<IBirthable>();

            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Citizen")
                {
                    entries.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }

                else if (tokens[0] == "Pet")
                {
                    entries.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            string year = Console.ReadLine();

            foreach (IBirthable entry in entries)
            {
                if (entry.Birthday.EndsWith(year))
                {
                    Console.WriteLine(entry.Birthday);
                }
            }

            

            
        }
    }
}