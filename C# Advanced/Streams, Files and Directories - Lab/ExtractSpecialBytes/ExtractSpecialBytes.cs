using System.Collections.Generic;
using System.Linq;

namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> bytes = new List<byte>();

            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    bytes.Add(byte.Parse(line));
                }
            }

            List<byte> occurrences = new List<byte>();
            using (FileStream fileStream = new FileStream(binaryFilePath, FileMode.Open))
            {
               
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (bytes.Contains(buffer[i]))
                    {
                        occurrences.Add(buffer[i]);
                    }
                }
            }

            using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
            {
               fileStream.Write(occurrences.ToArray(), 0, occurrences.Count);
            }
        }
    }
}
