namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            foreach (char character in text)
            {
                if (!dictionary.ContainsKey(character))
                {
                    dictionary[character] = 0;
                }
                dictionary[character]++;
            }

            foreach (var character in dictionary)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}