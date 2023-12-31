namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = new string[3];
            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                string continent = line[0];
                string country = line[1];
                string city = line[2];

                if(!dictionary.ContainsKey(continent))
                {
                    dictionary[continent] = new Dictionary<string, List<string>>();
                }

                if (!dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent][country] = new List<string>();
                }

                dictionary[continent][country].Add(city);
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"  {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
            
        }
    }
}