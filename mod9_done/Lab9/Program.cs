using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            //foreach (Book book in books.GetByPrice())       Console.WriteLine(book);
            //foreach (Book book in books.GetReverseEnum())   Console.WriteLine(book);
            //foreach (Book book in books.GetByAuthor())      Console.WriteLine(book);

            Console.WriteLine();
            // foreach (Book book in books)        Console.WriteLine(book);
            Book[] NotEnumerable = { new Book(1, 100, "q", "Q"), 
                new Book(2, 200, "w", "W"), 
                new Book(3, 300, "e", "E") };
            BooksEnumerable booklist = new BooksEnumerable(NotEnumerable);
            foreach (var book in booklist)
            {
                Console.WriteLine(book);
            }
        }
    }
}
