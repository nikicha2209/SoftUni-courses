using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BookShop.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookShop
{
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);
        }

        //Problem 2
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            try
            {
                AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command);

                List<string> books = context.Books
                    .Where(b => b.AgeRestriction == ageRestriction)
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title)
                    .ToList();

                return string.Join(Environment.NewLine, books);
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        //Problem 3
        public static string GetGoldenBooks(BookShopContext context)
        {
            try
            {
                EditionType editionType = Enum.Parse<EditionType>("Gold");

                List<string> books = context.Books
                    .Where(b => b.Copies < 5000)
                    .Where(b => b.EditionType == editionType)
                    .OrderBy(b => b.BookId)
                    .Select(b => b.Title)
                    .ToList();

                return string.Join(Environment.NewLine, books);
            }

            catch (Exception ex)
            {
                return null;
            }
        }



        //Problem 4
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }



        //Problem 5
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            List<string> books = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }



        //Problem 6
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split();

            List<string> books = context.BooksCategories
                .Where(bc => categories.Contains(bc.Category.Name.ToLower()))
                .OrderBy(bc => bc.Book.Title)
                .Select(bc => bc.Book.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }



        //Problem 7
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime dateTime = DateTime.ParseExact(date, "dd-MM-yyyy", null);

            List<string> books = context.Books
                .Where(b => b.ReleaseDate < dateTime)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType.ToString()} - ${b.Price:f2}")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }



        //Problem 8
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => a.FirstName + " " + a.LastName)
                .ToList();

            return string.Join(Environment.NewLine, authors);
        }




        //Problem 9
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            List<string> books = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }



        //Problem 10
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksAndTitles = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList();

            return string.Join(Environment.NewLine, booksAndTitles);
        }



        //Problem 11
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.
                Count(b => b.Title.Length > lengthCheck);
        }



        //Problem 12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var copies = context.Authors
                .OrderByDescending(a => a.Books.Sum(b => b.Copies))
                .Select(a => $"{a.FirstName} {a.LastName} - {a.Books.Sum(b => b.Copies)}")
                .ToList();

            return string.Join(Environment.NewLine, copies);

        }



        //Problem 13
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var books = context.Categories
                .OrderByDescending(c => c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price))
                .Select(c => $"{c.Name} ${c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price):f2}")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }



        //Problem 14
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var books = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks
                        .OrderByDescending(b => b.Book.ReleaseDate)
                        .Select(cb => new
                        {
                            BookTitle = cb.Book.Title,
                            BookYear = cb.Book.ReleaseDate.Value.Year
                        })
                        .Take(3)
                })
                .ToList();


            StringBuilder sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"--{book.CategoryName}");

                foreach (var bookInfo in book.Books)
                {
                    sb.AppendLine($"{bookInfo.BookTitle} ({bookInfo.BookYear})");
                }
            }


            return sb.ToString().TrimEnd();
        }



        //Problem 15
        public static void IncreasePrices(BookShopContext context)
        {
            List<Book> books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }
        }



        //Problem 16
        public static int RemoveBooks(BookShopContext context)
        {
            List<Book> books = context.Books
                .Where(b => b.Copies < 4200)
                .ToList();

            context.RemoveRange(books);
            context.SaveChanges();
            return books.Count;
        }
    }
}


