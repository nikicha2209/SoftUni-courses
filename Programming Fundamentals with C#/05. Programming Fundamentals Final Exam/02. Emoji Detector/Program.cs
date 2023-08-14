using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patternNumbers = @"(\d)";
            ulong coolThreshold = 1;

            foreach (Match match in Regex.Matches(text, patternNumbers))
            {
                coolThreshold *= ulong.Parse(match.Groups[1].Value);
            }

            string pattern = @"(\::|\*\*)([A-Z][a-z]{2,})\1";

            List<string> emojiList = new List<string>();
            List<string> coolEmoji = new List<string>();

            foreach (Match match in Regex.Matches(text, pattern))
            {
                ulong total = 0;
                for (int i = 2; i <= match.Length - 2; i++)
                {
                    total += (char)match.Value[i];
                }

                emojiList.Add(match.Groups[2].Value);

                if (total > coolThreshold)
                {
                    coolEmoji.Add(match.ToString());
                }

            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiList.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join('\n', coolEmoji));
           
        }
    }
}
