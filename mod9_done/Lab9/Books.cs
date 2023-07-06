using System;
using System.Collections;

namespace Lab9
{
    class BooksEnumerable : IEnumerable
    {
        Book[] books;
        public BooksEnumerable(Book[] pbooks)
        {
            books = new Book[pbooks.Length];
            for (int i = 0; i < pbooks.Length; i++)
            {
                books[i] = pbooks[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
        public Books GetEnumerator()
        {
            return new Books(books);
        }
    }
    class Books : IEnumerator // , IEnumerable
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }
        public Books(Book[] _books)
        {
            books = _books;
        }
        int position = -1;

        object IEnumerator.Current { get; }


        public bool MoveNext()
        {
            position++;
            return (position < books.Length);
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
        public Book Current
        {
            get
            {
                try
                {
                    return books[position];
                }
                catch
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i < books.Length; i++)
        //    {
        //        yield return books[i];
        //    }
        //}
        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = books.Length - 1; i >= 0; i--)
        //    {
        //        yield return books[i];
        //    }
        //}
    }
}
