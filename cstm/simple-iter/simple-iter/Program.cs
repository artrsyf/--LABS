using System;

namespace simple_iter
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(_ID: 12);
            Book book2 = new Book(_ID: 54);
            Books books = new Books(book1, book2);
            foreach (Book book in books)
            {
                Console.WriteLine(book.ID);
            }
        }
    }
}
