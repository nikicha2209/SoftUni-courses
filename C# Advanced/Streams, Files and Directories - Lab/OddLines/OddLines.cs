namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int count = 0;
                string line = string.Empty;


                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        count++;
                    }
                }
                
            }
        }
    }
}
