using System.Collections.Generic;

namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream fileStream = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] firstBuffer = new byte[(fileStream.Length + 1) / 2];
                fileStream.Read(firstBuffer, 0, firstBuffer.Length);

                using (FileStream firstSplit = new FileStream(partOneFilePath, FileMode.Create))
                {
                    firstSplit.Write(firstBuffer, 0, firstBuffer.Length);
                }

                byte[] secondBuffer = new byte[fileStream.Length/ 2];
                fileStream.Read(secondBuffer, 0, secondBuffer.Length);

                using (FileStream secondSplit = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    secondSplit.Write(secondBuffer, 0, secondBuffer.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream merging = new FileStream(joinedFilePath, FileMode.Create))
            {
                byte[] firstBuffer = null;

                using (FileStream firstFile = new FileStream(partOneFilePath, FileMode.Create))
                {
                    firstBuffer = new byte[firstFile.Length];
                    merging.Write(firstBuffer);
                }

                byte[] secondBuffer = null;
                using (var secondFile = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    secondBuffer = new byte[secondFile.Length];
                    merging.Write(secondBuffer, 0, secondBuffer.Length);
                }
            }
        }
    }
}