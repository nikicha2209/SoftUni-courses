using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfSynonyms = int.Parse(Console.ReadLine());
            string word;
            string synonym;

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfSynonyms; i++)
            {
                word = Console.ReadLine();
                synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);
            }

            foreach (var value in synonyms)
            {
                Console.WriteLine($"{value.Key} - {string.Join(", ", value.Value)}");
            }
        }
    }
}
