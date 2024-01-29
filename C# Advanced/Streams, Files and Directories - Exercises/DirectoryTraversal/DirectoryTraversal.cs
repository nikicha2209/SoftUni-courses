using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> filesAndExtensions = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!filesAndExtensions.ContainsKey(fileInfo.Name))
                {
                    filesAndExtensions[fileInfo.Extension] = new List<FileInfo>();
                }

                filesAndExtensions[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var extensionFiles in filesAndExtensions.OrderByDescending(ef=> ef.Value.Count))
            {
                sb.AppendLine(extensionFiles.Key);

                foreach (var file in extensionFiles.Value.OrderBy(f=> f.Length))
                {
                    sb.AppendLine($"--{file.FullName} - {file.Length / 1024.0:f3}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}
