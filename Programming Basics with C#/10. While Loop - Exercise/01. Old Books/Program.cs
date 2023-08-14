using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string book;
            int books = 0;

            while ((book = Console.ReadLine()) != "No More Books")
            {
                if (book == searchedBook)
                {
                    Console.WriteLine($"You checked {books} books and found it.");
                    break;
                }

                else
                {
                    books++;
                }
            }

            if (book == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
        }
    }
}
