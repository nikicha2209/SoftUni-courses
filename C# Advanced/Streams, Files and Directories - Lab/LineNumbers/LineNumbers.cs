namespace LineNumbers
{
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int count = 0;
                string line = string.Empty;
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{++count}. {line}");
                    }
                }
            }
        }
    }
}