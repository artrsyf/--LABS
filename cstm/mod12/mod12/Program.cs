using System.Data.Common;

class Book
{

    public int num { get; private set; }
    public Book() { }
    public Book(int num) { this.num = num; }
    public static int operator +(Book first_book, Book another_book)
    {
        return first_book.num + another_book.num;
    }
}
public class Check<T> where T : IComparable<T>
{
    T value { get; set; }
    public Check(T value)
    {
        this.value = value;
    }

    public bool GreaterThen(T other, T an)
    {
        return (an.CompareTo(other) > 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(12);
        Book book2 = new Book(32);
        Check<int> a = new Check<int>(2);
        Console.WriteLine(a.GreaterThen(1, 2));
    }
}
