using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int count = 0;
                List<string> output = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        line = line.Replace('-', '@')
                            .Replace(',', '@')
                            .Replace('.', '@')
                            .Replace('!', '@')
                            .Replace('@', '@');

                        string[] words = line.Split(' ');
                        Array.Reverse(words);
                        string outputLine = string.Join(" ", words);
                        output.Add(outputLine);
                    }

                    count++;

                }

                return string.Join("\r\n", output);
            }
        }
    }
}
