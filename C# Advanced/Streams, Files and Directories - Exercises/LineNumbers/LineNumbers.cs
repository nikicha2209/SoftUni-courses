using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int count = 1;
            List<string> lines = new List<string>();
           

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                
                foreach (string line in lines)
                {
                    List<char> letters = new List<char>();
                    List<char> punctuationMarks = new List<char>();

                    foreach (char character in line)
                    {
                        if (char.IsLetter(character))
                        {
                            letters.Add(character);
                        }

                        if (char.IsPunctuation(character))
                        {
                            punctuationMarks.Add(character);
                        }
                    }

                    writer.WriteLine($"Line {count}: {line} ({letters.Count})({punctuationMarks.Count})");
                    count++;
                }
            }

        }
    }
}
