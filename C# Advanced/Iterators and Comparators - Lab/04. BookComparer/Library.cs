using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.OrderBy(b=>b, new BookComparator()).ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex = -1;
            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose() { }
        }
    }
}