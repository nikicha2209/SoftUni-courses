namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ");
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color][clothes[j]] = 0;
                    }

                    wardrobe[color][clothes[j]]++;

                }
            }

            string[] searchedColorAndItem = Console.ReadLine().Split();
            string searchedColor = searchedColorAndItem[0];
            string searchedItem = searchedColorAndItem[1];
            bool foundColor = false;

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                if (kvp.Key == searchedColor)
                {
                    foundColor = true;
                }

                foreach (var itemAndCount in kvp.Value)
                {
                    Console.Write($"* {itemAndCount.Key} - {itemAndCount.Value}");
                    if (foundColor && searchedItem == itemAndCount.Key)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }

                foundColor = false;
            }
        }
    }
}