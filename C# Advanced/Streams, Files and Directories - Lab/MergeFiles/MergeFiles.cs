namespace MergeFiles
{
    using System;
    using System.IO;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstFile = File.ReadAllLines(firstInputFilePath);
            string[] secondFile = File.ReadAllLines(secondInputFilePath);

            int maxLength = Math.Max(firstFile.Length, secondFile.Length);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < maxLength; i++)
                {
                    if (i < firstFile.Length)
                    {
                        writer.WriteLine(firstFile[i]);
                    }

                    if (i < secondFile.Length)
                    {
                        writer.WriteLine(secondFile[i]);
                    }
                }
            }
        }

    }

}
