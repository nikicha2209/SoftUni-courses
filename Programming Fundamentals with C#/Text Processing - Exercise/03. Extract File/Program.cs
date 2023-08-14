using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input: C:\Internal\training-internal\Template.pptx
            string input = Console.ReadLine();

            string fileName = string.Empty;
            string extension = string.Empty;

            int indexOfTheNameAndExtension = input.LastIndexOf('\\');
            int extensionIndex = input.LastIndexOf('.');

            string nameAndExtension = input.Substring(indexOfTheNameAndExtension);

            extension  = input.Substring(extensionIndex + 1);
            fileName = input.Substring(indexOfTheNameAndExtension + 1, nameAndExtension.Length - extension.Length - 2);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");


        }
    }
}
