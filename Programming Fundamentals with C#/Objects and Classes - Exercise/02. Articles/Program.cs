using System;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit( string newContent)
        {
            Content = newContent;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(", ");

            string title = line[0];
            string content = line[1];
            string author = line[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        string newContent = command[1];
                        article.Edit(newContent);
                        break;

                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        article.ChangeAuthor(newAuthor);
                        break;

                    case "Rename":
                        string newTitle = command[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            
        }
    }
}
