using System.IO;
using System.Text;

namespace CopyBinaryFile
{
    using System;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream firstStream = new FileStream(inputFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[firstStream.Length];
                firstStream.Read(buffer, 0, buffer.Length);

                using (FileStream secondStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    secondStream.Write(buffer);
                }
            }
            

           
        }
    }
}
