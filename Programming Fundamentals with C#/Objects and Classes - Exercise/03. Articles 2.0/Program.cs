using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string [] line = Console.ReadLine().Split(", ");
                Article article = new Article();
                article.Title = line[0];
                article.Content = line[1];
                article.Author = line[2];

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}
