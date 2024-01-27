using System.Collections.Specialized;

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordAndOccurrences = new Dictionary<string, int>();

            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                string[] words = readerWords.ReadToEnd().Split();
                words = words.Select(word => word.ToLower()).ToArray();
                char[] separators = { ' ', '.', ',', '-', '?', '!', };
                foreach (string word in words)
                {
                    using (StreamReader readerText = new StreamReader(textFilePath))
                    {
                        string[] wordsInTheText = readerText.ReadToEnd().Split(separators);
                        wordsInTheText = wordsInTheText.Select(word => word.ToLower()).ToArray();

                        foreach (string wordInTheText in wordsInTheText)
                        {
                            if (wordInTheText == word)
                            {
                                if (!wordAndOccurrences.ContainsKey(wordInTheText))
                                {
                                    wordAndOccurrences[wordInTheText] = 0;
                                }

                                wordAndOccurrences[wordInTheText]++;
                            }
                        }

                    }

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        var sortedList = wordAndOccurrences.ToList();
                        sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

                        foreach (var kvp in sortedList)
                        {
                            writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}
