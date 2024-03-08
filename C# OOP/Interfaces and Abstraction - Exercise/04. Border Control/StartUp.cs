using System.Runtime.CompilerServices;

namespace _04._Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<IIdentifiable> entries = new List<IIdentifiable>();

            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    entries.Add(new Robot(tokens[0], tokens[1]));
                }

                else if (tokens.Length == 3)
                {
                    entries.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            string fakeSubstring = Console.ReadLine();

            foreach (var entry in entries)
            {
                entry.CheckId(fakeSubstring);
            }

            
        }
    }
}